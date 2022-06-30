namespace FInalProject
{
    partial class VehicleList
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonMoto = new System.Windows.Forms.RadioButton();
            this.radioButtonBike = new System.Windows.Forms.RadioButton();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.btn_Check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(395, 580);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(279, 44);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add New Vehicle";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.radioButtonAll);
            this.panel1.Controls.Add(this.radioButtonMoto);
            this.panel1.Controls.Add(this.radioButtonBike);
            this.panel1.Controls.Add(this.radioButtonCar);
            this.panel1.ForeColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(64, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 123);
            this.panel1.TabIndex = 3;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonAll.Location = new System.Drawing.Point(105, 84);
            this.radioButtonAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(55, 29);
            this.radioButtonAll.TabIndex = 3;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoto
            // 
            this.radioButtonMoto.AutoSize = true;
            this.radioButtonMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMoto.Location = new System.Drawing.Point(184, 30);
            this.radioButtonMoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMoto.Name = "radioButtonMoto";
            this.radioButtonMoto.Size = new System.Drawing.Size(77, 29);
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
            this.radioButtonBike.Location = new System.Drawing.Point(103, 30);
            this.radioButtonBike.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonBike.Name = "radioButtonBike";
            this.radioButtonBike.Size = new System.Drawing.Size(71, 29);
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
            this.radioButtonCar.Location = new System.Drawing.Point(16, 30);
            this.radioButtonCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(65, 29);
            this.radioButtonCar.TabIndex = 0;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Orange;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(904, 65);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(124, 41);
            this.btn_Check.TabIndex = 9;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(401, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vehicle Number";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumber.Location = new System.Drawing.Point(607, 68);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(268, 34);
            this.textBoxNumber.TabIndex = 7;
            // 
            // VehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 639);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VehicleList";
            this.Text = "VehicleList";
            this.Load += new System.EventHandler(this.VehicleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonMoto;
        private System.Windows.Forms.RadioButton radioButtonBike;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
    }
}