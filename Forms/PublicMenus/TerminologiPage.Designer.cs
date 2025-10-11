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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 416);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Exchange Rate:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 416);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Inhouse Fee:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(547, 416);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 5;
            label6.Text = "Accross Fee:";
            // 
            // TerminologiPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblTermin3);
            Controls.Add(lblTermin2);
            Controls.Add(lblTermin1);
            Name = "TerminologiPage";
            Size = new Size(779, 522);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTermin1;
        private Label lblTermin2;
        private Label lblTermin3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
