using EngineeringCoperation.API.Connectors;
using EngineeringCoperation.API.Models;
using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringCoperation.Forms.AdminMenus
{
   
    public partial class AcrossTransferPages : UserControl
    {
        Member loggedMember;
        public AcrossTransferPages(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void AcrossPages_Load(object sender, EventArgs e)
        {
            timerInbox.Enabled = false;
            if (loggedMember.ReferenceId == null || loggedMember.ReferenceId == "" || loggedMember.ReferenceId == "-")
            {
                DialogResult result = MessageBox.Show("You do not have a privilege to Use Across Transfer. Registration Now?", "Invalid", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    String message;
                    using (var db = new AppDbContext())
                    {
                        message = await MemberRegistration(db);
                    }
                    MessageBox.Show(message, "Registration Info", MessageBoxButtons.OK);
                }
            }
            else
            {
                timerInbox.Enabled = true;
            }

        }

        private async Task<string> MemberRegistration(AppDbContext db)
        {
            string message = "Success";
            MemberService memberService = new MemberService(db);
            ConnectorPost connectorPost = new ConnectorPost();
            ConfigurationService configurationService = new ConfigurationService(db);
            Configuration? configuration = await configurationService.GetConfig();
            if (configuration == null)
                message = "Configuration not found";

            if (configuration != null)
            {
                if (configuration.terminologi3 == null || configuration.terminologi3 == "--")
                    message = "Coop not registered to Across System. Please contact administrator.";

                try
                {
                    MemberApiResponse? memberApiResponse = await connectorPost.MemberRegistrationAsync(
                        new MemberPayload
                        {
                            name = loggedMember.FullName,
                            address = loggedMember.Address,
                            code = loggedMember.MemberId,
                            coopCode = configuration.terminologi3!
                        }
                    );

                    if (memberApiResponse != null && memberApiResponse.ResponseCode == "00")
                    {
                        loggedMember.ReferenceId = configuration.terminologi3!;
                        memberService.Update(loggedMember);

                        BalanceService balanceService = new BalanceService(db);
                        balanceService.setBalance(loggedMember.MemberId);

                        timerInbox.Enabled = true;
                    }
                    else
                    {
                        message = "Failed to register member to across system: "
                                  + memberApiResponse?.ResponseMessage;
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
            }

            return message;
        }

        private async void timerInbox_Tick(object sender, EventArgs e)
        {
            timerInbox.Stop();
            try
            {
                timerInbox.Start();
                Console.WriteLine("Retrieving...");
                ConnectorGet connectorGet = new ConnectorGet();

                // ===== OUTGOING =====
                TransferApiResponse? responseOutgoing = await connectorGet.GetOutgoingByMemberAsync(loggedMember.MemberId);
                if (responseOutgoing != null && responseOutgoing.ResponseCode == "00")
                {
                    dataGridOutgoing.DataSource = responseOutgoing.TransferList;
                    dataGridOutgoing.Columns["id"].Visible = false;
                    dataGridOutgoing.Columns["BenefCode"].HeaderText = "Beneficiary";
                    dataGridOutgoing.Columns["coopCode1"].Visible = false;
                    dataGridOutgoing.Columns["updateOn1"].Visible = false;
                    dataGridOutgoing.Columns["transferRef"].HeaderText = "Reference";
                    dataGridOutgoing.Columns["transferDate"].HeaderText = "Date";
                    dataGridOutgoing.Columns["Amount"].HeaderText = "Amount";
                    dataGridOutgoing.Columns["Fee1"].HeaderText = "Fee";
                    dataGridOutgoing.Columns["Remarks1"].HeaderText = "Remarks";
                    dataGridOutgoing.Columns["transactionCode1"].HeaderText = "Transaction Code";
                }

                // ===== INCOMING =====
                string benefCode = "Member ReferenceId " + loggedMember.MemberId;
                TransferApiResponse? responseIncoming = await connectorGet.GetIncomingByMemberAsync(loggedMember.MemberId);
                if (responseIncoming != null && responseOutgoing.ResponseCode == "00")
                {
                    dataGridBecoming.DataSource = responseIncoming.TransferList;
                    dataGridBecoming.Columns["id1"].Visible = false;
                    dataGridBecoming.Columns["memberCode"].HeaderText = "Member Code";
                    dataGridBecoming.Columns["BenefCode1"].Visible = false;
                    dataGridBecoming.Columns["CoopCode1"].Visible = false;
                    dataGridBecoming.Columns["updateOn1"].Visible = false;
                    dataGridBecoming.Columns["TransferRef1"].HeaderText = "Reference";
                    dataGridBecoming.Columns["TransferDate1"].HeaderText = "Date";
                    dataGridBecoming.Columns["Amount1"].HeaderText = "Amount";
                    dataGridBecoming.Columns["Fee1"].HeaderText = "Fee";
                    dataGridBecoming.Columns["Remarks1"].HeaderText = "Remarks";
                    dataGridBecoming.Columns["transactionCode1"].HeaderText = "Transaction Code";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                timerInbox.Start(); // restart setelah selesai
            }
        }

        async private void BtnSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            Configuration? config = await configService.GetConfig();
            ConnectorPost connectorPost = new ConnectorPost();
            Double transferAmount = Double.Parse(textAmount.Text);

            TransferApiResponse? response = await connectorPost.TransferAsync(new TransferPayload
            {
                amount = transferAmount,
                benefCode = loggedMember.ReferenceId,
                coopCode = loggedMember.MemberId,
                fee = Double.Parse(config?.transferAcrossFee.ToString()),
                remarks = textRemarks.Text,
                transferRef = textTransRef.Text,
            });

            if (response != null && response.ResponseCode == "00")
            {
                BalanceService balanceService = new BalanceService(db);
                Balance? balance = await balanceService.getBalance(loggedMember.MemberId);
                if (balance != null)
                {
                    balance.Amount = Decimal.Parse(transferAmount.ToString());
                    balance.UpdatedOn = DateTime.Now;
                    balance.TransactionName = "Across Transfer";
                    balance.Flow = "OUT";
                    balanceService.Update(balance);

                    BalanceApiResponse? balanceApiResponse = await connectorPost.BalanceUpdateAsync(new BalancePayload
                    {
                        amount = Double.Parse(balance.Amount.ToString()),
                        memberCode = loggedMember.MemberId,
                    });

                    if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
                    {
                        MessageBox.Show("Transfer Successful", "Success");
                    }
                }
            }
        }
    }
}
