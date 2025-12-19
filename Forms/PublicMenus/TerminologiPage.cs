using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;

namespace EngineeringCoperation.Forms.PublicMenus
{
    public partial class TerminologiPage : UserControl
    {
        private Member? loggedMember;
        public TerminologiPage(Member? member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private async void TerminologiPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            Configuration? configuration = await service.GetConfig();
            if (configuration != null) {
                labelTerminologi1.Text = configuration.terminologi1;
                labelTerminologi2.Text = configuration.terminologi2;
                labelTerminologi3.Text = configuration.terminologi3;
                labelExchange.Text += " " + configuration.exchangeRate.ToString();
                labelInhouse.Text += " " + configuration.transferInhouseFee.ToString();
                labelAccross.Text += " " + configuration.transferAcrossFee.ToString();
            }
        }
    }
}
