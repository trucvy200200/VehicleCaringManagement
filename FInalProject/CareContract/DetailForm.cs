using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }
        CaringContract ca = new CaringContract();
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int wID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                if ((MessageBox.Show("Are you sure want to delete this service", "Remove service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (ca.deleteCareCertDetail(Globals.GlobalCertId, wID))
                    {
                        double a = ca.Total_Price(Globals.GlobalCertId);
                        ca.update_TotalPrice(a, Globals.GlobalCertId);
                        lb_TotalPrice.Text = "TOTAL PRICE: " + Convert.ToString(a);
                        MessageBox.Show("Service Deleted", "Remove Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView2.DataSource = ca.getCertDetail(Globals.GlobalCertId);
                    }
                    else
                    {
                        MessageBox.Show("Service Not Deleted", "Remove Service", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Choose one to remove", "Remove Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = ca.getCertDetail(Globals.GlobalCertId);
                lb_TotalPrice.Text = "TOTAL PRICE: " + Convert.ToString(ca.Total_Price(Globals.GlobalCertId));
            
            }
            catch
            {
                MessageBox.Show("Any service is chosen!");
            }
        }
    }
}
