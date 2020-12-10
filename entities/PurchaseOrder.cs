using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Entities
{
    public class PurchaseOrder
    {
        private string code;
        private string date;
        private string staffcode;
        private string providercode;
        private double amount;

        public PurchaseOrder()
        {

        }

        public PurchaseOrder(string code, string date, string staffcode, string providercode, double amount)
        {
            this.Code = code;
            this.Date = date;
            this.Staffcode = staffcode;
            this.Providercode = providercode;
            this.Amount = amount;
        }

        public string Code { get => code; set => code = value; }
        public string Date { get => date; set => date = value; }
        public string Staffcode { get => staffcode; set => staffcode = value; }
        public string Providercode { get => providercode; set => providercode = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}
