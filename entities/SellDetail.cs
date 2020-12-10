using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Entities
{
    public class SellDetail
    {
        private string sellcode;
        private string productcode;
        private int quantity;
        private double amount;
        private double discount;
        public SellDetail()
        {

        }

        public SellDetail(string sellcode, string productcode, int quantity, double amount, double discount)
        {
            this.Sellcode = sellcode;
            this.Productcode = productcode;
            this.Quantity = quantity;
            this.Amount = amount;
            this.Discount = discount;
        }

        public string Sellcode { get => sellcode; set => sellcode = value; }
        public string Productcode { get => productcode; set => productcode = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Amount { get => amount; set => amount = value; }
        public double Discount { get => discount; set => discount = value; }
    }
}
