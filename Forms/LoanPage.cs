using EngineeringCoperation.Forms.PublicMenus;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;
using EngineeringCoperation.Utils;
using EngineeringCoperation.Models;
using System;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BraveHeroCooperation.Forms.MemberMenus
{ 
    public partial class LoanPage : UserControl
    {
        Member loggedMember;
        InstallmentForm installmentForm;

        public LoanPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void buttonFileKTP_Click(object sender, EventArgs e)
        {
            txtDocumentKTP.Text = FileHelper.UploadDocument("KTP");
        }

        private void buttonFileKK_Click(object sender, EventArgs e)
        {
            txtDocumentKK.Text = FileHelper.UploadDocument("KK");
        }

        private void buttonFileSlip_Click(object sender, EventArgs e)
        {
            txtDocumentSG.Text = FileHelper.UploadDocument("Slip Gaji");
        }

        private void LoanPage_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                SetLoanDropDown(db);
                SetDefaultField();
                ResetField();
                LoadLoanGrid(db);
                HideInstallment();
            }
        }

        private void SetLoanDropDown(AppDbContext db)
        {
            var productService = new ProductService(db);
            comboLoanMaster.DataSource = productService.SetDropDownLoan();
            comboLoanMaster.DisplayMember = "DisplayName";
            comboLoanMaster.ValueMember = "Id";
            comboLoanMaster.SelectedIndex = 0;
        }

        private void buttonNewLoan_Click(object sender, EventArgs e)
        {
            btnApplyLoan.Enabled = true;
            comboLoanMaster.Enabled = true;
            HideInstallment();
        }

        private void SetDefaultField()
        {
            comboLoanMaster.SelectedIndex = 0;
            btnKTP2.Visible = false;
            btnKK2.Visible = false;
            btnSG2.Visible = false;
            btnKTP1.Visible = true;
            btnKK1.Visible = true;
            btnSG1.Visible = true;
        }

        private void SetChosenField()
        {
            btnKTP2.Visible = true;
            btnKK2.Visible = true;
            btnSG2.Visible = true;
            btnKTP1.Visible = false;
            btnKK1.Visible = false;
            btnSG1.Visible = false;
        }

        private void ResetField()
        {
            txtDocumentKTP.Text = "";
            txtDocumentKK.Text = "";
            txtDocumentSG.Text = "";
            txtDueDate.Text = "";
            txtAmount.Text = "";
            txtAdminFee.Text = "";
            txtInterest.Text = "";
            txtTenor.Text = "";
            txtMinAmount.Text = "";
            txtMaxAmount.Text = "";
            txtLoanId.Text = RandomNumberGenerator.GetString("1234567890", 6);
            labelId.Text = "";
        }

        private async void LoadLoanGrid(AppDbContext db)
        {
            LoanService loanService = new LoanService(db);
            dataGridLoan.DataSource = await loanService.LoadLoanGrid(loggedMember.Id);

            dataGridLoan.Columns[0].DataPropertyName = "Id";
            dataGridLoan.Columns[1].DataPropertyName = "LoanId";
            dataGridLoan.Columns[2].DataPropertyName = "Outstanding";
            dataGridLoan.Columns[3].DataPropertyName = "TenorLeft";

            dataGridLoan.Columns[0].Visible = false;
            dataGridLoan.Columns[1].HeaderText = "Loan ID";
            dataGridLoan.Columns[2].HeaderText = "Outstanding";
            dataGridLoan.Columns[3].HeaderText = "Tenor Left";
        }

        private void dataGridViewLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridLoan.Rows[e.RowIndex].Cells[0].Value.ToString());

                using (var db = new AppDbContext())
                {
                    LoanService loanService = new LoanService(db);
                    var loan = loanService.GetLoanById(id);

                    if (loan != null)
                    {
                        if (loan.IsApproved)
                        {
                            SetChosenField();
                            txtDocumentKTP.Text = loan.KtpPath;
                            txtDocumentKK.Text = loan.KkPath;
                            txtDocumentSG.Text = loan.SlipGajiPath;
                            txtDueDate.Text = loan.DueDate.ToString();
                            txtInterest.Text = loan.Interest.ToString();
                            txtTenor.Text = loan.Tenor.ToString();
                            txtAmount.Text = loan.Amount.ToString();
                            txtAdminFee.Text = loan.AdminFee.ToString();
                            txtMinAmount.Text = loan.MinAmount.ToString();
                            txtMaxAmount.Text = loan.MaxAmount.ToString();
                            labelId.Text = loan.Id.ToString();

                            if (installmentForm == null)
                                installmentForm = new InstallmentForm(loggedMember, 0);

                            installmentForm.SetLoan(loan.Id);
                            installmentForm.Show();
                            btnApplyLoan.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Your loan is not approved yet.", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            HideInstallment();
                        }
                    }
                }
            }
        }

        private async void buttonApply_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                LoanService loanService = new LoanService(db);

                if (decimal.TryParse(txtAmount.Text, out var amount) &&
                    decimal.TryParse(txtMinAmount.Text, out var minAmount) &&
                    decimal.TryParse(txtMaxAmount.Text, out var maxAmount))
                {
                    if (amount < minAmount || amount > maxAmount)
                    {
                        MessageBox.Show("Invalid amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                await loanService.SaveOrUpdate(loggedMember,
                    txtDocumentKTP.Text, txtDocumentKK.Text, txtDocumenttSG.Text,
                    txtDueDate.Text, txtInterest.Text, txtTenor.Text,
                    txtAmount.Text, txtAdminFee.Text, txtMinAmount.Text,
                    txtMaxAmount.Text, txtLoanId.Text);
            }
        }

        private void HideInstallment()
        {
            if (installmentForm != null)
                installmentForm.Hide();
        }

        private void ResetDropDown()
        {
            txtInterest.Text = "";
            txtTenor.Text = "";
            txtAdminFee.Text = "";
            txtMinAmount.Text = "";
            txtMaxAmount.Text = "";
        }

        private async void comboLoanMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDropDown();

            if (comboLoanMaster.SelectedIndex > 0)
            {
                int loanMasterId = int.Parse(comboLoanMaster.SelectedValue.ToString());
                using (var db = new AppDbContext())
                {
                    ProductService productService = new ProductService(db);
                    var loanMaster = await productService.FindLoanById(loanMasterId);

                    if (loanMaster != null)
                    {
                        txtInterest.Text = loanMaster.Interest.ToString();
                        txtTenor.Text = loanMaster.Tenor.ToString();
                        txtAdminFee.Text = loanMaster.AdminFee.ToString();
                        txtMinAmount.Text = loanMaster.MinAmount.ToString();
                        txtMaxAmount.Text = loanMaster.MaxAmount.ToString();
                    }
                }
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                SetLoanDropDown(db);
                SetDefaultField();
                ResetField();
                LoadLoanGrid(db);
                HideInstallment();
            }
        }

        private void InitializeComponent()
        {

        }
    }
}
