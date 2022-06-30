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
    public partial class CaringContractListForm : Form
    {
        public CaringContractListForm()
        {
            InitializeComponent();
        }
        CaringContract ca = new CaringContract();
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = ca.GetContract(command);
        
            dataGridView1.AllowUserToAddRows = false;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd;
                String query;
                if (radioButton_yes.Checked)
                {
                    string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    query = "select CertificateId as 'ID', Date, CustomerID, CustomerName, VehicleID, b.Number, Address, TotalPrice " +
                        "from CaringCertificate a inner join Vehicle b on a.CertificateId=b.Id where Date between '" + date1 + "'and'" + date2 + "'";
                    cmd = new SqlCommand(query);
                    if (textBoxNumber.Text.Trim() != "")
                    {
                        string num = textBoxNumber.Text;
                        query += " and b.Number=@num";
                        cmd = new SqlCommand(query);
                        cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;
                    }
                    fillGrid(cmd);
                }
                else
                {
                    query = "select CertificateId as 'ID', Date, CustomerID, CustomerName, VehicleID, b.Number, Address, TotalPrice " +
                        "from CaringCertificate a inner join Vehicle b on a.CertificateId=b.Id";
                    cmd = new SqlCommand(query);
                    if (textBoxNumber.Text.Trim() != "")
                    {
                        string num = textBoxNumber.Text;
                        query += " and b.Number=@num";
                        cmd = new SqlCommand(query);
                        cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;
                    }
                    fillGrid(cmd);
                }
            }
            catch
            {
                MessageBox.Show("Something wrong");
            }
        }


        private void radioButton_yes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radioButton_No_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Globals.SetGlobalCertId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            DetailForm frm = new DetailForm();
            frm.Show(this);
        }
    }
}