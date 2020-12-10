using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.dal
{
    class UserDao
    {
        public bool isExisted(string username, string password)
        {
            bool isExisted = false;
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from users where username = '" + username + "'" + "and password = '" + password + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "users");
            if (ds.Tables["users"].Rows.Count > 0) isExisted = true;
            conn.Close();  
            return isExisted;
        }


        public string getPasswordByUsername(String username)
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select password from users where username = '" + username + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "users");
            if (ds.Tables["users"].Rows.Count > 0) return ds.Tables["users"].Rows[0].ItemArray[0].ToString();
            return "";
        }

        public void changePassword(string username, string password)
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "update users set password = @password where username = @username";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            cmd.ExecuteNonQuery();
        }

        public bool isExistIUsername(string username)
        {
            bool isExisted = false;
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from users where username = '" + username + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "users");
            if (ds.Tables["users"].Rows.Count > 0) isExisted = true;
            conn.Close();
            return isExisted;
        }

        public void insert(string username, string password)
        {
            SqlConnection conn = null;
            String sql = "insert into users(username, password) values(@username, @password)";
            conn = DBContext.GetConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                cmd.ExecuteNonQuery();
           
        }
    }
}
