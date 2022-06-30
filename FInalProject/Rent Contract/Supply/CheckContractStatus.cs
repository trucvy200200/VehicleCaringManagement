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
    public partial class CheckContractStatus : Form
    {
        public CheckContractStatus()
        {
            InitializeComponent();
        }
        CustomerSupply su = new CustomerSupply();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxNumber.Text);
                SqlCommand cmd = new SqlCommand("Select Duration, TimeIn from Supply " +
                    " where Id = @num");
                cmd.Parameters.Add("@num", SqlDbType.Int).Value =id;
                DataTable table = su.GetRentVehicle(cmd);
                DateTime d = Convert.ToDateTime(table.Rows[0].ItemArray[0]);
                string day = Convert.ToString(d.Day);
                string month = Convert.ToString(d.Month);
                string year = Convert.ToString(d.Year);
                string hour = Convert.ToString(d.Hour);
                string minute = Convert.ToString(d.Minute);
                string second = Convert.ToString(d.Second);
                textBoxDuration.Text = day + "/" + month + "/" + year+" "+hour+":"+minute+":"+second;
                d = Convert.ToDateTime(table.Rows[0].ItemArray[1]);
                day = Convert.ToString(d.Day);
                month = Convert.ToString(d.Month);
                year = Convert.ToString(d.Year);
                hour = Convert.ToString(d.Hour);
                minute = Convert.ToString(d.Minute);
                second = Convert.ToString(d.Second);
                textBoxSupplyTIme.Text =day + "/" + month + "/" + year + " " + hour + ":" + minute + ":" + second;
                if (Convert.ToDateTime(table.Rows[0].ItemArray[0]) > DateTime.Now)
                {
                    textBoxCertificateStatus.Text = "Validated";
                }
                else
                {
                    textBoxCertificateStatus.Text = "Out of date";
                }
            }
            catch
            {
                MessageBox.Show("Contract ID is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckContractStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
