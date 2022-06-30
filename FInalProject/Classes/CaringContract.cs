using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject
{
    class CaringContract
    {
        My_DB mydb = new My_DB();
        public bool add_CareCert(int id, int cusid, string cname, int vid, string add,double total)
        {
            SqlCommand command = new SqlCommand("insert into CaringCertificate(CertificateId, Date, CustomerID, CustomerName, VehicleID, Address, TotalPrice)" + "VALUES (@id, @date,  @cid, @cname,@vid,@add,@total)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cusid;
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = cname;
            command.Parameters.Add("@vid", SqlDbType.Int).Value = vid;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = add;
            command.Parameters.Add("@total", SqlDbType.Float).Value = total;
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
        public bool update_TotalPrice(double total, int id)
        {
            SqlCommand command = new SqlCommand("update CaringCertificate set TotalPrice = @total where CertificateId = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@total", SqlDbType.NVarChar).Value = total;

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
        public bool update_CareCert(int id, DateTime date, int cid, string cname, int vid, string add, double total)
        {
            SqlCommand command = new SqlCommand("update CaringCertificate set Date=@date,CustomerID=@cid,CustomerName=@cname,VehicleID=@vid, "
                +"address=@add, TotalPrice = @total where CertificateId = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = cname;
            command.Parameters.Add("@vid", SqlDbType.Int).Value = vid;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = add;
            command.Parameters.Add("@total", SqlDbType.Float).Value = total;

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
        public bool deleteCareCert(int CertID)
        {
            SqlCommand cmd = new SqlCommand("delete from CaringCertificate where CertificateId=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = CertID;
           
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Total_Price(int id)
        {
            SqlCommand cmd = new SqlCommand("select sum(WorkPrice) from CaringCertificateDetail where CertificateId=@id group by CertificateId", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Convert.ToDouble(table.Rows[0].ItemArray[0]);
        }
        public int autoCertID()
        {
            SqlCommand cmd = new SqlCommand("Select max(CertificateId) from CaringCertificate");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];
            return Convert.ToInt32(dr[0].ToString()) + 1;
        }
        public int autoCustomerID()
        {
            SqlCommand cmd = new SqlCommand("Select max(CustomerID) from CaringCertificate");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];
            return Convert.ToInt32(dr[0].ToString()) + 1;
        }
        public bool addCareCertDetail(int id, int wid, double price, int sid)
        {
            SqlCommand command = new SqlCommand("insert into CaringCertificateDetail(CertificateId, WorkID, WorkPrice, StaffID)" + "VALUES (@id, @wid, @price, @sid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@wid", SqlDbType.Int).Value = wid;
            command.Parameters.Add("@price", SqlDbType.Float).Value = price;
            command.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
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
        public DataTable getCertDetail(int certID)
        {
            SqlCommand cmd = new SqlCommand("Select WorkID as 'Service ID', b.Name as 'Service Name', WorkPrice as 'Price', StaffID as 'Staff ID'"
                + " from CaringCertificateDetail a inner join Work b on a.WorkID=b.Id where CertificateId=@certid ",mydb.getConnection);
            cmd.Parameters.Add("@certid", SqlDbType.Int).Value = certID;
            DataTable table = new DataTable();
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public bool deleteCareCertDetail(int certID, int wID)
        {
            SqlCommand cmd = new SqlCommand("delete from CaringCertificateDetail where CertificateId=@cid and WorkID=@wid", mydb.getConnection);
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = certID;
            cmd.Parameters.Add("@wid", SqlDbType.Int).Value = wID;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkSeviceExist(int certID, int wID)
        {
            SqlCommand cmd = new SqlCommand("select * from CaringCertificateDetail where CertificateId=@cid and WorkID=@wid", mydb.getConnection);
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = certID;
            cmd.Parameters.Add("@wid", SqlDbType.Int).Value = wID;
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
        public DataTable GetContract(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            DataTable table = new DataTable();
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public DataTable getAllConDetail()
        {
            SqlCommand cmd = new SqlCommand("Select CertificateId as 'Contract ID', WorkID as 'Service ID', b.Name as 'Service Name', WorkPrice as 'Price', StaffID as 'Staff ID'"
                + " from CaringCertificateDetail a inner join Work b on a.WorkID=b.Id ", mydb.getConnection);
          
            DataTable table = new DataTable();
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            mydb.closeConnection();
            return table;
        }
    }
}
