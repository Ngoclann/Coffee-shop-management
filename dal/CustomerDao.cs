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
    class CustomerDao
    {
        public DataSet getAll()
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from customers";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "customers");
            conn.Close();
            return ds;
        }

        public bool isExisted(string customerCode)
        {
            bool isExisted = false;
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from customers where customerCode = '" + customerCode + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "customer");
            if (ds.Tables["customer"].Rows.Count > 0) isExisted = true;
            conn.Close();
            return isExisted;
        }

        public void edit(Customer customer)
        {
            SqlConnection conn = null;
            String sql = "UPDATE customers SET customerName = @customerName, addressName = @addressName, phoneNumber = @phoneNumber WHERE customerCode = @customerCode";

            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@customerName", SqlDbType.NVarChar).Value = customer.Name;
                cmd.Parameters.Add("@addressName", SqlDbType.NVarChar).Value = customer.Address;
                cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = customer.Phone;
                cmd.Parameters.Add("@customerCode", SqlDbType.NVarChar).Value = customer.Code;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void insert(Customer customer)
        {
            SqlConnection conn = null;
            String sql = "insert into customers(customerCode, customerName, addressName, phoneNumber) values(@customerCode, @customerName, @addressName, @phoneNumber)";

            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@customerName", SqlDbType.NVarChar).Value = customer.Name;
                cmd.Parameters.Add("@addressName", SqlDbType.NVarChar).Value = customer.Address;
                cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = customer.Phone;
                cmd.Parameters.Add("@customerCode", SqlDbType.NVarChar).Value = customer.Code;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void deleteByCode(String customerCode)
        {
            SqlConnection conn = null;
            String sql = "delete from customers where customerCode = @customerCode";
            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@customerCode", SqlDbType.NVarChar).Value = customerCode;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
