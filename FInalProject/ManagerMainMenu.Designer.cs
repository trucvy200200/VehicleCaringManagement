
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caringCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCertificateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customersSupplyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkContractStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endSupplyContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.endContractToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rentVehicleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificateListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleToolStripMenuItem,
            this.garageToolStripMenuItem,
            this.workToolStripMenuItem,
            this.certificateToolStripMenuItem,
            this.revenueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(574, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiveVehicleToolStripMenuItem,
            this.returnVehicleToolStripMenuItem,
            this.statisticToolStripMenuItem,
            this.vehicleListToolStripMenuItem});
            this.vehicleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.vehicleToolStripMenuItem.Text = "VEHICLE";
            // 
            // receiveVehicleToolStripMenuItem
            // 
            this.receiveVehicleToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.receiveVehicleToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.receiveVehicleToolStripMenuItem.Name = "receiveVehicleToolStripMenuItem";
            this.receiveVehicleToolStripMenuItem.Size = new System.Drawing.Size(399, 32);
            this.receiveVehicleToolStripMenuItem.Text = "Receive Vehicle";
            this.receiveVehicleToolStripMenuItem.Click += new System.EventHandler(this.receiveVehicleToolStripMenuItem_Click);
            // 
            // returnVehicleToolStripMenuItem
            // 
            this.returnVehicleToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.returnVehicleToolStripMenuItem.Name = "returnVehicleToolStripMenuItem";
            this.returnVehicleToolStripMenuItem.Size = new System.Drawing.Size(399, 32);
            this.returnVehicleToolStripMenuItem.Text = "Return Vehicle/Calculate Parking Fee";
            this.returnVehicleToolStripMenuItem.Click += new System.EventHandler(this.returnVehicleToolStripMenuItem_Click);
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.statisticToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(399, 32);
            this.statisticToolStripMenuItem.Text = "Statistic";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // vehicleListToolStripMenuItem
            // 
            this.vehicleListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vehicleListToolStripMenuItem.Name = "vehicleListToolStripMenuItem";
            this.vehicleListToolStripMenuItem.Size = new System.Drawing.Size(399, 32);
            this.vehicleListToolStripMenuItem.Text = "Vehicle List";
            this.vehicleListToolStripMenuItem.Click += new System.EventHandler(this.vehicleListToolStripMenuItem_Click);
            // 
            // garageToolStripMenuItem
            // 
            this.garageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSlotToolStripMenuItem});
            this.garageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garageToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.garageToolStripMenuItem.Name = "garageToolStripMenuItem";
            this.garageToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.garageToolStripMenuItem.Text = "GARAGE";
            // 
            // updateSlotToolStripMenuItem
            // 
            this.updateSlotToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.updateSlotToolStripMenuItem.Name = "updateSlotToolStripMenuItem";
            this.updateSlotToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.updateSlotToolStripMenuItem.Text = "Capacity information";
            this.updateSlotToolStripMenuItem.Click += new System.EventHandler(this.updateSlotToolStripMenuItem_Click);
            // 
            // workToolStripMenuItem
            // 
            this.workToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWorkToolStripMenuItem,
            this.deleteWorkToolStripMenuItem,
            this.updateWorkToolStripMenuItem,
            this.workListToolStripMenuItem});
            this.workToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.workToolStripMenuItem.Name = "workToolStripMenuItem";
            this.workToolStripMenuItem.Size = new System.Drawing.Size(82, 32);
            this.workToolStripMenuItem.Text = "WORK";
            // 
            // addWorkToolStripMenuItem
            // 
            this.addWorkToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addWorkToolStripMenuItem.Name = "addWorkToolStripMenuItem";
            this.addWorkToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.addWorkToolStripMenuItem.Text = "Add  work";
            this.addWorkToolStripMenuItem.Click += new System.EventHandler(this.addWorkToolStripMenuItem_Click);
            // 
            // deleteWorkToolStripMenuItem
            // 
            this.deleteWorkToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.deleteWorkToolStripMenuItem.Name = "deleteWorkToolStripMenuItem";
            this.deleteWorkToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.deleteWorkToolStripMenuItem.Text = "Remove work";
            this.deleteWorkToolStripMenuItem.Click += new System.EventHandler(this.deleteWorkToolStripMenuItem_Click);
            // 
            // updateWorkToolStripMenuItem
            // 
            this.updateWorkToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.updateWorkToolStripMenuItem.Name = "updateWorkToolStripMenuItem";
            this.updateWorkToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.updateWorkToolStripMenuItem.Text = "Update work";
            this.updateWorkToolStripMenuItem.Click += new System.EventHandler(this.updateWorkToolStripMenuItem_Click);
            // 
            // workListToolStripMenuItem
            // 
            this.workListToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine;
            this.workListToolStripMenuItem.Name = "workListToolStripMenuItem";
            this.workListToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.workListToolStripMenuItem.Text = "Manage Work Form";
            this.workListToolStripMenuItem.Click += new System.EventHandler(this.workListToolStripMenuItem_Click);
            // 
            // certificateToolStripMenuItem
            // 
            this.certificateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentCertificateToolStripMenuItem,
            this.caringCertificateToolStripMenuItem,
            this.rentCertificateToolStripMenuItem1});
            this.certificateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certificateToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.certificateToolStripMenuItem.Name = "certificateToolStripMenuItem";
            this.certificateToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.certificateToolStripMenuItem.Text = "CONTRACT";
            // 
            // rentCertificateToolStripMenuItem
            // 
            this.rentCertificateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rentCertificateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.updateDetailToolStripMenuItem});
            this.rentCertificateToolStripMenuItem.Name = "rentCertificateToolStripMenuItem";
            this.rentCertificateToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.rentCertificateToolStripMenuItem.Text = "Caring Contract Detail";
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(177, 32);
            this.addNewToolStripMenuItem1.Text = "Add Detail";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // updateDetailToolStripMenuItem
            // 
            this.updateDetailToolStripMenuItem.Name = "updateDetailToolStripMenuItem";
            this.updateDetailToolStripMenuItem.Size = new System.Drawing.Size(177, 32);
            this.updateDetailToolStripMenuItem.Text = "Remove";
            this.updateDetailToolStripMenuItem.Click += new System.EventHandler(this.updateDetailToolStripMenuItem_Click);
            // 
            // caringCertificateToolStripMenuItem
            // 
            this.caringCertificateToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.caringCertificateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.caringCertificateToolStripMenuItem.Name = "caringCertificateToolStripMenuItem";
            this.caringCertificateToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.caringCertificateToolStripMenuItem.Text = "Caring Contract";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.listToolStripMenuItem.Text = "Caring Contract List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.removeToolStripMenuItem.Text = "Remove/Update";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // rentCertificateToolStripMenuItem1
            // 
            this.rentCertificateToolStripMenuItem1.BackColor = System.Drawing.Color.Yellow;
            this.rentCertificateToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersSupplyToolStripMenuItem1,
            this.customersRentToolStripMenuItem,
            this.rentVehicleListToolStripMenuItem,
            this.certificateListToolStripMenuItem});
            this.rentCertificateToolStripMenuItem1.Name = "rentCertificateToolStripMenuItem1";
            this.rentCertificateToolStripMenuItem1.Size = new System.Drawing.Size(277, 32);
            this.rentCertificateToolStripMenuItem1.Text = "Rent Contract";
            // 
            // customersSupplyToolStripMenuItem1
            // 
            this.customersSupplyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.checkContractStatusToolStripMenuItem,
            this.endSupplyContractToolStripMenuItem});
            this.customersSupplyToolStripMenuItem1.Name = "customersSupplyToolStripMenuItem1";
            this.customersSupplyToolStripMenuItem1.Size = new System.Drawing.Size(247, 32);
            this.customersSupplyToolStripMenuItem1.Text = "Customer\'s Supply";
            this.customersSupplyToolStripMenuItem1.Click += new System.EventHandler(this.customersSupplyToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(272, 32);
            this.addToolStripMenuItem2.Text = "Supply Form";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // checkContractStatusToolStripMenuItem
            // 
            this.checkContractStatusToolStripMenuItem.Name = "checkContractStatusToolStripMenuItem";
            this.checkContractStatusToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.checkContractStatusToolStripMenuItem.Text = "Check Contract status";
            this.checkContractStatusToolStripMenuItem.Click += new System.EventHandler(this.checkCertificateStatusToolStripMenuItem_Click);
            // 
            // endSupplyContractToolStripMenuItem
            // 
            this.endSupplyContractToolStripMenuItem.Name = "endSupplyContractToolStripMenuItem";
            this.endSupplyContractToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.endSupplyContractToolStripMenuItem.Text = "End Supply Contract";
            this.endSupplyContractToolStripMenuItem.Click += new System.EventHandler(this.endSupplyContractToolStripMenuItem_Click);
            // 
            // customersRentToolStripMenuItem
            // 
            this.customersRentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.endContractToolStripMenuItem1});
            this.customersRentToolStripMenuItem.Name = "customersRentToolStripMenuItem";
            this.customersRentToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.customersRentToolStripMenuItem.Text = "Customer\'s Rent";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(241, 32);
            this.addToolStripMenuItem1.Text = "Rent Form";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // endContractToolStripMenuItem1
            // 
            this.endContractToolStripMenuItem1.Name = "endContractToolStripMenuItem1";
            this.endContractToolStripMenuItem1.Size = new System.Drawing.Size(241, 32);
            this.endContractToolStripMenuItem1.Text = "End Rent Contract";
            this.endContractToolStripMenuItem1.Click += new System.EventHandler(this.endContractToolStripMenuItem1_Click);
            // 
            // rentVehicleListToolStripMenuItem
            // 
            this.rentVehicleListToolStripMenuItem.Name = "rentVehicleListToolStripMenuItem";
            this.rentVehicleListToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.rentVehicleListToolStripMenuItem.Text = "Rent Vehicle List";
            this.rentVehicleListToolStripMenuItem.Click += new System.EventHandler(this.rentVehicleListToolStripMenuItem_Click);
            // 
            // certificateListToolStripMenuItem
            // 
            this.certificateListToolStripMenuItem.Name = "certificateListToolStripMenuItem";
            this.certificateListToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.certificateListToolStripMenuItem.Text = "Contract List";
            this.certificateListToolStripMenuItem.Click += new System.EventHandler(this.certificateListToolStripMenuItem_Click);
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(107, 32);
            this.revenueToolStripMenuItem.Text = "REVENUE";
            this.revenueToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 68);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Location = new System.Drawing.Point(69, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 34);
            this.panel1.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(3, 8);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(65, 18);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Welcome";
            // 
            // ManagerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerMainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.ManagerMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem garageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentVehicleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersSupplyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem customersRentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkContractStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endContractToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem certificateListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endSupplyContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnVehicleToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_name;
    }
}