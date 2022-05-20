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
    public partial class ManagerMainMenu : Form
    {
        DataTable user = new DataTable();
        My_DB db = new My_DB();
        public int id = 0;
        public ManagerMainMenu()
        {
            InitializeComponent();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStaff frm = new AddNewStaff();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void ManagerMainMenu_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Id = @id", db.getConnection);
            db.openConnection();
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(user);
            db.closeConnection();
            label_Name.Text = "Hello " + user.Rows[0]["FirstName"] + " " + user.Rows[0]["LastName"] +
                "\nYou are the manager";
        }
    }
}
