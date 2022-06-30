
namespace FInalProject
{
    partial class ResetPassword
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
            this.button_SendOTP = new System.Windows.Forms.Button();
            this.button_ResetPassword = new System.Windows.Forms.Button();
            this.textBox_Password1 = new System.Windows.Forms.TextBox();
            this.textBox_Password2 = new System.Windows.Forms.TextBox();
            this.textBox_OTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_WarningOTP = new System.Windows.Forms.Label();
            this.label_InformOTP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_WarningUser = new System.Windows.Forms.Label();
            this.label_WarningPassword = new System.Windows.Forms.Label();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SendOTP
            // 
            this.button_SendOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SendOTP.Location = new System.Drawing.Point(38, 76);
            this.button_SendOTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_SendOTP.Name = "button_SendOTP";
            this.button_SendOTP.Size = new System.Drawing.Size(86, 29);
            this.button_SendOTP.TabIndex = 0;
            this.button_SendOTP.Text = "Send OTP";
            this.button_SendOTP.UseVisualStyleBackColor = true;
            this.button_SendOTP.Click += new System.EventHandler(this.button_SendOTP_Click);
            // 
            // button_ResetPassword
            // 
            this.button_ResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetPassword.Location = new System.Drawing.Point(37, 129);
            this.button_ResetPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ResetPassword.Name = "button_ResetPassword";
            this.button_ResetPassword.Size = new System.Drawing.Size(104, 29);
            this.button_ResetPassword.TabIndex = 1;
            this.button_ResetPassword.Text = "Redeem OTP";
            this.button_ResetPassword.UseVisualStyleBackColor = true;
            this.button_ResetPassword.Click += new System.EventHandler(this.button_ResetPassword_Click);
            // 
            // textBox_Password1
            // 
            this.textBox_Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password1.Location = new System.Drawing.Point(155, 179);
            this.textBox_Password1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Password1.Name = "textBox_Password1";
            this.textBox_Password1.PasswordChar = '*';
            this.textBox_Password1.ReadOnly = true;
            this.textBox_Password1.Size = new System.Drawing.Size(174, 23);
            this.textBox_Password1.TabIndex = 2;
            this.textBox_Password1.Leave += new System.EventHandler(this.textBox_Password1_Leave);
            // 
            // textBox_Password2
            // 
            this.textBox_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password2.Location = new System.Drawing.Point(155, 216);
            this.textBox_Password2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Password2.Name = "textBox_Password2";
            this.textBox_Password2.PasswordChar = '*';
            this.textBox_Password2.ReadOnly = true;
            this.textBox_Password2.Size = new System.Drawing.Size(174, 23);
            this.textBox_Password2.TabIndex = 3;
            // 
            // textBox_OTP
            // 
            this.textBox_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OTP.Location = new System.Drawing.Point(155, 136);
            this.textBox_OTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_OTP.Name = "textBox_OTP";
            this.textBox_OTP.Size = new System.Drawing.Size(174, 23);
            this.textBox_OTP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "New password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repeat password";
            // 
            // label_WarningOTP
            // 
            this.label_WarningOTP.AutoSize = true;
            this.label_WarningOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningOTP.ForeColor = System.Drawing.Color.Red;
            this.label_WarningOTP.Location = new System.Drawing.Point(340, 139);
            this.label_WarningOTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WarningOTP.Name = "label_WarningOTP";
            this.label_WarningOTP.Size = new System.Drawing.Size(72, 20);
            this.label_WarningOTP.TabIndex = 7;
            this.label_WarningOTP.Text = "Incorrect";
            this.label_WarningOTP.Visible = false;
            // 
            // label_InformOTP
            // 
            this.label_InformOTP.AutoSize = true;
            this.label_InformOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InformOTP.ForeColor = System.Drawing.Color.Yellow;
            this.label_InformOTP.Location = new System.Drawing.Point(155, 82);
            this.label_InformOTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_InformOTP.Name = "label_InformOTP";
            this.label_InformOTP.Size = new System.Drawing.Size(153, 17);
            this.label_InformOTP.TabIndex = 8;
            this.label_InformOTP.Text = "OTP sent to your email";
            this.label_InformOTP.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(38, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "User name";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserName.Location = new System.Drawing.Point(155, 39);
            this.textBox_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(174, 23);
            this.textBox_UserName.TabIndex = 10;
            this.textBox_UserName.Leave += new System.EventHandler(this.textBox_UserName_Leave);
            // 
            // label_WarningUser
            // 
            this.label_WarningUser.AutoSize = true;
            this.label_WarningUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningUser.ForeColor = System.Drawing.Color.Red;
            this.label_WarningUser.Location = new System.Drawing.Point(336, 42);
            this.label_WarningUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WarningUser.Name = "label_WarningUser";
            this.label_WarningUser.Size = new System.Drawing.Size(159, 20);
            this.label_WarningUser.TabIndex = 11;
            this.label_WarningUser.Text = "User name not found";
            this.label_WarningUser.Visible = false;
            // 
            // label_WarningPassword
            // 
            this.label_WarningPassword.AutoSize = true;
            this.label_WarningPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningPassword.ForeColor = System.Drawing.Color.Red;
            this.label_WarningPassword.Location = new System.Drawing.Point(339, 182);
            this.label_WarningPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WarningPassword.Name = "label_WarningPassword";
            this.label_WarningPassword.Size = new System.Drawing.Size(117, 20);
            this.label_WarningPassword.TabIndex = 12;
            this.label_WarningPassword.Text = "Password used";
            this.label_WarningPassword.Visible = false;
            // 
            // button_Confirm
            // 
            this.button_Confirm.BackColor = System.Drawing.Color.Yellow;
            this.button_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirm.Location = new System.Drawing.Point(260, 281);
            this.button_Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(104, 42);
            this.button_Confirm.TabIndex = 14;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = false;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.Red;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(77, 281);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(104, 42);
            this.button_Cancel.TabIndex = 15;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(506, 366);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.label_WarningPassword);
            this.Controls.Add(this.label_WarningUser);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_InformOTP);
            this.Controls.Add(this.label_WarningOTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_OTP);
            this.Controls.Add(this.textBox_Password2);
            this.Controls.Add(this.textBox_Password1);
            this.Controls.Add(this.button_ResetPassword);
            this.Controls.Add(this.button_SendOTP);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.ReserPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SendOTP;
        private System.Windows.Forms.Button button_ResetPassword;
        private System.Windows.Forms.TextBox textBox_Password1;
        private System.Windows.Forms.TextBox textBox_Password2;
        private System.Windows.Forms.TextBox textBox_OTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_WarningOTP;
        private System.Windows.Forms.Label label_InformOTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_WarningUser;
        private System.Windows.Forms.Label label_WarningPassword;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.Button button_Cancel;
    }
}