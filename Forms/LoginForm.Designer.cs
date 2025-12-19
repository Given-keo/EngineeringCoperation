namespace EngineeringCoperation.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            buttonRegistration = new Button();
            linkForgotPassword = new LinkLabel();
            buttonSubmit = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textPassword = new TextBox();
            textUsername = new TextBox();
            labelSuccess = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 359);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // buttonRegistration
            // 
            buttonRegistration.Location = new Point(330, 314);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(90, 23);
            buttonRegistration.TabIndex = 16;
            buttonRegistration.Text = "Registration";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(498, 232);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(95, 15);
            linkForgotPassword.TabIndex = 15;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot Password";
            linkForgotPassword.VisitedLinkColor = Color.Blue;
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(330, 228);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 14;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(417, 65);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 13;
            label3.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 170);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 115);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(330, 188);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(265, 23);
            textPassword.TabIndex = 10;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(330, 133);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(265, 23);
            textUsername.TabIndex = 9;
            // 
            // labelSuccess
            // 
            labelSuccess.AutoSize = true;
            labelSuccess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuccess.ForeColor = Color.Green;
            labelSuccess.Location = new Point(330, 22);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(22, 21);
            labelSuccess.TabIndex = 18;
            labelSuccess.Text = "...";
            labelSuccess.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 361);
            Controls.Add(labelSuccess);
            Controls.Add(pictureBox1);
            Controls.Add(buttonRegistration);
            Controls.Add(linkForgotPassword);
            Controls.Add(buttonSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonRegistration;
        private LinkLabel linkForgotPassword;
        private Button buttonSubmit;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textPassword;
        private TextBox textUsername;
        private Label labelSuccess;
    }
}