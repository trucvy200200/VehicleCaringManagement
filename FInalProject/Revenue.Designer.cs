
namespace FInalProject
{
    partial class Revenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_Revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown_Year = new System.Windows.Forms.NumericUpDown();
            this.button_Show = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.revenueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalProjectDataSet2 = new FInalProject.FinalProjectDataSet2();
            this.revenueTableAdapter1 = new FInalProject.FinalProjectDataSet2TableAdapters.RevenueTableAdapter();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Revenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Revenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Revenue.Legends.Add(legend1);
            this.chart_Revenue.Location = new System.Drawing.Point(9, 10);
            this.chart_Revenue.Margin = new System.Windows.Forms.Padding(2);
            this.chart_Revenue.Name = "chart_Revenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chart_Revenue.Series.Add(series1);
            this.chart_Revenue.Size = new System.Drawing.Size(582, 259);
            this.chart_Revenue.TabIndex = 0;
            this.chart_Revenue.Text = "chart1";
            title1.Name = "Revenue";
            title1.Text = "Revenue";
            this.chart_Revenue.Titles.Add(title1);
            // 
            // numericUpDown_Year
            // 
            this.numericUpDown_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Year.Location = new System.Drawing.Point(9, 274);
            this.numericUpDown_Year.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDown_Year.Minimum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDown_Year.Name = "numericUpDown_Year";
            this.numericUpDown_Year.Size = new System.Drawing.Size(90, 29);
            this.numericUpDown_Year.TabIndex = 1;
            this.numericUpDown_Year.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // button_Show
            // 
            this.button_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show.Location = new System.Drawing.Point(128, 274);
            this.button_Show.Margin = new System.Windows.Forms.Padding(2);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(85, 28);
            this.button_Show.TabIndex = 2;
            this.button_Show.Text = "Show";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // button_Print
            // 
            this.button_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.Location = new System.Drawing.Point(228, 274);
            this.button_Print.Margin = new System.Windows.Forms.Padding(2);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(85, 28);
            this.button_Print.TabIndex = 3;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moneyDataGridViewTextBoxColumn,
            this.Datee});
            this.dataGridView1.DataSource = this.revenueBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(351, 281);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(238, 122);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // revenueBindingSource1
            // 
            this.revenueBindingSource1.DataMember = "Revenue";
            this.revenueBindingSource1.DataSource = this.finalProjectDataSet2;
            // 
            // finalProjectDataSet2
            // 
            this.finalProjectDataSet2.DataSetName = "FinalProjectDataSet2";
            this.finalProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // revenueTableAdapter1
            // 
            this.revenueTableAdapter1.ClearBeforeFill = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.Width = 125;
            // 
            // Datee
            // 
            this.Datee.DataPropertyName = "Datee";
            this.Datee.HeaderText = "Datee";
            this.Datee.Name = "Datee";
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 414);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.numericUpDown_Year);
            this.Controls.Add(this.chart_Revenue);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Revenue";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.Revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Revenue;
        private System.Windows.Forms.NumericUpDown numericUpDown_Year;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateeDataGridViewTextBoxColumn;
        private FinalProjectDataSet2 finalProjectDataSet2;
        private System.Windows.Forms.BindingSource revenueBindingSource1;
        private FinalProjectDataSet2TableAdapters.RevenueTableAdapter revenueTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datee;
    }
}