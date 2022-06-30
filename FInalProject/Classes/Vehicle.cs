using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    class Vehicle
    {
        My_DB db = new My_DB();
        public Vehicle() { }
        public void AddToShortGarage(MemoryStream BackImage, string VehicleNumber, MemoryStream Driver,
            DateTime TimeIn, int Duration, string type)
        {
            if (!CheckFull(type, "Short"))
            {
                MessageBox.Show("Garage is full", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            My_DB db = new My_DB();
            DataTable table = new DataTable();
            //GetID==================================================
            SqlCommand cmd = new SqlCommand("SELECT MAX(Id) FROM Vehicle", db.getConnection);
            db.openConnection();
            int id = 1;
            object test = cmd.ExecuteScalar();
            if (test.ToString() !="")
            {
                id = (int)test;
                id++;
            }
            db.closeConnection();
            //Add====================================================
            cmd = new SqlCommand("INSERT INTO Vehicle (Id, Back, Number, Driver, TimeIn, Duration, Type, Garage) " +
                " VALUES (@id, @back, @num, @driver, @in, @out, @type, @garage)", db.getConnection);
            db.openConnection();
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@back", SqlDbType.Image).Value = BackImage.ToArray();
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = VehicleNumber;
            cmd.Parameters.Add("@driver", SqlDbType.Image).Value = Driver.ToArray();
            cmd.Parameters.Add("@in", SqlDbType.DateTime).Value = TimeIn;
            cmd.Parameters.Add("@out", SqlDbType.Int).Value = Duration;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@garage", SqlDbType.VarChar).Value = "Short";
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Vehicle added!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fail to add new vehicle!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
                return;
            }
            //ToShortGarage==========================================
            cmd = new SqlCommand("INSERT INTO ShortGarage (Id) VALUES (@id)", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            if (cmd.ExecuteNonQuery() != 1) 
            {
                MessageBox.Show("Fail to add new vehicle to garage!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Reduce capacity========================================
            if (type == "Bike") type = "Moto";
                cmd = new SqlCommand("SELECT Short" + type + " FROM Capacity", db.getConnection);
                //Reuse the "id"
                id = (int)cmd.ExecuteScalar();
                id--;
                cmd = new SqlCommand("UPDATE Capacity SET Short" + type + " = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                //cmd.Parameters.Add("@decoy", SqlDbType.Int).Value = id + 1;
                if (cmd.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Fail to adjust the garage capcity!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
            db.closeConnection();
        }
        public void AddToLongGarage(MemoryStream BackImage, string VehicleNumber, MemoryStream Driver,
            DateTime TimeIn, int Duration, string type)
        {
            if (!CheckFull(type, "Long"))
            {
                MessageBox.Show("Garage is full", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            My_DB db = new My_DB();
            DataTable table = new DataTable();
            //GetID==================================================
            SqlCommand cmd = new SqlCommand("SELECT MAX(Id) FROM Vehicle", db.getConnection);
            db.openConnection();
            int id = 1;
            object test = cmd.ExecuteScalar();
            if (test.ToString() != "")
            {
                id = (int)test;
                id++;
            }
            db.closeConnection();
            //Add====================================================
            cmd = new SqlCommand("INSERT INTO Vehicle (Id, Back, Number, Driver, TimeIn, Duration, Type, Garage) " +
                " VALUES (@id, @back, @num, @driver, @in, @out, @type, @garage)", db.getConnection);
            db.openConnection();
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@back", SqlDbType.Image).Value = BackImage.ToArray();
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = VehicleNumber;
            cmd.Parameters.Add("@driver", SqlDbType.Image).Value = Driver.ToArray();
            cmd.Parameters.Add("@in", SqlDbType.DateTime).Value = TimeIn;
            cmd.Parameters.Add("@out", SqlDbType.Int).Value = Duration;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@garage", SqlDbType.VarChar).Value = "Long";
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Vehicle added!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fail to add new vehicle!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
                return;
            }
            //ToShortGarage==========================================
            cmd = new SqlCommand("INSERT INTO LongGarage (Id) VALUES (@id)", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            if (cmd.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Fail to add new vehicle to garage!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Reduce capacity========================================
            if (type == "Bike") type = "Moto";
            cmd = new SqlCommand("SELECT Long" + type + " FROM Capacity", db.getConnection);
            //Reuse the "id"
            id = (int)cmd.ExecuteScalar();
            id--;
            cmd = new SqlCommand("UPDATE Capacity SET Long" + type + " = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            if (cmd.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Fail to adjust the garage capcity!", "Add new vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            db.closeConnection();
        }
        public bool CheckFull(string type, string Garage)
        {
            if (type == "Bike") return true;
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Capacity", db.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.openConnection();
            adapter.Fill(table);
            if (int.Parse(table.Rows[0][Garage + type].ToString()) > 0) return true;
            return false;
        }
        public DataTable GetVehicle(SqlCommand cmd)
        {
            cmd.Connection = db.getConnection;
            DataTable table = new DataTable();
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }
        
        public bool checkVehicleID(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * From Vehicle Where id=@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveVehicle(int id, int fee)
        {
            //if(!checkVehicleID(id))
            //{
            //    MessageBox.Show("ID not found!", "Remove vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //Check id===================================================================
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicle WHERE ID = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            db.openConnection();
            adapter.Fill(table);
            if(table.Rows.Count<=0)
            {
                MessageBox.Show("ID not found!", "Remove vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
                return;
            }
            string garage = (string)table.Rows[0]["Garage"];
            //Remove from Vehicle========================================================
            cmd = new SqlCommand("DELETE FROM Vehicle WHERE ID = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            if(cmd.ExecuteNonQuery()==0)
            {
                MessageBox.Show("Fail to remove from database!", "Remove vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
                return;
            }
            //Remove from Garage=========================================================
            cmd = new SqlCommand("DELETE FROM " + garage + "Garage WHERE ID = @id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            if (cmd.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Fail to remove from database!", "Remove vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
                return;
            }
            //Increase capacity==========================================================
            //Get capacity=
            string type = (string)table.Rows[0]["Type"];
            if (type == "Bike") type = "Moto";
            cmd = new SqlCommand("UPDATE Capacity SET " + garage + type + " = " + garage + type + " + 1", db.getConnection);
            if(cmd.ExecuteNonQuery()==0)
            {
                MessageBox.Show("Fail to adjust capacity!", "Remove vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
                return;
            }
            //Update revenue=============================================================
            cmd = new SqlCommand("SELECT * FROM Revenue WHERE Datee = @date", db.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.Date;
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            //New date===============================================
            if(table.Rows.Count==0)
            {
                cmd = new SqlCommand("INSERT INTO Revenue VALUES (@date, @money)", db.getConnection);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.Date;
                cmd.Parameters.Add("@money", SqlDbType.Int).Value = fee;
                if(cmd.ExecuteNonQuery()==0)
                {
                    MessageBox.Show("Fail to adjust revenue!", "Remove vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeConnection();
                    return;
                }
            }
            //Update the existed data================================
            else
            {
                cmd = new SqlCommand("UPDATE Revenue SET Money = Money + @fee WHERE Datee = @date", db.getConnection);
                cmd.Parameters.Add("@fee", SqlDbType.Int).Value = fee;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.Date;
                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Fail to adjust revenue!", "Remove vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeConnection();
                    return;
                }
            }
            MessageBox.Show("Vehicle removed!", "Remove car", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.closeConnection();
        }
    }
}
