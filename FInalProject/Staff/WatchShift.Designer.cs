
namespace FInalProject
{
    partial class WatchShift
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
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalProjectDataSet1 = new FInalProject.FinalProjectDataSet1();
            this.button_Request = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.shiftTableAdapter = new FInalProject.FinalProjectDataSet1TableAdapters.ShiftTableAdapter();
            this.finalProjectDataSet2 = new FInalProject.FinalProjectDataSet2();
            this.shiftBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shiftTableAdapter1 = new FInalProject.FinalProjectDataSet2TableAdapters.ShiftTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource1)).BeginInit();
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
            this.dataGridView1.DataSource = this.shiftBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 248);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            // shiftBindingSource
            // 
            this.shiftBindingSource.DataMember = "Shift";
            this.shiftBindingSource.DataSource = this.finalProjectDataSet1;
            // 
            // finalProjectDataSet1
            // 
            this.finalProjectDataSet1.DataSetName = "FinalProjectDataSet1";
            this.finalProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_Request
            // 
            this.button_Request.Location = new System.Drawing.Point(13, 340);
            this.button_Request.Name = "button_Request";
            this.button_Request.Size = new System.Drawing.Size(207, 41);
            this.button_Request.TabIndex = 2;
            this.button_Request.Text = "Request change";
            this.button_Request.UseVisualStyleBackColor = true;
            this.button_Request.Click += new System.EventHandler(this.button_Request_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(237, 340);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(154, 41);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // shiftTableAdapter
            // 
            this.shiftTableAdapter.ClearBeforeFill = true;
            // 
            // finalProjectDataSet2
            // 
            this.finalProjectDataSet2.DataSetName = "FinalProjectDataSet2";
            this.finalProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftBindingSource1
            // 
            this.shiftBindingSource1.DataMember = "Shift";
            this.shiftBindingSource1.DataSource = this.finalProjectDataSet2;
            // 
            // shiftTableAdapter1
            // 
            this.shiftTableAdapter1.ClearBeforeFill = true;
            // 
            // WatchShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1168, 451);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Request);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WatchShift";
            this.Text = "WatchShift";
            this.Load += new System.EventHandler(this.WatchShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Request;
        private System.Windows.Forms.Button button_Refresh;
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
        private FinalProjectDataSet2 finalProjectDataSet2;
        private System.Windows.Forms.BindingSource shiftBindingSource1;
        private FinalProjectDataSet2TableAdapters.ShiftTableAdapter shiftTableAdapter1;
    }
}