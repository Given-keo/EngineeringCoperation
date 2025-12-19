namespace EngineeringCoperation.Forms.MemberMenus
{
    partial class SavingPage
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
            buttonReload = new Button();
            label12 = new Label();
            textMinAmount = new TextBox();
            label13 = new Label();
            textMaxAmount = new TextBox();
            label11 = new Label();
            textAdminFee = new TextBox();
            textLoanId = new TextBox();
            labelSavingID = new Label();
            labelId = new Label();
            label10 = new Label();
            buttonShowDocSlip = new Button();
            buttonShowDocKk = new Button();
            buttonShowDocKtp = new Button();
            buttonNewSaving = new Button();
            buttonApply = new Button();
            buttonFileSlip = new Button();
            buttonFileKK = new Button();
            buttonFileKTP = new Button();
            textDocSlip = new TextBox();
            textDocKtp = new TextBox();
            textDocKK = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            textDueDate = new TextBox();
            label5 = new Label();
            textInterestFine = new TextBox();
            label4 = new Label();
            textInterest = new TextBox();
            label3 = new Label();
            textTenor = new TextBox();
            comboSavingMaster = new ComboBox();
            loanMasterBindingSource = new BindingSource(components);
            label2 = new Label();
            installmentBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LoanId = new DataGridViewTextBoxColumn();
            outstanding = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Fine = new DataGridViewTextBoxColumn();
            loanBindingSource = new BindingSource(components);
            dataGridViewSaving = new DataGridView();
            tenorLeft = new DataGridViewTextBoxColumn();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaving).BeginInit();
            SuspendLayout();
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(645, 398);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(125, 23);
            buttonReload.TabIndex = 81;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 161);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 80;
            label12.Text = "Min Amount";
            // 
            // textMinAmount
            // 
            textMinAmount.Location = new Point(22, 179);
            textMinAmount.Name = "textMinAmount";
            textMinAmount.ReadOnly = true;
            textMinAmount.Size = new Size(204, 23);
            textMinAmount.TabIndex = 79;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(245, 161);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 78;
            label13.Text = "Max Amount";
            // 
            // textMaxAmount
            // 
            textMaxAmount.Location = new Point(242, 179);
            textMaxAmount.Name = "textMaxAmount";
            textMaxAmount.ReadOnly = true;
            textMaxAmount.Size = new Size(204, 23);
            textMaxAmount.TabIndex = 77;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 116);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 76;
            label11.Text = "Admin Fee";
            // 
            // textAdminFee
            // 
            textAdminFee.Location = new Point(22, 134);
            textAdminFee.Name = "textAdminFee";
            textAdminFee.ReadOnly = true;
            textAdminFee.Size = new Size(204, 23);
            textAdminFee.TabIndex = 75;
            // 
            // textLoanId
            // 
            textLoanId.Location = new Point(22, 40);
            textLoanId.Name = "textLoanId";
            textLoanId.ReadOnly = true;
            textLoanId.Size = new Size(204, 23);
            textLoanId.TabIndex = 74;
            // 
            // labelSavingID
            // 
            labelSavingID.AutoSize = true;
            labelSavingID.Location = new Point(25, 23);
            labelSavingID.Name = "labelSavingID";
            labelSavingID.Size = new Size(59, 15);
            labelSavingID.TabIndex = 73;
            labelSavingID.Text = " Saving ID";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(152, 23);
            labelId.Name = "labelId";
            labelId.Size = new Size(16, 15);
            labelId.TabIndex = 72;
            labelId.Text = "...";
            labelId.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(466, 22);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 71;
            label10.Text = "Saving";
            // 
            // buttonShowDocSlip
            // 
            buttonShowDocSlip.Location = new Point(372, 345);
            buttonShowDocSlip.Name = "buttonShowDocSlip";
            buttonShowDocSlip.Size = new Size(74, 23);
            buttonShowDocSlip.TabIndex = 70;
            buttonShowDocSlip.Text = "Show";
            buttonShowDocSlip.UseVisualStyleBackColor = true;
            // 
            // buttonShowDocKk
            // 
            buttonShowDocKk.Location = new Point(152, 345);
            buttonShowDocKk.Name = "buttonShowDocKk";
            buttonShowDocKk.Size = new Size(74, 23);
            buttonShowDocKk.TabIndex = 69;
            buttonShowDocKk.Text = "Show";
            buttonShowDocKk.UseVisualStyleBackColor = true;
            // 
            // buttonShowDocKtp
            // 
            buttonShowDocKtp.Location = new Point(372, 252);
            buttonShowDocKtp.Name = "buttonShowDocKtp";
            buttonShowDocKtp.Size = new Size(74, 23);
            buttonShowDocKtp.TabIndex = 68;
            buttonShowDocKtp.Text = "Show";
            buttonShowDocKtp.UseVisualStyleBackColor = true;
            // 
            // buttonNewSaving
            // 
            buttonNewSaving.Location = new Point(242, 398);
            buttonNewSaving.Name = "buttonNewSaving";
            buttonNewSaving.Size = new Size(125, 23);
            buttonNewSaving.TabIndex = 67;
            buttonNewSaving.Text = "New Saving";
            buttonNewSaving.UseVisualStyleBackColor = true;
            buttonNewSaving.Click += buttonNewSaving_Click;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(91, 398);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(135, 23);
            buttonApply.TabIndex = 66;
            buttonApply.Text = "Apply Saving";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonFileSlip
            // 
            buttonFileSlip.Location = new Point(242, 345);
            buttonFileSlip.Name = "buttonFileSlip";
            buttonFileSlip.Size = new Size(74, 23);
            buttonFileSlip.TabIndex = 65;
            buttonFileSlip.Text = "Browse";
            buttonFileSlip.UseVisualStyleBackColor = true;
            // 
            // buttonFileKK
            // 
            buttonFileKK.Location = new Point(22, 345);
            buttonFileKK.Name = "buttonFileKK";
            buttonFileKK.Size = new Size(74, 23);
            buttonFileKK.TabIndex = 64;
            buttonFileKK.Text = "Browse";
            buttonFileKK.UseVisualStyleBackColor = true;
            buttonFileKK.Click += buttonFileKK_Click;
            // 
            // buttonFileKTP
            // 
            buttonFileKTP.Location = new Point(242, 252);
            buttonFileKTP.Name = "buttonFileKTP";
            buttonFileKTP.Size = new Size(74, 23);
            buttonFileKTP.TabIndex = 63;
            buttonFileKTP.Text = "Browse";
            buttonFileKTP.UseVisualStyleBackColor = true;
            // 
            // textDocSlip
            // 
            textDocSlip.Location = new Point(242, 316);
            textDocSlip.Name = "textDocSlip";
            textDocSlip.ReadOnly = true;
            textDocSlip.Size = new Size(204, 23);
            textDocSlip.TabIndex = 62;
            // 
            // textDocKtp
            // 
            textDocKtp.Location = new Point(242, 223);
            textDocKtp.Name = "textDocKtp";
            textDocKtp.ReadOnly = true;
            textDocKtp.Size = new Size(204, 23);
            textDocKtp.TabIndex = 61;
            // 
            // textDocKK
            // 
            textDocKK.Location = new Point(22, 316);
            textDocKK.Name = "textDocKK";
            textDocKK.ReadOnly = true;
            textDocKK.Size = new Size(204, 23);
            textDocKK.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(245, 298);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 59;
            label7.Text = "Document Slip Gaji";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(245, 205);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 58;
            label8.Text = "Document KTP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 298);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 57;
            label9.Text = "Document KK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 250);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 56;
            label6.Text = "Due Date";
            // 
            // textDueDate
            // 
            textDueDate.Location = new Point(22, 268);
            textDueDate.Name = "textDueDate";
            textDueDate.Size = new Size(204, 23);
            textDueDate.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 205);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 54;
            label5.Text = "Interest Fine";
            // 
            // textInterestFine
            // 
            textInterestFine.Location = new Point(22, 223);
            textInterestFine.Name = "textInterestFine";
            textInterestFine.ReadOnly = true;
            textInterestFine.Size = new Size(204, 23);
            textInterestFine.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 72);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 52;
            label4.Text = "Interest";
            // 
            // textInterest
            // 
            textInterest.Location = new Point(242, 90);
            textInterest.Name = "textInterest";
            textInterest.ReadOnly = true;
            textInterest.Size = new Size(204, 23);
            textInterest.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 116);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 50;
            label3.Text = "Tenor";
            // 
            // textTenor
            // 
            textTenor.Location = new Point(242, 134);
            textTenor.Name = "textTenor";
            textTenor.ReadOnly = true;
            textTenor.Size = new Size(204, 23);
            textTenor.TabIndex = 49;
            // 
            // comboSavingMaster
            // 
            comboSavingMaster.DataSource = loanMasterBindingSource;
            comboSavingMaster.FormattingEnabled = true;
            comboSavingMaster.Location = new Point(22, 90);
            comboSavingMaster.Name = "comboSavingMaster";
            comboSavingMaster.Size = new Size(204, 23);
            comboSavingMaster.TabIndex = 48;
            // 
            // loanMasterBindingSource
            // 
            loanMasterBindingSource.DataSource = typeof(Models.LoanMaster);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 47;
            label2.Text = "Saving Type";
            // 
            // installmentBindingSource
            // 
            installmentBindingSource.DataSource = typeof(Models.Installment);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 22);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 46;
            label1.Text = "Amount";
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
            // dataGridViewSaving
            // 
            dataGridViewSaving.AllowUserToAddRows = false;
            dataGridViewSaving.AllowUserToDeleteRows = false;
            dataGridViewSaving.AutoGenerateColumns = false;
            dataGridViewSaving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaving.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, LoanId, outstanding, tenorLeft, Fine });
            dataGridViewSaving.DataSource = loanBindingSource;
            dataGridViewSaving.Location = new Point(463, 40);
            dataGridViewSaving.Name = "dataGridViewSaving";
            dataGridViewSaving.ReadOnly = true;
            dataGridViewSaving.Size = new Size(491, 337);
            dataGridViewSaving.TabIndex = 45;
            // 
            // tenorLeft
            // 
            tenorLeft.DataPropertyName = "tenorLeft";
            tenorLeft.HeaderText = "tenorLeft";
            tenorLeft.Name = "tenorLeft";
            tenorLeft.ReadOnly = true;
            // 
            // textAmount
            // 
            textAmount.Location = new Point(242, 40);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(204, 23);
            textAmount.TabIndex = 44;
            // 
            // SavingPage
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
            Controls.Add(labelSavingID);
            Controls.Add(labelId);
            Controls.Add(label10);
            Controls.Add(buttonShowDocSlip);
            Controls.Add(buttonShowDocKk);
            Controls.Add(buttonShowDocKtp);
            Controls.Add(buttonNewSaving);
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
            Controls.Add(comboSavingMaster);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewSaving);
            Controls.Add(textAmount);
            Name = "SavingPage";
            Size = new Size(976, 442);
            Load += SavingPage_Load;
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaving).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReload;
        private Label label12;
        private TextBox textMinAmount;
        private Label label13;
        private TextBox textMaxAmount;
        private Label label11;
        private TextBox textAdminFee;
        private TextBox textLoanId;
        private Label labelSavingID;
        private Label labelId;
        private Label label10;
        private Button buttonShowDocSlip;
        private Button buttonShowDocKk;
        private Button buttonShowDocKtp;
        private Button buttonNewSaving;
        private Button buttonApply;
        private Button buttonFileSlip;
        private Button buttonFileKK;
        private Button buttonFileKTP;
        private TextBox textDocSlip;
        private TextBox textDocKtp;
        private TextBox textDocKK;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label6;
        private TextBox textDueDate;
        private Label label5;
        private TextBox textInterestFine;
        private Label label4;
        private TextBox textInterest;
        private Label label3;
        private TextBox textTenor;
        private ComboBox comboSavingMaster;
        private BindingSource loanMasterBindingSource;
        private Label label2;
        private BindingSource installmentBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn LoanId;
        private DataGridViewTextBoxColumn outstanding;
        private Label label1;
        private DataGridViewTextBoxColumn Fine;
        private BindingSource loanBindingSource;
        private DataGridView dataGridViewSaving;
        private DataGridViewTextBoxColumn tenorLeft;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textAmount;
    }
}
