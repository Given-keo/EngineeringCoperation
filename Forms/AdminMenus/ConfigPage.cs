using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void ConfigPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = AppDbContext();
            ConfigurationService Service = new ConfigurationService(db);
            if (config != null)
            {
                txtTermin1.Text = config.termin1;
                txtTermin2.Text = config.termin2;
                txtTermin3.Text = config.termin3;
                txtExchange.Text = config.ExchangeRate.ToString();
                txtInhouse.Text = config.TranferAcrossFee.ToString();
            }
        }

        private async Task btnUpdate_Click(object sender, EventArgs e)
        {
            decimal exchangeRate = decimal.Parse(txtExchange.Text);
            decimal inhouseFee = decimal.Parse(txtInhouse.Text);
            decimal accrossFee = decimal.Parse(txtAccross.Text);

            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            await service.addOrUpdate(txtTermin1.Text, txtTermin2.Text,
                txtTermin3.Text, exchangeRate, inhouseFee, accrossFee);
            MessageBox.Show("Configuration updated successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
