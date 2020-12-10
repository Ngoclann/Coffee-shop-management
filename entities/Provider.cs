using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Entities
{
    public class Provider
    {
        private String code;
        private String name;
        private String address;
        private String phone;

        public Provider()
        {

        }

        public Provider(string code, string name, string address, string phone)
        {
            this.Code = code;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
