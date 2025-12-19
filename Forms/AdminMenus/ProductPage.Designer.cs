namespace EngineeringCoperation.Forms.AdminMenus
{
    partial class ProductPage
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
            dataGridViewLoan = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loanMasterBindingSource = new BindingSource(components);
            dataGridViewSaving = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            interestDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            tenorDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            savingMasterBindingSource = new BindingSource(components);
            textBoxName = new TextBox();
            label1 = new Label();
            comboMode = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textInterest = new TextBox();
            label4 = new Label();
            textFine = new TextBox();
            label5 = new Label();
            textTenor = new TextBox();
            label6 = new Label();
            textAdminFee = new TextBox();
            label7 = new Label();
            textMinAmount = new TextBox();
            label8 = new Label();
            textMaxAmount = new TextBox();
            labelId = new Label();
            buttonSubmit = new Button();
            buttonNew = new Button();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaving).BeginInit();
            ((System.ComponentModel.ISupportInitialize)savingMasterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLoan
            // 
            dataGridViewLoan.AllowUserToAddRows = false;
            dataGridViewLoan.AllowUserToDeleteRows = false;
            dataGridViewLoan.AutoGenerateColumns = false;
            dataGridViewLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoan.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, interestDataGridViewTextBoxColumn, tenorDataGridViewTextBoxColumn });
            dataGridViewLoan.DataSource = loanMasterBindingSource;
            dataGridViewLoan.Location = new Point(13, 182);
            dataGridViewLoan.Name = "dataGridViewLoan";
            dataGridViewLoan.ReadOnly = true;
            dataGridViewLoan.Size = new Size(374, 203);
            dataGridViewLoan.TabIndex = 0;
            dataGridViewLoan.CellClick += dataGridViewLoan_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
            interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            interestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenorDataGridViewTextBoxColumn
            // 
            tenorDataGridViewTextBoxColumn.DataPropertyName = "Tenor";
            tenorDataGridViewTextBoxColumn.HeaderText = "Tenor";
            tenorDataGridViewTextBoxColumn.Name = "tenorDataGridViewTextBoxColumn";
            tenorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanMasterBindingSource
            // 
            loanMasterBindingSource.DataSource = typeof(Models.LoanMaster);
            // 
            // dataGridViewSaving
            // 
            dataGridViewSaving.AllowUserToAddRows = false;
            dataGridViewSaving.AllowUserToDeleteRows = false;
            dataGridViewSaving.AutoGenerateColumns = false;
            dataGridViewSaving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaving.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, interestDataGridViewTextBoxColumn1, tenorDataGridViewTextBoxColumn1 });
            dataGridViewSaving.DataSource = savingMasterBindingSource;
            dataGridViewSaving.Location = new Point(394, 182);
            dataGridViewSaving.Name = "dataGridViewSaving";
            dataGridViewSaving.ReadOnly = true;
            dataGridViewSaving.Size = new Size(370, 203);
            dataGridViewSaving.TabIndex = 1;
            dataGridViewSaving.CellClick += dataGridViewSaving_CellClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn1
            // 
            interestDataGridViewTextBoxColumn1.DataPropertyName = "Interest";
            interestDataGridViewTextBoxColumn1.HeaderText = "Interest";
            interestDataGridViewTextBoxColumn1.Name = "interestDataGridViewTextBoxColumn1";
            interestDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenorDataGridViewTextBoxColumn1
            // 
            tenorDataGridViewTextBoxColumn1.DataPropertyName = "Tenor";
            tenorDataGridViewTextBoxColumn1.HeaderText = "Tenor";
            tenorDataGridViewTextBoxColumn1.Name = "tenorDataGridViewTextBoxColumn1";
            tenorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // savingMasterBindingSource
            // 
            savingMasterBindingSource.DataSource = typeof(Models.SavingMaster);
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(13, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(184, 23);
            textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // comboMode
            // 
            comboMode.FormattingEnabled = true;
            comboMode.Items.AddRange(new object[] { "--Choose--", "Loan", "Saving" });
            comboMode.Location = new Point(203, 35);
            comboMode.Name = "comboMode";
            comboMode.Size = new Size(185, 23);
            comboMode.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 17);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Mode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 17);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Interest";
            // 
            // textInterest
            // 
            textInterest.Location = new Point(394, 35);
            textInterest.Name = "textInterest";
            textInterest.Size = new Size(180, 23);
            textInterest.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(583, 17);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 9;
            label4.Text = "Interest Fine";
            // 
            // textFine
            // 
            textFine.Location = new Point(580, 35);
            textFine.Name = "textFine";
            textFine.Size = new Size(184, 23);
            textFine.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 64);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Tenor";
            // 
            // textTenor
            // 
            textTenor.Location = new Point(13, 82);
            textTenor.Name = "textTenor";
            textTenor.Size = new Size(184, 23);
            textTenor.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 64);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 13;
            label6.Text = "Admin Fee";
            // 
            // textAdminFee
            // 
            textAdminFee.Location = new Point(203, 82);
            textAdminFee.Name = "textAdminFee";
            textAdminFee.Size = new Size(184, 23);
            textAdminFee.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(396, 64);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 15;
            label7.Text = "Minimum Amount";
            // 
            // textMinAmount
            // 
            textMinAmount.Location = new Point(393, 82);
            textMinAmount.Name = "textMinAmount";
            textMinAmount.Size = new Size(184, 23);
            textMinAmount.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(586, 64);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 17;
            label8.Text = "Maximum Amount";
            // 
            // textMaxAmount
            // 
            textMaxAmount.Location = new Point(583, 82);
            textMaxAmount.Name = "textMaxAmount";
            textMaxAmount.Size = new Size(184, 23);
            textMaxAmount.TabIndex = 16;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(203, 125);
            labelId.Name = "labelId";
            labelId.Size = new Size(16, 15);
            labelId.TabIndex = 18;
            labelId.Text = "...";
            labelId.Visible = false;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(12, 121);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 19;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(93, 121);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 20;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 164);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 21;
            label9.Text = "Master Loan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(397, 164);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 22;
            label10.Text = "Master Saving";
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(buttonNew);
            Controls.Add(buttonSubmit);
            Controls.Add(labelId);
            Controls.Add(label8);
            Controls.Add(textMaxAmount);
            Controls.Add(label7);
            Controls.Add(textMinAmount);
            Controls.Add(label6);
            Controls.Add(textAdminFee);
            Controls.Add(label5);
            Controls.Add(textTenor);
            Controls.Add(label4);
            Controls.Add(textFine);
            Controls.Add(label3);
            Controls.Add(textInterest);
            Controls.Add(label2);
            Controls.Add(comboMode);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(dataGridViewSaving);
            Controls.Add(dataGridViewLoan);
            Name = "ProductPage";
            Size = new Size(781, 399);
            Load += ProductPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanMasterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaving).EndInit();
            ((System.ComponentModel.ISupportInitialize)savingMasterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLoan;
        private DataGridView dataGridViewSaving;
        private TextBox textBoxName;
        private Label label1;
        private ComboBox comboMode;
        private Label label2;
        private Label label3;
        private TextBox textInterest;
        private Label label4;
        private TextBox textFine;
        private Label label5;
        private TextBox textTenor;
        private Label label6;
        private TextBox textAdminFee;
        private Label label7;
        private TextBox textMinAmount;
        private Label label8;
        private TextBox textMaxAmount;
        private Label labelId;
        private Button buttonSubmit;
        private Button buttonNew;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenorDataGridViewTextBoxColumn;
        private BindingSource loanMasterBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tenorDataGridViewTextBoxColumn1;
        private BindingSource savingMasterBindingSource;
        private Label label9;
        private Label label10;
    }
}
