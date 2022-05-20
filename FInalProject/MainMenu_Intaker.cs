using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.ML;
//using Emgu.CV.ML.Structure;
//using Emgu.CV.UI;
using Emgu.Util;
using System.Diagnostics;
using Emgu.CV.CvEnum;
using System.IO;
using System.IO.Ports;
using Tesseract;
using System.Collections;
using System.Threading;
using System.Media;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace FInalProject
{
    public partial class MainMenu_Intaker : Form
    {
        Vehicle vehicle = new Vehicle();
        DataTable user = new DataTable();
        My_DB db = new My_DB();
        public int id = 0;
        public MainMenu_Intaker()
        {
            InitializeComponent();
        }
        //private bool test = false;
        private void MainMenu_Intaker_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Id = @id", db.getConnection);
            db.openConnection();
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(user);
            db.closeConnection();
            dateTimePicker_Time.Format = DateTimePickerFormat.Time;
            label_Now.Text = DateTime.Now.ToString("H:mm");
            //=======================================================
            label_Time.Text = "Hours";
            numericUpDown_Time.Maximum = 24 - int.Parse(DateTime.Now.Hour.ToString()) - 1;
            if (numericUpDown_Time.Maximum < 1) numericUpDown_Time.Maximum = 1;
            dateTimePicker_Time.Format = DateTimePickerFormat.Time;
            dateTimePicker_Time.Enabled = false;
        }

        private void button_Vehicle_Click(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();
            frm.ShowDialog();
            if (frm.FileName == "") return;
            string path = frm.FileName;
            pictureBox_Vehicle.Image = Image.FromFile(path);
        }

        private void button_Driver_Click(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();
            frm.ShowDialog();
            string path = frm.FileName;
            if (frm.FileName == "") return;
            pictureBox_Driver.Image = Image.FromFile(path);
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            if (pictureBox_Vehicle.Image != null)
            {
                pictureBox_Vehicle.Image.Dispose();
                pictureBox_Vehicle.Image = null;
            }
            if(pictureBox_Driver.Image != null)
            {
                pictureBox_Driver.Image.Dispose();
                pictureBox_Driver.Image = null;
            }
        }

        private void radioButton_Bike_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Bike.Checked)
            {
                textBox_Number.Clear();
                textBox_Number.ReadOnly = true;
            }
            else
            {
                textBox_Number.ReadOnly = false;
            }
            if (pictureBox_Vehicle.Image != null)
            {
                pictureBox_Vehicle.Image.Dispose();
                pictureBox_Vehicle.Image = null;
            }
        }

        private void radioButton_Moto_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_Moto.Checked) return;
            if (pictureBox_Vehicle.Image != null)
            {
                pictureBox_Vehicle.Image.Dispose();
                pictureBox_Vehicle.Image = null;
            }
        }

        private void radioButton_Car_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_Car.Checked) return;
            if (pictureBox_Vehicle.Image != null)
            {
                pictureBox_Vehicle.Image.Dispose();
                pictureBox_Vehicle.Image = null;
            }
        }

        private void radioButton_Short_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Short.Checked)
            {
                label_Time.Text = "Hours";
                numericUpDown_Time.Maximum = 24 - int.Parse(DateTime.Now.Hour.ToString()) - 1;
                if (numericUpDown_Time.Maximum < 1) numericUpDown_Time.Maximum = 1;
                dateTimePicker_Time.Format = DateTimePickerFormat.Time;
                dateTimePicker_Time.Enabled = false;
            }
        }

        private void radioButton_Long_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Long.Checked)
            {
                label_Time.Text = "Days";
                numericUpDown_Time.Maximum = 200;
                dateTimePicker_Time.Format = DateTimePickerFormat.Short;
                dateTimePicker_Time.Enabled = true;
                //TimeSpan duration = new TimeSpan(int.Parse(numericUpDown_Time.Value.ToString()), 0, 0, 0);
                dateTimePicker_Time.Value = DateTime.Now.AddDays(int.Parse(numericUpDown_Time.Value.ToString()));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (radioButton_Short.Checked)
            {
                dateTimePicker_Time.Value = DateTime.Now.AddHours(int.Parse(numericUpDown_Time.Value.ToString()));
                if (DateTime.Now.Hour >= 23)
                {
                    radioButton_Short.Enabled = false;
                    radioButton_Long.Checked = true;
                }
            }
            //dateTimePicker_Time.Text = dateTimePicker_Time.Value.ToString();
            label_Now.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void button_Approve_Click(object sender, EventArgs e)
        {
            MemoryStream pic1 = new MemoryStream();
            MemoryStream pic2 = new MemoryStream();
            if (radioButton_Bike.Checked)
            {
                if(pictureBox_Driver.Image == null || pictureBox_Vehicle == null)
                {
                    MessageBox.Show("Missing image!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    pictureBox_Vehicle.Image.Save(pic1, pictureBox_Vehicle.Image.RawFormat);
                    pictureBox_Driver.Image.Save(pic2, pictureBox_Driver.Image.RawFormat);
                    if (radioButton_Short.Checked)
                    { 
                        vehicle.AddToShortGarage(pic1, "None", pic2, DateTime.Parse(label_Now.Text), 
                            int.Parse(numericUpDown_Time.Value.ToString()), "Bike"); 
                    }
                    else
                    {
                        vehicle.AddToLongGarage(pic1, "None", pic2, DateTime.Parse(label_Now.Text), 
                            int.Parse(numericUpDown_Time.Value.ToString()), "Bike");
                    }
                }
            }
            else
            {
                if(pictureBox_Driver.Image == null || pictureBox_Vehicle == null)
                {
                    MessageBox.Show("Missing image!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBox_Number.Text.Trim()=="")
                {
                    MessageBox.Show("Missing plate number!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox_Vehicle.Image.Save(pic1, pictureBox_Vehicle.Image.RawFormat);
                    pictureBox_Driver.Image.Save(pic2, pictureBox_Driver.Image.RawFormat);
                    string type = "Moto";
                    if (radioButton_Car.Checked)
                    {
                        type = "Car";
                    }
                    if (radioButton_Short.Checked)
                    {
                        vehicle.AddToShortGarage(pic1, textBox_Number.Text, pic2, DateTime.Parse(label_Now.Text), 
                            int.Parse(numericUpDown_Time.Value.ToString()), type);
                    }
                    else
                    {
                        vehicle.AddToLongGarage(pic1, textBox_Number.Text, pic2, DateTime.Parse(label_Now.Text), int.Parse(numericUpDown_Time.Value.ToString()), type);
                    }
                }
            }
        }
        private void dateTimePicker_Time_ValueChanged(object sender, EventArgs e)
        {
            if(radioButton_Long.Checked)
            {
                TimeSpan duration = dateTimePicker_Time.Value - DateTime.Now;
                numericUpDown_Time.Text = duration.Days.ToString();
            }
        }

        private void numericUpDown_Time_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton_Short.Checked)
            {
                dateTimePicker_Time.Value = DateTime.Now.AddHours(int.Parse(numericUpDown_Time.Value.ToString()));
            }
            else
            {
                dateTimePicker_Time.Value = DateTime.Now.AddDays(int.Parse(numericUpDown_Time.Value.ToString()));
            }
        }
    }
}
