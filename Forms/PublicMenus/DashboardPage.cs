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

namespace EngineeringCoperation.Forms.AdminMenus
{
    public partial class DashboardPage : UserControl
    {
        private Member loggedMember;
        public DashboardPage(Member member)
        {
            loggedMember = Member;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
        }
    }
}
