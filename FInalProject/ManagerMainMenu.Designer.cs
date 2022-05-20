
namespace FInalProject
{
    partial class ManagerMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Name = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.personalInformationToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.addNewToolStripMenuItem.Text = "Add new staff";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.personalInformationToolStripMenuItem.Text = "Personal information";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(12, 77);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(109, 39);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "label1";
            // 
            // ManagerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerMainMenu";
            this.Text = "ManagerMainMenu";
            this.Load += new System.EventHandler(this.ManagerMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.Label label_Name;
    }
}