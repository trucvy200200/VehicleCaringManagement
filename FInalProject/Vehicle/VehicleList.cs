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
    public partial class VehicleList : Form
    {
        public VehicleList()
        {
            InitializeComponent();
        }
        Vehicle ve = new Vehicle();
        private void VehicleList_Load(object sender, EventArgs e)
        {
            //dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            SqlCommand cmd = new SqlCommand("select Id as 'Vehicle ID', Back as 'Back Image',"
                +" Number, Driver as 'Driver Image', TimeIn as 'Arrival Time', Duration, Type, Garage from Vehicle");
            dataGridView1.DataSource = ve.GetVehicle(cmd);
            dataGridView1.RowTemplate.Height = 60;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[1];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MainMenu_Intaker frm = new MainMenu_Intaker();
            frm.Show(this);
        }
       
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = ve.GetVehicle(command);
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
                    query = "Select Id, Back as 'Back Image', Number, Driver, TimeIn as 'Arrival Time', Duration, Type, Garage from Vehicle where Type = 'Car'";
                }
                else if (radioButtonMoto.Checked)
                {
                    query = "Select Id, Back as 'Back Image', Number, Driver, TimeIn as 'Arrival Time', Duration, Type, Garage from Vehicle where Type = 'Moto'";
                }
                else if (radioButtonBike.Checked)
                {
                    query = "Select Id, Back as 'Back Image', Number, Driver, TimeIn as 'Arrival Time', Duration, Type, Garage from Vehicle where Type = 'Bike'";
                }
                else
                {
                    query = "Select Id, Back as 'Back Image', Number, Driver, TimeIn as 'Arrival Time', Duration, Type, Garage from Vehicle where Id>0";

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
