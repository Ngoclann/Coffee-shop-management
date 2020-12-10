using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Entities
{
    public class Product
    {
        private string code;
        private string name;
        private string categorycode;
        private double purchasePrice;
        private double sellPrice;
        private int quantity;
        private string image;

        public Product()
        {

        }

        public override string ToString()
        {
            return code + " " + name + " " + categorycode + " " + purchasePrice + " " + sellPrice + " " + quantity + " " + image;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Categorycode { get => categorycode; set => categorycode = value; }
        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public double SellPrice { get => sellPrice; set => sellPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Image { get => image; set => image = value; }
    }
}
