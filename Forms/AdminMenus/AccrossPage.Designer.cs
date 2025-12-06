namespace EngineeringCoperation.Forms.AdminMenus
{
    partial class AccrossPage
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
            buttonRefresh = new Button();
            lbl_3 = new Label();
            dgvTransfer = new DataGridView();
            dgvBalance = new DataGridView();
            lbl_2 = new Label();
            dgvCoop = new DataGridView();
            lbl_1 = new Label();
            CoopCode = new DataGridViewTextBoxColumn();
            CoodName = new DataGridViewTextBoxColumn();
            CoodAddress = new DataGridViewTextBoxColumn();
            MemberCode = new DataGridViewTextBoxColumn();
            MemberName = new DataGridViewTextBoxColumn();
            MemberBalance = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).BeginInit();
            SuspendLayout();
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(533, 637);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(112, 34);
            buttonRefresh.TabIndex = 13;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // lbl_3
            // 
            lbl_3.AutoSize = true;
            lbl_3.Location = new Point(45, 342);
            lbl_3.Name = "lbl_3";
            lbl_3.Size = new Size(73, 25);
            lbl_3.TabIndex = 12;
            lbl_3.Text = "Transfer";
            // 
            // dgvTransfer
            // 
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Location = new Point(45, 370);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.RowHeadersWidth = 62;
            dgvTransfer.Size = new Size(1071, 251);
            dgvTransfer.TabIndex = 11;
            // 
            // dgvBalance
            // 
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Columns.AddRange(new DataGridViewColumn[] { MemberCode, MemberName, MemberBalance });
            dgvBalance.Location = new Point(602, 58);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.RowHeadersWidth = 62;
            dgvBalance.Size = new Size(514, 268);
            dgvBalance.TabIndex = 10;
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Location = new Point(791, 30);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(79, 25);
            lbl_2.TabIndex = 9;
            lbl_2.Text = "Member";
            // 
            // dgvCoop
            // 
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Columns.AddRange(new DataGridViewColumn[] { CoopCode, CoodName, CoodAddress });
            dgvCoop.Location = new Point(45, 58);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.RowHeadersWidth = 62;
            dgvCoop.Size = new Size(508, 268);
            dgvCoop.TabIndex = 8;
            dgvCoop.CellContentClick += dgvCoop_CellContentClick;
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Location = new Point(45, 32);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(56, 25);
            lbl_1.TabIndex = 7;
            lbl_1.Text = "Coop";
            // 
            // CoopCode
            // 
            CoopCode.HeaderText = "Code";
            CoopCode.MinimumWidth = 8;
            CoopCode.Name = "CoopCode";
            CoopCode.Width = 150;
            // 
            // CoodName
            // 
            CoodName.HeaderText = "Name";
            CoodName.MinimumWidth = 8;
            CoodName.Name = "CoodName";
            CoodName.Width = 150;
            // 
            // CoodAddress
            // 
            CoodAddress.HeaderText = "Address";
            CoodAddress.MinimumWidth = 8;
            CoodAddress.Name = "CoodAddress";
            CoodAddress.Width = 150;
            // 
            // MemberCode
            // 
            MemberCode.HeaderText = "Code";
            MemberCode.MinimumWidth = 8;
            MemberCode.Name = "MemberCode";
            MemberCode.Width = 150;
            // 
            // MemberName
            // 
            MemberName.HeaderText = "Name";
            MemberName.MinimumWidth = 8;
            MemberName.Name = "MemberName";
            MemberName.Width = 150;
            // 
            // MemberBalance
            // 
            MemberBalance.HeaderText = "Balance";
            MemberBalance.MinimumWidth = 8;
            MemberBalance.Name = "MemberBalance";
            MemberBalance.Width = 150;
            // 
            // AccrossPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRefresh);
            Controls.Add(lbl_3);
            Controls.Add(dgvTransfer);
            Controls.Add(dgvBalance);
            Controls.Add(lbl_2);
            Controls.Add(dgvCoop);
            Controls.Add(lbl_1);
            Name = "AccrossPage";
            Size = new Size(1209, 705);
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRefresh;
        private Label lbl_3;
        private DataGridView dgvTransfer;
        private DataGridView dgvBalance;
        private Label lbl_2;
        private DataGridView dgvCoop;
        private Label lbl_1;
        private DataGridViewTextBoxColumn MemberCode;
        private DataGridViewTextBoxColumn MemberName;
        private DataGridViewTextBoxColumn MemberBalance;
        private DataGridViewTextBoxColumn CoopCode;
        private DataGridViewTextBoxColumn CoodName;
        private DataGridViewTextBoxColumn CoodAddress;
    }
}
