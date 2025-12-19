namespace EngineeringCoperation.Forms.MemberMenus
{
    partial class LoanPage
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
            components = new System.ComponentModel.Container();
            textAmount = new TextBox();
            installmentBindingSource = new BindingSource(components);
            dataGridViewLoan = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LoanId = new DataGridViewTextBoxColumn();
            outstanding = new DataGridViewTextBoxColumn();
            tenorLeft = new DataGridViewTextBoxColumn();
            Fine = new DataGridViewTextBoxColumn();
            loanBindingSource = new BindingSource(components);
            loanMasterBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            comboLoanMaster = new ComboBox();
            label3 = new Label();
            textTenor = new TextBox();
            label4 = new Label();
            textInterest = new TextBox();
            label5 = new Label();
            textInterestFine = new TextBox();
            label6 = new Label();
            textDueDate = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textDocSlip = new TextBox();
            textDocKtp = new TextBox();
            textDocKK = new TextBox();
            buttonFileKTP = new Button();
            buttonFileKK = new Button();
            buttonFileSlip = new Button();
            buttonApply = new Button();
            buttonNewLoan = new Button();
            buttonShowDocKtp = new Button();
            buttonShowDocKk = new Button();
            buttonShowDocSlip = new Button();
            label10 = new Label();
            labelId = new Label();
            labelLoanID = new Label();
            textLoanId = new TextBox();
            label11 = new Label();
            textAdminFee = new TextBox();
            label12 = new Label();
            textMinAmount = new TextBox();
            label13 = new Label();
            textMaxAmount = new TextBox();
            buttonReload = new Button();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textAmount
            // 
            textAmount.Location = new Point(243, 42);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(204, 23);
            textAmount.TabIndex = 0;
            // 
            // installmentBindingSource
            // 
            installmentBindingSource.DataSource = typeof(Models.Installment);
            // 
            // dataGridViewLoan
            // 
            dataGridViewLoan.AllowUserToAddRows = false;
            dataGridViewLoan.AllowUserToDeleteRows = false;
            dataGridViewLoan.AutoGenerateColumns = false;
            dataGridViewLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoan.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, LoanId, outstanding, tenorLeft, Fine });
            dataGridViewLoan.DataSource = loanBindingSource;
            dataGridViewLoan.Location = new Point(464, 42);
            dataGridViewLoan.Name = "dataGridViewLoan";
            dataGridViewLoan.ReadOnly = true;
            dataGridViewLoan.Size = new Size(491, 337);
            dataGridViewLoan.TabIndex = 2;
            dataGridViewLoan.CellClick += dataGridViewLoan_CellClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // LoanId
            // 
            LoanId.DataPropertyName = "LoanId";
            LoanId.HeaderText = "LoanId";
            LoanId.Name = "LoanId";
            LoanId.ReadOnly = true;
            // 
            // outstanding
            // 
            outstanding.DataPropertyName = "outstanding";
            outstanding.HeaderText = "outstanding";
            outstanding.Name = "outstanding";
            outstanding.ReadOnly = true;
            // 
            // tenorLeft
            // 
            tenorLeft.DataPropertyName = "tenorLeft";
            tenorLeft.HeaderText = "tenorLeft";
            tenorLeft.Name = "tenorLeft";
            tenorLeft.ReadOnly = true;
            // 
            // Fine
            // 
            Fine.DataPropertyName = "Fine";
            Fine.HeaderText = "Fine";
            Fine.Name = "Fine";
            Fine.ReadOnly = true;
            // 
            // loanBindingSource
            // 
            loanBindingSource.DataSource = typeof(Models.Loan);
            // 
            // loanMasterBindingSource
            // 
            loanMasterBindingSource.DataSource = typeof(Models.LoanMaster);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 24);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 74);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Loan Type";
            // 
            // comboLoanMaster
            // 
            comboLoanMaster.DataSource = loanMasterBindingSource;
            comboLoanMaster.FormattingEnabled = true;
            comboLoanMaster.Location = new Point(23, 92);
            comboLoanMaster.Name = "comboLoanMaster";
            comboLoanMaster.Size = new Size(204, 23);
            comboLoanMaster.TabIndex = 5;
            comboLoanMaster.SelectedIndexChanged += comboLoanMaster_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 118);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Tenor";
            // 
            // textTenor
            // 
            textTenor.Location = new Point(243, 136);
            textTenor.Name = "textTenor";
            textTenor.ReadOnly = true;
            textTenor.Size = new Size(204, 23);
            textTenor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 74);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "Interest";
            // 
            // textInterest
            // 
            textInterest.Location = new Point(243, 92);
            textInterest.Name = "textInterest";
            textInterest.ReadOnly = true;
            textInterest.Size = new Size(204, 23);
            textInterest.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 207);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 11;
            label5.Text = "Interest Fine";
            // 
            // textInterestFine
            // 
            textInterestFine.Location = new Point(23, 225);
            textInterestFine.Name = "textInterestFine";
            textInterestFine.ReadOnly = true;
            textInterestFine.Size = new Size(204, 23);
            textInterestFine.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 252);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 13;
            label6.Text = "Due Date";
            // 
            // textDueDate
            // 
            textDueDate.Location = new Point(23, 270);
            textDueDate.Name = "textDueDate";
            textDueDate.Size = new Size(204, 23);
            textDueDate.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 300);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 19;
            label7.Text = "Document Slip Gaji";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(246, 207);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 17;
            label8.Text = "Document KTP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 300);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 15;
            label9.Text = "Document KK";
            // 
            // textDocSlip
            // 
            textDocSlip.Location = new Point(243, 318);
            textDocSlip.Name = "textDocSlip";
            textDocSlip.ReadOnly = true;
            textDocSlip.Size = new Size(204, 23);
            textDocSlip.TabIndex = 22;
            // 
            // textDocKtp
            // 
            textDocKtp.Location = new Point(243, 225);
            textDocKtp.Name = "textDocKtp";
            textDocKtp.ReadOnly = true;
            textDocKtp.Size = new Size(204, 23);
            textDocKtp.TabIndex = 21;
            // 
            // textDocKK
            // 
            textDocKK.Location = new Point(23, 318);
            textDocKK.Name = "textDocKK";
            textDocKK.ReadOnly = true;
            textDocKK.Size = new Size(204, 23);
            textDocKK.TabIndex = 20;
            // 
            // buttonFileKTP
            // 
            buttonFileKTP.Location = new Point(243, 254);
            buttonFileKTP.Name = "buttonFileKTP";
            buttonFileKTP.Size = new Size(74, 23);
            buttonFileKTP.TabIndex = 23;
            buttonFileKTP.Text = "Browse";
            buttonFileKTP.UseVisualStyleBackColor = true;
            buttonFileKTP.Click += buttonFileKTP_Click;
            // 
            // buttonFileKK
            // 
            buttonFileKK.Location = new Point(23, 347);
            buttonFileKK.Name = "buttonFileKK";
            buttonFileKK.Size = new Size(74, 23);
            buttonFileKK.TabIndex = 24;
            buttonFileKK.Text = "Browse";
            buttonFileKK.UseVisualStyleBackColor = true;
            buttonFileKK.Click += buttonFileKK_Click;
            // 
            // buttonFileSlip
            // 
            buttonFileSlip.Location = new Point(243, 347);
            buttonFileSlip.Name = "buttonFileSlip";
            buttonFileSlip.Size = new Size(74, 23);
            buttonFileSlip.TabIndex = 25;
            buttonFileSlip.Text = "Browse";
            buttonFileSlip.UseVisualStyleBackColor = true;
            buttonFileSlip.Click += buttonFileSlip_Click;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(92, 400);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(135, 23);
            buttonApply.TabIndex = 26;
            buttonApply.Text = "Apply Loan";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonNewLoan
            // 
            buttonNewLoan.Location = new Point(243, 400);
            buttonNewLoan.Name = "buttonNewLoan";
            buttonNewLoan.Size = new Size(125, 23);
            buttonNewLoan.TabIndex = 27;
            buttonNewLoan.Text = "New Loan";
            buttonNewLoan.UseVisualStyleBackColor = true;
            buttonNewLoan.Click += buttonNewLoan_Click;
            // 
            // buttonShowDocKtp
            // 
            buttonShowDocKtp.Location = new Point(373, 254);
            buttonShowDocKtp.Name = "buttonShowDocKtp";
            buttonShowDocKtp.Size = new Size(74, 23);
            buttonShowDocKtp.TabIndex = 29;
            buttonShowDocKtp.Text = "Show";
            buttonShowDocKtp.UseVisualStyleBackColor = true;
            // 
            // buttonShowDocKk
            // 
            buttonShowDocKk.Location = new Point(153, 347);
            buttonShowDocKk.Name = "buttonShowDocKk";
            buttonShowDocKk.Size = new Size(74, 23);
            buttonShowDocKk.TabIndex = 30;
            buttonShowDocKk.Text = "Show";
            buttonShowDocKk.UseVisualStyleBackColor = true;
            // 
            // buttonShowDocSlip
            // 
            buttonShowDocSlip.Location = new Point(373, 347);
            buttonShowDocSlip.Name = "buttonShowDocSlip";
            buttonShowDocSlip.Size = new Size(74, 23);
            buttonShowDocSlip.TabIndex = 31;
            buttonShowDocSlip.Text = "Show";
            buttonShowDocSlip.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(467, 24);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 32;
            label10.Text = "Loan";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(153, 25);
            labelId.Name = "labelId";
            labelId.Size = new Size(16, 15);
            labelId.TabIndex = 34;
            labelId.Text = "...";
            labelId.Visible = false;
            // 
            // labelLoanID
            // 
            labelLoanID.AutoSize = true;
            labelLoanID.Location = new Point(26, 25);
            labelLoanID.Name = "labelLoanID";
            labelLoanID.Size = new Size(47, 15);
            labelLoanID.TabIndex = 35;
            labelLoanID.Text = "Loan ID";
            // 
            // textLoanId
            // 
            textLoanId.Location = new Point(23, 42);
            textLoanId.Name = "textLoanId";
            textLoanId.ReadOnly = true;
            textLoanId.Size = new Size(204, 23);
            textLoanId.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 118);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 38;
            label11.Text = "Admin Fee";
            // 
            // textAdminFee
            // 
            textAdminFee.Location = new Point(23, 136);
            textAdminFee.Name = "textAdminFee";
            textAdminFee.ReadOnly = true;
            textAdminFee.Size = new Size(204, 23);
            textAdminFee.TabIndex = 37;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 163);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 42;
            label12.Text = "Min Amount";
            // 
            // textMinAmount
            // 
            textMinAmount.Location = new Point(23, 181);
            textMinAmount.Name = "textMinAmount";
            textMinAmount.ReadOnly = true;
            textMinAmount.Size = new Size(204, 23);
            textMinAmount.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(246, 163);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 40;
            label13.Text = "Max Amount";
            // 
            // textMaxAmount
            // 
            textMaxAmount.Location = new Point(243, 181);
            textMaxAmount.Name = "textMaxAmount";
            textMaxAmount.ReadOnly = true;
            textMaxAmount.Size = new Size(204, 23);
            textMaxAmount.TabIndex = 39;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(646, 400);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(125, 23);
            buttonReload.TabIndex = 43;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // LoanPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonReload);
            Controls.Add(label12);
            Controls.Add(textMinAmount);
            Controls.Add(label13);
            Controls.Add(textMaxAmount);
            Controls.Add(label11);
            Controls.Add(textAdminFee);
            Controls.Add(textLoanId);
            Controls.Add(labelLoanID);
            Controls.Add(labelId);
            Controls.Add(label10);
            Controls.Add(buttonShowDocSlip);
            Controls.Add(buttonShowDocKk);
            Controls.Add(buttonShowDocKtp);
            Controls.Add(buttonNewLoan);
            Controls.Add(buttonApply);
            Controls.Add(buttonFileSlip);
            Controls.Add(buttonFileKK);
            Controls.Add(buttonFileKTP);
            Controls.Add(textDocSlip);
            Controls.Add(textDocKtp);
            Controls.Add(textDocKK);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(textDueDate);
            Controls.Add(label5);
            Controls.Add(textInterestFine);
            Controls.Add(label4);
            Controls.Add(textInterest);
            Controls.Add(label3);
            Controls.Add(textTenor);
            Controls.Add(comboLoanMaster);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewLoan);
            Controls.Add(textAmount);
            Name = "LoanPage";
            Size = new Size(976, 442);
            Load += LoanPage_Load;
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textAmount;
        private DataGridView dataGridViewLoan;
        private Label label1;
        private Label label2;
        private ComboBox comboLoanMaster;
        private Label label3;
        private TextBox textTenor;
        private Label label4;
        private TextBox textInterest;
        private Label label5;
        private TextBox textInterestFine;
        private Label label6;
        private TextBox textDueDate;
        private Label label7;
        private Label label8;
        private Label label9;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textDocSlip;
        private TextBox textDocKtp;
        private TextBox textDocKK;
        private Button buttonFileKTP;
        private Button buttonFileKK;
        private Button buttonFileSlip;
        private Button buttonApply;
        private BindingSource loanMasterBindingSource;
        private Button buttonNewLoan;
        private Button buttonShowDocKtp;
        private Button buttonShowDocKk;
        private Button buttonShowDocSlip;
        private Label label10;
        private Label labelId;
        private BindingSource installmentBindingSource;
        private BindingSource loanBindingSource;
        private Label labelLoanID;
        private TextBox textLoanId;
        private Label label11;
        private TextBox textAdminFee;
        private Label label12;
        private TextBox textMinAmount;
        private Label label13;
        private TextBox textMaxAmount;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn LoanId;
        private DataGridViewTextBoxColumn outstanding;
        private DataGridViewTextBoxColumn tenorLeft;
        private DataGridViewTextBoxColumn Fine;
        private Button buttonReload;
    }
}
