using System.Security.Cryptography;
using EngineeringCoperation.Data;
using EngineeringCoperation.Forms.PublicMenus;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;
using EngineeringCoperation.Utils;

namespace EngineeringCoperation.Forms.MemberMenus
{
    public partial class LoanPage : UserControl
    {
        Member loggedMember;
        InstallmentForm? installmentForm;
        public LoanPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void buttonFileKTP_Click(object sender, EventArgs e)
        {
            textDocKtp.Text = FileHelper.UploadDocument("KTP");
        }

        private void buttonFileKK_Click(object sender, EventArgs e)
        {
            textDocKK.Text = FileHelper.UploadDocument("KK");
        }

        private void buttonFileSlip_Click(object sender, EventArgs e)
        {
            textDocSlip.Text = FileHelper.UploadDocument("Slip Gaji");
        }

        private void LoanPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetLoanDropDown(db);
            SetDefaultField();
            ResetField();

            LoadLoanGrid(db);
            HideInstallment();
        }

        private void SetLoanDropDown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            loanMasterBindingSource.DataSource = productService.SetDropDownLoan();
            comboLoanMaster.DisplayMember = "DisplayName";
            comboLoanMaster.ValueMember = "Id";
        }

        private void buttonNewLoan_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField();
            buttonApply.Enabled = true;
            comboLoanMaster.SelectedIndex = 0;
            comboLoanMaster.Enabled = true;

            HideInstallment();
        }

        private void SetDefaultField()
        {
            comboLoanMaster.SelectedIndex = 0;
            buttonShowDocKtp.Visible = false;
            buttonShowDocKk.Visible = false;
            buttonShowDocSlip.Visible = false;
            buttonFileKTP.Visible = true;
            buttonFileKK.Visible = true;
            buttonFileSlip.Visible = true;
        }

        private void SetChosenField()
        {
            buttonShowDocKtp.Visible = true;
            buttonShowDocKk.Visible = true;
            buttonShowDocSlip.Visible = true;
            buttonFileKTP.Visible = false;
            buttonFileKK.Visible = false;
            buttonFileSlip.Visible = false;
        }

        private void ResetField()
        {
            textDocKK.Text = "";
            textDocKtp.Text = "";
            textDocSlip.Text = "";
            textDueDate.Text = "";
            textAmount.Text = "";
            ResetDropDown();
            textLoanId.Text = RandomNumberGenerator.GetString("1234567890", 6);
            labelId.Text = "";
        }

        private async void LoadLoanGrid(AppDbContext db)
        {
            LoanService loanService = new LoanService(db);
            loanBindingSource.DataSource = await loanService.LoadLoanGrid(loggedMember.Id);
            dataGridViewLoan.Columns[0].DataPropertyName = "Id";
            dataGridViewLoan.Columns[1].DataPropertyName = "LoanId";
            dataGridViewLoan.Columns[2].DataPropertyName = "outstanding";
            dataGridViewLoan.Columns[3].DataPropertyName = "tenorLeft";

            dataGridViewLoan.Columns[0].Visible = false;
            dataGridViewLoan.Columns[1].HeaderText = "Loan ID";
            dataGridViewLoan.Columns[2].HeaderText = "Outstanding";
            dataGridViewLoan.Columns[3].HeaderText = "Tenor Left";
        }

        private async void dataGridViewLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridViewLoan.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                LoanService loanService = new LoanService(db);
                Loan? loan = await loanService.findById(id);
                if (loan != null)
                {
                    if (loan.IsApproved)
                    {
                        SetChosenField();
                        textDocKK.Text = loan.KkPath;
                        textDocKtp.Text = loan.KtpPath;
                        textDocSlip.Text = loan.SlipGajiPath;
                        textDueDate.Text = loan.DueDate.ToString();
                        textInterest.Text = loan.Interest.ToString();
                        textInterestFine.Text = loan.InterestFine.ToString();
                        textAmount.Text = loan.Amount.ToString();
                        textTenor.Text = loan.Tenor.ToString();
                        textAdminFee.Text = loan.AdminFee.ToString();
                        textMinAmount.Text = "";
                        textMaxAmount.Text = "";
                        labelId.Text = loan.Id.ToString();
                        comboLoanMaster.SelectedIndex = 0;
                        comboLoanMaster.Enabled = false;

                        if (installmentForm == null)
                            installmentForm = new InstallmentForm(loggedMember, 0);
                        installmentForm.SetLoan(loan.Id);
                        installmentForm.Show();

                        buttonApply.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Your Loan is not approved yet.", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        HideInstallment();
                    }
                }
                else
                {
                    HideInstallment();
                }
            }
        }

        private async void buttonApply_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            LoanService loanService = new LoanService(db);
            decimal amount = decimal.Parse(textAmount.Text);
            decimal minAmount = decimal.Parse(textMinAmount.Text);
            decimal maxAmount = decimal.Parse(textMaxAmount.Text);
            if (amount > maxAmount || amount < minAmount)
            {
                MessageBox.Show("Invalid Amount", "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                await loanService.saveOrUpdate(loggedMember, textAmount.Text,
                    textDocKK.Text, textDocKtp.Text, textDocSlip.Text, textDueDate.Text,
                    textInterest.Text, textInterestFine.Text, textLoanId.Text,
                    textTenor.Text, textAdminFee.Text);
                LoadLoanGrid(db);
                ResetField();
            }
        }

        private void HideInstallment()
        {
            if (installmentForm == null)
                installmentForm = new InstallmentForm(loggedMember, 0);
            installmentForm.SetLoan(0);
            installmentForm.Hide();
        }

        private void ResetDropDown()
        {
            textInterest.Text = "";
            textInterestFine.Text = "";
            textTenor.Text = "";
            textAdminFee.Text = "";
            textMinAmount.Text = "";
            textMaxAmount.Text = "";
        }

        private async void comboLoanMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLoanMaster.SelectedIndex == 0)
                ResetDropDown();

            if (comboLoanMaster.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(comboLoanMaster.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.findLoanById(idLoanMaster);
                if (loanMaster != null)
                {
                    textInterest.Text = loanMaster.Interest.ToString();
                    textInterestFine.Text = loanMaster.Fine.ToString();
                    textTenor.Text = loanMaster.Tenor.ToString();
                    textAdminFee.Text = loanMaster.AdminFee.ToString();
                    textMinAmount.Text = loanMaster.MinAmount.ToString();
                    textMaxAmount.Text = loanMaster.MaxAmount.ToString();
                }
                else
                {
                    ResetDropDown();
                }
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetLoanDropDown(db);
            SetDefaultField();
            ResetField();

            LoadLoanGrid(db);
            HideInstallment();
        }
    }
}
