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
            lblJudul = new Label();
            LblSign = new Label();
            TxtBUsername = new TextBox();
            TxtBPassword = new TextBox();
            BtnSubmit = new Button();
            BtnReg = new Button();
            LblLink = new LinkLabel();
            pictureBox1 = new PictureBox();
            LblRegSign = new Label();
            LblUsername = new Label();
            LblPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("TT Octosquares Trl Cnd XBd", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(540, 63);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(89, 33);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "LOGIN";
            // 
            // LblSign
            // 
            LblSign.AutoSize = true;
            LblSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSign.ForeColor = Color.Red;
            LblSign.Location = new Point(389, 12);
            LblSign.Name = "LblSign";
            LblSign.Size = new Size(35, 32);
            LblSign.TabIndex = 1;
            LblSign.Text = "...";
            
            // 
            // TxtBUsername
            // 
            TxtBUsername.Location = new Point(419, 151);
            TxtBUsername.Name = "TxtBUsername";
            TxtBUsername.Size = new Size(350, 31);
            TxtBUsername.TabIndex = 2;
            // 
            // TxtBPassword
            // 
            TxtBPassword.Location = new Point(419, 214);
            TxtBPassword.Name = "TxtBPassword";
            TxtBPassword.Size = new Size(350, 31);
            TxtBPassword.TabIndex = 3;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(416, 283);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(128, 34);
            BtnSubmit.TabIndex = 4;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // BtnReg
            // 
            BtnReg.Location = new Point(419, 376);
            BtnReg.Name = "BtnReg";
            BtnReg.Size = new Size(125, 34);
            BtnReg.TabIndex = 5;
            BtnReg.Text = "Regitsration";
            BtnReg.UseVisualStyleBackColor = true;
            BtnReg.Click += BtnReg_Click;
            // 
            // LblLink
            // 
            LblLink.AutoSize = true;
            LblLink.Location = new Point(623, 288);
            LblLink.Name = "LblLink";
            LblLink.Size = new Size(146, 25);
            LblLink.TabIndex = 6;
            LblLink.TabStop = true;
            LblLink.Text = "Forgot Password";
            LblLink.LinkClicked += LblLink_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 411);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LblRegSign
            // 
            LblRegSign.AutoSize = true;
            LblRegSign.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblRegSign.Location = new Point(419, 348);
            LblRegSign.Name = "LblRegSign";
            LblRegSign.Size = new Size(183, 25);
            LblRegSign.TabIndex = 8;
            LblRegSign.Text = "Dont Have account ?";
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUsername.Location = new Point(419, 123);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(96, 25);
            LblUsername.TabIndex = 9;
            LblUsername.Text = "Username";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPassword.Location = new Point(419, 185);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(90, 25);
            LblPassword.TabIndex = 10;
            LblPassword.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(LblPassword);
            Controls.Add(LblUsername);
            Controls.Add(LblRegSign);
            Controls.Add(pictureBox1);
            Controls.Add(LblLink);
            Controls.Add(BtnReg);
            Controls.Add(BtnSubmit);
            Controls.Add(TxtBPassword);
            Controls.Add(TxtBUsername);
            Controls.Add(LblSign);
            Controls.Add(lblJudul);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label LblSign;
        private TextBox TxtBUsername;
        private TextBox TxtBPassword;
        private Button BtnSubmit;
        private Button BtnReg;
        private LinkLabel LblLink;
        private PictureBox pictureBox1;
        private Label LblRegSign;
        private Label LblUsername;
        private Label LblPassword;
    }
}