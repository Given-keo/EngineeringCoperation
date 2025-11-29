
using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;
using System.CodeDom;

namespace EngineeringCoperation.Forms.AdminMenus
{
    public partial class ConfigPage : UserControl
    {
        public ConfigPage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ConfigPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService Service = new ConfigurationService(db);
            Configuration config = await Service.GetConfig();
            if (config != null)
            {
                txtTermin1.Text = config.terminologi1;
                txtTermin2.Text = config.terminologi2;
                txtTermin3.Text = config.terminologi3;
                textExchangeRate.Text = config.exchangeRate.ToString();
                textInhouseFee.Text = config.transferInhouseFee.ToString();
                textInhouseFee.Text = config.transferAcrossFee.ToString();
            }
        }

        private async Task btnUpdate_Click(object sender, EventArgs e)
        {
            decimal exchangeRate = decimal.Parse(textExchangeRate.Text);
            decimal inhouseFee = decimal.Parse(textInhouseFee.Text);
            decimal accrossFee = decimal.Parse(textAccrossFee.Text);

            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            await service.addOrUpdate(txtTermin1.Text, txtTermin2.Text,
                txtTermin3.Text, exchangeRate, inhouseFee, accrossFee);
            MessageBox.Show("Configuration updated successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
