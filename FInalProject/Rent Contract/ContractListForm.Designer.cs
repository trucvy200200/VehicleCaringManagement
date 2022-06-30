namespace FInalProject
{
    partial class ContractListForm
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
            this.radioButtonRent = new System.Windows.Forms.RadioButton();
            this.radioButtonSupply = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonValidated = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonOut = new System.Windows.Forms.RadioButton();
            this.btn_Check = new System.Windows.Forms.Button();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonRent
            // 
            this.radioButtonRent.AutoSize = true;
            this.radioButtonRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonRent.Location = new System.Drawing.Point(99, 20);
            this.radioButtonRent.Name = "radioButtonRent";
            this.radioButtonRent.Size = new System.Drawing.Size(62, 24);
            this.radioButtonRent.TabIndex = 0;
            this.radioButtonRent.TabStop = true;
            this.radioButtonRent.Text = "Rent";
            this.radioButtonRent.UseVisualStyleBackColor = true;
            // 
            // radioButtonSupply
            // 
            this.radioButtonSupply.AutoSize = true;
            this.radioButtonSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSupply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonSupply.Location = new System.Drawing.Point(99, 60);
            this.radioButtonSupply.Name = "radioButtonSupply";
            this.radioButtonSupply.Size = new System.Drawing.Size(75, 24);
            this.radioButtonSupply.TabIndex = 1;
            this.radioButtonSupply.TabStop = true;
            this.radioButtonSupply.Text = "Supply";
            this.radioButtonSupply.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(927, 321);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(404, 464);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(136, 32);
            this.btn_Print.TabIndex = 4;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonRent);
            this.panel1.Controls.Add(this.radioButtonSupply);
            this.panel1.Location = new System.Drawing.Point(47, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(542, 56);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(210, 20);
            this.textBoxID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(594, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contract ID";
            // 
            // radioButtonValidated
            // 
            this.radioButtonValidated.AutoSize = true;
            this.radioButtonValidated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonValidated.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonValidated.Location = new System.Drawing.Point(355, 13);
            this.radioButtonValidated.Name = "radioButtonValidated";
            this.radioButtonValidated.Size = new System.Drawing.Size(94, 24);
            this.radioButtonValidated.TabIndex = 3;
            this.radioButtonValidated.TabStop = true;
            this.radioButtonValidated.Text = "Validated";
            this.radioButtonValidated.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(265, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duration:";
            // 
            // radioButtonOut
            // 
            this.radioButtonOut.AutoSize = true;
            this.radioButtonOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonOut.Location = new System.Drawing.Point(355, 52);
            this.radioButtonOut.Name = "radioButtonOut";
            this.radioButtonOut.Size = new System.Drawing.Size(107, 24);
            this.radioButtonOut.TabIndex = 8;
            this.radioButtonOut.TabStop = true;
            this.radioButtonOut.Text = "Out of date";
            this.radioButtonOut.UseVisualStyleBackColor = true;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Orange;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(804, 46);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(93, 33);
            this.btn_Check.TabIndex = 9;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonNone.Location = new System.Drawing.Point(355, 89);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(65, 24);
            this.radioButtonNone.TabIndex = 10;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // ContractListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(951, 508);
            this.Controls.Add(this.radioButtonNone);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.radioButtonOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonValidated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ContractListForm";
            this.Text = "ContractListForm";
            this.Load += new System.EventHandler(this.ContractListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRent;
        private System.Windows.Forms.RadioButton radioButtonSupply;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonValidated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonOut;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.RadioButton radioButtonNone;
    }
}