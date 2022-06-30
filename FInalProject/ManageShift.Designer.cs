
namespace FInalProject
{
    partial class ManageShift
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Auto = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Filter = new System.Windows.Forms.Button();
            this.finalProjectDataSet1 = new FInalProject.FinalProjectDataSet1();
            this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftTableAdapter = new FInalProject.FinalProjectDataSet1TableAdapters.ShiftTableAdapter();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shiftDataGridViewTextBoxColumn,
            this.moDataGridViewTextBoxColumn,
            this.tuDataGridViewTextBoxColumn,
            this.weDataGridViewTextBoxColumn,
            this.thDataGridViewTextBoxColumn,
            this.frDataGridViewTextBoxColumn,
            this.saDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shiftBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 162);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button_Auto
            // 
            this.button_Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Auto.Location = new System.Drawing.Point(10, 261);
            this.button_Auto.Margin = new System.Windows.Forms.Padding(2);
            this.button_Auto.Name = "button_Auto";
            this.button_Auto.Size = new System.Drawing.Size(129, 32);
            this.button_Auto.TabIndex = 1;
            this.button_Auto.Text = "Auto arrange";
            this.button_Auto.UseVisualStyleBackColor = true;
            this.button_Auto.Click += new System.EventHandler(this.button_Auto_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(143, 261);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(129, 32);
            this.button_Reset.TabIndex = 2;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 200);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // button_Filter
            // 
            this.button_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Filter.Location = new System.Drawing.Point(143, 200);
            this.button_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(129, 32);
            this.button_Filter.TabIndex = 4;
            this.button_Filter.Text = "Filter";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // finalProjectDataSet1
            // 
            this.finalProjectDataSet1.DataSetName = "FinalProjectDataSet1";
            this.finalProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftBindingSource
            // 
            this.shiftBindingSource.DataMember = "Shift";
            this.shiftBindingSource.DataSource = this.finalProjectDataSet1;
            // 
            // shiftTableAdapter
            // 
            this.shiftTableAdapter.ClearBeforeFill = true;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moDataGridViewTextBoxColumn
            // 
            this.moDataGridViewTextBoxColumn.DataPropertyName = "mo";
            this.moDataGridViewTextBoxColumn.HeaderText = "Monday";
            this.moDataGridViewTextBoxColumn.Name = "moDataGridViewTextBoxColumn";
            this.moDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tuDataGridViewTextBoxColumn
            // 
            this.tuDataGridViewTextBoxColumn.DataPropertyName = "tu";
            this.tuDataGridViewTextBoxColumn.HeaderText = "Tuesday";
            this.tuDataGridViewTextBoxColumn.Name = "tuDataGridViewTextBoxColumn";
            this.tuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weDataGridViewTextBoxColumn
            // 
            this.weDataGridViewTextBoxColumn.DataPropertyName = "we";
            this.weDataGridViewTextBoxColumn.HeaderText = "Wednesday";
            this.weDataGridViewTextBoxColumn.Name = "weDataGridViewTextBoxColumn";
            this.weDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thDataGridViewTextBoxColumn
            // 
            this.thDataGridViewTextBoxColumn.DataPropertyName = "th";
            this.thDataGridViewTextBoxColumn.HeaderText = "Thursday";
            this.thDataGridViewTextBoxColumn.Name = "thDataGridViewTextBoxColumn";
            this.thDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frDataGridViewTextBoxColumn
            // 
            this.frDataGridViewTextBoxColumn.DataPropertyName = "fr";
            this.frDataGridViewTextBoxColumn.HeaderText = "Friday";
            this.frDataGridViewTextBoxColumn.Name = "frDataGridViewTextBoxColumn";
            this.frDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saDataGridViewTextBoxColumn
            // 
            this.saDataGridViewTextBoxColumn.DataPropertyName = "sa";
            this.saDataGridViewTextBoxColumn.HeaderText = "Saturday";
            this.saDataGridViewTextBoxColumn.Name = "saDataGridViewTextBoxColumn";
            this.saDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Sunday";
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            this.suDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManageShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Auto);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageShift";
            this.Text = "ManageShift";
            this.Load += new System.EventHandler(this.ManageShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Auto;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Filter;
        private FinalProjectDataSet1 finalProjectDataSet1;
        private System.Windows.Forms.BindingSource shiftBindingSource;
        private FinalProjectDataSet1TableAdapters.ShiftTableAdapter shiftTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
    }
}