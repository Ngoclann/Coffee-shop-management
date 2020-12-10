using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Entities
{
    public class SellOrder
    {
        private string code;
        private string date;
        private string staffcode;
        private string customercode;
        private double amount;

        public SellOrder()
        {

        }

        public SellOrder(string code, string date, string staffcode, string customercode, double amount)
        {
            this.Code = code;
            this.Date = date;
            this.Staffcode = staffcode;
            this.Customercode = customercode;
            this.Amount = amount;
        }

        public string Code { get => code; set => code = value; }
        public string Date { get => date; set => date = value; }
        public string Staffcode { get => staffcode; set => staffcode = value; }
        public string Customercode { get => customercode; set => customercode = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}
