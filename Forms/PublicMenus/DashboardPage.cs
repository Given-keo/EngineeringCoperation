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

namespace EngineeringCoperation.Forms.PublicMenus
{
    public partial class DashboardPage : UserControl
    {
        private Member loggedMember;
        public DashboardPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

        }
    }
}
