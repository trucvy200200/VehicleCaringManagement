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
    public partial class ManagePrice : Form
    {
        DataTable table;
        public ManagePrice()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManagePrice_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Price",db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            textBox_LongBike.Text = table.Rows[0][2].ToString();
            textBox_LongCar.Text = table.Rows[0][0].ToString();
            textBox_LongMoto.Text = table.Rows[0][1].ToString();
            textBox_ShortBike.Text = table.Rows[0][5].ToString();
            textBox_ShortCar.Text = table.Rows[0][3].ToString();
            textBox_ShortMoto.Text = table.Rows[0][4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                My_DB db = new My_DB();
                SqlCommand cmd = new SqlCommand("UPDATE Price SET LongCar = @lc, LongBike = @lb, LongMoto = @lm," +
                    " ShortCar = @sc, ShortBike = @sb, ShortMoto = @sm", db.getConnection);
                cmd.Parameters.Add("@lc", SqlDbType.Int).Value = int.Parse(textBox_LongCar.Text);
                cmd.Parameters.Add("@lb", SqlDbType.Int).Value = int.Parse(textBox_LongBike.Text);
                cmd.Parameters.Add("@lm", SqlDbType.Int).Value = int.Parse(textBox_LongMoto.Text);
                cmd.Parameters.Add("@sc", SqlDbType.Int).Value = int.Parse(textBox_ShortCar.Text);
                cmd.Parameters.Add("@sb", SqlDbType.Int).Value = int.Parse(textBox_ShortBike.Text);
                cmd.Parameters.Add("@sm", SqlDbType.Int).Value = int.Parse(textBox_ShortMoto.Text);
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Price changed!", "Manage price", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error!", "Manage price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            ManagePrice_Load(sender, e);
        }
    }
}
