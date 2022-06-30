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
    public partial class ManagerMainMenu : Form
    {
        DataTable user = new DataTable();
        My_DB db = new My_DB();
        public int id = 0;
        public ManagerMainMenu()
        {
            InitializeComponent();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewStaff frm = new AddNewStaff();
            Hide();
            frm.ShowDialog();
            Show();
        }
        My_DB mydb = new My_DB();
        public void getImageAndUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from Login where Id = @uid", mydb.getConnection);
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                lb_name.Text = "Welcome (" + table.Rows[0]["username"].ToString() + ")";
            }
        }
        private void ManagerMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                getImageAndUsername();
            }
            catch
            {
                MessageBox.Show("There is no user");
            }
        }

        private void addWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWorkForm frm = new AddWorkForm();
            frm.Show(this);
        }

        private void deleteWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveWorkForm frm = new RemoveWorkForm();
            frm.Show(this);

        }

        private void updateWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateWorkForm frm = new UpdateWorkForm();
            frm.Show(this);
        }

        private void workListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageWorkForm frm = new ManageWorkForm();
            frm.Show(this);
        }

        private void receiveVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu_Intaker frm = new MainMenu_Intaker();
            frm.Show(this);
        }

        private void updateSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSlotForm frm = new UpdateSlotForm();
            frm.Show(this);
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddDetailForm frm = new AddDetailForm();
            frm.Show(this);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSupplyForm frm = new CustomerSupplyForm();
            frm.Show(this);
        }

        private void rentVehicleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentVehicleList frm = new RentVehicleList();
            frm.Show(this);
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustomerSupplyForm frm = new CustomerSupplyForm();
            frm.Show(this);
        }

        private void checkCertificateStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckContractStatus frm = new CheckContractStatus();
            frm.Show(this);
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerRentForm frm = new CustomerRentForm();
            frm.Show(this);
        }

        private void customersSupplyToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void endContractToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EndContractForm frm = new EndContractForm();
            frm.Show(this);
        }

        private void endSupplyContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndSupplyContract frm = new EndSupplyContract();
            frm.Show(this);
        }

        private void certificateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractListForm frm = new ContractListForm();
            frm.Show(this);
        }

        private void updateDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveDetailForm frm = new RemoveDetailForm();
            frm.Show(this);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaringContractListForm frm = new CaringContractListForm();
            frm.Show(this);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUpdateCaringContractForm frm = new RemoveUpdateCaringContractForm();
            frm.Show(this);
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void vehicleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleList frm = new VehicleList();
            frm.Show(this);
        }

        private void returnVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu_Outtaker frm = new MainMenu_Outtaker();
            frm.Show(this);
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Revenue frm = new Revenue();
            frm.ShowDialog();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistic frm = new Statistic();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void shiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WatchShift frm = new WatchShift();
            frm.id = id;
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WatchShift frm = new WatchShift();
            frm.Show(this);
        }
    }
}
