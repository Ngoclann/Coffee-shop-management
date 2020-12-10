using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Entities
{
    public class PurchaseDetail
    {
        private string purchasecode;
        private string materialcode;
        private int quantity;
        private double price;
        private double amount;
        private double discount;
        public PurchaseDetail()
        {

        }

        public PurchaseDetail(string purchasecode, string materialcode, int quantity, double price, double amount, double discount)
        {
            this.Purchasecode = purchasecode;
            this.Materialcode = materialcode;
            this.Quantity = quantity;
            this.Price = price;
            this.Amount = amount;
            this.Discount = discount;
        }

        public string Purchasecode { get => purchasecode; set => purchasecode = value; }
        public string Materialcode { get => materialcode; set => materialcode = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public double Amount { get => amount; set => amount = value; }
        public double Discount { get => discount; set => discount = value; }
    }
}
