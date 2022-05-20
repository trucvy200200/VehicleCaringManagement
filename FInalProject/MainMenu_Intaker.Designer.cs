
namespace FInalProject
{
    partial class MainMenu_Intaker
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_Vehicle = new System.Windows.Forms.PictureBox();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.button_Vehicle = new System.Windows.Forms.Button();
            this.button_Driver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_Moto = new System.Windows.Forms.RadioButton();
            this.radioButton_Car = new System.Windows.Forms.RadioButton();
            this.radioButton_Bike = new System.Windows.Forms.RadioButton();
            this.pictureBox_Driver = new System.Windows.Forms.PictureBox();
            this.button_Approve = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_Long = new System.Windows.Forms.RadioButton();
            this.radioButton_Short = new System.Windows.Forms.RadioButton();
            this.numericUpDown_Time = new System.Windows.Forms.NumericUpDown();
            this.label_Time = new System.Windows.Forms.Label();
            this.dateTimePicker_Time = new System.Windows.Forms.DateTimePicker();
            this.label_Now = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Test = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Vehicle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Driver)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // pictureBox_Vehicle
            // 
            this.pictureBox_Vehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Vehicle.Location = new System.Drawing.Point(12, 40);
            this.pictureBox_Vehicle.Name = "pictureBox_Vehicle";
            this.pictureBox_Vehicle.Size = new System.Drawing.Size(308, 263);
            this.pictureBox_Vehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Vehicle.TabIndex = 1;
            this.pictureBox_Vehicle.TabStop = false;
            // 
            // textBox_Number
            // 
            this.textBox_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Number.Location = new System.Drawing.Point(12, 322);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(308, 34);
            this.textBox_Number.TabIndex = 2;
            // 
            // button_Vehicle
            // 
            this.button_Vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Vehicle.Location = new System.Drawing.Point(657, 40);
            this.button_Vehicle.Name = "button_Vehicle";
            this.button_Vehicle.Size = new System.Drawing.Size(225, 43);
            this.button_Vehicle.TabIndex = 3;
            this.button_Vehicle.Text = "Load vehicle";
            this.button_Vehicle.UseVisualStyleBackColor = true;
            this.button_Vehicle.Click += new System.EventHandler(this.button_Vehicle_Click);
            // 
            // button_Driver
            // 
            this.button_Driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Driver.Location = new System.Drawing.Point(657, 89);
            this.button_Driver.Name = "button_Driver";
            this.button_Driver.Size = new System.Drawing.Size(225, 43);
            this.button_Driver.TabIndex = 4;
            this.button_Driver.Text = "Load driver";
            this.button_Driver.UseVisualStyleBackColor = true;
            this.button_Driver.Click += new System.EventHandler(this.button_Driver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_Moto);
            this.panel1.Controls.Add(this.radioButton_Car);
            this.panel1.Controls.Add(this.radioButton_Bike);
            this.panel1.Location = new System.Drawing.Point(657, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 108);
            this.panel1.TabIndex = 5;
            // 
            // radioButton_Moto
            // 
            this.radioButton_Moto.AutoSize = true;
            this.radioButton_Moto.Checked = true;
            this.radioButton_Moto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Moto.Location = new System.Drawing.Point(3, 38);
            this.radioButton_Moto.Name = "radioButton_Moto";
            this.radioButton_Moto.Size = new System.Drawing.Size(113, 29);
            this.radioButton_Moto.TabIndex = 2;
            this.radioButton_Moto.TabStop = true;
            this.radioButton_Moto.Text = "Motobike";
            this.radioButton_Moto.UseVisualStyleBackColor = true;
            this.radioButton_Moto.CheckedChanged += new System.EventHandler(this.radioButton_Moto_CheckedChanged);
            // 
            // radioButton_Car
            // 
            this.radioButton_Car.AutoSize = true;
            this.radioButton_Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Car.Location = new System.Drawing.Point(3, 73);
            this.radioButton_Car.Name = "radioButton_Car";
            this.radioButton_Car.Size = new System.Drawing.Size(65, 29);
            this.radioButton_Car.TabIndex = 1;
            this.radioButton_Car.Text = "Car";
            this.radioButton_Car.UseVisualStyleBackColor = true;
            this.radioButton_Car.CheckedChanged += new System.EventHandler(this.radioButton_Car_CheckedChanged);
            // 
            // radioButton_Bike
            // 
            this.radioButton_Bike.AutoSize = true;
            this.radioButton_Bike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Bike.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Bike.Name = "radioButton_Bike";
            this.radioButton_Bike.Size = new System.Drawing.Size(71, 29);
            this.radioButton_Bike.TabIndex = 0;
            this.radioButton_Bike.Text = "Bike";
            this.radioButton_Bike.UseVisualStyleBackColor = true;
            this.radioButton_Bike.CheckedChanged += new System.EventHandler(this.radioButton_Bike_CheckedChanged);
            // 
            // pictureBox_Driver
            // 
            this.pictureBox_Driver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Driver.Location = new System.Drawing.Point(343, 40);
            this.pictureBox_Driver.Name = "pictureBox_Driver";
            this.pictureBox_Driver.Size = new System.Drawing.Size(308, 263);
            this.pictureBox_Driver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Driver.TabIndex = 6;
            this.pictureBox_Driver.TabStop = false;
            // 
            // button_Approve
            // 
            this.button_Approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Approve.Location = new System.Drawing.Point(704, 309);
            this.button_Approve.Name = "button_Approve";
            this.button_Approve.Size = new System.Drawing.Size(138, 43);
            this.button_Approve.TabIndex = 7;
            this.button_Approve.Text = "Approve";
            this.button_Approve.UseVisualStyleBackColor = true;
            this.button_Approve.Click += new System.EventHandler(this.button_Approve_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(657, 138);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(225, 43);
            this.button_Refresh.TabIndex = 8;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton_Long);
            this.panel2.Controls.Add(this.radioButton_Short);
            this.panel2.Location = new System.Drawing.Point(783, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 100);
            this.panel2.TabIndex = 9;
            // 
            // radioButton_Long
            // 
            this.radioButton_Long.AutoSize = true;
            this.radioButton_Long.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Long.Location = new System.Drawing.Point(3, 54);
            this.radioButton_Long.Name = "radioButton_Long";
            this.radioButton_Long.Size = new System.Drawing.Size(120, 29);
            this.radioButton_Long.TabIndex = 12;
            this.radioButton_Long.Text = "Long term";
            this.radioButton_Long.UseVisualStyleBackColor = true;
            this.radioButton_Long.CheckedChanged += new System.EventHandler(this.radioButton_Long_CheckedChanged);
            // 
            // radioButton_Short
            // 
            this.radioButton_Short.AutoSize = true;
            this.radioButton_Short.Checked = true;
            this.radioButton_Short.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Short.Location = new System.Drawing.Point(3, 19);
            this.radioButton_Short.Name = "radioButton_Short";
            this.radioButton_Short.Size = new System.Drawing.Size(123, 29);
            this.radioButton_Short.TabIndex = 11;
            this.radioButton_Short.TabStop = true;
            this.radioButton_Short.Text = "Short term";
            this.radioButton_Short.UseVisualStyleBackColor = true;
            this.radioButton_Short.CheckedChanged += new System.EventHandler(this.radioButton_Short_CheckedChanged);
            // 
            // numericUpDown_Time
            // 
            this.numericUpDown_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Time.Location = new System.Drawing.Point(343, 322);
            this.numericUpDown_Time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Time.Name = "numericUpDown_Time";
            this.numericUpDown_Time.Size = new System.Drawing.Size(308, 34);
            this.numericUpDown_Time.TabIndex = 10;
            this.numericUpDown_Time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Time.ValueChanged += new System.EventHandler(this.numericUpDown_Time_ValueChanged);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(541, 331);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(55, 20);
            this.label_Time.TabIndex = 11;
            this.label_Time.Text = "Hours";
            // 
            // dateTimePicker_Time
            // 
            this.dateTimePicker_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Time.Location = new System.Drawing.Point(343, 372);
            this.dateTimePicker_Time.Name = "dateTimePicker_Time";
            this.dateTimePicker_Time.Size = new System.Drawing.Size(308, 34);
            this.dateTimePicker_Time.TabIndex = 12;
            this.dateTimePicker_Time.ValueChanged += new System.EventHandler(this.dateTimePicker_Time_ValueChanged);
            // 
            // label_Now
            // 
            this.label_Now.AutoSize = true;
            this.label_Now.Location = new System.Drawing.Point(701, 372);
            this.label_Now.Name = "label_Now";
            this.label_Now.Size = new System.Drawing.Size(73, 17);
            this.label_Now.TabIndex = 13;
            this.label_Now.Text = "label_Now";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Test
            // 
            this.label_Test.AutoSize = true;
            this.label_Test.Location = new System.Drawing.Point(549, 446);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(33, 17);
            this.label_Test.TabIndex = 14;
            this.label_Test.Text = "See";
            this.label_Test.Visible = false;
            // 
            // MainMenu_Intaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 497);
            this.Controls.Add(this.label_Test);
            this.Controls.Add(this.label_Now);
            this.Controls.Add(this.dateTimePicker_Time);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.numericUpDown_Time);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Approve);
            this.Controls.Add(this.pictureBox_Driver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Driver);
            this.Controls.Add(this.button_Vehicle);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.pictureBox_Vehicle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu_Intaker";
            this.Tag = "";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainMenu_Intaker_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Vehicle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Driver)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_Vehicle;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Button button_Vehicle;
        private System.Windows.Forms.Button button_Driver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_Moto;
        private System.Windows.Forms.RadioButton radioButton_Car;
        private System.Windows.Forms.RadioButton radioButton_Bike;
        private System.Windows.Forms.PictureBox pictureBox_Driver;
        private System.Windows.Forms.Button button_Approve;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton_Long;
        private System.Windows.Forms.RadioButton radioButton_Short;
        private System.Windows.Forms.NumericUpDown numericUpDown_Time;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Time;
        private System.Windows.Forms.Label label_Now;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Test;
    }
}