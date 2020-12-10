using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Entities
{
    public class Staff
    {
        private string code;
        private string name;
        private string address;
        private string sex;
        private string dob;
        private string phone;

        public Staff()
        {

        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
