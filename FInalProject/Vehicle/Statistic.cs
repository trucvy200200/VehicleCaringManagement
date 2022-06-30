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
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicle ",db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            if(table.Rows.Count<=0)
            {
                MessageBox.Show("There is no vehicle in the garage!", "Statistic", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            int car = 0;
            int bike = 0;
            int moto = 0;
            for(int i=0;i<table.Rows.Count;i++)
            {
                if ((string)table.Rows[i]["Type"] == "Car") car++;
                else if ((string)table.Rows[i]["Type"] == "Bike") bike++;
                else moto++;
            }
            chart1.Titles.Add("Vehicle ration");
            chart1.Series["s1"].Points.AddXY("Car", car.ToString());
            chart1.Series["s1"].Points.AddXY("Bike", bike.ToString());
            chart1.Series["s1"].Points.AddXY("Moto", moto.ToString());
        }
    }
}
