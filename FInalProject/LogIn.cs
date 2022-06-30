using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        //All will be reuse multiple times
        private My_DB db = new My_DB();
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            if (verif())
            {
                if (radioButton_staff.Checked)
                {
                    command = new SqlCommand("SELECT * FROM Login WHERE username=@User AND password=@Pass", db.getConnection);
                    command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
                    command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox_Password.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        int id = Globals.GlobalUserId;
                        int x = Convert.ToInt32(table.Rows[0]["Id"]);
                        Globals.SetGlobalUserId(x);
                        ManagerMainMenu mainfrm = new ManagerMainMenu();
                        mainfrm.id = x;
                        mainfrm.Show(this);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radioButtonHuman.Checked)
                {
                    command = new SqlCommand("SELECT * FROM hr WHERE uname=@User AND pwd=@Pass", db.getConnection);
                    command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
                    command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox_Password.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        int id = Globals.GlobalUserId;
                        int x = Convert.ToInt32(table.Rows[0][0]);
                        Globals.SetGlobalUserId(x);
                        ContactForm mainfrm = new ContactForm();
                        mainfrm.Show(this);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

    bool verif()
    {
        if ((textBox_UserName.Text.Trim() == "") || (textBox_Password.Text.Trim() == ""))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    //if user leave this textbox, fill the table with all information that matches the user name (must be 1 or 0 match)
    //Reson: faster
    //       When click on the login button it can only compare the textbox with the table
    private void textBox_UserName_Leave(object sender, EventArgs e)
        {
            //table.Clear();
            //command = new SqlCommand("SELECT * FROM Login WHERE username = @User", db.getConnection);
            //db.openConnection();
            //command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
            //adapter = new SqlDataAdapter(command);
            //adapter.Fill(table);
            //db.closeConnection();
            //if(table.Rows.Count!=1)
            //{
            //    MessageBox.Show("Empty");
            //}
            //else
            //{
            //    MessageBox.Show(table.Rows[0]["username"].ToString(), table.Rows[0]["password"].ToString());
            //}
        }

        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {
            //table.Clear();
            //command = new SqlCommand("SELECT * FROM Login WHERE username = @User", db.getConnection);
            //db.openConnection();
            //command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
            //adapter = new SqlDataAdapter(command);
            //adapter.Fill(table);
            //db.closeConnection();
        }

        private void linkLabel_ResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword frm = new ResetPassword();
            frm.ShowDialog();
            textBox_Password.Clear();
            table.Clear();
            command = new SqlCommand("SELECT * FROM Login WHERE username = @User", db.getConnection);
            db.openConnection();
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            db.closeConnection();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
