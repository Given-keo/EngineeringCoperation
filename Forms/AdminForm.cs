using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineeringCoperation.Forms.AdminMenus;
using EngineeringCoperation.Models;

namespace EngineeringCoperation.Forms
{
    public partial class AdminForm : Form

    {
        Member? loggedMember = null;
        public AdminForm(Member member)
        {
            loggedMember = member;
            InitializeComponent();
            this.Text = "Engineering Cooperation (Administrator: " +
                loggedMember.MemberId + " - " + loggedMember.FullName + ")";
        }

        public void route(System.Windows.Forms.Control control)
        {
            this.panelAdminForm.Controls.Clear();
            this.panelAdminForm.Dock = DockStyle.Fill;
            this.panelAdminForm.Controls.Add(control);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            route(new DashboardAdmin(loggedMember));
        }


        private void accessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AccessPage(loggedMember));
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ConfigPage());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggedMember = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new member());
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ProductPage());
        }

        private void acrossCooperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AcrossPage());
        }

        private void approvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ApprovalPage(loggedMember));
        }
    }
}
