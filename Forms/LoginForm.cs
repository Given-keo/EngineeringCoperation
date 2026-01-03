using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using EngineeringCoperation.Services;

namespace EngineeringCoperation.Forms
{
    public partial class LoginForm : Form
    {
        public Member? LoggedInUser { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        public void setSuccessAlert(String message)
        {
            labelSuccess.Text = message;
            labelSuccess.Visible = true;
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelSuccess.Visible = false;
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var user = await auth.LoginAsync(textUsername.Text, textPassword.Text);
            if (user != null)
            {
                LoggedInUser = user;
                if (LoggedInUser.level == "admin")
                {
                    this.Hide(); // this = form login
                    AdminForm form = new AdminForm(LoggedInUser);
                    form.ShowDialog();
                } else
                {
                    Balance balance = new Balance();
                    BalanceService balanceService = new BalanceService(db);
                    balanceService.setBalance(user.MemberId);

                    AccessService accessService = new AccessService(db);
                    Access access = await accessService.GetAccess(user.Id);
                    if (access == null)
                    {
                        labelSuccess.Text = "Access Is Not Granted By Admin!";
                        labelSuccess.ForeColor = Color.Red;
                        labelSuccess.Visible = true;
                    }
                    else
                    {
                        this.Hide();
                        HomeForm form = new HomeForm(LoggedInUser);
                        form.ShowDialog();
                    }
                }       
            }
            else
            {
                labelSuccess.Text = "Invalid Credentials";
                labelSuccess.ForeColor = Color.Red;
                labelSuccess.Visible = true;
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.ShowDialog();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }
    }
}
