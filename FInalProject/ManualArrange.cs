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
    public partial class ManualArrange : Form
    {
        public int iID = 0;
        public string shift;
        public string day;
        public ManualArrange()
        {
            InitializeComponent();
        }

        private void ManualArrange_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet2.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter1.Fill(this.finalProjectDataSet2.Login);
            // TODO: This line of code loads data into the 'finalProjectDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.finalProjectDataSet.Login);

        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("UPDATE Shift SET " + this.day + " = @id " +
                "WHERE Shift = @shift",db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmd.Parameters.Add("@shift", SqlDbType.VarChar).Value = this.shift;
            db.openConnection();
            if(cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Shift changed!", "Shift arrangement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error!", "Shift arrangement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("UPDATE Shift SET " + this.day + " = @id " +
                "WHERE Shift = @shift", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = "0";
            cmd.Parameters.Add("@shift", SqlDbType.VarChar).Value = this.shift;
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Shift changed!", "Shift arrangement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error!", "Shift arrangement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
