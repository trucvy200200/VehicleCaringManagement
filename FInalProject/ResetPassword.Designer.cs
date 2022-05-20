
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
            this.button_SendOTP.Location = new System.Drawing.Point(50, 93);
            this.button_SendOTP.Name = "button_SendOTP";
            this.button_SendOTP.Size = new System.Drawing.Size(115, 36);
            this.button_SendOTP.TabIndex = 0;
            this.button_SendOTP.Text = "Send OTP";
            this.button_SendOTP.UseVisualStyleBackColor = true;
            this.button_SendOTP.Click += new System.EventHandler(this.button_SendOTP_Click);
            // 
            // button_ResetPassword
            // 
            this.button_ResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetPassword.Location = new System.Drawing.Point(50, 158);
            this.button_ResetPassword.Name = "button_ResetPassword";
            this.button_ResetPassword.Size = new System.Drawing.Size(139, 36);
            this.button_ResetPassword.TabIndex = 1;
            this.button_ResetPassword.Text = "Redeem OTP";
            this.button_ResetPassword.UseVisualStyleBackColor = true;
            this.button_ResetPassword.Click += new System.EventHandler(this.button_ResetPassword_Click);
            // 
            // textBox_Password1
            // 
            this.textBox_Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password1.Location = new System.Drawing.Point(207, 220);
            this.textBox_Password1.Name = "textBox_Password1";
            this.textBox_Password1.PasswordChar = '*';
            this.textBox_Password1.ReadOnly = true;
            this.textBox_Password1.Size = new System.Drawing.Size(182, 26);
            this.textBox_Password1.TabIndex = 2;
            this.textBox_Password1.Leave += new System.EventHandler(this.textBox_Password1_Leave);
            // 
            // textBox_Password2
            // 
            this.textBox_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password2.Location = new System.Drawing.Point(207, 266);
            this.textBox_Password2.Name = "textBox_Password2";
            this.textBox_Password2.PasswordChar = '*';
            this.textBox_Password2.ReadOnly = true;
            this.textBox_Password2.Size = new System.Drawing.Size(182, 26);
            this.textBox_Password2.TabIndex = 3;
            // 
            // textBox_OTP
            // 
            this.textBox_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OTP.Location = new System.Drawing.Point(207, 168);
            this.textBox_OTP.Name = "textBox_OTP";
            this.textBox_OTP.Size = new System.Drawing.Size(182, 26);
            this.textBox_OTP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "New password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repeat password";
            // 
            // label_WarningOTP
            // 
            this.label_WarningOTP.AutoSize = true;
            this.label_WarningOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningOTP.ForeColor = System.Drawing.Color.Red;
            this.label_WarningOTP.Location = new System.Drawing.Point(412, 174);
            this.label_WarningOTP.Name = "label_WarningOTP";
            this.label_WarningOTP.Size = new System.Drawing.Size(75, 20);
            this.label_WarningOTP.TabIndex = 7;
            this.label_WarningOTP.Text = "Incorrect";
            this.label_WarningOTP.Visible = false;
            // 
            // label_InformOTP
            // 
            this.label_InformOTP.AutoSize = true;
            this.label_InformOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InformOTP.ForeColor = System.Drawing.Color.Blue;
            this.label_InformOTP.Location = new System.Drawing.Point(174, 101);
            this.label_InformOTP.Name = "label_InformOTP";
            this.label_InformOTP.Size = new System.Drawing.Size(181, 20);
            this.label_InformOTP.TabIndex = 8;
            this.label_InformOTP.Text = "OTP sent to your email";
            this.label_InformOTP.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(46, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "User name";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserName.Location = new System.Drawing.Point(158, 46);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(231, 26);
            this.textBox_UserName.TabIndex = 10;
            this.textBox_UserName.Leave += new System.EventHandler(this.textBox_UserName_Leave);
            // 
            // label_WarningUser
            // 
            this.label_WarningUser.AutoSize = true;
            this.label_WarningUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningUser.ForeColor = System.Drawing.Color.Red;
            this.label_WarningUser.Location = new System.Drawing.Point(412, 52);
            this.label_WarningUser.Name = "label_WarningUser";
            this.label_WarningUser.Size = new System.Drawing.Size(165, 20);
            this.label_WarningUser.TabIndex = 11;
            this.label_WarningUser.Text = "User name not found";
            this.label_WarningUser.Visible = false;
            // 
            // label_WarningPassword
            // 
            this.label_WarningPassword.AutoSize = true;
            this.label_WarningPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WarningPassword.ForeColor = System.Drawing.Color.Red;
            this.label_WarningPassword.Location = new System.Drawing.Point(412, 226);
            this.label_WarningPassword.Name = "label_WarningPassword";
            this.label_WarningPassword.Size = new System.Drawing.Size(124, 20);
            this.label_WarningPassword.TabIndex = 12;
            this.label_WarningPassword.Text = "Password used";
            this.label_WarningPassword.Visible = false;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirm.Location = new System.Drawing.Point(315, 328);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(139, 36);
            this.button_Confirm.TabIndex = 14;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(109, 328);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(139, 36);
            this.button_Cancel.TabIndex = 15;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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