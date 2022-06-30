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
    public partial class RemoveUpdateCaringContractForm : Form
    {
        public RemoveUpdateCaringContractForm()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            CaringContractListForm frm = new CaringContractListForm();
            frm.Show(this);
        }
        CaringContract ca = new CaringContract();
        private void btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxConID.Text);
                SqlCommand cmd = new SqlCommand("Select * from CaringCertificate where CertificateId=@id ");
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                DataTable table = ca.GetContract(cmd);
                textBoxCusID.Text = table.Rows[0].ItemArray[2].ToString();
                textBoxCusName.Text = table.Rows[0].ItemArray[3].ToString();
                textBoxVehicleID.Text = table.Rows[0].ItemArray[4].ToString();
                textBoxAddress.Text = table.Rows[0].ItemArray[5].ToString();
                textBoxPrice.Text = table.Rows[0].ItemArray[6].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(table.Rows[0].ItemArray[1].ToString());
            }
            catch
            {
                MessageBox.Show("ID is invalid", "Update contract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {

                if (verif())
                {
                    int id = Convert.ToInt32(textBoxConID.Text);
                    int cid = Convert.ToInt32(textBoxCusID.Text);
                    int vid = Convert.ToInt32(textBoxVehicleID.Text);
                    double price = Convert.ToDouble(textBoxPrice.Text);
                    string add = textBoxAddress.Text;
                    string cname = textBoxCusName.Text;
                    DateTime d = dateTimePicker1.Value;
                    if (ca.update_CareCert(id, d, cid, cname, vid, add, price))
                    {
                        MessageBox.Show("Contract edited", "Update contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update contract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (textBoxAddress.Text.Trim() == "" || textBoxCusID.Text.Trim() == ""
                || textBoxCusName.Text.Trim() == "" || textBoxVehicleID.Text.Trim() == ""
                || textBoxPrice.Text.Trim() == "")
            {
                return false;
            }
            else return true;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {

                if (ca.deleteCareCert(Convert.ToInt32(textBoxConID.Text)))
                    MessageBox.Show("Remove successfully", "Remove contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
            catch
            {
                MessageBox.Show("Contract ID is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
