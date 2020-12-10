using CoffeeShopManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.dal
{
    class ProviderDao
    {

        public bool isExisted(string providerCode)
        {
            bool isExisted = false;
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from providers where providerCode = '" + providerCode + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "providers");
            if (ds.Tables["providers"].Rows.Count > 0) isExisted = true;
            conn.Close();
            return isExisted;
        }

        public DataSet getByCode(string providerCode)
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from providers where providerCode = '" + providerCode + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "providers");
            conn.Close();
            return ds;
        }
        public DataSet getAll()
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from providers";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "providers");
            conn.Close();
            return ds;
        }

        public void edit(Provider provider)
        {
            SqlConnection conn = null;
            String sql = "UPDATE staff SET providerName = @providerName, address = @address, phoneNumber = @phoneNumber WHERE providerCode = @providerCode";

            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@providerCode", SqlDbType.NVarChar).Value = provider.Code;
                cmd.Parameters.Add("@providerName", SqlDbType.NVarChar).Value = provider.Name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = provider.Address;
                cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = provider.Phone;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
        }

        public void insert(Provider provider)
        {
            SqlConnection conn = null;
            String sql = "insert into providers(providerCode, providerName, address, phoneNumber) "
           + "values(@providerCode, @providerName, @address, @phoneNumber)";
            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@providerCode", SqlDbType.NVarChar).Value = provider.Code;
                cmd.Parameters.Add("@providerName", SqlDbType.NVarChar).Value = provider.Name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = provider.Address;
                cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = provider.Phone;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
        }

        public void deleteByCode(String providerCode)
        {
            SqlConnection conn = null;
            String sql = "delete from providers where providerCode = @providerCode";
            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@providerCode", SqlDbType.NVarChar).Value = providerCode;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
           
        }
    }
}
