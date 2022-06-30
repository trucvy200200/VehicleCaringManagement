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
    public partial class RemoveStaff : Form
    {
        public RemoveStaff()
        {
            InitializeComponent();
        }

        private void RemoveStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDataSet2.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter1.Fill(this.finalProjectDataSet2.Login);
            

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            //Remove all the shift relate to this staff==================================
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Shift",db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            for(int i=0;i<table.Rows.Count;i++)
            {
                for(int j=1;j<=7;j++)
                {
                    if(table.Rows[i][j].ToString()==dataGridView1.CurrentRow.Cells[0].Value.ToString())
                    {
                        //day and shift are reverted!
                        string day = table.Rows[i][0].ToString();
                        string shift;
                        if (j == 1) shift = "mo";
                        else if (j == 2) shift = "tu";
                        else if (j == 3) shift = "we";
                        else if (j == 4) shift = "th";
                        else if (j == 5) shift = "fr";
                        else if (j == 6) shift = "sa";
                        else shift = "su";
                        cmd = new SqlCommand("UPDATE Shift SET " + shift + " = @id WHERE Shift = @shift", db.getConnection);
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = "0";
                        cmd.Parameters.Add("@shift", SqlDbType.VarChar).Value = day;
                        db.openConnection();
                        cmd.ExecuteNonQuery();
                        db.closeConnection();
                    }
                }
            }
            MessageBox.Show("Shift removed!","Remove shift",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button_RemoveStaff_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Removing staff may create gaps in the schedule!\nProceed to countinue?", "Remove staff"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.No:
                    return;
            }
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Shift", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (table.Rows[i][j].ToString() == dataGridView1.CurrentRow.Cells[0].Value.ToString())
                    {
                        //day and shift are reverted!
                        string day = table.Rows[i][0].ToString();
                        string shift;
                        if (j == 1) shift = "mo";
                        else if (j == 2) shift = "tu";
                        else if (j == 3) shift = "we";
                        else if (j == 4) shift = "th";
                        else if (j == 5) shift = "fr";
                        else if (j == 6) shift = "sa";
                        else shift = "su";
                        cmd = new SqlCommand("UPDATE Shift SET " + shift + " = @id WHERE Shift = @shift", db.getConnection);
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = "0";
                        cmd.Parameters.Add("@shift", SqlDbType.VarChar).Value = day;
                        db.openConnection();
                        cmd.ExecuteNonQuery();
                        db.closeConnection();
                    }
                }
            }
            //Remove staff===============================================================
            cmd = new SqlCommand("DELETE FROM LogIn WHERE Id = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            db.openConnection();
            if(cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Staff removed!", "Remove staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot remove staff!", "Remove staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }
    }
}
