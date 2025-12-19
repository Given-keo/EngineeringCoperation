namespace EngineeringCoperation.Forms.MemberMenus
{
    partial class ExchangePage
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
            txtAmount = new TextBox();
            txtRate = new TextBox();
            txtFee = new TextBox();
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            exchangeBindingSource = new BindingSource(components);
            txtSubTotal = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)exchangeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(107, 82);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(180, 23);
            txtAmount.TabIndex = 0;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(107, 131);
            txtRate.Name = "txtRate";
            txtRate.ReadOnly = true;
            txtRate.Size = new Size(180, 23);
            txtRate.TabIndex = 1;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(107, 225);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(180, 23);
            txtFee.TabIndex = 2;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(107, 276);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(180, 23);
            txtTotal.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(107, 20);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 4;
            label1.Text = "Exchange USD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 134);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Rate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 228);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 7;
            label4.Text = "Fee";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 279);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 8;
            label5.Text = "Total";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(107, 326);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(212, 326);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // exchangeBindingSource
            // 
            exchangeBindingSource.DataSource = typeof(Models.Exchange);
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(107, 178);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(180, 23);
            txtSubTotal.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 181);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 14;
            label7.Text = "Sub Total";
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(txtSubTotal);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(txtFee);
            Controls.Add(txtRate);
            Controls.Add(txtAmount);
            Name = "ExchangePage";
            Size = new Size(345, 387);
            Load += ExchangePage_Load;
            ((System.ComponentModel.ISupportInitialize)exchangeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private TextBox txtRate;
        private TextBox txtFee;
        private TextBox txtTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSubmit;
        private Button btnClear;
        private BindingSource exchangeBindingSource;
        private TextBox txtSubTotal;
        private Label label7;
    }
}
