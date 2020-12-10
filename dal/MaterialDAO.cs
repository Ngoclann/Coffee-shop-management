using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.dal
{
    class MaterialDAO
    {
        public bool isExisted(string materialCode)
        {
            bool isExisted = false;
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from materials where materialCode = '" + materialCode + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "materials");
            if (ds.Tables["materials"].Rows.Count > 0) isExisted = true;
            conn.Close();
            return isExisted;
        }

        public DataSet getAll(string providerCode)
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from materials where providerCode = '" + providerCode + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "materials");
            conn.Close();
            return ds;
        }
    }
}
