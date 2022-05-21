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
    public partial class UpdateWorkForm : Form
    {
        public UpdateWorkForm()
        {
            InitializeComponent();
        }
        Work wo = new Work();
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string desc = Description.Text;
            int id = (int)ComboBoxWork.SelectedValue;
            if (!wo.checkWorkName(name, Convert.ToInt32(ComboBoxWork.SelectedValue)))
            {
                MessageBox.Show("This Work Name Already Exist", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (wo.EditWork(id, name, desc))
            {
                MessageBox.Show("Work Updated", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(ComboBoxWork.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Work Not Updated", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void fillCombo(int index)
        {
            ComboBoxWork.DataSource = wo.getAllWork();
            ComboBoxWork.DisplayMember = "id";
            ComboBoxWork.ValueMember = "id";
            ComboBoxWork.SelectedIndex = index;
        }
        private void ComboBoxWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ComboBoxWork.SelectedValue);
                DataTable table = new DataTable();
                table = wo.getWorkByID(id);
                Name.Text = table.Rows[0][1].ToString();
                Description.Text = table.Rows[0][2].ToString();
            }
            catch
            { }
        }

        private void UpdateWorkForm_Load(object sender, EventArgs e)
        {
            ComboBoxWork.DataSource = wo.getAllWork();
            ComboBoxWork.DisplayMember = "id";
            ComboBoxWork.ValueMember = "id";
            ComboBoxWork.SelectedItem = null;
        }
    }
}
