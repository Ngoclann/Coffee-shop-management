using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.dal
{
    class PurchaseDetailDao
    {   

        public DataSet getAll()
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select materialName, date, PurchaseDetail.price, quantity, discount, (quantity*PurchaseDetail.price) * (1 - discount/100) as amount from staff join PurchaseOrder"
            + " on staff.staffCode = PurchaseOrder.staffCode"
            + " join PurchaseDetail on PurchaseDetail.purchaseCode = PurchaseOrder.code"
            + " join Materials on PurchaseDetail.materialCode = Materials.materialCode";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "purchaseDetails");
            conn.Close();
            return ds;
        }
        public DataSet getByStaffCode(string staffCode)
        {
            SqlConnection conn = DBContext.GetConnection();
            conn.Open();
            String sql = "select materialName, date, PurchaseDetail.price, quantity, discount, (quantity*PurchaseDetail.price) * (1 - discount/100) as amount from staff join PurchaseOrder"
            + " on staff.staffCode = PurchaseOrder.staffCode"
            + " join PurchaseDetail on PurchaseDetail.purchaseCode = PurchaseOrder.code"
            + " join Materials on PurchaseDetail.materialCode = Materials.materialCode"
            + " where staff.staffCode = '" + staffCode + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "purchaseDetails");
            conn.Close();
            return ds;
        }
    }
}
