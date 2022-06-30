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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void addNewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStaff frm = new AddNewStaff();
            frm.ShowDialog();
        }

    

        private void removeStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStaff frm = new RemoveStaff();
            frm.ShowDialog();
        }

        private void managePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePrice frm = new ManagePrice();
            frm.ShowDialog();
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffList frm = new StaffList();
            frm.Show(this);
        }

        private void manageShiftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageShift frm = new ManageShift();
            frm.ShowDialog();
        }

        private void updateStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStaff frm = new UpdateStaff();
            frm.Show(this);
        }
    }
}
