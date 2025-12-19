using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;
using EngineeringCoperation.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringCoperation.Forms.MemberMenus
{
    public partial class SavingPage : UserControl
    {
        Member loggedMember;
        public SavingPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {

        }

        private void buttonFileKK_Click(object sender, EventArgs e)
        {
            textDocKK.Text = FileHelper.UploadDocument("KK");
        }

        private void SavingPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }

        private void SetSavingDropDown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            loanMasterBindingSource.DataSource = productService.SetDropDownSaving();
            comboSavingMaster.DisplayMember = "DisplayName";
            comboSavingMaster.ValueMember = "Id";
        }
        private void SetDefaultField()
        {
            comboSavingMaster.SelectedIndex = 0;
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

        private void ResetDropDown()
        {
            textInterest.Text = "";
            textInterestFine.Text = "";
            textTenor.Text = "";
            textAdminFee.Text = "";
            textMinAmount.Text = "";
            textMaxAmount.Text = "";
        }

        private async void LoadSavingGrid(AppDbContext db)
        {
            SavingService savingService = new SavingService(db);
            loanBindingSource.DataSource = await savingService.LoadSavingGrid(loggedMember.Id);
            dataGridViewSaving.Columns[0].DataPropertyName = "Id";
            dataGridViewSaving.Columns[1].DataPropertyName = "SavingId";
            dataGridViewSaving.Columns[2].DataPropertyName = "Amount";
            dataGridViewSaving.Columns[3].DataPropertyName = "Tenor";

            dataGridViewSaving.Columns[0].Visible = false;
            dataGridViewSaving.Columns[1].HeaderText = "Saving ID";
            dataGridViewSaving.Columns[2].HeaderText = "Amount";
            dataGridViewSaving.Columns[3].HeaderText = "Tenor";
        }

        private async void comboLoanMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSavingMaster.SelectedIndex == 0)
                ResetDropDown();

            if (comboSavingMaster.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(comboSavingMaster.SelectedValue.ToString());
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
            
        }

        private void buttonNewSaving_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField();
            buttonApply.Enabled = true;
            comboSavingMaster.SelectedIndex = 0;
            comboSavingMaster.Enabled = true;
        }

        private void buttonReload_Click_1(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }
    }
}
