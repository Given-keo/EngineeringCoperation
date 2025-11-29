using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringCoperation.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var member = auth.RegisterAsync(txtAddress.Text, txtCardId.Text,
                txtEmail.Text, txtFullName.Text, txtPassword.Text,
                txtPhone.Text, txtPhoneAlt.Text, txtReferenceId.Text,
                txtUsername.Text, txtQuestion1.Text, txtQuestion2.Text);

            if (member != null)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.setSuccessAlert("Registration Success! Please Login...");
                loginForm.ShowDialog();
            }
            else
            {
                labelError.Text = "Registration Failed!";
                labelError.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
