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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFullName = new TextBox();
            txtCardId = new TextBox();
            txtEmail = new TextBox();
            txtQuestion1 = new TextBox();
            txtQuestion2 = new TextBox();
            txtReferenceId = new TextBox();
            txtPhone = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSubmit = new Button();
            btnBack = new Button();
            Password = new Label();
            txtPassword = new TextBox();
            txtPhoneAlt = new TextBox();
            label10 = new Label();
            txtAddress = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 121);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "Card ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 233);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 344);
            label4.Name = "label4";
            label4.Size = new Size(199, 25);
            label4.TabIndex = 3;
            label4.Text = "What Is Your Fav Color?";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(27, 51);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(329, 31);
            txtFullName.TabIndex = 4;
            // 
            // txtCardId
            // 
            txtCardId.Location = new Point(27, 158);
            txtCardId.Name = "txtCardId";
            txtCardId.Size = new Size(329, 31);
            txtCardId.TabIndex = 5;
            txtCardId.TextChanged += txtCard_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(27, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(329, 31);
            txtEmail.TabIndex = 6;
            // 
            // txtQuestion1
            // 
            txtQuestion1.Location = new Point(27, 386);
            txtQuestion1.Name = "txtQuestion1";
            txtQuestion1.Size = new Size(329, 31);
            txtQuestion1.TabIndex = 7;
            // 
            // txtQuestion2
            // 
            txtQuestion2.Location = new Point(430, 386);
            txtQuestion2.Name = "txtQuestion2";
            txtQuestion2.Size = new Size(329, 31);
            txtQuestion2.TabIndex = 15;
            // 
            // txtReferenceId
            // 
            txtReferenceId.Location = new Point(430, 272);
            txtReferenceId.Name = "txtReferenceId";
            txtReferenceId.Size = new Size(329, 31);
            txtReferenceId.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(430, 158);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(329, 31);
            txtPhone.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(430, 51);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(329, 31);
            txtUsername.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 344);
            label5.Name = "label5";
            label5.Size = new Size(250, 25);
            label5.TabIndex = 11;
            label5.Text = "Who is Your Fav Artist/Singer?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 233);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 10;
            label6.Text = "Reference ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(430, 121);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 9;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(430, 23);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 8;
            label8.Text = "Username";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(27, 452);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(139, 34);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(191, 452);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(137, 34);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button2_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(849, 23);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 18;
            Password.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(849, 51);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 31);
            txtPassword.TabIndex = 19;
            // 
            // txtPhoneAlt
            // 
            txtPhoneAlt.Location = new Point(849, 158);
            txtPhoneAlt.Name = "txtPhoneAlt";
            txtPhoneAlt.Size = new Size(315, 31);
            txtPhoneAlt.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(849, 121);
            label10.Name = "label10";
            label10.Size = new Size(89, 25);
            label10.TabIndex = 20;
            label10.Text = "Phone Alt";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(849, 272);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(315, 145);
            txtAddress.TabIndex = 23;
            txtAddress.TextChanged += textBox3_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(849, 244);
            label11.Name = "label11";
            label11.Size = new Size(77, 25);
            label11.TabIndex = 22;
            label11.Text = "Address";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 510);
            Controls.Add(txtAddress);
            Controls.Add(label11);
            Controls.Add(txtPhoneAlt);
            Controls.Add(label10);
            Controls.Add(txtPassword);
            Controls.Add(Password);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(txtQuestion2);
            Controls.Add(txtReferenceId);
            Controls.Add(txtPhone);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtQuestion1);
            Controls.Add(txtEmail);
            Controls.Add(txtCardId);
            Controls.Add(txtFullName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFullName;
        private TextBox txtCardId;
        private TextBox txtEmail;
        private TextBox txtQuestion1;
        private TextBox txtQuestion2;
        private TextBox txtReferenceId;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSubmit;
        private Button btnBack;
        private Label Password;
        private TextBox txtPassword;
        private TextBox txtPhoneAlt;
        private Label label10;
        private TextBox txtAddress;
        private Label label11;
    }
}