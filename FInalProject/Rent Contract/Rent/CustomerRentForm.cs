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
    public partial class CustomerRentForm : Form
    {
        public CustomerRentForm()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            RentVehicleList frm = new RentVehicleList();
            frm.Show(this);
        }
        CustomerSupply su = new CustomerSupply();
        CustomerRent re = new CustomerRent();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if (re.checkVehicleID(id))
                {
                    SqlCommand cmd = new SqlCommand("Select Type, Back from RentVehicle where Id=@id");
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    DataTable table = su.GetRentVehicle(cmd);
                    textBoxType.Text = table.Rows[0].ItemArray[0].ToString();
                    textBoxStatus.Text = re.checkVehicleStatus(id);
                    byte[] pic;
                    pic = (byte[])table.Rows[0].ItemArray[1];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxBack.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("ID is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Enter an id", "Rent Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Rent_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    string name = textBoxCusName.Text;
                    string phone = textBoxPhone.Text;
                    string add = textBoxAddress.Text;
                    int id = Convert.ToInt32(textBoxID.Text);
                    int dur = Convert.ToInt32(textBoxDuration.Text);
                    double price = Convert.ToDouble(textBoxPrice.Text);
                    if (textBoxStatus.Text == "Validated")
                    {
                        if (re.checkVehicleInRent(id)==false)
                        {
                            if (re.add_RentCert(re.autoCertID(), name, add, phone, id, dur, price))
                            {
                                MessageBox.Show("Rent successfully", "Rent Form", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("This vehicle is in rent", "Rent Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This vehicle is out of date", "Rent Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Something wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verif()
        {
            if (textBoxCusName.Text.Trim() == "" || textBoxPhone.Text.Trim() == ""
                || textBoxAddress.Text.Trim() == "" || textBoxID.Text.Trim() == ""
                || textBoxDuration.Text.Trim() == "" || textBoxPrice.Text.Trim() == ""
                || textBoxStatus.Text.Trim() == "")
                return false;
            else return true;
        }

        private void CustomerRentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
