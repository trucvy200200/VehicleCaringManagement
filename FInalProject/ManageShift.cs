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
    public partial class ManageShift : Form
    {
        private bool check = false;
        public ManageShift()
        {
            InitializeComponent();
        }

        private void ManageShift_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet1.Shift' table. You can move, or remove it, as needed.
            this.shiftTableAdapter.Fill(this.finalProjectDataSet1.Shift);
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Shift", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            for(int i=0;i<3;i++)
            {
                for(int j=1;j<=7;j++)
                {
                    if((string)table.Rows[i][j]=="0")
                    {
                        table.Rows[i][j] = "Empty";
                    }
                }
            }
            dataGridView1.DataSource = table;
            cmd = new SqlCommand("SELECT * FROM LogIn", db.getConnection);
            table = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Show all!");
            for(int i=0;i<table.Rows.Count;i++)
            {
                comboBox1.Items.Add(table.Rows[i][0].ToString());
            }
            //comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //label1.Text = (string)dataGridView1.CurrentCell.Value;
            //if (dataGridView1.CurrentCell.ColumnIndex == 0) return;
            //ManualArrange frm = new ManualArrange();
            //if ((string)dataGridView1.CurrentCell.Value == "Empty") frm.iID = 0;
            //else frm.iID = int.Parse((string)dataGridView1.CurrentCell.Value);
            //frm.shift = (string)dataGridView1.CurrentRow.Cells[0].Value;
            ////I dont know how to get the DataPropertyName so I do it manually============
            //if (dataGridView1.CurrentCell.ColumnIndex == 1) frm.day = "mo";
            //else if (dataGridView1.CurrentCell.ColumnIndex == 2) frm.day = "tu";
            //else if (dataGridView1.CurrentCell.ColumnIndex == 3) frm.day = "we";
            //else if (dataGridView1.CurrentCell.ColumnIndex == 4) frm.day = "th";
            //else if (dataGridView1.CurrentCell.ColumnIndex == 5) frm.day = "fr";
            //else if (dataGridView1.CurrentCell.ColumnIndex == 6) frm.day = "sa";
            //else if (dataGridView1.CurrentCell.ColumnIndex == 7) frm.day = "su";
            //frm.ShowDialog();
            //ManageShift_Load(sender, e);
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete all the data!\nProceed to countinue?", "Manage shift"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.No:
                    check = false;
                    return;
            }
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("UPDATE Shift Set" +
                " mo = @rs, tu = @rs, we = @rs, th = @rs, fr = @rs, sa = @rs, su = @rs", db.getConnection);
            cmd.Parameters.Add("@rs", SqlDbType.VarChar).Value = "0";
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
            MessageBox.Show("Shift reset!", "Manage shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ManageShift_Load(sender, e);
            check = true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0) return;
            ManualArrange frm = new ManualArrange();
            //if ((string)dataGridView1.CurrentCell.Value == "Empty") frm.iID = 0;
            //else frm.iID = int.Parse((string)dataGridView1.CurrentCell.Value);
            frm.shift = (string)dataGridView1.CurrentRow.Cells[0].Value;
            //I dont know how to get the DataPropertyName so I do it manually============
            if (dataGridView1.CurrentCell.ColumnIndex == 1) frm.day = "mo";
            else if (dataGridView1.CurrentCell.ColumnIndex == 2) frm.day = "tu";
            else if (dataGridView1.CurrentCell.ColumnIndex == 3) frm.day = "we";
            else if (dataGridView1.CurrentCell.ColumnIndex == 4) frm.day = "th";
            else if (dataGridView1.CurrentCell.ColumnIndex == 5) frm.day = "fr";
            else if (dataGridView1.CurrentCell.ColumnIndex == 6) frm.day = "sa";
            else if (dataGridView1.CurrentCell.ColumnIndex == 7) frm.day = "su";
            frm.ShowDialog();
            ManageShift_Load(sender, e);
        }

        private void button_Auto_Click(object sender, EventArgs e)
        {
            button_Reset_Click(sender, e);
            if (!check) return;
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("SELEct * FROM LogIn", db.getConnection);
            SqlDataAdapter apapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            db.openConnection();
            apapter.Fill(table);
            db.closeConnection();
            if (table.Rows.Count <= 0) return;
            List<String> id = new List<string>();
            for(int i=0;i<table.Rows.Count;i++)
            {
                id.Add(table.Rows[i][0].ToString());
            }
            List<int> shift = new List<int>();
            for(int i=0;i<id.Count-1;i++)
            {
                shift.Add((int)(21 / id.Count));
            }
            int row = 0;
            int col = 1;
            shift.Add((int)(21 - shift[0]* (id.Count - 1)));
            for(int i=0;i<id.Count;i++)
            {
                string s;
                string day;
                for(;shift[i]>0;shift[i]--)
                {
                    if (row == 0) s = "Morning";
                    else if (row == 1) s = "Noon";
                    else s = "Afternoon";
                    //===============================================
                    if (col == 1) day = "mo";
                    else if (col == 2) day = "tu";
                    else if (col == 3) day = "we";
                    else if (col == 4) day = "th";
                    else if (col == 5) day = "fr";
                    else if (col == 6) day = "sa";
                    else day = "su";
                    //===============================================
                    cmd = new SqlCommand("UPDATE Shift SET " + day + " = @id WHERE Shift = @shift", db.getConnection);
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id[i];
                    cmd.Parameters.Add("@shift", SqlDbType.VarChar).Value = s;
                    db.openConnection();
                    cmd.ExecuteNonQuery();
                    db.closeConnection();
                    col++;
                    if(col>=8)
                    {
                        col = 1;
                        row++;
                    }
                    if (row == 2 && col >= 8) break;
                }
            }
            MessageBox.Show("Shift arrenged!", "Arrange shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ManageShift_Load(sender, e);
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            ManageShift_Load(sender, e);
            if (comboBox1.Text == "Show all!") return;
            else
            {
                My_DB db = new My_DB();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Shift", db.getConnection);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                db.openConnection();
                adapter.Fill(table);
                db.closeConnection();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 1; j < table.Columns.Count; j++)
                    {
                        if(table.Rows[i][j].ToString()!=comboBox1.Text)
                        {
                            table.Rows[i][j] = "";
                        }
                    }
                }
                dataGridView1.DataSource = table;
            }
        }
    }
}
