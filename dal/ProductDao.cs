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
    class ProductDao
    {
        public DataSet getAll(string categoryCode)
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "Select productCode, productName, purchasePrice as Cost, sellPrice, quantity, image  from Products where categoryCode = '" + categoryCode + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "products");
            conn.Close();
            return ds;
        }

        public bool isExisted(string productCode)
        {
            bool isExisted = false;
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from products where productCode = '" + productCode + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "product");
            if (ds.Tables["product"].Rows.Count > 0) isExisted = true;
            conn.Close();
            return isExisted;
        }

        public void insert(Product product)
        {
            SqlConnection conn = null;
            String sql = "insert into products(productCode, productName, categoryCode, purchasePrice, sellPrice, quantity, image)"
           + "values(@productCode, @productName, @categoryCode, @purchasePrice, @sellPrice, @quantity, @image)";
            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@productCode", SqlDbType.NVarChar).Value = product.Code;
                cmd.Parameters.Add("@productName", SqlDbType.NVarChar).Value = product.Name;
                cmd.Parameters.Add("@categoryCode", SqlDbType.NVarChar).Value = product.Categorycode;
                cmd.Parameters.Add("@purchasePrice", SqlDbType.Money).Value = product.PurchasePrice;
                cmd.Parameters.Add("@sellPrice", SqlDbType.Money).Value = product.SellPrice;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = product.Quantity;
                cmd.Parameters.Add("@image", SqlDbType.NVarChar).Value = product.Image;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
        }

        public void edit(Product product)
        {
            SqlConnection conn = null;
            String sql = "UPDATE products SET productName = @productName, categoryCode = @categoryCode, purchasePrice = @purchasePrice," +
                " sellPrice = @sellPrice, image = @image, quantity = @quantity WHERE productCode = @productCode";

            try
            {
            
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@productName", SqlDbType.NVarChar).Value = product.Name;
                cmd.Parameters.Add("@categoryCode", SqlDbType.NVarChar).Value = product.Categorycode;
                cmd.Parameters.Add("@purchasePrice", SqlDbType.Money).Value = product.PurchasePrice;
                cmd.Parameters.Add("@sellPrice", SqlDbType.Money).Value = product.SellPrice;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = product.Quantity;
                cmd.Parameters.Add("@image", SqlDbType.NVarChar).Value = product.Image;
                cmd.Parameters.Add("@productCode", SqlDbType.NVarChar).Value = product.Code;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void deleteByCode(String productCode)
        {
            SqlConnection conn = null;
            String sql = "delete from products where productCode = @productCode";
            try
            {
                conn = DBContext.GetConnection();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@productCode", SqlDbType.NVarChar).Value = productCode;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
        }
    }
}
