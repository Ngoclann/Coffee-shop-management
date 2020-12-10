using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Entities
{
    public class User
    {
        private String username;
        private String password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public User()
        {

        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
