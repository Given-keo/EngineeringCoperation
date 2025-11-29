namespace EngineeringCoperation.Forms
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
            LblSign = new Label();
            LblMasterSaving = new Label();
            DataGridMasterSaving = new DataGridView();
            DataGridMasterLoan = new DataGridView();
            LblMasterLoan = new Label();
            BtnNew = new Button();
            BtnSubmit = new Button();
            LblMaxAmount = new Label();
            LblMinAmount = new Label();
            LblAdminFee = new Label();
            LblTenor = new Label();
            TxtMaxAmount = new TextBox();
            TxtMinAmount = new TextBox();
            TxtInterest = new TextBox();
            TxtAdminFee = new TextBox();
            ComboMode = new ComboBox();
            TxtTenor = new TextBox();
            TxtName = new TextBox();
            TxtInterestFine = new TextBox();
            LblInterestFine = new Label();
            LblInterest = new Label();
            LblMode = new Label();
            LblName = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridMasterSaving).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridMasterLoan).BeginInit();
            SuspendLayout();
            // 
            // LblSign
            // 
            LblSign.AutoSize = true;
            LblSign.Location = new Point(350, 230);
            LblSign.Name = "LblSign";
            LblSign.Size = new Size(24, 25);
            LblSign.TabIndex = 45;
            LblSign.Text = "...";
            // 
            // LblMasterSaving
            // 
            LblMasterSaving.AutoSize = true;
            LblMasterSaving.Location = new Point(479, 281);
            LblMasterSaving.Name = "LblMasterSaving";
            LblMasterSaving.Size = new Size(124, 25);
            LblMasterSaving.TabIndex = 44;
            LblMasterSaving.Text = "Master Saving";
            // 
            // DataGridMasterSaving
            // 
            DataGridMasterSaving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridMasterSaving.Location = new Point(479, 309);
            DataGridMasterSaving.Name = "DataGridMasterSaving";
            DataGridMasterSaving.RowHeadersWidth = 62;
            DataGridMasterSaving.Size = new Size(435, 225);
            DataGridMasterSaving.TabIndex = 43;
            DataGridMasterSaving.CellContentClick += DataGridMasterSaving_CellContentClick;
            // 
            // DataGridMasterLoan
            // 
            DataGridMasterLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridMasterLoan.Location = new Point(24, 309);
            DataGridMasterLoan.Name = "DataGridMasterLoan";
            DataGridMasterLoan.RowHeadersWidth = 62;
            DataGridMasterLoan.Size = new Size(435, 225);
            DataGridMasterLoan.TabIndex = 42;
            DataGridMasterLoan.CellContentClick += DataGridMasterLoan_CellContentClick;
            // 
            // LblMasterLoan
            // 
            LblMasterLoan.AutoSize = true;
            LblMasterLoan.Location = new Point(24, 281);
            LblMasterLoan.Name = "LblMasterLoan";
            LblMasterLoan.Size = new Size(109, 25);
            LblMasterLoan.TabIndex = 41;
            LblMasterLoan.Text = "Master Loan";
            // 
            // BtnNew
            // 
            BtnNew.Location = new Point(185, 225);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(112, 34);
            BtnNew.TabIndex = 40;
            BtnNew.Text = "New";
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(23, 225);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(112, 34);
            BtnSubmit.TabIndex = 39;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // LblMaxAmount
            // 
            LblMaxAmount.AutoSize = true;
            LblMaxAmount.Location = new Point(701, 119);
            LblMaxAmount.Name = "LblMaxAmount";
            LblMaxAmount.Size = new Size(148, 25);
            LblMaxAmount.TabIndex = 38;
            LblMaxAmount.Text = "Maximal Amount";
            // 
            // LblMinAmount
            // 
            LblMinAmount.AutoSize = true;
            LblMinAmount.Location = new Point(479, 119);
            LblMinAmount.Name = "LblMinAmount";
            LblMinAmount.Size = new Size(152, 25);
            LblMinAmount.TabIndex = 37;
            LblMinAmount.Text = "Minimun Amount";
            // 
            // LblAdminFee
            // 
            LblAdminFee.AutoSize = true;
            LblAdminFee.Location = new Point(254, 119);
            LblAdminFee.Name = "LblAdminFee";
            LblAdminFee.Size = new Size(97, 25);
            LblAdminFee.TabIndex = 36;
            LblAdminFee.Text = "Admin Fee";
            // 
            // LblTenor
            // 
            LblTenor.AutoSize = true;
            LblTenor.Location = new Point(35, 119);
            LblTenor.Name = "LblTenor";
            LblTenor.Size = new Size(55, 25);
            LblTenor.TabIndex = 35;
            LblTenor.Text = "Tenor";
            // 
            // TxtMaxAmount
            // 
            TxtMaxAmount.Location = new Point(701, 156);
            TxtMaxAmount.Name = "TxtMaxAmount";
            TxtMaxAmount.Size = new Size(172, 31);
            TxtMaxAmount.TabIndex = 34;
            // 
            // TxtMinAmount
            // 
            TxtMinAmount.Location = new Point(479, 156);
            TxtMinAmount.Name = "TxtMinAmount";
            TxtMinAmount.Size = new Size(179, 31);
            TxtMinAmount.TabIndex = 33;
            // 
            // TxtInterest
            // 
            TxtInterest.Location = new Point(479, 64);
            TxtInterest.Name = "TxtInterest";
            TxtInterest.Size = new Size(179, 31);
            TxtInterest.TabIndex = 32;
            // 
            // TxtAdminFee
            // 
            TxtAdminFee.Location = new Point(254, 156);
            TxtAdminFee.Name = "TxtAdminFee";
            TxtAdminFee.Size = new Size(182, 31);
            TxtAdminFee.TabIndex = 31;
            // 
            // ComboMode
            // 
            ComboMode.FormattingEnabled = true;
            ComboMode.Location = new Point(254, 62);
            ComboMode.Name = "ComboMode";
            ComboMode.Size = new Size(182, 33);
            ComboMode.TabIndex = 30;
            // 
            // TxtTenor
            // 
            TxtTenor.Location = new Point(23, 156);
            TxtTenor.Name = "TxtTenor";
            TxtTenor.Size = new Size(178, 31);
            TxtTenor.TabIndex = 29;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(23, 64);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(178, 31);
            TxtName.TabIndex = 28;
            // 
            // TxtInterestFine
            // 
            TxtInterestFine.Location = new Point(701, 64);
            TxtInterestFine.Name = "TxtInterestFine";
            TxtInterestFine.Size = new Size(172, 31);
            TxtInterestFine.TabIndex = 27;
            // 
            // LblInterestFine
            // 
            LblInterestFine.AutoSize = true;
            LblInterestFine.Location = new Point(701, 24);
            LblInterestFine.Name = "LblInterestFine";
            LblInterestFine.Size = new Size(108, 25);
            LblInterestFine.TabIndex = 26;
            LblInterestFine.Text = "Interest Fine";
            // 
            // LblInterest
            // 
            LblInterest.AutoSize = true;
            LblInterest.Location = new Point(479, 24);
            LblInterest.Name = "LblInterest";
            LblInterest.Size = new Size(71, 25);
            LblInterest.TabIndex = 25;
            LblInterest.Text = "Interest";
            // 
            // LblMode
            // 
            LblMode.AutoSize = true;
            LblMode.Location = new Point(254, 24);
            LblMode.Name = "LblMode";
            LblMode.Size = new Size(59, 25);
            LblMode.TabIndex = 24;
            LblMode.Text = "Mode";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(35, 24);
            LblName.Name = "LblName";
            LblName.Size = new Size(59, 25);
            LblName.TabIndex = 23;
            LblName.Text = "Name";
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LblSign);
            Controls.Add(LblMasterSaving);
            Controls.Add(DataGridMasterSaving);
            Controls.Add(DataGridMasterLoan);
            Controls.Add(LblMasterLoan);
            Controls.Add(BtnNew);
            Controls.Add(BtnSubmit);
            Controls.Add(LblMaxAmount);
            Controls.Add(LblMinAmount);
            Controls.Add(LblAdminFee);
            Controls.Add(LblTenor);
            Controls.Add(TxtMaxAmount);
            Controls.Add(TxtMinAmount);
            Controls.Add(TxtInterest);
            Controls.Add(TxtAdminFee);
            Controls.Add(ComboMode);
            Controls.Add(TxtTenor);
            Controls.Add(TxtName);
            Controls.Add(TxtInterestFine);
            Controls.Add(LblInterestFine);
            Controls.Add(LblInterest);
            Controls.Add(LblMode);
            Controls.Add(LblName);
            Name = "ProductPage";
            Size = new Size(934, 552);
            Load += ProductPage_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridMasterSaving).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridMasterLoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSign;
        private Label LblMasterSaving;
        private DataGridView DataGridMasterSaving;
        private DataGridView DataGridMasterLoan;
        private Label LblMasterLoan;
        private Button BtnNew;
        private Button BtnSubmit;
        private Label LblMaxAmount;
        private Label LblMinAmount;
        private Label LblAdminFee;
        private Label LblTenor;
        private TextBox TxtMaxAmount;
        private TextBox TxtMinAmount;
        private TextBox TxtInterest;
        private TextBox TxtAdminFee;
        private ComboBox ComboMode;
        private TextBox TxtTenor;
        private TextBox TxtName;
        private TextBox TxtInterestFine;
        private Label LblInterestFine;
        private Label LblInterest;
        private Label LblMode;
        private Label LblName;
    }
}
