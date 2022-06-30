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
    public partial class EndSupplyContract : Form
    {
        public EndSupplyContract()
        {
            InitializeComponent();
        }
        CustomerRent re = new CustomerRent();
        CustomerSupply su = new CustomerSupply();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxNumber.Text);
                SqlCommand cmd = new SqlCommand("Select Duration, TimeIn, VehicleID, Price from Supply " +
                    " where Id = @num");
                cmd.Parameters.Add("@num", SqlDbType.Int).Value = id;
                DataTable table = su.GetRentVehicle(cmd);
                DateTime d = Convert.ToDateTime(table.Rows[0].ItemArray[0]);
                string day = Convert.ToString(d.Day);
                string month = Convert.ToString(d.Month);
                string year = Convert.ToString(d.Year);
                string hour = Convert.ToString(d.Hour);
                string minute = Convert.ToString(d.Minute);
                string second = Convert.ToString(d.Second);
                textBoxDuration.Text = day + "/" + month + "/" + year + " " + hour + ":" + minute + ":" + second;
                d = Convert.ToDateTime(table.Rows[0].ItemArray[1]);
                day = Convert.ToString(d.Day);
                month = Convert.ToString(d.Month);
                year = Convert.ToString(d.Year);
                hour = Convert.ToString(d.Hour);
                minute = Convert.ToString(d.Minute);
                second = Convert.ToString(d.Second);
                textBoxSupplyTIme.Text = day + "/" + month + "/" + year + " " + hour + ":" + minute + ":" + second;
                if (Convert.ToDateTime(table.Rows[0].ItemArray[0]) > DateTime.Now)
                {
                    textBoxContractStatus.Text = "Validated";
                    textBoxFine.Text = Convert.ToString(Math.Round(Convert.ToDouble(table.Rows[0].ItemArray[3]) * 0.2,0));
                }
                else
                {
                    textBoxContractStatus.Text = "Out of date";
                    textBoxFine.Text = "None";
                }
                if (re.checkVehicleInRent(Convert.ToInt32(table.Rows[0].ItemArray[2])))
                {
                    textBoxVehicleStatus.Text = "In Use";
                }
                else
                {
                    textBoxVehicleStatus.Text = "Not In Use";

                }
                
            }
            catch
            {
                MessageBox.Show("Contract ID is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxNumber.Text);
            if (textBoxVehicleStatus.Text == "Not In Use")
            {
                if ((MessageBox.Show("Are you sure want to end this contract", "End Contract Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (re.Remove_RentCon(id))
                    {
                        MessageBox.Show("End successfully", "End Contract Form", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            else
            {
                MessageBox.Show("Can not end this contract. Vehicle is in use", "End Contract Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
