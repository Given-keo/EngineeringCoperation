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
            textAmount.Location = new Point(278, 56);
            textAmount.Margin = new Padding(3, 4, 3, 4);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(233, 27);
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
            dataGridViewLoan.Location = new Point(530, 56);
            dataGridViewLoan.Margin = new Padding(3, 4, 3, 4);
            dataGridViewLoan.Name = "dataGridViewLoan";
            dataGridViewLoan.ReadOnly = true;
            dataGridViewLoan.RowHeadersWidth = 51;
            dataGridViewLoan.Size = new Size(561, 449);
            dataGridViewLoan.TabIndex = 2;
            dataGridViewLoan.CellClick += dataGridViewLoan_CellClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // LoanId
            // 
            LoanId.DataPropertyName = "LoanId";
            LoanId.HeaderText = "LoanId";
            LoanId.MinimumWidth = 6;
            LoanId.Name = "LoanId";
            LoanId.ReadOnly = true;
            LoanId.Width = 125;
            // 
            // outstanding
            // 
            outstanding.DataPropertyName = "outstanding";
            outstanding.HeaderText = "outstanding";
            outstanding.MinimumWidth = 6;
            outstanding.Name = "outstanding";
            outstanding.ReadOnly = true;
            outstanding.Width = 125;
            // 
            // tenorLeft
            // 
            tenorLeft.DataPropertyName = "tenorLeft";
            tenorLeft.HeaderText = "tenorLeft";
            tenorLeft.MinimumWidth = 6;
            tenorLeft.Name = "tenorLeft";
            tenorLeft.ReadOnly = true;
            tenorLeft.Width = 125;
            // 
            // Fine
            // 
            Fine.DataPropertyName = "Fine";
            Fine.HeaderText = "Fine";
            Fine.MinimumWidth = 6;
            Fine.Name = "Fine";
            Fine.ReadOnly = true;
            Fine.Width = 125;
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
            label1.Location = new Point(281, 32);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 99);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Loan Type";
            // 
            // comboLoanMaster
            // 
            comboLoanMaster.DataSource = loanMasterBindingSource;
            comboLoanMaster.FormattingEnabled = true;
            comboLoanMaster.Location = new Point(26, 123);
            comboLoanMaster.Margin = new Padding(3, 4, 3, 4);
            comboLoanMaster.Name = "comboLoanMaster";
            comboLoanMaster.Size = new Size(233, 28);
            comboLoanMaster.TabIndex = 5;
            comboLoanMaster.SelectedIndexChanged += comboLoanMaster_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 157);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 7;
            label3.Text = "Tenor";
            // 
            // textTenor
            // 
            textTenor.Location = new Point(278, 181);
            textTenor.Margin = new Padding(3, 4, 3, 4);
            textTenor.Name = "textTenor";
            textTenor.ReadOnly = true;
            textTenor.Size = new Size(233, 27);
            textTenor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 99);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 9;
            label4.Text = "Interest";
            // 
            // textInterest
            // 
            textInterest.Location = new Point(278, 123);
            textInterest.Margin = new Padding(3, 4, 3, 4);
            textInterest.Name = "textInterest";
            textInterest.ReadOnly = true;
            textInterest.Size = new Size(233, 27);
            textInterest.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 276);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 11;
            label5.Text = "Interest Fine";
            // 
            // textInterestFine
            // 
            textInterestFine.Location = new Point(26, 300);
            textInterestFine.Margin = new Padding(3, 4, 3, 4);
            textInterestFine.Name = "textInterestFine";
            textInterestFine.ReadOnly = true;
            textInterestFine.Size = new Size(233, 27);
            textInterestFine.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 336);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 13;
            label6.Text = "Due Date";
            // 
            // textDueDate
            // 
            textDueDate.Location = new Point(26, 360);
            textDueDate.Margin = new Padding(3, 4, 3, 4);
            textDueDate.Name = "textDueDate";
            textDueDate.Size = new Size(233, 27);
            textDueDate.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(281, 400);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 19;
            label7.Text = "Document Slip Gaji";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(281, 276);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 17;
            label8.Text = "Document KTP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 400);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 15;
            label9.Text = "Document KK";
            // 
            // textDocSlip
            // 
            textDocSlip.Location = new Point(278, 424);
            textDocSlip.Margin = new Padding(3, 4, 3, 4);
            textDocSlip.Name = "textDocSlip";
            textDocSlip.ReadOnly = true;
            textDocSlip.Size = new Size(233, 27);
            textDocSlip.TabIndex = 22;
            // 
            // textDocKtp
            // 
            textDocKtp.Location = new Point(278, 300);
            textDocKtp.Margin = new Padding(3, 4, 3, 4);
            textDocKtp.Name = "textDocKtp";
            textDocKtp.ReadOnly = true;
            textDocKtp.Size = new Size(233, 27);
            textDocKtp.TabIndex = 21;
            // 
            // textDocKK
            // 
            textDocKK.Location = new Point(26, 424);
            textDocKK.Margin = new Padding(3, 4, 3, 4);
            textDocKK.Name = "textDocKK";
            textDocKK.ReadOnly = true;
            textDocKK.Size = new Size(233, 27);
            textDocKK.TabIndex = 20;
            // 
            // buttonFileKTP
            // 
            buttonFileKTP.Location = new Point(278, 339);
            buttonFileKTP.Margin = new Padding(3, 4, 3, 4);
            buttonFileKTP.Name = "buttonFileKTP";
            buttonFileKTP.Size = new Size(85, 31);
            buttonFileKTP.TabIndex = 23;
            buttonFileKTP.Text = "Browse";
            buttonFileKTP.UseVisualStyleBackColor = true;
            buttonFileKTP.Click += buttonFileKTP_Click;
            // 
            // buttonFileKK
            // 
            buttonFileKK.Location = new Point(26, 463);
            buttonFileKK.Margin = new Padding(3, 4, 3, 4);
            buttonFileKK.Name = "buttonFileKK";
            buttonFileKK.Size = new Size(85, 31);
            buttonFileKK.TabIndex = 24;
            buttonFileKK.Text = "Browse";
            buttonFileKK.UseVisualStyleBackColor = true;
            buttonFileKK.Click += buttonFileKK_Click;
            // 
            // buttonFileSlip
            // 
            buttonFileSlip.Location = new Point(278, 463);
            buttonFileSlip.Margin = new Padding(3, 4, 3, 4);
            buttonFileSlip.Name = "buttonFileSlip";
            buttonFileSlip.Size = new Size(85, 31);
            buttonFileSlip.TabIndex = 25;
            buttonFileSlip.Text = "Browse";
            buttonFileSlip.UseVisualStyleBackColor = true;
            buttonFileSlip.Click += buttonFileSlip_Click;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(105, 533);
            buttonApply.Margin = new Padding(3, 4, 3, 4);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(154, 31);
            buttonApply.TabIndex = 26;
            buttonApply.Text = "Apply Loan";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonNewLoan
            // 
            buttonNewLoan.Location = new Point(278, 533);
            buttonNewLoan.Margin = new Padding(3, 4, 3, 4);
            buttonNewLoan.Name = "buttonNewLoan";
            buttonNewLoan.Size = new Size(143, 31);
            buttonNewLoan.TabIndex = 27;
            buttonNewLoan.Text = "New Loan";
            buttonNewLoan.UseVisualStyleBackColor = true;
            buttonNewLoan.Click += buttonNewLoan_Click;
            // 
            // buttonShowDocKtp
            // 
            buttonShowDocKtp.Location = new Point(426, 339);
            buttonShowDocKtp.Margin = new Padding(3, 4, 3, 4);
            buttonShowDocKtp.Name = "buttonShowDocKtp";
            buttonShowDocKtp.Size = new Size(85, 31);
            buttonShowDocKtp.TabIndex = 29;
            buttonShowDocKtp.Text = "Show";
            buttonShowDocKtp.UseVisualStyleBackColor = true;
            // 
            // buttonShowDocKk
            // 
            buttonShowDocKk.Location = new Point(175, 463);
            buttonShowDocKk.Margin = new Padding(3, 4, 3, 4);
            buttonShowDocKk.Name = "buttonShowDocKk";
            buttonShowDocKk.Size = new Size(85, 31);
            buttonShowDocKk.TabIndex = 30;
            buttonShowDocKk.Text = "Show";
            buttonShowDocKk.UseVisualStyleBackColor = true;
            // 
            // buttonShowDocSlip
            // 
            buttonShowDocSlip.Location = new Point(426, 463);
            buttonShowDocSlip.Margin = new Padding(3, 4, 3, 4);
            buttonShowDocSlip.Name = "buttonShowDocSlip";
            buttonShowDocSlip.Size = new Size(85, 31);
            buttonShowDocSlip.TabIndex = 31;
            buttonShowDocSlip.Text = "Show";
            buttonShowDocSlip.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(534, 32);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 32;
            label10.Text = "Loan";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(175, 33);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 20);
            labelId.TabIndex = 34;
            labelId.Text = "...";
            labelId.Visible = false;
            // 
            // labelLoanID
            // 
            labelLoanID.AutoSize = true;
            labelLoanID.Location = new Point(30, 33);
            labelLoanID.Name = "labelLoanID";
            labelLoanID.Size = new Size(60, 20);
            labelLoanID.TabIndex = 35;
            labelLoanID.Text = "Loan ID";
            // 
            // textLoanId
            // 
            textLoanId.Location = new Point(26, 56);
            textLoanId.Margin = new Padding(3, 4, 3, 4);
            textLoanId.Name = "textLoanId";
            textLoanId.ReadOnly = true;
            textLoanId.Size = new Size(233, 27);
            textLoanId.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 157);
            label11.Name = "label11";
            label11.Size = new Size(80, 20);
            label11.TabIndex = 38;
            label11.Text = "Admin Fee";
            // 
            // textAdminFee
            // 
            textAdminFee.Location = new Point(26, 181);
            textAdminFee.Margin = new Padding(3, 4, 3, 4);
            textAdminFee.Name = "textAdminFee";
            textAdminFee.ReadOnly = true;
            textAdminFee.Size = new Size(233, 27);
            textAdminFee.TabIndex = 37;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 217);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 42;
            label12.Text = "Min Amount";
            // 
            // textMinAmount
            // 
            textMinAmount.Location = new Point(26, 241);
            textMinAmount.Margin = new Padding(3, 4, 3, 4);
            textMinAmount.Name = "textMinAmount";
            textMinAmount.ReadOnly = true;
            textMinAmount.Size = new Size(233, 27);
            textMinAmount.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(281, 217);
            label13.Name = "label13";
            label13.Size = new Size(94, 20);
            label13.TabIndex = 40;
            label13.Text = "Max Amount";
            // 
            // textMaxAmount
            // 
            textMaxAmount.Location = new Point(278, 241);
            textMaxAmount.Margin = new Padding(3, 4, 3, 4);
            textMaxAmount.Name = "textMaxAmount";
            textMaxAmount.ReadOnly = true;
            textMaxAmount.Size = new Size(233, 27);
            textMaxAmount.TabIndex = 39;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(738, 533);
            buttonReload.Margin = new Padding(3, 4, 3, 4);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(143, 31);
            buttonReload.TabIndex = 43;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // LoanPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoanPage";
            Size = new Size(1115, 589);
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
