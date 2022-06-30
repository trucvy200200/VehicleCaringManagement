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
    public partial class StaffList : Form
    {
        public StaffList()
        {
            InitializeComponent();
        }
        Staff s = new Staff();
        private void StaffList_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select Id as 'Staff ID', firstname as 'First Name', lastname as 'Last Name', email as 'Email', Type as 'Type', username as 'UserName' from Login");
            dataGridView1.DataSource = s.GetStaff(cmd);
        }
    }
}
