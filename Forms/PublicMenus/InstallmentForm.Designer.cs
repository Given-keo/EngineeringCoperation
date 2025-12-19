namespace EngineeringCoperation.Forms.PublicMenus
{
    partial class InstallmentForm
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
            components = new System.ComponentModel.Container();
            buttonSubmit = new Button();
            dataGridViewInstallment = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proofPathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            installmentBindingSource = new BindingSource(components);
            textLoanId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textAmount = new TextBox();
            label3 = new Label();
            textPath = new TextBox();
            buttonNew = new Button();
            buttonReceipt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInstallment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(312, 240);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(91, 23);
            buttonSubmit.TabIndex = 30;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // dataGridViewInstallment
            // 
            dataGridViewInstallment.AllowUserToAddRows = false;
            dataGridViewInstallment.AllowUserToDeleteRows = false;
            dataGridViewInstallment.AutoGenerateColumns = false;
            dataGridViewInstallment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInstallment.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, paymentDateDataGridViewTextBoxColumn, proofPathDataGridViewTextBoxColumn });
            dataGridViewInstallment.DataSource = installmentBindingSource;
            dataGridViewInstallment.Location = new Point(2, 2);
            dataGridViewInstallment.Name = "dataGridViewInstallment";
            dataGridViewInstallment.ReadOnly = true;
            dataGridViewInstallment.Size = new Size(291, 390);
            dataGridViewInstallment.TabIndex = 29;
            dataGridViewInstallment.CellClick += dataGridViewInstallment_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            amountDataGridViewTextBoxColumn.HeaderText = "amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proofPathDataGridViewTextBoxColumn
            // 
            proofPathDataGridViewTextBoxColumn.DataPropertyName = "ProofPath";
            proofPathDataGridViewTextBoxColumn.HeaderText = "ProofPath";
            proofPathDataGridViewTextBoxColumn.Name = "proofPathDataGridViewTextBoxColumn";
            proofPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // installmentBindingSource
            // 
            installmentBindingSource.DataSource = typeof(Models.Installment);
            // 
            // textLoanId
            // 
            textLoanId.Location = new Point(312, 27);
            textLoanId.Name = "textLoanId";
            textLoanId.ReadOnly = true;
            textLoanId.Size = new Size(212, 23);
            textLoanId.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 32;
            label1.Text = "Loan ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 34;
            label2.Text = "Amount";
            // 
            // textAmount
            // 
            textAmount.Location = new Point(312, 82);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(212, 23);
            textAmount.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 123);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 36;
            label3.Text = "Receipt";
            // 
            // textPath
            // 
            textPath.Location = new Point(312, 141);
            textPath.Name = "textPath";
            textPath.ReadOnly = true;
            textPath.Size = new Size(212, 23);
            textPath.TabIndex = 35;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(412, 240);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(112, 23);
            buttonNew.TabIndex = 37;
            buttonNew.Text = "New Installment";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonReceipt
            // 
            buttonReceipt.Location = new Point(451, 170);
            buttonReceipt.Name = "buttonReceipt";
            buttonReceipt.Size = new Size(73, 23);
            buttonReceipt.TabIndex = 38;
            buttonReceipt.Text = "Browse";
            buttonReceipt.UseVisualStyleBackColor = true;
            buttonReceipt.Click += buttonReceipt_Click;
            // 
            // InstallmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 406);
            ControlBox = false;
            Controls.Add(buttonReceipt);
            Controls.Add(buttonNew);
            Controls.Add(label3);
            Controls.Add(textPath);
            Controls.Add(label2);
            Controls.Add(textAmount);
            Controls.Add(label1);
            Controls.Add(textLoanId);
            Controls.Add(buttonSubmit);
            Controls.Add(dataGridViewInstallment);
            Name = "InstallmentForm";
            Text = "Installment";
            Load += InstallmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInstallment).EndInit();
            ((System.ComponentModel.ISupportInitialize)installmentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSubmit;
        private DataGridView dataGridViewInstallment;
        private BindingSource installmentBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proofPathDataGridViewTextBoxColumn;
        private TextBox textLoanId;
        private Label label1;
        private Label label2;
        private TextBox textAmount;
        private Label label3;
        private TextBox textPath;
        private Button buttonNew;
        private Button buttonReceipt;
    }
}