using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Entities

{
    public class Category
    {
        private String code;
        private String name;
        public Category()
        {

        }

        public Category(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
    }
}
