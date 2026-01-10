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
            buttonReload.Location = new Point(737, 531);
            buttonReload.Margin = new Padding(3, 4, 3, 4);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(143, 31);
            buttonReload.TabIndex = 81;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(29, 215);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 80;
            label12.Text = "Min Amount";
            // 
            // textMinAmount
            // 
            textMinAmount.Location = new Point(25, 239);
            textMinAmount.Margin = new Padding(3, 4, 3, 4);
            textMinAmount.Name = "textMinAmount";
            textMinAmount.ReadOnly = true;
            textMinAmount.Size = new Size(233, 27);
            textMinAmount.TabIndex = 79;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(280, 215);
            label13.Name = "label13";
            label13.Size = new Size(94, 20);
            label13.TabIndex = 78;
            label13.Text = "Max Amount";
            // 
            // textMaxAmount
            // 
            textMaxAmount.Location = new Point(277, 239);
            textMaxAmount.Margin = new Padding(3, 4, 3, 4);
            textMaxAmount.Name = "textMaxAmount";
            textMaxAmount.ReadOnly = true;
            textMaxAmount.Size = new Size(233, 27);
            textMaxAmount.TabIndex = 77;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 155);
            label11.Name = "label11";
            label11.Size = new Size(80, 20);
            label11.TabIndex = 76;
            label11.Text = "Admin Fee";
            // 
            // textAdminFee
            // 
            textAdminFee.Location = new Point(25, 179);
            textAdminFee.Margin = new Padding(3, 4, 3, 4);
            textAdminFee.Name = "textAdminFee";
            textAdminFee.ReadOnly = true;
            textAdminFee.Size = new Size(233, 27);
            textAdminFee.TabIndex = 75;
            // 
            // textLoanId
            // 
            textLoanId.Location = new Point(25, 53);
            textLoanId.Margin = new Padding(3, 4, 3, 4);
            textLoanId.Name = "textLoanId";
            textLoanId.ReadOnly = true;
            textLoanId.Size = new Size(233, 27);
            textLoanId.TabIndex = 74;
            // 
            // labelSavingID
            // 
            labelSavingID.AutoSize = true;
            labelSavingID.Location = new Point(29, 31);
            labelSavingID.Name = "labelSavingID";
            labelSavingID.Size = new Size(76, 20);
            labelSavingID.TabIndex = 73;
            labelSavingID.Text = " Saving ID";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(174, 31);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 20);
            labelId.TabIndex = 72;
            labelId.Text = "...";
            labelId.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(533, 29);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 71;
            label10.Text = "Saving";
            // 
            // buttonShowDocSlip
            // 
            buttonShowDocSlip.Location = new Point(425, 460);
            buttonShowDocSlip.Margin = new Padding(3, 4, 3, 4);
            buttonShowDocSlip.Name = "buttonShowDocSlip";
            buttonShowDocSlip.Size = new Size(85, 31);
            buttonShowDocSlip.TabIndex = 70;
            buttonShowDocSlip.Text = "Show";
            buttonShowDocSlip.UseVisualStyleBackColor = true;
            // 
            // buttonShowDocKk
            // 
            buttonShowDocKk.Location = new Point(174, 460);
            buttonShowDocKk.Margin = new Padding(3, 4, 3, 4);
            buttonShowDocKk.Name = "buttonShowDocKk";
            buttonShowDocKk.Size = new Size(85, 31);
            buttonShowDocKk.TabIndex = 69;
            buttonShowDocKk.Text = "Show";
            buttonShowDocKk.UseVisualStyleBackColor = true;
            // 
            // buttonShowDocKtp
            // 
            buttonShowDocKtp.Location = new Point(425, 336);
            buttonShowDocKtp.Margin = new Padding(3, 4, 3, 4);
            buttonShowDocKtp.Name = "buttonShowDocKtp";
            buttonShowDocKtp.Size = new Size(85, 31);
            buttonShowDocKtp.TabIndex = 68;
            buttonShowDocKtp.Text = "Show";
            buttonShowDocKtp.UseVisualStyleBackColor = true;
            // 
            // buttonNewSaving
            // 
            buttonNewSaving.Location = new Point(277, 531);
            buttonNewSaving.Margin = new Padding(3, 4, 3, 4);
            buttonNewSaving.Name = "buttonNewSaving";
            buttonNewSaving.Size = new Size(143, 31);
            buttonNewSaving.TabIndex = 67;
            buttonNewSaving.Text = "New Saving";
            buttonNewSaving.UseVisualStyleBackColor = true;
            buttonNewSaving.Click += buttonNewSaving_Click;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(104, 531);
            buttonApply.Margin = new Padding(3, 4, 3, 4);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(154, 31);
            buttonApply.TabIndex = 66;
            buttonApply.Text = "Apply Saving";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // buttonFileSlip
            // 
            buttonFileSlip.Location = new Point(277, 460);
            buttonFileSlip.Margin = new Padding(3, 4, 3, 4);
            buttonFileSlip.Name = "buttonFileSlip";
            buttonFileSlip.Size = new Size(85, 31);
            buttonFileSlip.TabIndex = 65;
            buttonFileSlip.Text = "Browse";
            buttonFileSlip.UseVisualStyleBackColor = true;
            // 
            // buttonFileKK
            // 
            buttonFileKK.Location = new Point(25, 460);
            buttonFileKK.Margin = new Padding(3, 4, 3, 4);
            buttonFileKK.Name = "buttonFileKK";
            buttonFileKK.Size = new Size(85, 31);
            buttonFileKK.TabIndex = 64;
            buttonFileKK.Text = "Browse";
            buttonFileKK.UseVisualStyleBackColor = true;
            buttonFileKK.Click += buttonFileKK_Click;
            // 
            // buttonFileKTP
            // 
            buttonFileKTP.Location = new Point(277, 336);
            buttonFileKTP.Margin = new Padding(3, 4, 3, 4);
            buttonFileKTP.Name = "buttonFileKTP";
            buttonFileKTP.Size = new Size(85, 31);
            buttonFileKTP.TabIndex = 63;
            buttonFileKTP.Text = "Browse";
            buttonFileKTP.UseVisualStyleBackColor = true;
            // 
            // textDocSlip
            // 
            textDocSlip.Location = new Point(277, 421);
            textDocSlip.Margin = new Padding(3, 4, 3, 4);
            textDocSlip.Name = "textDocSlip";
            textDocSlip.ReadOnly = true;
            textDocSlip.Size = new Size(233, 27);
            textDocSlip.TabIndex = 62;
            // 
            // textDocKtp
            // 
            textDocKtp.Location = new Point(277, 297);
            textDocKtp.Margin = new Padding(3, 4, 3, 4);
            textDocKtp.Name = "textDocKtp";
            textDocKtp.ReadOnly = true;
            textDocKtp.Size = new Size(233, 27);
            textDocKtp.TabIndex = 61;
            // 
            // textDocKK
            // 
            textDocKK.Location = new Point(25, 421);
            textDocKK.Margin = new Padding(3, 4, 3, 4);
            textDocKK.Name = "textDocKK";
            textDocKK.ReadOnly = true;
            textDocKK.Size = new Size(233, 27);
            textDocKK.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(280, 397);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 59;
            label7.Text = "Document Slip Gaji";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(280, 273);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 58;
            label8.Text = "Document KTP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 397);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 57;
            label9.Text = "Document KK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 333);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 56;
            label6.Text = "Due Date";
            // 
            // textDueDate
            // 
            textDueDate.Location = new Point(25, 357);
            textDueDate.Margin = new Padding(3, 4, 3, 4);
            textDueDate.Name = "textDueDate";
            textDueDate.Size = new Size(233, 27);
            textDueDate.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 273);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 54;
            label5.Text = "Interest Fine";
            // 
            // textInterestFine
            // 
            textInterestFine.Location = new Point(25, 297);
            textInterestFine.Margin = new Padding(3, 4, 3, 4);
            textInterestFine.Name = "textInterestFine";
            textInterestFine.ReadOnly = true;
            textInterestFine.Size = new Size(233, 27);
            textInterestFine.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 96);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 52;
            label4.Text = "Interest";
            // 
            // textInterest
            // 
            textInterest.Location = new Point(277, 120);
            textInterest.Margin = new Padding(3, 4, 3, 4);
            textInterest.Name = "textInterest";
            textInterest.ReadOnly = true;
            textInterest.Size = new Size(233, 27);
            textInterest.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 155);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 50;
            label3.Text = "Tenor";
            // 
            // textTenor
            // 
            textTenor.Location = new Point(277, 179);
            textTenor.Margin = new Padding(3, 4, 3, 4);
            textTenor.Name = "textTenor";
            textTenor.ReadOnly = true;
            textTenor.Size = new Size(233, 27);
            textTenor.TabIndex = 49;
            // 
            // comboSavingMaster
            // 
            comboSavingMaster.DataSource = loanMasterBindingSource;
            comboSavingMaster.FormattingEnabled = true;
            comboSavingMaster.Location = new Point(25, 120);
            comboSavingMaster.Margin = new Padding(3, 4, 3, 4);
            comboSavingMaster.Name = "comboSavingMaster";
            comboSavingMaster.Size = new Size(233, 28);
            comboSavingMaster.TabIndex = 48;
            // 
            // loanMasterBindingSource
            // 
            loanMasterBindingSource.DataSource = typeof(Models.LoanMaster);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 96);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 46;
            label1.Text = "Amount";
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
            // dataGridViewSaving
            // 
            dataGridViewSaving.AllowUserToAddRows = false;
            dataGridViewSaving.AllowUserToDeleteRows = false;
            dataGridViewSaving.AutoGenerateColumns = false;
            dataGridViewSaving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaving.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, LoanId, outstanding, tenorLeft, Fine });
            dataGridViewSaving.DataSource = loanBindingSource;
            dataGridViewSaving.Location = new Point(529, 53);
            dataGridViewSaving.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSaving.Name = "dataGridViewSaving";
            dataGridViewSaving.ReadOnly = true;
            dataGridViewSaving.RowHeadersWidth = 51;
            dataGridViewSaving.Size = new Size(561, 449);
            dataGridViewSaving.TabIndex = 45;
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
            // textAmount
            // 
            textAmount.Location = new Point(277, 53);
            textAmount.Margin = new Padding(3, 4, 3, 4);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(233, 27);
            textAmount.TabIndex = 44;
            // 
            // SavingPage
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "SavingPage";
            Size = new Size(1115, 589);
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
