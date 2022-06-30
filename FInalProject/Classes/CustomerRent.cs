using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject
{
    class CustomerRent
    {
        My_DB mydb = new My_DB();
        public int autoCertID()
        {
            SqlCommand cmd = new SqlCommand("Select max(Id) from Rent");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];
            return Convert.ToInt32(dr[0].ToString()) + 1;
        }
        public bool add_RentCert(int id, string cname, string add, string phone, int vid, int duration, double price)
        {
            SqlCommand command = new SqlCommand("insert into Rent(Id, CusName, Address, Phone, VehicleID, Duration, Price, RentTime)" + "VALUES (@id, @cn, @add, @phone, @vid, @dur, @price,@rtime)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cn", SqlDbType.NVarChar).Value = cname;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = add;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@vid", SqlDbType.Int).Value = vid;
            command.Parameters.Add("@dur", SqlDbType.Int).Value =duration;
            command.Parameters.Add("@rtime", SqlDbType.DateTime).Value = DateTime.Now;
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
        CustomerSupply su = new CustomerSupply();
        public string checkRentConStatus(int id)
        {
            SqlCommand cmd = new SqlCommand("Select Duration, RentTime from Rent " +
                    " where Id = @num");
            cmd.Parameters.Add("@num", SqlDbType.Int).Value = id;
            DataTable table = su.GetRentVehicle(cmd);
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
        public string checkVehicleStatus(int id)
        {
            SqlCommand cmd = new SqlCommand("Select Duration, TimeIn from Supply " +
                    " where VehicleID = @num");
            cmd.Parameters.Add("@num", SqlDbType.Int).Value = id;
            DataTable table = su.GetRentVehicle(cmd);
            if (Convert.ToDateTime(table.Rows[0].ItemArray[0])> DateTime.Now)
            {
                return "Validated";
            }
            else
            {
                return "Out of date";
            }
        }
        public bool checkVehicleID(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * From RentVehicle Where id=@id", mydb.getConnection);
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
        public bool checkVehicleInRent(int vid)
        {
            SqlCommand cmd = new SqlCommand("Select * From Rent Where VehicleID=@vid", mydb.getConnection);
            cmd.Parameters.Add("@vid", SqlDbType.Int).Value = vid;
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
        public bool checkContractID(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * From Rent Where id=@id", mydb.getConnection);
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
        public bool Remove_RentCon(int id)
        {
            SqlCommand command = new SqlCommand("delete from Rent where id = @id", mydb.getConnection);

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
