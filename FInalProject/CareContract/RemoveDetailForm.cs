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
    public partial class RemoveDetailForm : Form
    {
        public RemoveDetailForm()
        {
            InitializeComponent();
        }
        CaringContract ca = new CaringContract();
        private void RemoveDetailForm_Load(object sender, EventArgs e)
        {
            DataGridViewService.DataSource = ca.getAllConDetail();
        }

        private void btn_RemoveService_Click(object sender, EventArgs e)
        {
            try
            {
                int conID = Convert.ToInt32(DataGridViewService.CurrentRow.Cells[0].Value.ToString());
                int wID = Convert.ToInt32(DataGridViewService.CurrentRow.Cells[1].Value.ToString());
                if ((MessageBox.Show("Are you sure want to delete this service", "Remove Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (ca.deleteCareCertDetail(conID, wID))
                    {
                        MessageBox.Show("Service Deleted", "Remove Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataGridViewService.DataSource = ca.getAllConDetail();
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
    }
}
