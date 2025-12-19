using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;
using EngineeringCoperation.Utils;

namespace EngineeringCoperation.Forms.PublicMenus
{
    public partial class InstallmentForm : Form
    {
        Member loggedMember;
        int _IdLoan;
        public InstallmentForm(Member member, int IdLoan)
        {
            this.loggedMember = member;
            this._IdLoan = IdLoan;
            InitializeComponent();
        }

        public void SetLoan(int idLoan)
        {
            this._IdLoan = idLoan;
            LoadInstallment();
        }

        private async void LoadInstallment()
        {
            if (_IdLoan > 0)
            {
                this.Show();
                AppDbContext db = new AppDbContext();
                LoanService loanService = new LoanService(db);
                Loan? loan = await loanService.findById(this._IdLoan);
                if (loan != null)
                {
                    textLoanId.Text = loan.LoanId.ToString();
                    installmentBindingSource.DataSource = await loanService.LoadInstallmentsGrid(this._IdLoan);
                    dataGridViewInstallment.Columns[0].DataPropertyName = "Id";
                    dataGridViewInstallment.Columns[1].DataPropertyName = "amount";
                    dataGridViewInstallment.Columns[2].DataPropertyName = "PaymentDate";
                    dataGridViewInstallment.Columns[3].DataPropertyName = "ProofPath";

                    dataGridViewInstallment.Columns[0].Visible = false;
                    dataGridViewInstallment.Columns[3].Visible = false;
                }
            }
            else
            {
                this.Hide();
            }
        }

        private async void InstallmentForm_Load(object sender, EventArgs e)
        {
            LoadInstallment();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textAmount.Text = "";
            textPath.Text = "";

        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            LoanService loanService = new LoanService(db);
            await loanService.saveOrUpdateInstallment(_IdLoan, textAmount.Text, textPath.Text);
            await loanService.recalculateLoan(_IdLoan, textAmount.Text);
            LoadInstallment();
        }

        private void buttonReceipt_Click(object sender, EventArgs e)
        {
            textPath.Text = FileHelper.UploadDocument("Receipt");

        }

        private void dataGridViewInstallment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                FileHelper.ShowFile(dataGridViewInstallment.Rows[e.RowIndex].Cells[3].Value.ToString());
        }
    }
}
