using EngineeringCoperation.Data;
using EngineeringCoperation.Models;
using Microsoft.EntityFrameworkCore;

namespace EngineeringCoperation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
           // Application.Run(new MainForm());

            try
            {
                using (var db = new AppDbContext())
                {
                    db.Database.Migrate();
                }

                // show login form
                using var login = new Forms.LoginForm();
                login.ShowDialog();
                /*if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Forms.HomeForm(login.LoggedInUser));
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection failed!\nPlease Check Your Network.\nCode:" + ex.Message,
                    "Database Connection ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}