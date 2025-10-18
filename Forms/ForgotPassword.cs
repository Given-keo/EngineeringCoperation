using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringCoperation.Forms
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db); //EA1C1B
            var password = await auth.ResetPasswordAsync(txtName.Text, txtBorn.Text, txtPet.Text);
            if (password = "")
            {
                MessageBox.Show("Invalid username or the answer.", "Validation Failed !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                txtPass.Text = password;
            }
        }
    }
}
