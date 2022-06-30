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
    public partial class ManageWorkForm : Form
    {
        public ManageWorkForm()
        {
            InitializeComponent();
        }

        private void ManageWorkForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        Work wo = new Work();
        int pos;
        void reloadListBoxData()
        {
            listBoxWork.DataSource = wo.getAllWork();
            listBoxWork.ValueMember = "id";
            listBoxWork.DisplayMember = "name";
            listBoxWork.SelectedItem = null;
            LabelTotalWorks.Text = ("Total Works: " + wo.totalWorks());
        }
        void showData(int index)
        {
            DataRow dr = wo.getAllWork().Rows[index];
            listBoxWork.SelectedIndex = index;
            TextBoxID.Text = dr.ItemArray[0].ToString();
            TextBoxName.Text = dr.ItemArray[1].ToString();
            TextBoxDescription.Text = dr.ItemArray[2].ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Work wo = new Work();
            int id = Convert.ToInt32(TextBoxID.Text);
            string name = TextBoxName.Text;
            string desc = TextBoxDescription.Text;
            try
            {
                if (name.Trim() == "")
                {
                    MessageBox.Show("Add a work name", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (wo.checkWorkName(name))
                {
                    if (wo.insertWork(id, name, desc))
                    {
                        MessageBox.Show("New Work Inserted", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Work Not Inserted", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("This Work Name Already Exists", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("ID already exists");
            }
        }

        private void listBoxWork_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxWork.SelectedItem;
            pos = listBoxWork.SelectedIndex;
            showData(pos);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string desc = TextBoxDescription.Text;
            int id = Convert.ToInt32(TextBoxID.Text);
            if (!wo.checkWorkName(name, Convert.ToInt32(id)))
            {
                MessageBox.Show("This Work Name Already Exist", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (wo.EditWork(id, name, desc))
            {
                MessageBox.Show("Work Updated", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Work Not Updated", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pos = 0;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Work wo = new Work();
            try
            {
                int ID = Convert.ToInt32(TextBoxID.Text);
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
            pos = 0;
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (pos < (wo.getAllWork().Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            pos = wo.getAllWork().Rows.Count - 1;
            showData(pos);
        }
    }
}
