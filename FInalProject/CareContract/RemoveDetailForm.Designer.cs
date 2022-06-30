namespace FInalProject
{
    partial class RemoveDetailForm
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
            this.btn_RemoveService = new System.Windows.Forms.Button();
            this.DataGridViewService = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewService)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RemoveService
            // 
            this.btn_RemoveService.BackColor = System.Drawing.Color.Yellow;
            this.btn_RemoveService.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveService.Location = new System.Drawing.Point(47, 382);
            this.btn_RemoveService.Name = "btn_RemoveService";
            this.btn_RemoveService.Size = new System.Drawing.Size(182, 42);
            this.btn_RemoveService.TabIndex = 3;
            this.btn_RemoveService.Text = "Remove Service";
            this.btn_RemoveService.UseVisualStyleBackColor = false;
            this.btn_RemoveService.Click += new System.EventHandler(this.btn_RemoveService_Click);
            // 
            // DataGridViewService
            // 
            this.DataGridViewService.AllowUserToResizeColumns = false;
            this.DataGridViewService.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewService.Location = new System.Drawing.Point(47, 27);
            this.DataGridViewService.Name = "DataGridViewService";
            this.DataGridViewService.Size = new System.Drawing.Size(707, 333);
            this.DataGridViewService.TabIndex = 2;
            // 
            // RemoveDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_RemoveService);
            this.Controls.Add(this.DataGridViewService);
            this.Name = "RemoveDetailForm";
            this.Text = "RemoveDetailForm";
            this.Load += new System.EventHandler(this.RemoveDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RemoveService;
        private System.Windows.Forms.DataGridView DataGridViewService;
    }
}