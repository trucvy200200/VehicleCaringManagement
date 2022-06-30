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
    public partial class AddDetailForm : Form
    {
        public AddDetailForm()
        {
            InitializeComponent();
        }
        int check = 0;
        Work wo = new Work();
        void reloadListBoxData()
        {
            listBoxService.DataSource = wo.getAllWork();
            listBoxService.ValueMember = "Id";
            listBoxService.DisplayMember = "Name";
            listBoxService.SelectedItem = null;

        }
        CaringContract ca = new CaringContract();
        public double total_price = 1;
        Vehicle ve = new Vehicle();
        Staff st = new Staff();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    int sID = Convert.ToInt32(textBoxServiceID.Text);
                string name = textBoxName.Text;
                string des = textBoxDescription.Text;
                double price = Convert.ToDouble(textBoxPrice.Text);
                int cusid = Convert.ToInt32(textBoxCustomerID.Text);
                string cname = textBoxCusName.Text;
                int vid = Convert.ToInt32(textBoxVehicleID.Text);
                string add = textBoxAddress.Text;
                int sid = Convert.ToInt32(textBoxStaffID.Text);          
                    if (ve.checkVehicleID(vid))
                    {
                        if (check == 0)
                        {
                            int certID = ca.autoCertID();
                            Globals.SetGlobalCertId(certID);
                            if (ca.checkSeviceExist(certID, sID) == false)
                            {
                                if (st.checkStaffID(sid) == true)
                                {
                                    if (ca.add_CareCert(certID, cusid, cname, vid, add, total_price) == true)
                                    {
                                        ca.addCareCertDetail(certID, sID, price, sid);
                                        double a = ca.Total_Price(certID);
                                        ca.update_TotalPrice(a, certID);
                                        MessageBox.Show("Add successfully!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error");
                                    }
                                    check++;
                                }
                                else MessageBox.Show("Staff is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("Sevice has already chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            if (ca.checkSeviceExist(Globals.GlobalCertId, sID) == false)
                            {
                                if (st.checkStaffID(sid) == true)
                                {
                                        ca.addCareCertDetail(Globals.GlobalCertId, sID, price, sid);
                                        double a = ca.Total_Price(Globals.GlobalCertId);
                                        ca.update_TotalPrice(a, Globals.GlobalCertId);
                                        MessageBox.Show("Add successfully!");
                                }
                               else MessageBox.Show("Staff is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("Sevice has already chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        pos = listBoxService.SelectedIndex;
                        showData(pos);
                    }
                    else
                    {
                        MessageBox.Show("Vehicle ID is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verif()
        {
            if (textBoxCusName.Text.Trim()==""||textBoxPrice.Text.Trim()==""
                ||textBoxAddress.Text.Trim()==""||textBoxVehicleID.Text.Trim()=="")
            {
                return false;
            }
            return true;
        }
        void showData(int index)
        {
            DataRow dr = wo.getAllWork().Rows[index];
            listBoxService.SelectedIndex = index;
            textBoxServiceID.Text = dr.ItemArray[0].ToString();
            textBoxName.Text = dr.ItemArray[1].ToString();
            textBoxDescription.Text = dr.ItemArray[2].ToString();
        }
        int pos;
        private void listBoxService_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxService.SelectedItem;
            pos = listBoxService.SelectedIndex;
            showData(pos);
        }

        private void AddDetailForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
            Globals.SetGlobalCertId(0);
            textBoxCustomerID.Text = Convert.ToString(ca.autoCustomerID());
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            VehicleList frm = new VehicleList();
            frm.Show(this);
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            DetailForm frm = new DetailForm();
            frm.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffList frm = new StaffList();
            frm.Show(this);
        }
    }
}
