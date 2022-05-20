using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace FInalProject
{
    public partial class ResetPassword : Form
    {
        //For sending mail
        //NetworkCredential Login;
        //SmtpClient client;
        //MailMessage mail;
        //For checking with database
        private My_DB db = new My_DB();
        private DataTable table = new DataTable();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private string OTP;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ReserPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_UserName_Leave(object sender, EventArgs e)
        {
            table.Clear();
            cmd = new SqlCommand("SELECT * FROM Login WHERE username = @User", db.getConnection);
            db.openConnection();
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            db.closeConnection();
            textBox_Password1.ReadOnly = true;
            textBox_Password2.ReadOnly = true;
            //if()
        }

        private void button_SendOTP_Click(object sender, EventArgs e)
        {
            //Check if user name is valid
            textBox_Password1.ReadOnly = true;
            textBox_Password2.ReadOnly = true;
            if (textBox_UserName.Text.Trim() == "")
            {
                MessageBox.Show("User name is empty!", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(table.Rows.Count<=0)
            {
                MessageBox.Show("User name not found!", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label_InformOTP.Visible = false;
                return;
            }
            if(textBox_UserName.Text.Trim()=="")
            {
                MessageBox.Show("User name is empty!", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label_InformOTP.Visible = false;
                return;
            }
            //Try to send Email
            try
            {
                //https://www.youtube.com/watch?v=vDxs3NYTvUs&t=1196s
                Random rng = new Random();
                OTP = Convert.ToString(rng.Next(999999));
                MailMessage mail = new MailMessage();
                SmtpClient sever = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("voduchoangphi@gmail.com");
                mail.To.Add(table.Rows[0]["email"].ToString());
                mail.Subject = "Reset password";
                mail.Body = OTP + " is your OTP to reset password";
                sever.Port = 587;
                sever.Credentials = new NetworkCredential("voduchoangphi@gmail.com", "phi09phi09");
                sever.EnableSsl = true;
                sever.Send(mail);
                MessageBox.Show("Success!");
                //Inform
                textBox_UserName.ReadOnly = true;
                textBox_OTP.ReadOnly = false;
                char[] to = table.Rows[0]["email"].ToString().ToCharArray();
                int n = to.Length;
                for(int i=0;i<n;i++)
                {
                    if(to[i]=='@')
                    {
                        int tempn = i - 1;
                        for (int j = 2; j < tempn;j++) to[j] = '*';
                    }
                }
                label_InformOTP.Text = "OTP sent to ";
                for (int i = 0; i < n; i++) label_InformOTP.Text += to[i];
                label_InformOTP.Visible = true;
            }
            catch(Exception loi)
            {
                MessageBox.Show(loi.Message, "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ResetPassword_Click(object sender, EventArgs e)
        {
            if(label_InformOTP.Visible==false)
            {
                MessageBox.Show("No OTP was sent!", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Password1.ReadOnly = true;
                textBox_Password2.ReadOnly = true;
                
                return;
            }
            if(textBox_OTP.Text==OTP)
            {
                textBox_Password1.ReadOnly = false;
                textBox_Password2.ReadOnly = false;
                label_WarningOTP.Visible = false;
                textBox_OTP.ReadOnly = true;
            }
            else
            {
                textBox_Password1.ReadOnly = true;
                textBox_Password2.ReadOnly = true;
                label_WarningOTP.Visible = true;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            //Set read only property
            textBox_Password1.ReadOnly = true;
            textBox_Password2.ReadOnly = true;
            textBox_UserName.ReadOnly = false;
            textBox_OTP.ReadOnly = false;
            //Clear all the texbox
            textBox_Password1.Clear();
            textBox_Password2.Clear();
            textBox_UserName.Clear();
            textBox_OTP.Clear();
            //Hide all the warning/inform
            label_InformOTP.Visible = false;
            label_WarningOTP.Visible = false;
            label_WarningPassword.Visible = false;
            label_WarningUser.Visible = false;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            //Check
            if (label_WarningPassword.Visible == true)
            {
                MessageBox.Show("Password was already used!\nPlease try a new one", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(textBox_Password1.Text!=textBox_Password2.Text)
            {
                MessageBox.Show("Passwords does not match!", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Execute
            My_DB db = new My_DB();
            db.openConnection();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Login SET password = @Pass " +
                " WHERE username = @User", db.getConnection);
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox_Password1.Text;
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
            if(cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Password was reseted", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                Close();
            }
            else
            {
                MessageBox.Show("Unknown error!\nPlease contact to your manager", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
            }
            
        }

        private void textBox_Password1_Leave(object sender, EventArgs e)
        {
            if (textBox_Password1.Text == table.Rows[0]["password"].ToString())
            {
                label_WarningPassword.Visible = true;
            }
            else label_WarningPassword.Visible = false;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MailMessage mail = new MailMessage();
        //    SmtpClient sever = new SmtpClient("smtp.gmail.com");
        //    mail.From = new MailAddress("voduchoangphi@gmail.com");
        //    mail.To.Add(table.Rows[0]["email"].ToString());
        //    mail.Subject = "Reset password";
        //    mail.Body = "Mail test";
        //    sever.Port = 587;
        //    sever.Credentials = new NetworkCredential("voduchoangphi@gmail.com", "phi09phi09");
        //    sever.EnableSsl = true;
        //    sever.Send(mail);
        //    MessageBox.Show("Success!");
        //}
    }
}
