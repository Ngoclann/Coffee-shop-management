using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace CoffeeShopManagement.dal
{
    class DBContext
    {
        public static SqlConnection GetConnection()
        {
            string connString =  ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            //string connString = @"Data Source=" + datasource + ";Initial Catalog="
            //        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
