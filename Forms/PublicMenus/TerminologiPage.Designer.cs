namespace EngineeringCoperation.Forms.PublicMenus
{
    partial class TerminologiPage
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
            labelTerminologi1 = new Label();
            labelTerminologi2 = new Label();
            labelTerminologi3 = new Label();
            labelExchange = new Label();
            labelInhouse = new Label();
            labelAccross = new Label();
            SuspendLayout();
            // 
            // labelTerminologi1
            // 
            labelTerminologi1.AutoSize = true;
            labelTerminologi1.Location = new Point(38, 35);
            labelTerminologi1.Name = "labelTerminologi1";
            labelTerminologi1.Size = new Size(18, 20);
            labelTerminologi1.TabIndex = 0;
            labelTerminologi1.Text = "...";
            // 
            // labelTerminologi2
            // 
            labelTerminologi2.AutoSize = true;
            labelTerminologi2.Location = new Point(38, 224);
            labelTerminologi2.Name = "labelTerminologi2";
            labelTerminologi2.Size = new Size(18, 20);
            labelTerminologi2.TabIndex = 1;
            labelTerminologi2.Text = "...";
            // 
            // labelTerminologi3
            // 
            labelTerminologi3.AutoSize = true;
            labelTerminologi3.Location = new Point(38, 415);
            labelTerminologi3.Name = "labelTerminologi3";
            labelTerminologi3.Size = new Size(18, 20);
            labelTerminologi3.TabIndex = 2;
            labelTerminologi3.Text = "...";
            // 
            // labelExchange
            // 
            labelExchange.AutoSize = true;
            labelExchange.Location = new Point(38, 524);
            labelExchange.Name = "labelExchange";
            labelExchange.Size = new Size(113, 20);
            labelExchange.TabIndex = 3;
            labelExchange.Text = "Exchange Rate: ";
            // 
            // labelInhouse
            // 
            labelInhouse.AutoSize = true;
            labelInhouse.Location = new Point(271, 524);
            labelInhouse.Name = "labelInhouse";
            labelInhouse.Size = new Size(90, 20);
            labelInhouse.TabIndex = 4;
            labelInhouse.Text = "Inhouse Fee:";
            // 
            // labelAccross
            // 
            labelAccross.AutoSize = true;
            labelAccross.Location = new Point(520, 524);
            labelAccross.Name = "labelAccross";
            labelAccross.Size = new Size(89, 20);
            labelAccross.TabIndex = 5;
            labelAccross.Text = "Accross Fee:";
            // 
            // TerminologiPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(labelAccross);
            Controls.Add(labelInhouse);
            Controls.Add(labelExchange);
            Controls.Add(labelTerminologi3);
            Controls.Add(labelTerminologi2);
            Controls.Add(labelTerminologi1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TerminologiPage";
            Size = new Size(759, 653);
            Load += TerminologiPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTerminologi1;
        private Label labelTerminologi2;
        private Label labelTerminologi3;
        private Label labelExchange;
        private Label labelInhouse;
        private Label labelAccross;
    }
}
