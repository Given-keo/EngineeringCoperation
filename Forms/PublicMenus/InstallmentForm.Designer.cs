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
            buttonSubmit.Location = new Point(357, 320);
            buttonSubmit.Margin = new Padding(3, 4, 3, 4);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(104, 31);
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
            dataGridViewInstallment.Location = new Point(2, 3);
            dataGridViewInstallment.Margin = new Padding(3, 4, 3, 4);
            dataGridViewInstallment.Name = "dataGridViewInstallment";
            dataGridViewInstallment.ReadOnly = true;
            dataGridViewInstallment.RowHeadersWidth = 51;
            dataGridViewInstallment.Size = new Size(333, 520);
            dataGridViewInstallment.TabIndex = 29;
            dataGridViewInstallment.CellClick += dataGridViewInstallment_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            amountDataGridViewTextBoxColumn.HeaderText = "amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            paymentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // proofPathDataGridViewTextBoxColumn
            // 
            proofPathDataGridViewTextBoxColumn.DataPropertyName = "ProofPath";
            proofPathDataGridViewTextBoxColumn.HeaderText = "ProofPath";
            proofPathDataGridViewTextBoxColumn.MinimumWidth = 6;
            proofPathDataGridViewTextBoxColumn.Name = "proofPathDataGridViewTextBoxColumn";
            proofPathDataGridViewTextBoxColumn.ReadOnly = true;
            proofPathDataGridViewTextBoxColumn.Width = 125;
            // 
            // installmentBindingSource
            // 
            installmentBindingSource.DataSource = typeof(Models.Installment);
            // 
            // textLoanId
            // 
            textLoanId.Location = new Point(357, 36);
            textLoanId.Margin = new Padding(3, 4, 3, 4);
            textLoanId.Name = "textLoanId";
            textLoanId.ReadOnly = true;
            textLoanId.Size = new Size(242, 27);
            textLoanId.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 12);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 32;
            label1.Text = "Loan ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 85);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 34;
            label2.Text = "Amount";
            // 
            // textAmount
            // 
            textAmount.Location = new Point(357, 109);
            textAmount.Margin = new Padding(3, 4, 3, 4);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(242, 27);
            textAmount.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 164);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 36;
            label3.Text = "Receipt";
            // 
            // textPath
            // 
            textPath.Location = new Point(357, 188);
            textPath.Margin = new Padding(3, 4, 3, 4);
            textPath.Name = "textPath";
            textPath.ReadOnly = true;
            textPath.Size = new Size(242, 27);
            textPath.TabIndex = 35;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(471, 320);
            buttonNew.Margin = new Padding(3, 4, 3, 4);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(128, 31);
            buttonNew.TabIndex = 37;
            buttonNew.Text = "New Installment";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonReceipt
            // 
            buttonReceipt.Location = new Point(515, 227);
            buttonReceipt.Margin = new Padding(3, 4, 3, 4);
            buttonReceipt.Name = "buttonReceipt";
            buttonReceipt.Size = new Size(83, 31);
            buttonReceipt.TabIndex = 38;
            buttonReceipt.Text = "Browse";
            buttonReceipt.UseVisualStyleBackColor = true;
            buttonReceipt.Click += buttonReceipt_Click;
            // 
            // InstallmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(618, 541);
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
            Margin = new Padding(3, 4, 3, 4);
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