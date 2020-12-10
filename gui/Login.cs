using CoffeeShopManagement.dal;
using CoffeeShopManagement.gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class Login : Form
    {
        UserDao userDao;
        public Login()
        {
            InitializeComponent();
            userDao = new UserDao();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (userDao.isExisted(username, password))
            {
                MainScreen mainScreen = new MainScreen(txtUsername.Text);
                mainScreen.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Username of password is incorrect");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
