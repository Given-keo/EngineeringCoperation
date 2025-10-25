using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringCoperation.Forms
{
    public partial class ProductPage : UserControl
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppContext();
            LoadGrids(db);
        }
        private void LoadGrids(AppDbContext db)
        {
            ProductService service = new ProductService(db);
            LoanMasterBindingSource.DataSource = service.LoadLoanGrid();
            SavingMasterBindingSource.DataSource = service.LoadSavingGrid();

            DataGridMasterLoan.Columns[0].Visible = false;
            DataGridMasterSaving.Columns[0].Visible = false;

            DataGridMasterLoan.Columns[0].DataPropertyName = "Id";
            DataGridMasterLoan.Columns[0].DataPropertyName = "Name";
            DataGridMasterLoan.Columns[0].DataPropertyName = "Interest";
            DataGridMasterLoan.Columns[0].DataPropertyName = "Tenor";


            DataGridMasterSaving.Columns[0].DataPropertyName = "Id";
            DataGridMasterSaving.Columns[0].DataPropertyName = "Name";
            DataGridMasterSaving.Columns[0].DataPropertyName = "Interest";
            DataGridMasterSaving.Columns[0].DataPropertyName = "Tenor";



        }

        private async Task BtnSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            productService service new ProductService(db);
            if (comboMode.SelectedIndex == 0)
            {
                await service.saveOrUpdateLoan(labelId.Text, TxtAdminFee.Text, TxtName.Text, TxtInterestFine.Text, TxtInterest.Text, TxtMaxAmount.Text, TxtMinAmount.Text, TxtTenor.Text);
            }
            else
            {
                await service.saveOrUpdateLoan(LabelId.Text, TxtAdminFee.Text, TxtName.Text, TxtInterestFine.Text, TxtInterest.Text, TxtMaxAmount.Text, TxtMinAmount.Text, TxtTenor.Text);
            }
            clearField();
            LoadGrids(db);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            clearField();
        }
        private void clearfield()
        {
            labelId.Text = "";
            TxtAdminFee.Text = "";
            TxtName.Text = "";
            TxtInterestFine.Text = "";
            TxtInterest.Text = "";
            TxtMaxAmount.Text = "";
            TxtMinAmount.Text = "";
            TxtTenor.Text = "";
            ComboMode.SelectedIndex = 0;
            BtnSubmit.Enabled = true;
        }

        private void DataGridMasterLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(DataGridMasterLoan.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                ProductService service = new ProductService(db);
                LoanMaster? loanMaster = await service.findLoanById(id);
                if (loanMaster != null)
                {
                    labelId.Text = loanMaster.Id.ToString();
                    TxtAdminFee.Text = loanMaster.AdminFee.ToString();
                    TxtName.Text = loanMaster.Name.ToString();
                    TxtInterestFine.Text = loanMaster.Fine.ToString();
                    TxtInterest.Text = loanMaster.Interest.ToString();
                    TxtMaxAmount.Text = loanMaster.MaxAmount.ToString();
                    TxtMinAmount.Text = loanMaster.MinAmount.ToString();
                    TxtTenor.Text = loanMaster.Tenor.ToString();
                    ComboMode.SelectedIndex = 1;
                    BtnSubmit.Enabled = false;
                }
            }
        }

        private void DataGridMasterSaving_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridViewSaving.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                ProductService service = new ProductService(db);
                SavingMaster? savingMaster = await service.findSavingById(id);
                if (savingMaster != null)
                {
                    labelId.Text = savingMaster.Id.ToString();
                    TxtAdminFee.Text = savingMaster.AdminFee.ToString();
                    TxtName.Text = savingMaster.Name.ToString();
                    TxtInterestFine.Text = savingMaster.Fine.ToString();
                    TxtInterest.Text = savingMaster.Interest.ToString();
                    TxtMaxAmount.Text = savingMaster.MaxAmount.ToString();
                    TxtMinAmount.Text = savingMaster.MinAmount.ToString();
                    TxtTenor.Text = savingMaster.Tenor.ToString();
                    ComboMode.SelectedIndex = 2;
                    BtnSubmit.Enabled = false;
                }
            }
        }






