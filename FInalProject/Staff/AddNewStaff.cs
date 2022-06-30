using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class AddNewStaff : Form
    {
        My_DB db = new My_DB();
        Staff staff = new Staff();
        SqlDataAdapter adapter;
        DataTable table = new DataTable();

        public AddNewStaff()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            for(int i=0;i<table.Rows.Count;i++)
            {
                if(table.Rows[i]["UserName"].ToString()==textBox_UserName.Text)
                {
                    MessageBox.Show("User name existed!", "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if(textBox_Email1.Text.Trim()==""
                ||textBox_Email2.Text.Trim()==""
                ||textBox_FirstName.Text.Trim()==""
                ||textBox_LastName.Text.Trim()==""
                ||comboBox_Type.Text.Trim()==""
                ||textBox_UserName.Text.Trim()=="")
            {
                MessageBox.Show("Empty fields!", "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!textBox_Email2.Text.Contains("@"))
            {
                MessageBox.Show("Invalid email address!", "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlCommand cmd = new SqlCommand("SELECT MAX(Id) FROM Login", db.getConnection);
            db.openConnection();
            int id = (int)cmd.ExecuteScalar();
            if(staff.AddToDataBase(id + 1, textBox_UserName.Text, "1", textBox_Email1.Text + textBox_Email2.Text,
                comboBox_Type.Text, textBox_FirstName.Text, textBox_LastName.Text))
            {
                //Try to send Email
                try
                {
                    //https://www.youtube.com/watch?v=vDxs3NYTvUs&t=1196s
                    Random rng = new Random();
                    MailMessage mail = new MailMessage();
                    SmtpClient sever = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("voduchoangphi@gmail.com");
                    mail.To.Add(textBox_Email1.Text + textBox_Email2.Text);
                    mail.Subject = "Add new staff";
                    mail.Body = "Welcom to our company " + textBox_FirstName.Text + " " + textBox_LastName.Text +
                        "\nYour user name is " + textBox_UserName.Text + " Your password is 1, please change your password ASAP";
                    sever.Port = 587;
                    sever.Credentials = new NetworkCredential("20110432@student.hcmute.edu.vn", "Phi09Phi09");
                    sever.EnableSsl = true;
                    sever.Send(mail);
                    //MessageBox.Show("Success!");
                    //Inform
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message, "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("An email was sent to " + textBox_Email1.Text + textBox_Email2.Text, "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddNewStaff_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fail to add new staff", "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddNewStaff_Load(object sender, EventArgs e)
        {
            //Get info of all the staffs
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login", db.getConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            //Add type
            comboBox_Type.Items.Add("Repair");
            comboBox_Type.Items.Add("Wash");
            comboBox_Type.Items.Add("Intaker");
            comboBox_Type.Items.Add("Outtaker");
            comboBox_Type.Text = comboBox_Type.Items[0].ToString();
            //comboBox_Type.Items.Add("");
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
