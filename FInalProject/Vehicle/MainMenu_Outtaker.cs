using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class MainMenu_Outtaker : Form
    {
        public int id;
        My_DB db = new My_DB();
        DataTable table = new DataTable();
        Vehicle vehicle = new Vehicle();
        public MainMenu_Outtaker()
        {
            InitializeComponent();
        }

        private void MainMenu_Outtaker_Load(object sender, EventArgs e)
        {

        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            int id;
            table.Clear();
            if (int.TryParse(textBox_ID.Text, out id))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicle WHERE Id = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                table = vehicle.GetVehicle(cmd);
                if(table.Rows.Count==0)
                {
                    MessageBox.Show("No vehicle found!", "Find vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    TimeSpan span = DateTime.Now - (DateTime)table.Rows[0]["TimeIn"];
                    textBox_Number.Text = table.Rows[0]["Number"].ToString();
                    if (table.Rows[0]["Garage"].ToString() == "Long")
                    {
                        radioButton_Long.Checked = true;
                        textBox_Duration.Text = table.Rows[0]["Duration"].ToString();
                        textBox_Exceed.Text = (span.Days - int.Parse(textBox_Duration.Text)).ToString();
                        if (int.Parse(textBox_Exceed.Text) <= 1) textBox_Exceed.Text = "0";
                        //textBox_Duration.Text += " Days";
                    }
                    else
                    {
                        radioButton_Short.Checked = true;
                        textBox_Duration.Text = table.Rows[0]["Duration"].ToString();
                        textBox_Exceed.Text = ((span.Hours - int.Parse(textBox_Duration.Text)) + span.Days * 24).ToString();
                        if (int.Parse(textBox_Exceed.Text) <= 1) textBox_Exceed.Text = "0";
                        //textBox_Duration.Text += " Hours";
                    }
                    DataTable price = new DataTable();
                    cmd = new SqlCommand("SELECT * FROM Price", db.getConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(price);
                    if(table.Rows[0]["Type"].ToString()=="Car")
                    {
                        radioButton_Car.Checked = true;
                        textBox_Basic.Text = (int.Parse(textBox_Duration.Text) * int.Parse(price.Rows[0][table.Rows[0]["Garage"].ToString() + "Car"].ToString())).ToString();
                        textBox_Fine.Text = Convert.ToInt32((int.Parse(textBox_Exceed.Text) * int.Parse(price.Rows[0][table.Rows[0]["Garage"].ToString() + "Car"].ToString()) * 1.3)).ToString();
                    }
                    else if(table.Rows[0]["Type"].ToString() == "Moto")
                    {
                        radioButton_Moto.Checked = true;
                        textBox_Basic.Text = (int.Parse(textBox_Duration.Text) * int.Parse(price.Rows[0][table.Rows[0]["Garage"].ToString() + "Moto"].ToString())).ToString();
                        textBox_Fine.Text = Convert.ToInt32((int.Parse(textBox_Exceed.Text) * int.Parse(price.Rows[0][table.Rows[0]["Garage"].ToString() + "Moto"].ToString()) * 1.3)).ToString();
                    }
                    else
                    {
                        radioButton_Bike.Checked = true;
                        textBox_Basic.Text = (int.Parse(textBox_Duration.Text) * int.Parse(price.Rows[0][table.Rows[0]["Garage"].ToString() + "Bike"].ToString())).ToString();
                        textBox_Fine.Text = Convert.ToInt32((int.Parse(textBox_Exceed.Text) * int.Parse(price.Rows[0][table.Rows[0]["Garage"].ToString() + "Bike"].ToString()) * 1.3)).ToString();
                    }
                    textBox_TimeIn.Text = table.Rows[0]["TimeIn"].ToString();
                    textBox_Total.Text = (int.Parse(textBox_Basic.Text) + int.Parse(textBox_Fine.Text)).ToString();
                    byte[] bytes = (byte[])table.Rows[0]["Back"];
                    Bitmap pic;
                    using (var ms = new MemoryStream(bytes))
                    {
                        pic = new Bitmap(ms);
                    }
                    pictureBox_Vehicle.Image = (Image)pic;
                    pictureBox_Vehicle1.Image = (Image)pic;
                    //=====
                    byte[] bytes1 = (byte[])table.Rows[0]["Driver"];
                    Bitmap pic1;
                    using (var ms = new MemoryStream(bytes1))
                    {
                        pic1 = new Bitmap(ms);
                    }
                    pictureBox_Driver.Image = (Image)pic1;
                    pictureBox_Driver1.Image = (Image)pic1;
                }
            }
            else
            {
                MessageBox.Show("Incorrect format!", "Find vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            pictureBox_Driver.Image = null;
            pictureBox_Driver1.Image = null;
            pictureBox_Vehicle.Image = null;
            pictureBox_Vehicle1.Image = null;
            textBox_ID.Clear();
            textBox_Number.Clear();
            textBox_TimeIn.Clear();
            textBox_Duration.Clear();
            textBox_Exceed.Clear();
            textBox_Basic.Clear();
            textBox_Fine.Clear();
            textBox_Total.Clear();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Charge_Click(object sender, EventArgs e)
        {
            Vehicle v = new Vehicle();
            v.RemoveVehicle(int.Parse(textBox_ID.Text), int.Parse(textBox_Total.Text));
            button_Refresh_Click(sender, e);
        }
    }
}
