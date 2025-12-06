namespace EngineeringCoperation.Forms.AdminMenus
{
    partial class AcrossTransferPages
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
            TxtBalance = new TextBox();
            LblBalance = new Label();
            LblBeneficiary = new Label();
            TxtBeneficiary = new TextBox();
            LblAmount = new Label();
            TxtAmount = new TextBox();
            LblTransfer = new Label();
            TxtTransferRef = new TextBox();
            LblRemarks = new Label();
            TxtRemarks = new TextBox();
            BtnSubmit = new Button();
            BtnClear = new Button();
            dataGridBecoming = new DataGridView();
            dataGridOutgoing = new DataGridView();
            LblBecoming = new Label();
            LblOutgoing = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridBecoming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOutgoing).BeginInit();
            SuspendLayout();
            // 
            // TxtBalance
            // 
            TxtBalance.Location = new Point(100, 59);
            TxtBalance.Name = "TxtBalance";
            TxtBalance.Size = new Size(247, 31);
            TxtBalance.TabIndex = 0;
            // 
            // LblBalance
            // 
            LblBalance.AutoSize = true;
            LblBalance.Location = new Point(100, 31);
            LblBalance.Name = "LblBalance";
            LblBalance.Size = new Size(71, 25);
            LblBalance.TabIndex = 1;
            LblBalance.Text = "Balance";
            LblBalance.Click += label1_Click;
            // 
            // LblBeneficiary
            // 
            LblBeneficiary.AutoSize = true;
            LblBeneficiary.Location = new Point(100, 106);
            LblBeneficiary.Name = "LblBeneficiary";
            LblBeneficiary.Size = new Size(96, 25);
            LblBeneficiary.TabIndex = 3;
            LblBeneficiary.Text = "Beneficiary";
            // 
            // TxtBeneficiary
            // 
            TxtBeneficiary.Location = new Point(100, 134);
            TxtBeneficiary.Name = "TxtBeneficiary";
            TxtBeneficiary.Size = new Size(247, 31);
            TxtBeneficiary.TabIndex = 2;
            // 
            // LblAmount
            // 
            LblAmount.AutoSize = true;
            LblAmount.Location = new Point(100, 168);
            LblAmount.Name = "LblAmount";
            LblAmount.Size = new Size(77, 25);
            LblAmount.TabIndex = 5;
            LblAmount.Text = "Amount";
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(100, 196);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(247, 31);
            TxtAmount.TabIndex = 4;
            // 
            // LblTransfer
            // 
            LblTransfer.AutoSize = true;
            LblTransfer.Location = new Point(100, 230);
            LblTransfer.Name = "LblTransfer";
            LblTransfer.Size = new Size(103, 25);
            LblTransfer.TabIndex = 7;
            LblTransfer.Text = "Transfer Ref";
            // 
            // TxtTransferRef
            // 
            TxtTransferRef.Location = new Point(100, 258);
            TxtTransferRef.Name = "TxtTransferRef";
            TxtTransferRef.Size = new Size(247, 31);
            TxtTransferRef.TabIndex = 6;
            // 
            // LblRemarks
            // 
            LblRemarks.AutoSize = true;
            LblRemarks.Location = new Point(100, 292);
            LblRemarks.Name = "LblRemarks";
            LblRemarks.Size = new Size(79, 25);
            LblRemarks.TabIndex = 9;
            LblRemarks.Text = "Remarks";
            // 
            // TxtRemarks
            // 
            TxtRemarks.Location = new Point(100, 320);
            TxtRemarks.Multiline = true;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.Size = new Size(247, 49);
            TxtRemarks.TabIndex = 11;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(100, 392);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(112, 34);
            BtnSubmit.TabIndex = 12;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += this.BtnSubmit_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(235, 392);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(112, 34);
            BtnClear.TabIndex = 13;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // dataGridBecoming
            // 
            dataGridBecoming.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBecoming.Location = new Point(417, 64);
            dataGridBecoming.Name = "dataGridBecoming";
            dataGridBecoming.RowHeadersWidth = 62;
            dataGridBecoming.Size = new Size(332, 141);
            dataGridBecoming.TabIndex = 14;
            // 
            // dataGridOutgoing
            // 
            dataGridOutgoing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOutgoing.Location = new Point(417, 258);
            dataGridOutgoing.Name = "dataGridOutgoing";
            dataGridOutgoing.RowHeadersWidth = 62;
            dataGridOutgoing.Size = new Size(332, 141);
            dataGridOutgoing.TabIndex = 15;
            // 
            // LblBecoming
            // 
            LblBecoming.AutoSize = true;
            LblBecoming.Location = new Point(417, 31);
            LblBecoming.Name = "LblBecoming";
            LblBecoming.Size = new Size(91, 25);
            LblBecoming.TabIndex = 16;
            LblBecoming.Text = "Becoming";
            // 
            // LblOutgoing
            // 
            LblOutgoing.AutoSize = true;
            LblOutgoing.Location = new Point(417, 219);
            LblOutgoing.Name = "LblOutgoing";
            LblOutgoing.Size = new Size(89, 25);
            LblOutgoing.TabIndex = 17;
            LblOutgoing.Text = "Outgoing";
            // 
            // AcrossTransferPages
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LblOutgoing);
            Controls.Add(LblBecoming);
            Controls.Add(dataGridOutgoing);
            Controls.Add(dataGridBecoming);
            Controls.Add(BtnClear);
            Controls.Add(BtnSubmit);
            Controls.Add(TxtRemarks);
            Controls.Add(LblRemarks);
            Controls.Add(LblTransfer);
            Controls.Add(TxtTransferRef);
            Controls.Add(LblAmount);
            Controls.Add(TxtAmount);
            Controls.Add(LblBeneficiary);
            Controls.Add(TxtBeneficiary);
            Controls.Add(LblBalance);
            Controls.Add(TxtBalance);
            Name = "AcrossTransferPages";
            Size = new Size(797, 452);
            ((System.ComponentModel.ISupportInitialize)dataGridBecoming).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOutgoing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBalance;
        private Label LblBalance;
        private Label LblBeneficiary;
        private TextBox TxtBeneficiary;
        private Label LblAmount;
        private TextBox TxtAmount;
        private Label LblTransfer;
        private TextBox TxtTransferRef;
        private Label LblRemarks;
        private TextBox TxtRemarks;
        private Button BtnSubmit;
        private Button BtnClear;
        private DataGridView dataGridBecoming;
        private DataGridView dataGridOutgoing;
        private Label LblBecoming;
        private Label LblOutgoing;
        private System.Windows.Forms.Timer timer1;
    }
}
