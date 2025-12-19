namespace EngineeringCoperation.Forms.AdminMenus
{
    partial class AcrossPage
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
            dgvCoop = new DataGridView();
            CoopCode = new DataGridViewTextBoxColumn();
            CoopName = new DataGridViewTextBoxColumn();
            CoopAddress = new DataGridViewTextBoxColumn();
            IsDelete = new DataGridViewTextBoxColumn();
            dgvBalance = new DataGridView();
            MemberCode = new DataGridViewTextBoxColumn();
            MemberName = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            dgvTransfer = new DataGridView();
            TransferCode = new DataGridViewTextBoxColumn();
            Origin = new DataGridViewTextBoxColumn();
            Benef = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            TransferOn = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            SuspendLayout();
            // 
            // dgvCoop
            // 
            dgvCoop.AllowUserToAddRows = false;
            dgvCoop.AllowUserToDeleteRows = false;
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Columns.AddRange(new DataGridViewColumn[] { CoopCode, CoopName, CoopAddress, IsDelete });
            dgvCoop.Location = new Point(23, 37);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.ReadOnly = true;
            dgvCoop.Size = new Size(467, 192);
            dgvCoop.TabIndex = 0;
            // 
            // CoopCode
            // 
            CoopCode.HeaderText = "Code";
            CoopCode.Name = "CoopCode";
            CoopCode.ReadOnly = true;
            // 
            // CoopName
            // 
            CoopName.HeaderText = "Name";
            CoopName.Name = "CoopName";
            CoopName.ReadOnly = true;
            // 
            // CoopAddress
            // 
            CoopAddress.HeaderText = "Address";
            CoopAddress.Name = "CoopAddress";
            CoopAddress.ReadOnly = true;
            // 
            // IsDelete
            // 
            IsDelete.HeaderText = "Telah dihapus?";
            IsDelete.Name = "IsDelete";
            IsDelete.ReadOnly = true;
            // 
            // dgvBalance
            // 
            dgvBalance.AllowUserToAddRows = false;
            dgvBalance.AllowUserToDeleteRows = false;
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Columns.AddRange(new DataGridViewColumn[] { MemberCode, MemberName, Balance });
            dgvBalance.Location = new Point(496, 37);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.ReadOnly = true;
            dgvBalance.Size = new Size(376, 192);
            dgvBalance.TabIndex = 1;
            // 
            // MemberCode
            // 
            MemberCode.HeaderText = "Code";
            MemberCode.Name = "MemberCode";
            MemberCode.ReadOnly = true;
            // 
            // MemberName
            // 
            MemberName.HeaderText = "Name";
            MemberName.Name = "MemberName";
            MemberName.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // dgvTransfer
            // 
            dgvTransfer.AllowUserToAddRows = false;
            dgvTransfer.AllowUserToDeleteRows = false;
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Columns.AddRange(new DataGridViewColumn[] { TransferCode, Origin, Benef, Amount, TransferOn, Remarks });
            dgvTransfer.Location = new Point(23, 261);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.ReadOnly = true;
            dgvTransfer.Size = new Size(849, 186);
            dgvTransfer.TabIndex = 2;
            // 
            // TransferCode
            // 
            TransferCode.HeaderText = "Transfer Code";
            TransferCode.Name = "TransferCode";
            TransferCode.ReadOnly = true;
            // 
            // Origin
            // 
            Origin.HeaderText = "Origin";
            Origin.Name = "Origin";
            Origin.ReadOnly = true;
            // 
            // Benef
            // 
            Benef.HeaderText = "Benef";
            Benef.Name = "Benef";
            Benef.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // TransferOn
            // 
            TransferOn.HeaderText = "Transfer On";
            TransferOn.Name = "TransferOn";
            TransferOn.ReadOnly = true;
            // 
            // Remarks
            // 
            Remarks.HeaderText = "Remarks";
            Remarks.Name = "Remarks";
            Remarks.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Coop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(496, 19);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 243);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Transfer";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(439, 453);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // AcrossPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRefresh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTransfer);
            Controls.Add(dgvBalance);
            Controls.Add(dgvCoop);
            Name = "AcrossPage";
            Size = new Size(921, 492);
            Load += AcrossPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCoop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCoop;
        private DataGridView dgvBalance;
        private DataGridView dgvTransfer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonRefresh;
        private DataGridViewTextBoxColumn MemberCode;
        private DataGridViewTextBoxColumn MemberName;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn TransferCode;
        private DataGridViewTextBoxColumn Origin;
        private DataGridViewTextBoxColumn Benef;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn TransferOn;
        private DataGridViewTextBoxColumn Remarks;
        private DataGridViewTextBoxColumn CoopCode;
        private DataGridViewTextBoxColumn CoopName;
        private DataGridViewTextBoxColumn CoopAddress;
        private DataGridViewTextBoxColumn IsDelete;
    }
}
