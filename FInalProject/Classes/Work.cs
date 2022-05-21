using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject
{
    class Work
    {
        My_DB mydb = new My_DB();
        public bool insertWork(int Id, string Name, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Work (id, name, description)" +
                "VALUES (@id, @name, @desc)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = description;

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

        public bool EditWork(int ID, string Name, string description)
        {
            SqlCommand command = new SqlCommand("Update Work set name=@name, description=@descr where id=@id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;
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
        public bool RemoveWork(int id)
        {
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("Delete from Work where id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            if ((cmd.ExecuteNonQuery() == 1))
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
        public bool checkWorkName(string Name, int ID = 0)
        {
            SqlCommand cmd = new SqlCommand("Select * From Work Where name=@Name and id<>@id", mydb.getConnection);
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable getAllWork()
        {
            SqlCommand cmd = new SqlCommand("select * from Work", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getWorkByID(int ID)
        {
            SqlCommand cmd = new SqlCommand("Select * from work where id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalWorks()
        {
            return execCount("Select count(*) from Work");
        }
    }
}
