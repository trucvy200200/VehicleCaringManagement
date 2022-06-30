using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject
{
    class CustomerSupply
    {
        My_DB mydb = new My_DB();
        public int autoVehicleID()
        {
            SqlCommand cmd = new SqlCommand("Select max(Id) from RentVehicle");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];
            return Convert.ToInt32(dr[0].ToString()) + 1;
        }
        public int autoCertID()
        {
            SqlCommand cmd = new SqlCommand("Select max(Id) from Supply");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];
            return Convert.ToInt32(dr[0].ToString()) + 1;
        }
        public bool add_SupplyCert(int id, string oname, int vid, DateTime duration, double price)
        {
            SqlCommand command = new SqlCommand("insert into Supply(Id, OwnerName, VehicleID, Duration, TimeIn, Price)" + "VALUES (@id, @on, @vid, @dur, @in, @price)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@on", SqlDbType.NVarChar).Value = oname;
            command.Parameters.Add("@vid", SqlDbType.Int).Value = vid;
            command.Parameters.Add("@dur", SqlDbType.DateTime).Value = duration;
            command.Parameters.Add("@in", SqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@price", SqlDbType.Float).Value = price;
            
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;

            }
        }
        public bool add_RentVehicle(int id, MemoryStream back, string num, MemoryStream cuspic, string type, string add, string phone)
        {
            SqlCommand command = new SqlCommand("insert into RentVehicle(Id, Back, Number, CustomerImage, Type, Address, Phone)" + "VALUES (@id, @back,  @num, @pic, @type, @add, @phone)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@back", SqlDbType.Image).Value = back.ToArray();
            command.Parameters.Add("@num", SqlDbType.VarChar).Value = num;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = cuspic.ToArray();
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = add;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;

            }
        }
        public bool checkRentVehicleNumber(string num)
        {
            if (num != "None")
            {
                SqlCommand cmd = new SqlCommand("Select * From RentVehicle Where Number=@num", mydb.getConnection);
                cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;
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
            else return false;
        }
        public DataTable GetRentVehicle(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            DataTable table = new DataTable();
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public string checkSupplyConStatus(int id)
        {
            SqlCommand cmd = new SqlCommand("Select Duration, InTime from Supply " +
                    " where Id = @num");
            cmd.Parameters.Add("@num", SqlDbType.Int).Value = id;
            DataTable table = GetRentVehicle(cmd);
            DateTime d = Convert.ToDateTime(table.Rows[0].ItemArray[1]).AddHours(Convert.ToInt32(table.Rows[0].ItemArray[0]));
            if (d > DateTime.Now)
            {
                return "Validated";
            }
            else
            {
                return "Out of date";
            }
        }
        public bool Remove_SupplyCon(int id)
        {
            SqlCommand command = new SqlCommand("delete from Supply where id = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;

            }
        }
    }
}
