
namespace FInalProject
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.linkLabel_ResetPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwod:";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserName.Location = new System.Drawing.Point(229, 79);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(249, 34);
            this.textBox_UserName.TabIndex = 0;
            this.textBox_UserName.TextChanged += new System.EventHandler(this.textBox_UserName_TextChanged);
            this.textBox_UserName.Leave += new System.EventHandler(this.textBox_UserName_Leave);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(229, 130);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(249, 34);
            this.textBox_Password.TabIndex = 1;
            // 
            // button_LogIn
            // 
            this.button_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogIn.Location = new System.Drawing.Point(160, 276);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(116, 41);
            this.button_LogIn.TabIndex = 2;
            this.button_LogIn.Text = "Log in";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // linkLabel_ResetPassword
            // 
            this.linkLabel_ResetPassword.AutoSize = true;
            this.linkLabel_ResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_ResetPassword.Location = new System.Drawing.Point(89, 206);
            this.linkLabel_ResetPassword.Name = "linkLabel_ResetPassword";
            this.linkLabel_ResetPassword.Size = new System.Drawing.Size(130, 20);
            this.linkLabel_ResetPassword.TabIndex = 5;
            this.linkLabel_ResetPassword.TabStop = true;
            this.linkLabel_ResetPassword.Text = "Reset password";
            this.linkLabel_ResetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ResetPassword_LinkClicked);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 368);
            this.Controls.Add(this.linkLabel_ResetPassword);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.LinkLabel linkLabel_ResetPassword;
    }
}

