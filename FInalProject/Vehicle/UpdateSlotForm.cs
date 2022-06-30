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
    public partial class UpdateSlotForm : Form
    {
        public UpdateSlotForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        private void UpdateSlotForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Capacity", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            textBoxLongCar.Text = table.Rows[0].ItemArray[0].ToString();
            textBoxLongMo.Text = table.Rows[0].ItemArray[1].ToString();
            textBoxCarShort.Text = table.Rows[0].ItemArray[2].ToString();
            textBoxShortMo.Text = table.Rows[0].ItemArray[3].ToString();
        }
        
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("update Capacity set LongCar=@lc, LongMoto=@ml, ShortCar=@sc, ShortMoto=@sm", mydb.getConnection);
                cmd.Parameters.Add("@lc", SqlDbType.Int).Value = Convert.ToInt32(textBoxLongCar.Text);
                cmd.Parameters.Add("@ml", SqlDbType.Int).Value = Convert.ToInt32(textBoxLongMo.Text);
                cmd.Parameters.Add("@sc", SqlDbType.Int).Value = Convert.ToInt32(textBoxCarShort.Text);
                cmd.Parameters.Add("@sm", SqlDbType.Int).Value = Convert.ToInt32(textBoxShortMo.Text);
                mydb.openConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    MessageBox.Show("Update successfully");
                }
                else
                {
                    mydb.closeConnection();
                    MessageBox.Show("Garage not updated");
                }
            }
            catch 
            {
                MessageBox.Show("Wrong Format");
            }
        }
    }
}
