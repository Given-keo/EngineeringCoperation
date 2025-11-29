
namespace EngineeringCoperation.Forms
{
    partial class AccessPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbMember = new ComboBox();
            btnSubmit = new Button();
            groupBox1 = new GroupBox();
            labelAddress = new Label();
            labelPhoneAlt = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelJoinDate = new Label();
            labelFullName = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridViewAccess = new DataGridView();
            label2 = new Label();
            listBoxAccess = new CheckedListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 35);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "Member";
            // 
            // cmbMember
            // 
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(44, 79);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(276, 33);
            cmbMember.TabIndex = 1;
            cmbMember.SelectedIndexChanged += cmbMember_SelectedIndexChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(338, 79);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelAddress);
            groupBox1.Controls.Add(labelPhoneAlt);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelJoinDate);
            groupBox1.Controls.Add(labelFullName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(51, 396);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 247);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(178, 209);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(26, 25);
            labelAddress.TabIndex = 11;
            labelAddress.Text = "--";
            // 
            // labelPhoneAlt
            // 
            labelPhoneAlt.AutoSize = true;
            labelPhoneAlt.Location = new Point(178, 170);
            labelPhoneAlt.Name = "labelPhoneAlt";
            labelPhoneAlt.Size = new Size(26, 25);
            labelPhoneAlt.TabIndex = 10;
            labelPhoneAlt.Text = "--";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(178, 135);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(26, 25);
            labelPhone.TabIndex = 9;
            labelPhone.Text = "--";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(178, 100);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(26, 25);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "--";
            // 
            // labelJoinDate
            // 
            labelJoinDate.AutoSize = true;
            labelJoinDate.Location = new Point(178, 64);
            labelJoinDate.Name = "labelJoinDate";
            labelJoinDate.Size = new Size(26, 25);
            labelJoinDate.TabIndex = 7;
            labelJoinDate.Text = "--";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(178, 27);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(26, 25);
            labelFullName.TabIndex = 6;
            labelFullName.Text = "--";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 209);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 5;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 170);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 4;
            label7.Text = "Phone Alt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 135);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 3;
            label6.Text = "Phone";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 100);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 64);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 1;
            label4.Text = "JoinDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 27);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 0;
            label3.Text = "FullName";
            // 
            // dataGridViewAccess
            // 
            dataGridViewAccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccess.Location = new Point(471, 79);
            dataGridViewAccess.Name = "dataGridViewAccess";
            dataGridViewAccess.RowHeadersWidth = 62;
            dataGridViewAccess.Size = new Size(418, 564);
            dataGridViewAccess.TabIndex = 5;
            dataGridViewAccess.CellContentClick += dataGridViewAccess_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 35);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 6;
            label2.Text = "Access";
            // 
            // listBoxAccess
            // 
            listBoxAccess.FormattingEnabled = true;
            listBoxAccess.Items.AddRange(new object[] { "Grant All", "Loan", "Saving", "Transfer - Inhouse", "Transfer - Accross", "Exchange" });
            listBoxAccess.Location = new Point(44, 127);
            listBoxAccess.Name = "listBoxAccess";
            listBoxAccess.Size = new Size(406, 256);
            listBoxAccess.TabIndex = 7;
            // 
            // AccessPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxAccess);
            Controls.Add(label2);
            Controls.Add(dataGridViewAccess);
            Controls.Add(groupBox1);
            Controls.Add(btnSubmit);
            Controls.Add(cmbMember);
            Controls.Add(label1);
            Name = "AccessPage";
            Size = new Size(1026, 681);
            Load += AccessPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void AccessPage_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMember;
        private Button btnSubmit;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridViewAccess;
        private Label label2;
        private Label labelFullName;
        private Label label8;
        private Label label7;
        private Label labelAddress;
        private Label labelPhoneAlt;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelJoinDate;
        private CheckedListBox listBoxAccess;
    }
}
