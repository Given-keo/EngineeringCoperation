using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;

namespace EngineeringCoperation.Forms.AdminMenus
{
    public partial class ProductPage : UserControl
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            LoadGrids(db);
        }

        private void LoadGrids(AppDbContext db)
        {
            ProductService service = new ProductService(db);
            loanMasterBindingSource.DataSource = service.LoadLoanGrid();
            savingMasterBindingSource.DataSource = service.LoadSavingGrid();

            dataGridViewLoan.Columns[0].Visible = false;
            dataGridViewSaving.Columns[0].Visible = false;

            dataGridViewLoan.Columns[0].DataPropertyName = "Id";
            dataGridViewLoan.Columns[1].DataPropertyName = "Name";
            dataGridViewLoan.Columns[2].DataPropertyName = "Interest";
            dataGridViewLoan.Columns[3].DataPropertyName = "Tenor";

            dataGridViewSaving.Columns[0].DataPropertyName = "Id";
            dataGridViewSaving.Columns[1].DataPropertyName = "Name";
            dataGridViewSaving.Columns[2].DataPropertyName = "Interest";
            dataGridViewSaving.Columns[3].DataPropertyName = "Tenor";
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ProductService service = new ProductService(db);
            if (comboMode.SelectedIndex == 0) // loan
            {
                await service.saveOrUpdateLoan(labelId.Text, textAdminFee.Text, textBoxName.Text,
                    textFine.Text, textInterest.Text, textMaxAmount.Text,
                    textMinAmount.Text, textTenor.Text);
            }
            else
            {
                await service.saveOrUpdateSaving(labelId.Text, textAdminFee.Text, textBoxName.Text,
                    textFine.Text, textInterest.Text, textMaxAmount.Text,
                    textMinAmount.Text, textTenor.Text);
            }
            clearField();
            LoadGrids(db);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void clearField()
        {
            labelId.Text = "";
            textAdminFee.Text = "";
            textBoxName.Text = "";
            textFine.Text = "";
            textInterest.Text = "";
            textMaxAmount.Text = "";
            textMinAmount.Text = "";
            textTenor.Text = "";
            comboMode.SelectedIndex = 0;
            buttonSubmit.Enabled = true;
        }

        private async void dataGridViewLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridViewLoan.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                ProductService service = new ProductService(db);
                LoanMaster? loanMaster = await service.findLoanById(id);
                if (loanMaster != null)
                {
                    labelId.Text = loanMaster.Id.ToString();
                    textAdminFee.Text = loanMaster.AdminFee.ToString();
                    textBoxName.Text = loanMaster.Name.ToString();
                    textFine.Text = loanMaster.Fine.ToString();
                    textInterest.Text = loanMaster.Interest.ToString();
                    textMaxAmount.Text = loanMaster.MaxAmount.ToString();
                    textMinAmount.Text = loanMaster.MinAmount.ToString();
                    textTenor.Text = loanMaster.Tenor.ToString();
                    comboMode.SelectedIndex = 1;
                    buttonSubmit.Enabled = false;
                }
            }
        }

        private async void dataGridViewSaving_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    textAdminFee.Text = savingMaster.AdminFee.ToString();
                    textBoxName.Text = savingMaster.Name.ToString();
                    textFine.Text = savingMaster.Fine.ToString();
                    textInterest.Text = savingMaster.Interest.ToString();
                    textMaxAmount.Text = savingMaster.MaxAmount.ToString();
                    textMinAmount.Text = savingMaster.MinAmount.ToString();
                    textTenor.Text = savingMaster.Tenor.ToString();
                    comboMode.SelectedIndex = 2;
                    buttonSubmit.Enabled = false;
                }
            }
        }  
    }
}
