namespace EngineeringCoperation.Forms
{
    partial class RegistrationForm
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
            textFullname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textUsername = new TextBox();
            label3 = new Label();
            textPassword = new TextBox();
            label4 = new Label();
            textPhoneAlt = new TextBox();
            label5 = new Label();
            textPhone = new TextBox();
            label6 = new Label();
            textCardId = new TextBox();
            label7 = new Label();
            textAddress = new TextBox();
            label8 = new Label();
            textReferenceId = new TextBox();
            label9 = new Label();
            textEmail = new TextBox();
            buttonSubmit = new Button();
            buttonBack = new Button();
            label10 = new Label();
            textQuest2 = new TextBox();
            label11 = new Label();
            textQuest1 = new TextBox();
            labelError = new Label();
            SuspendLayout();
            // 
            // textFullname
            // 
            textFullname.Location = new Point(25, 44);
            textFullname.Name = "textFullname";
            textFullname.Size = new Size(218, 23);
            textFullname.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 26);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(254, 44);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(218, 23);
            textUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 26);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(484, 44);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(218, 23);
            textPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 78);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 11;
            label4.Text = "Phone Alt";
            // 
            // textPhoneAlt
            // 
            textPhoneAlt.Location = new Point(484, 96);
            textPhoneAlt.Name = "textPhoneAlt";
            textPhoneAlt.Size = new Size(218, 23);
            textPhoneAlt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 78);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Phone";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(254, 96);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(218, 23);
            textPhone.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 78);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 7;
            label6.Text = "Card ID";
            // 
            // textCardId
            // 
            textCardId.Location = new Point(25, 96);
            textCardId.Name = "textCardId";
            textCardId.Size = new Size(218, 23);
            textCardId.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 126);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 17;
            label7.Text = "Address";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(484, 144);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(218, 73);
            textAddress.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(257, 126);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 15;
            label8.Text = "Reference ID";
            // 
            // textReferenceId
            // 
            textReferenceId.Location = new Point(254, 144);
            textReferenceId.Name = "textReferenceId";
            textReferenceId.ReadOnly = true;
            textReferenceId.Size = new Size(218, 23);
            textReferenceId.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 126);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 13;
            label9.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(25, 144);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(218, 23);
            textEmail.TabIndex = 12;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(25, 228);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 18;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(106, 228);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 19;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(257, 176);
            label10.Name = "label10";
            label10.Size = new Size(165, 15);
            label10.TabIndex = 23;
            label10.Text = "Who is Your Fav Artist/Singer?";
            // 
            // textQuest2
            // 
            textQuest2.Location = new Point(254, 194);
            textQuest2.Name = "textQuest2";
            textQuest2.Size = new Size(218, 23);
            textQuest2.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 176);
            label11.Name = "label11";
            label11.Size = new Size(131, 15);
            label11.TabIndex = 21;
            label11.Text = "What is Your Fav Color?";
            // 
            // textQuest1
            // 
            textQuest1.Location = new Point(25, 194);
            textQuest1.Name = "textQuest1";
            textQuest1.Size = new Size(218, 23);
            textQuest1.TabIndex = 20;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(213, 232);
            labelError.Name = "labelError";
            labelError.Size = new Size(22, 21);
            labelError.TabIndex = 24;
            labelError.Text = "...";
            labelError.Visible = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 285);
            ControlBox = false;
            Controls.Add(labelError);
            Controls.Add(label10);
            Controls.Add(textQuest2);
            Controls.Add(label11);
            Controls.Add(textQuest1);
            Controls.Add(buttonBack);
            Controls.Add(buttonSubmit);
            Controls.Add(label7);
            Controls.Add(textAddress);
            Controls.Add(label8);
            Controls.Add(textReferenceId);
            Controls.Add(label9);
            Controls.Add(textEmail);
            Controls.Add(label4);
            Controls.Add(textPhoneAlt);
            Controls.Add(label5);
            Controls.Add(textPhone);
            Controls.Add(label6);
            Controls.Add(textCardId);
            Controls.Add(label3);
            Controls.Add(textPassword);
            Controls.Add(label2);
            Controls.Add(textUsername);
            Controls.Add(label1);
            Controls.Add(textFullname);
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFullname;
        private Label label1;
        private Label label2;
        private TextBox textUsername;
        private Label label3;
        private TextBox textPassword;
        private Label label4;
        private TextBox textPhoneAlt;
        private Label label5;
        private TextBox textPhone;
        private Label label6;
        private TextBox textCardId;
        private Label label7;
        private TextBox textAddress;
        private Label label8;
        private TextBox textReferenceId;
        private Label label9;
        private TextBox textEmail;
        private Button buttonSubmit;
        private Button buttonBack;
        private Label label10;
        private TextBox textQuest2;
        private Label label11;
        private TextBox textQuest1;
        private Label labelError;
    }
}