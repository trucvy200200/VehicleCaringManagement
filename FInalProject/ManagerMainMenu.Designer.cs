
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
            this.workToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caringCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCertificateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Name = new System.Windows.Forms.Label();
            this.workListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleToolStripMenuItem,
            this.garageToolStripMenuItem,
            this.workToolStripMenuItem,
            this.certificateToolStripMenuItem,
            this.revenueToolStripMenuItem,
            this.managerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.personalInformationToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.managerToolStripMenuItem.Text = "Staff";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addNewToolStripMenuItem.Text = "Add new staff";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.personalInformationToolStripMenuItem.Text = "Personal information";
            // 
            // workToolStripMenuItem
            // 
            this.workToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWorkToolStripMenuItem,
            this.deleteWorkToolStripMenuItem,
            this.updateWorkToolStripMenuItem,
            this.workListToolStripMenuItem});
            this.workToolStripMenuItem.Name = "workToolStripMenuItem";
            this.workToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.workToolStripMenuItem.Text = "Work";
            // 
            // addWorkToolStripMenuItem
            // 
            this.addWorkToolStripMenuItem.Name = "addWorkToolStripMenuItem";
            this.addWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addWorkToolStripMenuItem.Text = "Add  work";
            this.addWorkToolStripMenuItem.Click += new System.EventHandler(this.addWorkToolStripMenuItem_Click);
            // 
            // deleteWorkToolStripMenuItem
            // 
            this.deleteWorkToolStripMenuItem.Name = "deleteWorkToolStripMenuItem";
            this.deleteWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteWorkToolStripMenuItem.Text = "Remove work";
            this.deleteWorkToolStripMenuItem.Click += new System.EventHandler(this.deleteWorkToolStripMenuItem_Click);
            // 
            // updateWorkToolStripMenuItem
            // 
            this.updateWorkToolStripMenuItem.Name = "updateWorkToolStripMenuItem";
            this.updateWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateWorkToolStripMenuItem.Text = "Update work";
            this.updateWorkToolStripMenuItem.Click += new System.EventHandler(this.updateWorkToolStripMenuItem_Click);
            // 
            // certificateToolStripMenuItem
            // 
            this.certificateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caringCertificateToolStripMenuItem,
            this.rentCertificateToolStripMenuItem,
            this.rentCertificateToolStripMenuItem1});
            this.certificateToolStripMenuItem.Name = "certificateToolStripMenuItem";
            this.certificateToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.certificateToolStripMenuItem.Text = "Certificate";
            // 
            // caringCertificateToolStripMenuItem
            // 
            this.caringCertificateToolStripMenuItem.Name = "caringCertificateToolStripMenuItem";
            this.caringCertificateToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.caringCertificateToolStripMenuItem.Text = "Caring Certificate";
            // 
            // rentCertificateToolStripMenuItem
            // 
            this.rentCertificateToolStripMenuItem.Name = "rentCertificateToolStripMenuItem";
            this.rentCertificateToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.rentCertificateToolStripMenuItem.Text = "Caring Certificate Detail";
            // 
            // rentCertificateToolStripMenuItem1
            // 
            this.rentCertificateToolStripMenuItem1.Name = "rentCertificateToolStripMenuItem1";
            this.rentCertificateToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.rentCertificateToolStripMenuItem1.Text = "Rent Certificate";
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.revenueToolStripMenuItem.Text = "Revenue";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(9, 63);
            this.label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(86, 31);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "label1";
            // 
            // workListToolStripMenuItem
            // 
            this.workListToolStripMenuItem.Name = "workListToolStripMenuItem";
            this.workListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.workListToolStripMenuItem.Text = "Manage Work Form";
            this.workListToolStripMenuItem.Click += new System.EventHandler(this.workListToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiveVehicleToolStripMenuItem,
            this.removeVehicleToolStripMenuItem,
            this.statisticToolStripMenuItem});
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            // 
            // receiveVehicleToolStripMenuItem
            // 
            this.receiveVehicleToolStripMenuItem.Name = "receiveVehicleToolStripMenuItem";
            this.receiveVehicleToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.receiveVehicleToolStripMenuItem.Text = "Receive Vehicle";
            this.receiveVehicleToolStripMenuItem.Click += new System.EventHandler(this.receiveVehicleToolStripMenuItem_Click);
            // 
            // removeVehicleToolStripMenuItem
            // 
            this.removeVehicleToolStripMenuItem.Name = "removeVehicleToolStripMenuItem";
            this.removeVehicleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.removeVehicleToolStripMenuItem.Text = "Update/Remove Vehicle";
            // 
            // garageToolStripMenuItem
            // 
            this.garageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSlotToolStripMenuItem});
            this.garageToolStripMenuItem.Name = "garageToolStripMenuItem";
            this.garageToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.garageToolStripMenuItem.Text = "Garage";
            // 
            // updateSlotToolStripMenuItem
            // 
            this.updateSlotToolStripMenuItem.Name = "updateSlotToolStripMenuItem";
            this.updateSlotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateSlotToolStripMenuItem.Text = "Update Slot";
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.statisticToolStripMenuItem.Text = "Statistic";
            // 
            // ManagerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem workToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caringCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentCertificateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
    }
}