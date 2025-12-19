using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;

namespace EngineeringCoperation.Forms.AdminMenus
{
    public partial class ConfigPage : UserControl
    {
        public ConfigPage()
        {
            InitializeComponent();
        }

        private async void ConfigPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            Configuration config = await service.GetConfig();
            if (config != null)
            {
                textTerminologi1.Text = config.terminologi1;
                textTerminologi2.Text = config.terminologi2;
                textTerminologi3.Text = config.terminologi3;
                textExchangeRate.Text = config.exchangeRate.ToString();
                textInhouseFee.Text = config.transferInhouseFee.ToString();
                textAccrossFee.Text = config.transferAcrossFee.ToString();
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            decimal exchangeRate = decimal.Parse(textExchangeRate.Text);
            decimal inhouseFee = decimal.Parse(textInhouseFee.Text);
            decimal accrossFee = decimal.Parse(textAccrossFee.Text);

            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            await service.addOrUpdate(textTerminologi1.Text, textTerminologi2.Text,
                textTerminologi3.Text, exchangeRate, inhouseFee, accrossFee);
            MessageBox.Show("Configuration updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
