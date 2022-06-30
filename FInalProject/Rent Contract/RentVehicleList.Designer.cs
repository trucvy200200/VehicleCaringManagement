namespace FInalProject
{
    partial class RentVehicleList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonMoto = new System.Windows.Forms.RadioButton();
            this.radioButtonBike = new System.Windows.Forms.RadioButton();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.Size = new System.Drawing.Size(875, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumber.Location = new System.Drawing.Point(534, 50);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(202, 29);
            this.textBoxNumber.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.radioButtonAll);
            this.panel1.Controls.Add(this.radioButtonMoto);
            this.panel1.Controls.Add(this.radioButtonBike);
            this.panel1.Controls.Add(this.radioButtonCar);
            this.panel1.ForeColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(67, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 100);
            this.panel1.TabIndex = 2;
            // 
            // radioButtonMoto
            // 
            this.radioButtonMoto.AutoSize = true;
            this.radioButtonMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMoto.Location = new System.Drawing.Point(138, 24);
            this.radioButtonMoto.Name = "radioButtonMoto";
            this.radioButtonMoto.Size = new System.Drawing.Size(63, 24);
            this.radioButtonMoto.TabIndex = 2;
            this.radioButtonMoto.TabStop = true;
            this.radioButtonMoto.Text = "Moto";
            this.radioButtonMoto.UseVisualStyleBackColor = true;
            // 
            // radioButtonBike
            // 
            this.radioButtonBike.AutoSize = true;
            this.radioButtonBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBike.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonBike.Location = new System.Drawing.Point(77, 24);
            this.radioButtonBike.Name = "radioButtonBike";
            this.radioButtonBike.Size = new System.Drawing.Size(58, 24);
            this.radioButtonBike.TabIndex = 1;
            this.radioButtonBike.TabStop = true;
            this.radioButtonBike.Text = "Bike";
            this.radioButtonBike.UseVisualStyleBackColor = true;
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonCar.Location = new System.Drawing.Point(12, 24);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(52, 24);
            this.radioButtonCar.TabIndex = 0;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(380, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehicle Number";
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Orange;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(757, 48);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(93, 33);
            this.btn_Check.TabIndex = 6;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonAll.Location = new System.Drawing.Point(79, 68);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(44, 24);
            this.radioButtonAll.TabIndex = 3;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // RentVehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(892, 580);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RentVehicleList";
            this.Text = "RentVehicleList";
            this.Load += new System.EventHandler(this.RentVehicleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonMoto;
        private System.Windows.Forms.RadioButton radioButtonBike;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.RadioButton radioButtonAll;
    }
}