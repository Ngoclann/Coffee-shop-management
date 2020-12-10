using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.dal
{
    class CategoryDao
    {
        public DataSet getAll()
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select * from category";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "category");
            conn.Close();
            return ds;
        }
    }
}
