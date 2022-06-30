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
    public partial class RentVehicleList : Form
    {
        public RentVehicleList()
        {
            InitializeComponent();
        }
        CustomerSupply re = new CustomerSupply();
        private void RentVehicleList_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from RentVehicle");
            dataGridView1.DataSource = re.GetRentVehicle(cmd);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[1];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = re.GetRentVehicle(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[1];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd;
                String query;
                if (radioButtonCar.Checked)
                {
                    query = "Select * from RentVehicle where Type = 'Car'";
                }
                else if (radioButtonMoto.Checked)
                {
                    query = "Select * from RentVehicle where Type = 'Moto'";
                }
                else if (radioButtonBike.Checked)
                {
                    query = "Select * from RentVehicle where Type = 'Bike'";
                }
                else
                {
                    query = "Select * from RentVehicle where Id>0";
                }
                cmd = new SqlCommand(query);
                if (textBoxNumber.Text.Trim() != "")
                {
                    string id = textBoxNumber.Text;
                    query += " and Number=@id";
                    cmd = new SqlCommand(query);
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                }
                fillGrid(cmd);
            }
            catch
            {
                MessageBox.Show("Something wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
