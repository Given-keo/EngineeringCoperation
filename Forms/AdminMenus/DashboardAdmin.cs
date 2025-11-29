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
    public partial class DashboardAdmin : UserControl
    {
        private Member? loggedMember;
        public DashboardAdmin(Member? member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
