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
            txtExchange = new TextBox();
            txtInhouse = new TextBox();
            label3 = new Label();
            txtTermin2 = new TextBox();
            label4 = new Label();
            txtAccross = new TextBox();
            label5 = new Label();
            txtTermin3 = new TextBox();
            label6 = new Label();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Terminologi 1";
            // 
            // txtTermin1
            // 
            txtTermin1.Location = new Point(36, 91);
            txtTermin1.Margin = new Padding(4);
            txtTermin1.Multiline = true;
            txtTermin1.Name = "txtTermin1";
            txtTermin1.Size = new Size(268, 332);
            txtTermin1.TabIndex = 1;
            txtTermin1.TextChanged += txtTermin1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 454);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 2;
            label2.Text = "Exchange Rate";
            // 
            // txtExchange
            // 
            txtExchange.Location = new Point(39, 514);
            txtExchange.Margin = new Padding(4);
            txtExchange.Name = "txtExchange";
            txtExchange.Size = new Size(268, 31);
            txtExchange.TabIndex = 3;
            txtExchange.TextChanged += textBox2_TextChanged;
            // 
            // txtInhouse
            // 
            txtInhouse.Location = new Point(410, 514);
            txtInhouse.Margin = new Padding(4);
            txtInhouse.Name = "txtInhouse";
            txtInhouse.Size = new Size(268, 31);
            txtInhouse.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 454);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 6;
            label3.Text = "Inhouse Fee";
            // 
            // txtTermin2
            // 
            txtTermin2.Location = new Point(408, 91);
            txtTermin2.Margin = new Padding(4);
            txtTermin2.Multiline = true;
            txtTermin2.Name = "txtTermin2";
            txtTermin2.Size = new Size(268, 332);
            txtTermin2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 36);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 4;
            label4.Text = "Terminologi 2";
            // 
            // txtAccross
            // 
            txtAccross.Location = new Point(770, 514);
            txtAccross.Margin = new Padding(4);
            txtAccross.Name = "txtAccross";
            txtAccross.Size = new Size(268, 31);
            txtAccross.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(770, 454);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 10;
            label5.Text = "Accross Fee";
            // 
            // txtTermin3
            // 
            txtTermin3.Location = new Point(768, 91);
            txtTermin3.Margin = new Padding(4);
            txtTermin3.Multiline = true;
            txtTermin3.Name = "txtTermin3";
            txtTermin3.Size = new Size(268, 332);
            txtTermin3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(770, 36);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 8;
            label6.Text = "Terminologi 3";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(479, 579);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 36);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // ConfigPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdate);
            Controls.Add(txtAccross);
            Controls.Add(label5);
            Controls.Add(txtTermin3);
            Controls.Add(label6);
            Controls.Add(txtInhouse);
            Controls.Add(label3);
            Controls.Add(txtTermin2);
            Controls.Add(label4);
            Controls.Add(txtExchange);
            Controls.Add(label2);
            Controls.Add(txtTermin1);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "ConfigPage";
            Size = new Size(1132, 645);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTermin1;
        private Label label2;
        private TextBox txtExchange;
        private TextBox txtInhouse;
        private Label label3;
        private TextBox txtTermin2;
        private Label label4;
        private TextBox txtAccross;
        private Label label5;
        private TextBox txtTermin3;
        private Label label6;
        private Button btnUpdate;
    }
}
