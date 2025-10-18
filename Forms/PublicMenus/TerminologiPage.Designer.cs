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
            lblTermin1 = new Label();
            lblTermin2 = new Label();
            lblTermin3 = new Label();
            lblExchange = new Label();
            lblInhouse = new Label();
            lblAccross = new Label();
            SuspendLayout();
            // 
            // lblTermin1
            // 
            lblTermin1.AutoSize = true;
            lblTermin1.Location = new Point(62, 39);
            lblTermin1.Name = "lblTermin1";
            lblTermin1.Size = new Size(18, 20);
            lblTermin1.TabIndex = 0;
            lblTermin1.Text = "...";
            // 
            // lblTermin2
            // 
            lblTermin2.AutoSize = true;
            lblTermin2.Location = new Point(62, 182);
            lblTermin2.Name = "lblTermin2";
            lblTermin2.Size = new Size(18, 20);
            lblTermin2.TabIndex = 1;
            lblTermin2.Text = "...";
            // 
            // lblTermin3
            // 
            lblTermin3.AutoSize = true;
            lblTermin3.Location = new Point(62, 337);
            lblTermin3.Name = "lblTermin3";
            lblTermin3.Size = new Size(18, 20);
            lblTermin3.TabIndex = 2;
            lblTermin3.Text = "...";
            // 
            // lblExchange
            // 
            lblExchange.AutoSize = true;
            lblExchange.Location = new Point(62, 416);
            lblExchange.Name = "lblExchange";
            lblExchange.Size = new Size(109, 20);
            lblExchange.TabIndex = 3;
            lblExchange.Text = "Exchange Rate:";
            // 
            // lblInhouse
            // 
            lblInhouse.AutoSize = true;
            lblInhouse.Location = new Point(305, 416);
            lblInhouse.Name = "lblInhouse";
            lblInhouse.Size = new Size(90, 20);
            lblInhouse.TabIndex = 4;
            lblInhouse.Text = "Inhouse Fee:";
            // 
            // lblAccross
            // 
            lblAccross.AutoSize = true;
            lblAccross.Location = new Point(547, 416);
            lblAccross.Name = "lblAccross";
            lblAccross.Size = new Size(89, 20);
            lblAccross.TabIndex = 5;
            lblAccross.Text = "Accross Fee:";
            // 
            // TerminologiPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAccross);
            Controls.Add(lblInhouse);
            Controls.Add(lblExchange);
            Controls.Add(lblTermin3);
            Controls.Add(lblTermin2);
            Controls.Add(lblTermin1);
            Name = "TerminologiPage";
            Size = new Size(779, 522);
            Load += TerminologiPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTermin1;
        private Label lblTermin2;
        private Label lblTermin3;
        private Label lblExchange;
        private Label lblInhouse;
        private Label lblAccross;
    }
}
