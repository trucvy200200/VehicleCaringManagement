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
    }
}
