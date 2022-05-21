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
    public partial class RemoveWorkForm : Form
    {
        public RemoveWorkForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work wo = new Work();
            try
            {
                int ID = Convert.ToInt32(TextBoxWorkID.Text);
                if ((MessageBox.Show("Are you sure want to delete this work", "Remove Work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (wo.RemoveWork(ID))
                    {
                        MessageBox.Show("Work Deleted", "Remove Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Work Not Deleted", "Remove Work", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter valid numeric ID", "Remove Work", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
