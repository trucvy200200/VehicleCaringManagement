using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    class Staff
    {
        My_DB db = new My_DB();
        public bool AddToDataBase(int id, string user, string password, string email, string type, string firstname, string lastname)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Login (Id, username, password, Email, Type, Firstname, LastName) " +
                " VALUES (@id, @username, @password, @email, @type, @firstname, @lastname)", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = firstname;
            cmd.Parameters.Add("@lastname", SqlDbType.VarChar).Value = lastname;
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("New staff added!", "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Fail to add new staff", "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
                return false;
            }
        }
        public DataTable GetStaff(SqlCommand cmd)
        {
            cmd.Connection = db.getConnection;
            DataTable table = new DataTable();
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }
        public bool updateStaff(int id, string user, string mail, string type, string fname, string lname)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("update Login set username=@us, " +
                "email=@email, type=@ty,firstname=@fname,lastname=@lname where Id=@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@us", SqlDbType.VarChar).Value = user;

            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = mail;
            cmd.Parameters.Add("@ty", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            if (cmd.ExecuteNonQuery() == 1)
            {
                //MessageBox.Show("New staff added!", "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                return true;
            }
            else
            {
               // MessageBox.Show("Fail to add new staff", "Add new staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
                return false;
            }
        }
        public bool checkStaffID(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * From Login Where Id=@id", db.getConnection);
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
        public bool checkUsername(int id, string user)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login where username=@user and Id<>@id", db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
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
    }
}
