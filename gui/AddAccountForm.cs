using CoffeeShopManagement.dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement.gui
{
    public partial class AddAccountForm : Form
    {   
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("") || txtUsername.Text.Equals(""))
            {
                MessageBox.Show("Username and password can't not empty!");
                return;
            }
            UserDao userDao = new UserDao();
            if (userDao.isExistIUsername(txtUsername.Text))
            {
                MessageBox.Show("This account is already exist!");
            }
            else
            {
                userDao.insert(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Add acccount successfully");
                this.Dispose();
            }
        }
    }
}
