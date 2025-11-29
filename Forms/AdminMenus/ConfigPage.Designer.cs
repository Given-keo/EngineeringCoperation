namespace EngineeringCoperation.Forms.AdminMenus
{
    partial class ConfigPage
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
            label1 = new Label();
            txtTermin1 = new TextBox();
            label2 = new Label();
            textExchangeRate = new TextBox();
            textInhouseFee = new TextBox();
            label3 = new Label();
            txtTermin2 = new TextBox();
            label4 = new Label();
            textAccrossFee = new TextBox();
            label5 = new Label();
            txtTermin3 = new TextBox();
            label6 = new Label();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Terminologi 1";
            // 
            // txtTermin1
            // 
            txtTermin1.Location = new Point(29, 73);
            txtTermin1.Multiline = true;
            txtTermin1.Name = "txtTermin1";
            txtTermin1.Size = new Size(215, 266);
            txtTermin1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 363);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Exchange Rate";
            // 
            // textExchangeRate
            // 
            textExchangeRate.Location = new Point(31, 411);
            textExchangeRate.Name = "textExchangeRate";
            textExchangeRate.Size = new Size(215, 27);
            textExchangeRate.TabIndex = 3;
            textExchangeRate.TextChanged += textBox2_TextChanged;
            // 
            // textInhouseFee
            // 
            textInhouseFee.Location = new Point(328, 411);
            textInhouseFee.Name = "textInhouseFee";
            textInhouseFee.Size = new Size(215, 27);
            textInhouseFee.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 363);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Inhouse Fee";
            // 
            // txtTermin2
            // 
            txtTermin2.Location = new Point(326, 73);
            txtTermin2.Multiline = true;
            txtTermin2.Name = "txtTermin2";
            txtTermin2.Size = new Size(215, 266);
            txtTermin2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 29);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 4;
            label4.Text = "Terminologi 2";
            // 
            // textAccrossFee
            // 
            textAccrossFee.Location = new Point(616, 411);
            textAccrossFee.Name = "textAccrossFee";
            textAccrossFee.Size = new Size(215, 27);
            textAccrossFee.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(616, 363);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 10;
            label5.Text = "Accross Fee";
            // 
            // txtTermin3
            // 
            txtTermin3.Location = new Point(614, 73);
            txtTermin3.Multiline = true;
            txtTermin3.Name = "txtTermin3";
            txtTermin3.Size = new Size(215, 266);
            txtTermin3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(616, 29);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 8;
            label6.Text = "Terminologi 3";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(383, 463);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // ConfigPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdate);
            Controls.Add(textAccrossFee);
            Controls.Add(label5);
            Controls.Add(txtTermin3);
            Controls.Add(label6);
            Controls.Add(textInhouseFee);
            Controls.Add(label3);
            Controls.Add(txtTermin2);
            Controls.Add(label4);
            Controls.Add(textExchangeRate);
            Controls.Add(label2);
            Controls.Add(txtTermin1);
            Controls.Add(label1);
            Name = "ConfigPage";
            Size = new Size(906, 516);
            Load += ConfigPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTermin1;
        private Label label2;
        private TextBox textExchangeRate;
        private TextBox textInhouseFee;
        private Label label3;
        private TextBox txtTermin2;
        private Label label4;
        private TextBox textAccrossFee;
        private Label label5;
        private TextBox txtTermin3;
        private Label label6;
        private Button btnUpdate;
    }
}
