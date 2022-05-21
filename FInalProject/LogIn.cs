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
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text.Trim() == "" || textBox_UserName.Text.Trim() == "")
            {
                MessageBox.Show("User name or password is empty!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(table.Rows.Count==0)
                {
                    MessageBox.Show("Incorrect user name or password!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox_Password.Text == table.Rows[0]["Password"].ToString())
                {
                    //MessageBox.Show("Loged in", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(table.Rows[0]["Type"].ToString()=="Manager")
                    {
                        Hide();
                        ManagerMainMenu frm = new ManagerMainMenu();
                        frm.id = int.Parse(table.Rows[0]["Id"].ToString());
                        frm.ShowDialog();
                        textBox_Password.Clear();
                        Show();
                    }
                    else if(table.Rows[0]["Type"].ToString() =="Intaker")
                    {
                        MainMenu_Intaker frm = new MainMenu_Intaker();
                        frm.id = int.Parse(table.Rows[0]["Id"].ToString());
                        frm.ShowDialog();
                        textBox_Password.Clear();
                        Show();
                    }
                    else if (table.Rows[0]["Type"].ToString() == "Outtaker")
                    {
                        MainMenu_Outtaker frm = new MainMenu_Outtaker();
                        frm.id = int.Parse(table.Rows[0]["Id"].ToString());
                        frm.ShowDialog();
                        textBox_Password.Clear();
                        Show();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password!", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //if user leave this textbox, fill the table with all information that matches the user name (must be 1 or 0 match)
        //Reson: faster
        //       When click on the login button it can only compare the textbox with the table
        private void textBox_UserName_Leave(object sender, EventArgs e)
        {
            table.Clear();
            cmd = new SqlCommand("SELECT * FROM Login WHERE username = @User", db.getConnection);
            db.openConnection();
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            db.closeConnection();
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
            //cmd = new SqlCommand("SELECT * FROM Login WHERE username = @User", db.getConnection);
            //db.openConnection();
            //cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
            //adapter = new SqlDataAdapter(cmd);
            //adapter.Fill(table);
            //db.closeConnection();
        }

        private void linkLabel_ResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword frm = new ResetPassword();
            frm.ShowDialog();
            textBox_Password.Clear();
            table.Clear();
            cmd = new SqlCommand("SELECT * FROM Login WHERE username = @User", db.getConnection);
            db.openConnection();
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_UserName.Text;
            adapter = new SqlDataAdapter(cmd);
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
