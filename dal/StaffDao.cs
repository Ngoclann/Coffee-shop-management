using CoffeeShopManagement.Entities;
using System;
using System.Data;
using System.Data.SqlClient;


namespace CoffeeShopManagement.dal
{
    class StaffDao
    {
        public DataSet getAll()
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from staff";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "staff");
            conn.Close();
            return ds;
        }

        public void insert(Staff staff)
        {
            SqlConnection conn = null;
            String sql = "insert into staff(staffCode, staffName, address, sex, dob, phoneNumber) "
           + "values(@staffCode, @staffName, @address, @sex, @dob, @phoneNumber)";
            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@staffCode", SqlDbType.NVarChar).Value = staff.Code;
                cmd.Parameters.Add("@staffName", SqlDbType.NVarChar).Value = staff.Name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = staff.Address;
                cmd.Parameters.Add("@sex", SqlDbType.NVarChar).Value = staff.Sex;
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = staff.Dob;
                cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = staff.Phone;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
        }

        public  void edit(Staff staff)
        {
            SqlConnection conn = null;
            String sql = "UPDATE staff SET staffName = @staffName, address = @address, sex = @sex, dob = @dob," +
             "phoneNumber = @phoneNumber WHERE staffCode = @staffCode";

            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@staffName", SqlDbType.NVarChar).Value = staff.Name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = staff.Address;
                cmd.Parameters.Add("@sex", SqlDbType.NVarChar).Value = staff.Sex;
                cmd.Parameters.Add("@dob", SqlDbType.NVarChar).Value = staff.Dob;
                cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = staff.Phone;
                cmd.Parameters.Add("@staffCode", SqlDbType.NVarChar).Value = staff.Code;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public bool isExisted(string staffCode)
        {
            bool isExisted = false;
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from staff where staffCode = '" + staffCode + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "staff");
            if (ds.Tables["staff"].Rows.Count > 0) isExisted = true;
            conn.Close();
            return isExisted;
        }

        public void deleteByCode(String staffCode)
        {
            SqlConnection conn = null;
            String sql = "delete from staff where staffCode = @staffCode";
            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@staffCode", SqlDbType.NVarChar).Value = staffCode;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
           
        }
    }
}
