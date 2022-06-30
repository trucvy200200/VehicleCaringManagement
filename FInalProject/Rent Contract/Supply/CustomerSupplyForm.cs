using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class CustomerSupplyForm : Form
    {
        public CustomerSupplyForm()
        {
            InitializeComponent();
        }

        private void AddRentCertificate_Load(object sender, EventArgs e)
        {
            comboBoxType.Items.Add("Bike");
            comboBoxType.Items.Add("Moto");
            comboBoxType.Items.Add("Car");
            textBoxID.Text = Convert.ToString(re.autoVehicleID());
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxType.SelectedItem.ToString() == "Bike")
                textBoxNumber.ReadOnly = true;
            else textBoxNumber.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select image(*.jpg;*.png;*gif;*bmp)|*.jpg;*png;*.gif;*.bmp";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxBack.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select image(*.jpg;*.png;*gif;*bmp)|*.jpg;*png;*.gif;*.bmp";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }
        CustomerSupply re = new CustomerSupply();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif(comboBoxType.SelectedItem.ToString()))
                {
                    int id = Convert.ToInt32(textBoxID.Text);
                    string type = comboBoxType.SelectedItem.ToString();
                    string number = textBoxNumber.Text;
                    string phone = textBoxPhone.Text;
                    string add = textBoxAddress.Text;
                    string owner = textBoxOwnerName.Text;
                    DateTime dur =dateTimePicker1.Value;
                    double price = Convert.ToDouble(textBoxPrice.Text);
                    if (re.checkRentVehicleNumber(number) == false)
                    {
                        if (dateTimePicker1.Value > DateTime.Now)
                        {
                            MemoryStream pic = new MemoryStream();
                            pictureBoxBack.Image.Save(pic, pictureBoxBack.Image.RawFormat);
                            MemoryStream pic2 = new MemoryStream();
                            pictureBoxImage.Image.Save(pic2, pictureBoxImage.Image.RawFormat);
                            if (re.add_RentVehicle(id, pic, number, pic2, type, add, phone))
                            {
                                if (re.add_SupplyCert(re.autoCertID(), owner, id, dur, price))
                                {
                                    MessageBox.Show("Add successfully", "Add Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Duration is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vehicle already supplied!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Something Wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        bool verif(string a)
        {
            if (a == "Bike")
            {
                if ((comboBoxType.SelectedItem == null)
                       || (textBoxAddress.Text.Trim() == "")
                       || (textBoxPhone.Text.Trim() == "")
                       || (pictureBoxImage.Image == null)
                       || (pictureBoxBack.Image == null)
                       || (textBoxOwnerName.Text.Trim() == "")
                       
                       || (dateTimePicker1.Value== null)
                       || (textBoxPrice.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    textBoxNumber.Text = "None";
                    return true;
                }
            }
            else
            {
                if ((comboBoxType.SelectedItem == null) || (textBoxNumber.Text.Trim() == "")
                       || (textBoxAddress.Text.Trim() == "")
                       || (textBoxPhone.Text.Trim() == "")
                       || (pictureBoxImage.Image == null)
                       || (pictureBoxBack.Image == null)
                       || (textBoxOwnerName.Text.Trim() == "")
                       
                       || (dateTimePicker1.Value == null)
                       || (textBoxPrice.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            textBoxID.Text = Convert.ToString(re.autoVehicleID());
            textBoxAddress.Text = "";
            textBoxNumber.Text = "";
            textBoxOwnerName.Text = "";
            textBoxPhone.Text = "";
            textBoxPrice.Text = "";
            pictureBoxBack.Image = null;
            pictureBoxImage.Image = null;
        }
    }
}
