using EngineeringCoperation.Api.Connectors;
using EngineeringCoperation.Api.Models;
using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;
using EngineeringCoperation.Utils;

namespace EngineeringCoperation.Forms.AdminMenus
{
    public partial class ApprovalPage : UserControl
    {
        Member loggedMember;
        public ApprovalPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void ApprovalPage_Load(object sender, EventArgs e)
        {
            comboProduct.SelectedIndex = 0;
        }

        private async void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

            AppDbContext db = new AppDbContext();
            if (comboProduct.SelectedIndex == 1)
            {
                LoanService loanService = new LoanService(db);
                dataGridViewApproval.AutoGenerateColumns = true;
                dataGridViewApproval.DataSource = await loanService.LoadsApproval();
                
                dataGridViewApproval.Columns[0].DataPropertyName = "Id";
                dataGridViewApproval.Columns[1].DataPropertyName = "LoanId";
                dataGridViewApproval.Columns[2].DataPropertyName = "CreatedOn";
                dataGridViewApproval.Columns[3].DataPropertyName = "Amount";
                dataGridViewApproval.Columns[4].DataPropertyName = "Amount";
                dataGridViewApproval.Columns[5].DataPropertyName = "Outstanding";
                dataGridViewApproval.Columns[6].DataPropertyName = "Interest";
                dataGridViewApproval.Columns[7].DataPropertyName = "Tenor";
                dataGridViewApproval.Columns[8].DataPropertyName = "KtpPath";
                dataGridViewApproval.Columns[9].DataPropertyName = "KkPath";
                dataGridViewApproval.Columns[10].DataPropertyName = "SlipGajiPath";
                dataGridViewApproval.Columns[11].DataPropertyName = "Amount";

                dataGridViewApproval.Columns[0].Visible = false;
                dataGridViewApproval.Columns[1].HeaderText = "Loan Id";
                dataGridViewApproval.Columns[2].HeaderText = "Created On";
                dataGridViewApproval.Columns[3].HeaderText = "Member";
                dataGridViewApproval.Columns[4].HeaderText = "Amount";
                dataGridViewApproval.Columns[5].HeaderText = "Outstanding";
                dataGridViewApproval.Columns[6].HeaderText = "Interest";
                dataGridViewApproval.Columns[7].HeaderText = "Tenor";
                dataGridViewApproval.Columns[8].HeaderText = "Ktp";
                dataGridViewApproval.Columns[9].HeaderText = "Kk";
                dataGridViewApproval.Columns[10].HeaderText = "Slip";
                dataGridViewApproval.Columns[11].HeaderText = "Join Date";

                for (int i = 11; i < dataGridViewApproval.Columns.Count; i++)
                {
                    dataGridViewApproval.Columns[i].Visible = false;
                }
            }

            /*if (comboProduct.SelectedIndex == 3)
            {
                MemberService memberService = new MemberService(db);
                dataGridViewApproval.AutoGenerateColumns = true;
                List<Member> members = memberService.SetGrid();
                List<Member> requestAcrossList = new List<Member>();
                for (int i = 0; i < members.Count; i++)
                {
                    if (members[i].ReferenceId == "REQ")
                    {
                        requestAcrossList.Add(members[i]);
                    }
                }
                dataGridViewApproval.DataSource = requestAcrossList;
                dataGridViewApproval.Columns[0].DataPropertyName = "Id";
                dataGridViewApproval.Columns[1].DataPropertyName = "FullName";
                dataGridViewApproval.Columns[2].DataPropertyName = "MemberId";
                dataGridViewApproval.Columns[3].DataPropertyName = "ReferenceId";

                dataGridViewApproval.Columns[0].Visible = false;
                dataGridViewApproval.Columns[1].HeaderText = "Full Name";
                dataGridViewApproval.Columns[2].HeaderText = "Member ID";
                dataGridViewApproval.Columns[3].HeaderText = "Across Code";

            }*/ // no need approval for across registration
        }

        private async void dataGridViewApproval_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AppDbContext db = new AppDbContext();
            if (comboProduct.SelectedIndex == 1)
            {
                if (e.RowIndex >= 0)
                {
                    string path;
                    if (e.ColumnIndex == 8)
                    {
                        path = dataGridViewApproval.Rows[e.RowIndex].Cells[8].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else if (e.ColumnIndex == 9)
                    {
                        path = dataGridViewApproval.Rows[e.RowIndex].Cells[8].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else if (e.ColumnIndex == 10)
                    {
                        path = dataGridViewApproval.Rows[e.RowIndex].Cells[8].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else
                    {
                        LoanService loanService = new LoanService(db);
                        DialogResult result = MessageBox.Show("Approve?", "Decision", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        int idLoan = int.Parse(dataGridViewApproval.Rows[e.RowIndex].Cells[0].Value.ToString());
                        if (result == DialogResult.Yes)
                            loanService.SetApproval(idLoan, true);
                        else if (result == DialogResult.No)
                            loanService.SetApproval(idLoan, false);

                        comboProduct.SelectedIndex = 0;
                        comboProduct.SelectedIndex = 1;
                    }
                }
            }
            /*else
            {
                if (comboProduct.SelectedIndex == 3)
                {
                    if (e.RowIndex >= 0)
                    {
                        String message = "";
                        MemberService memberService = new MemberService(db);
                        Member? member = memberService.FindById(int.Parse(dataGridViewApproval.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        if (member == null || member.ReferenceId != "REQ")
                        {
                            message = "Member not found or already registered!";
                        }
                        else
                        {
                            ConnectorPost connectorPost = new ConnectorPost();
                            ConfigurationService configurationService = new ConfigurationService(db);
                            Configuration? configuration = await configurationService.GetConfig();
                            if (configuration == null)
                                message = "Configuration not found!";

                            if (configuration != null)
                            {
                                if (configuration.terminologi3 == null || configuration.terminologi3 == "-")
                                { 
                                    CoopApiResponse? coopApiResponse = await connectorPost.CoopRegistrationAsync(new CoopPayload
                                    {
                                        name = "Brave Hero Cooperation",
                                        address = "Jakarta",
                                        code = ""
                                    });

                                    if (coopApiResponse != null && coopApiResponse.CoopCode != null)
                                    {
                                        configuration.terminologi3 = coopApiResponse.CoopCode;
                                        configurationService.Update(configuration);
                                    }
                                    else
                                    {
                                        message = "Failed to register coop to across system: " + coopApiResponse?.ResponseMessage;
                                    }
                                }

                                MemberApiResponse? memberApiResponse = await connectorPost.MemberRegistrationAsync(new MemberPayload
                                {
                                    name = member.FullName,
                                    address = member.Address,
                                    code = member.MemberId,
                                    coopCode = configuration.terminologi3
                                });

                                if (memberApiResponse != null && memberApiResponse.ResponseCode == "00")
                                {
                                    member.ReferenceId = configuration.terminologi3;
                                    memberService.Update(member);

                                    BalanceService balanceService = new BalanceService(db);
                                    balanceService.setBalance(member.MemberId);
                                }
                                else
                                {
                                    message = "Failed to register member to across system: " + memberApiResponse?.ResponseMessage;
                                }
                            }
                        }

                        if (message != "")
                        {
                            MessageBox.Show(message);
                            return;
                        }
                    }
                }
            
            }*/
        }

    }
}
