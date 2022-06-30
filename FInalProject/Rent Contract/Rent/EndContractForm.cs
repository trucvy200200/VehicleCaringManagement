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
    public partial class EndContractForm : Form
    {
        public EndContractForm()
        {
            InitializeComponent();
        }
        CustomerRent re = new CustomerRent();
        CustomerSupply su = new CustomerSupply();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
            if (re.checkContractID(id))
            {
                SqlCommand cmd = new SqlCommand("Select Duration, RentTime from Rent where Id=@id");
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                DataTable table = su.GetRentVehicle(cmd);
                textBoxDuration.Text = table.Rows[0].ItemArray[0].ToString();
                textBoxRentTime.Text = table.Rows[0].ItemArray[1].ToString();
                textBoxStatus.Text = re.checkRentConStatus(id);
                DateTime d = Convert.ToDateTime(table.Rows[0].ItemArray[1]).AddHours(Convert.ToInt32(table.Rows[0].ItemArray[0]));
                if (d > DateTime.Now)
                {
                    textBoxFine.Text = "None";
                }
                else
                {
                    TimeSpan x = DateTime.Now.Subtract(d);
                    double hour = Math.Round(x.TotalHours, 0);
                    if (hour >= 1)
                    {
                        textBoxFine.Text = Convert.ToString(hour*10000);
                    }
                }
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

        }
        
        private void btn_End_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            if ((MessageBox.Show("Are you sure want to end this contract", "End Contract Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (re.Remove_RentCon(id))
                {
                    MessageBox.Show("End successfully", "End Contract Form", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
