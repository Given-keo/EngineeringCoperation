namespace EngineeringCoperation.Forms.PublicMenus
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
            LblAmount = new Label();
            LblSubTotal = new Label();
            LblRate = new Label();
            TxtAmount = new TextBox();
            TxtRate = new TextBox();
            TxtSubTotal = new TextBox();
            TxtTotal = new TextBox();
            TxtFee = new TextBox();
            LblTotal = new Label();
            LblFee = new Label();
            BtnSubmit = new Button();
            BtnClear = new Button();
            LblTittle = new Label();
            SuspendLayout();
            // 
            // LblAmount
            // 
            LblAmount.AutoSize = true;
            LblAmount.Location = new Point(70, 55);
            LblAmount.Margin = new Padding(2, 0, 2, 0);
            LblAmount.Name = "LblAmount";
            LblAmount.Size = new Size(62, 20);
            LblAmount.TabIndex = 0;
            LblAmount.Text = "Amount";
            LblAmount.Click += label1_Click;
            // 
            // LblSubTotal
            // 
            LblSubTotal.AutoSize = true;
            LblSubTotal.Location = new Point(70, 170);
            LblSubTotal.Margin = new Padding(2, 0, 2, 0);
            LblSubTotal.Name = "LblSubTotal";
            LblSubTotal.Size = new Size(71, 20);
            LblSubTotal.TabIndex = 1;
            LblSubTotal.Text = "Sub Total";
            // 
            // LblRate
            // 
            LblRate.AutoSize = true;
            LblRate.Location = new Point(70, 117);
            LblRate.Margin = new Padding(2, 0, 2, 0);
            LblRate.Name = "LblRate";
            LblRate.Size = new Size(39, 20);
            LblRate.TabIndex = 2;
            LblRate.Text = "Rate";
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(166, 62);
            TxtAmount.Margin = new Padding(2);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(202, 27);
            TxtAmount.TabIndex = 3;
            TxtAmount.TextChanged += TxtAmount_TextChanged;
            // 
            // TxtRate
            // 
            TxtRate.Location = new Point(166, 114);
            TxtRate.Margin = new Padding(2);
            TxtRate.Name = "TxtRate";
            TxtRate.ReadOnly = true;
            TxtRate.Size = new Size(202, 27);
            TxtRate.TabIndex = 4;
            // 
            // TxtSubTotal
            // 
            TxtSubTotal.Location = new Point(166, 165);
            TxtSubTotal.Margin = new Padding(2);
            TxtSubTotal.Name = "TxtSubTotal";
            TxtSubTotal.ReadOnly = true;
            TxtSubTotal.Size = new Size(202, 27);
            TxtSubTotal.TabIndex = 5;
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(166, 270);
            TxtTotal.Margin = new Padding(2);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(202, 27);
            TxtTotal.TabIndex = 7;
            // 
            // TxtFee
            // 
            TxtFee.Location = new Point(166, 218);
            TxtFee.Margin = new Padding(2);
            TxtFee.Name = "TxtFee";
            TxtFee.ReadOnly = true;
            TxtFee.Size = new Size(202, 27);
            TxtFee.TabIndex = 6;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Location = new Point(70, 274);
            LblTotal.Margin = new Padding(2, 0, 2, 0);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(42, 20);
            LblTotal.TabIndex = 11;
            LblTotal.Text = "Total";
            // 
            // LblFee
            // 
            LblFee.AutoSize = true;
            LblFee.Location = new Point(70, 213);
            LblFee.Margin = new Padding(2, 0, 2, 0);
            LblFee.Name = "LblFee";
            LblFee.Size = new Size(32, 20);
            LblFee.TabIndex = 9;
            LblFee.Text = "Fee";
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(70, 339);
            BtnSubmit.Margin = new Padding(2);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(90, 27);
            BtnSubmit.TabIndex = 13;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(277, 339);
            BtnClear.Margin = new Padding(2);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(90, 27);
            BtnClear.TabIndex = 14;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // LblTittle
            // 
            LblTittle.AutoSize = true;
            LblTittle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTittle.Location = new Point(186, 22);
            LblTittle.Margin = new Padding(2, 0, 2, 0);
            LblTittle.Name = "LblTittle";
            LblTittle.Size = new Size(141, 25);
            LblTittle.TabIndex = 15;
            LblTittle.Text = "Exchange USD";
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LblTittle);
            Controls.Add(BtnClear);
            Controls.Add(BtnSubmit);
            Controls.Add(LblTotal);
            Controls.Add(LblFee);
            Controls.Add(TxtTotal);
            Controls.Add(TxtFee);
            Controls.Add(TxtSubTotal);
            Controls.Add(TxtRate);
            Controls.Add(TxtAmount);
            Controls.Add(LblRate);
            Controls.Add(LblSubTotal);
            Controls.Add(LblAmount);
            Margin = new Padding(2);
            Name = "ExchangePage";
            Size = new Size(786, 446);
            Load += ExchangePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAmount;
        private Label LblSubTotal;
        private Label LblRate;
        private TextBox TxtAmount;
        private TextBox TxtRate;
        private TextBox TxtSubTotal;
        private TextBox TxtTotal;
        private TextBox TxtFee;
        private Label LblTotal;
        private Label LblFee;
        private Button BtnSubmit;
        private Button BtnClear;
        private Label LblTittle;
    }
}
