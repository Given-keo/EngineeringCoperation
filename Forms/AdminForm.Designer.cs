namespace EngineeringCoperation.Forms
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuItem = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            accessToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            approvalToolStripMenuItem = new ToolStripMenuItem();
            acrossCooperationToolStripMenuItem = new ToolStripMenuItem();
            panelAdminForm = new Panel();
            menuItem.SuspendLayout();
            SuspendLayout();
            // 
            // menuItem
            // 
            menuItem.ImageScalingSize = new Size(24, 24);
            menuItem.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, memberToolStripMenuItem, accessToolStripMenuItem, productToolStripMenuItem, approvalToolStripMenuItem, acrossCooperationToolStripMenuItem });
            menuItem.Location = new Point(0, 0);
            menuItem.Name = "menuItem";
            menuItem.Size = new Size(800, 33);
            menuItem.TabIndex = 0;
            menuItem.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(95, 29);
            memberToolStripMenuItem.Text = "Member";
            // 
            // accessToolStripMenuItem
            // 
            accessToolStripMenuItem.Name = "accessToolStripMenuItem";
            accessToolStripMenuItem.Size = new Size(81, 29);
            accessToolStripMenuItem.Text = "Access";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(90, 29);
            productToolStripMenuItem.Text = "Product";
            // 
            // approvalToolStripMenuItem
            // 
            approvalToolStripMenuItem.Name = "approvalToolStripMenuItem";
            approvalToolStripMenuItem.Size = new Size(101, 29);
            approvalToolStripMenuItem.Text = "Approval";
            // 
            // acrossCooperationToolStripMenuItem
            // 
            acrossCooperationToolStripMenuItem.Name = "acrossCooperationToolStripMenuItem";
            acrossCooperationToolStripMenuItem.Size = new Size(185, 29);
            acrossCooperationToolStripMenuItem.Text = "Across Cooperation";
            // 
            // panelAdminForm
            // 
            panelAdminForm.Dock = DockStyle.Bottom;
            panelAdminForm.Location = new Point(0, 40);
            panelAdminForm.Name = "panelAdminForm";
            panelAdminForm.Size = new Size(800, 410);
            panelAdminForm.TabIndex = 1;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAdminForm);
            Controls.Add(menuItem);
            MainMenuStrip = menuItem;
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            menuItem.ResumeLayout(false);
            menuItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem accessToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem approvalToolStripMenuItem;
        private ToolStripMenuItem acrossCooperationToolStripMenuItem;
        private Panel panelAdminForm;
    }
}