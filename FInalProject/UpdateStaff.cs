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
    public partial class UpdateStaff : Form
    {
        public UpdateStaff()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    int id = Convert.ToInt32(textBoxID.Text);
                    string fname = textBox_FirstName.Text;
                    string lname = textBox_LastName.Text;
                    string email = textBox_Email1.Text;
                    string type = comboBox_Type.SelectedItem.ToString();
                    string user = textBox_UserName.Text;
                    if (s.checkUsername(id, user)==false)
                    {
                        if (s.updateStaff(id, user, email, type, fname, lname))
                        {
                            MessageBox.Show("Staff edited", "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Staff not edited", "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username exist!", "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Something wrong (Empty field/Wrong format)", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        Staff s = new Staff();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                SqlCommand cmd = new SqlCommand("Select * from Login where id =@id");
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                DataTable table = s.GetStaff(cmd);
                textBox_FirstName.Text = table.Rows[0]["firstname"].ToString();
                textBox_LastName.Text = table.Rows[0]["lastname"].ToString();
                textBox_Email1.Text = table.Rows[0]["email"].ToString();
                comboBox_Type.Text= table.Rows[0]["Type"].ToString();
                textBox_UserName.Text= table.Rows[0]["username"].ToString(); 
            }
            catch
            {
                MessageBox.Show("ID is invalid", "Update contract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if (textBox_FirstName.Text.Trim() == "" || textBox_LastName.Text.Trim() == ""
                || textBox_Email1.Text.Trim() == "" || comboBox_Type.Text.Trim() == ""
                    || textBox_UserName.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }

            private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        My_DB db = new My_DB();
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            
            //Add type
            comboBox_Type.Items.Add("Repair");
            comboBox_Type.Items.Add("Wash");
            comboBox_Type.Items.Add("Intaker");
            comboBox_Type.Items.Add("Outtaker");
            comboBox_Type.Text = comboBox_Type.Items[0].ToString();
        }

        private void btn_StaffList_Click(object sender, EventArgs e)
        {
            StaffList frm = new StaffList();
            frm.Show(this);
        }
    }
}
