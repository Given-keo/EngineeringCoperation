using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineeringCoperation.Api.Connectors;
using EngineeringCoperation.Api.Models;
using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;

namespace EngineeringCoperation.Forms.PublicMenus
{
    public partial class InhousePage : UserControl
    {
        Member loggedMember;
        public InhousePage(Member member)
        {
            this.loggedMember = member;
            InitializeComponent();
        }

        private async void InhousePage_Load(object sender, EventArgs e)
        {
            String dateUtc = DateTime.UtcNow.ToString();
            textTransRef.Text = dateUtc.Substring(0, 10);

            var db = new AppDbContext();
            BalanceService balanceService = new BalanceService(db);
            Balance? balance = await balanceService.getBalance(loggedMember.MemberId);
            if (balance != null)
            {
                textBalance.Text = balance.Amount.ToString();
            }

            labelMyBenef.Text = "My Benef: " + loggedMember.MemberId;
            timerInbox.Enabled = true;
        }

        private void clearForm()
        {
            textAmount.Text = "";
            textBenef.Text = "";
            textRemarks.Text = "";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext appDbContext = new AppDbContext();
            
            clearForm();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private async Task LoadInboxAsync()
        {
            try
            {
                //timerInbox.Start();
                Console.WriteLine("Retrieving...");
                ConnectorGet connectorGet = new ConnectorGet();
                var responseOutgoing = await connectorGet.GetOutgoingByMemberAsync(loggedMember.MemberId);
                if (responseOutgoing?.ResponseCode == "00")
                {
                    dgvOutgoing.DataSource = null;
                    dgvOutgoing.DataSource = responseOutgoing.TransferList;
                }

                String benefCode = $"{loggedMember.ReferenceId}-{loggedMember.MemberId}";
                var responseIncoming = await connectorGet.GetIncomingByMemberAsync(loggedMember.MemberId);
                if (responseIncoming?.ResponseCode == "00")
                {
                    dgvIncoming.DataSource = null;
                    dgvIncoming.DataSource = responseIncoming.TransferList;
                }

                BalanceApiResponse? responseBalance = await connectorGet.GetBalanceByMemberAsync(loggedMember.MemberId);
                if (responseBalance?.ResponseCode == "00")
                {
                    textBalance.Text = responseBalance.Balance.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void SetupOutgoingGrid()
        {
            dgvOutgoing.AutoGenerateColumns = false;
            dgvOutgoing.Columns.Clear();

            dgvOutgoing.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodeBenef",
                HeaderText = "Beneficiary",
                Name = "CodeBenef"
            });

            dgvOutgoing.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TransferRef",
                HeaderText = "Time",
                Name = "TransferRef"
            });

            dgvOutgoing.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Remarks",
                HeaderText = "Remarks",
                Name = "Remarks"
            });

            dgvOutgoing.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Amount",
                Name = "Amount"
            });

            dgvOutgoing.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fee",
                HeaderText = "Fee",
                Name = "Fee"
            });

            dgvOutgoing.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Total",
                Name = "TotalAmount"
            });
        }

        private void SetupIncomingGrid()
        {
            dgvIncoming.AutoGenerateColumns = false;
            dgvIncoming.Columns.Clear();

            dgvIncoming.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodeBenef",
                HeaderText = "Beneficiary",
                Name = "CodeBenef"
            });

            dgvIncoming.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TransferRef",
                HeaderText = "Time",
                Name = "TransferRef"
            });

            dgvIncoming.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Remarks",
                HeaderText = "Remarks",
                Name = "Remarks"
            });

            dgvIncoming.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Amount",
                Name = "Amount"
            });

            dgvIncoming.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fee",
                HeaderText = "Fee",
                Name = "Fee"
            });

            dgvIncoming.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Total",
                Name = "TotalAmount"
            });
        }
    }
}
