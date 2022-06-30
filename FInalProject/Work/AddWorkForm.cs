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
    public partial class AddWorkForm : Form
    {
        public AddWorkForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Work wo = new Work();
            int id = Convert.ToInt32(ID.Text);
            string name = Name.Text;
            string desc = Description.Text;
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

        private void AddWorkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
