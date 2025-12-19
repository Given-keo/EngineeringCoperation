using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineeringCoperation.Models;

namespace EngineeringCoperation.Forms.AdminMenus
{
    public partial class DashboardAdminPage : UserControl
    {
        private Member? loggedMember;
        public DashboardAdminPage(Member? member )
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void DashboardAdminControl_Load(object sender, EventArgs e)
        {

        }
    }
}
