using EngineeringCoperation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
private void TerminologiPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            Configuration? configuration = await service.GetConfig();
            if (configuration != null)
            {
                lblTermin1.Text = configuration.terminologi1;
                lblTermin2.Text = configuration.terminologi2;
                lblTermin3.Text = configuration.terminologi3;
                lblExchange.Text += " " + configuration.exchangeRate.ToString();
                lblInhouse.Text += " " + configuration.transferInhouseFee.ToString();
                lblAccross.Text += " " + configuration.transferAcrossFee.ToString();    
            }

        }
    }
}
