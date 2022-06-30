namespace FInalProject
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageShiftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managePriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.managePriceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(533, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStaffToolStripMenuItem,
            this.removeStaffToolStripMenuItem,
            this.updateStaffToolStripMenuItem,
            this.staffListToolStripMenuItem,
            this.manageShiftToolStripMenuItem1});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // addNewStaffToolStripMenuItem
            // 
            this.addNewStaffToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.addNewStaffToolStripMenuItem.Name = "addNewStaffToolStripMenuItem";
            this.addNewStaffToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.addNewStaffToolStripMenuItem.Text = "Add new staff";
            this.addNewStaffToolStripMenuItem.Click += new System.EventHandler(this.addNewStaffToolStripMenuItem_Click);
            // 
            // removeStaffToolStripMenuItem
            // 
            this.removeStaffToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.removeStaffToolStripMenuItem.Name = "removeStaffToolStripMenuItem";
            this.removeStaffToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.removeStaffToolStripMenuItem.Text = "Remove staff";
            this.removeStaffToolStripMenuItem.Click += new System.EventHandler(this.removeStaffToolStripMenuItem_Click);
            // 
            // updateStaffToolStripMenuItem
            // 
            this.updateStaffToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateStaffToolStripMenuItem.Name = "updateStaffToolStripMenuItem";
            this.updateStaffToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.updateStaffToolStripMenuItem.Text = "Update staff";
            this.updateStaffToolStripMenuItem.Click += new System.EventHandler(this.updateStaffToolStripMenuItem_Click);
            // 
            // staffListToolStripMenuItem
            // 
            this.staffListToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow;
            this.staffListToolStripMenuItem.Name = "staffListToolStripMenuItem";
            this.staffListToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.staffListToolStripMenuItem.Text = "Staff List";
            this.staffListToolStripMenuItem.Click += new System.EventHandler(this.staffListToolStripMenuItem_Click);
            // 
            // manageShiftToolStripMenuItem1
            // 
            this.manageShiftToolStripMenuItem1.BackColor = System.Drawing.Color.Yellow;
            this.manageShiftToolStripMenuItem1.Name = "manageShiftToolStripMenuItem1";
            this.manageShiftToolStripMenuItem1.Size = new System.Drawing.Size(199, 30);
            this.manageShiftToolStripMenuItem1.Text = "Manage Shift";
            this.manageShiftToolStripMenuItem1.Click += new System.EventHandler(this.manageShiftToolStripMenuItem1_Click);
            // 
            // managePriceToolStripMenuItem
            // 
            this.managePriceToolStripMenuItem.Name = "managePriceToolStripMenuItem";
            this.managePriceToolStripMenuItem.Size = new System.Drawing.Size(140, 29);
            this.managePriceToolStripMenuItem.Text = "Manage Price";
            this.managePriceToolStripMenuItem.Click += new System.EventHandler(this.managePriceToolStripMenuItem_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageShiftToolStripMenuItem1;
    }
}