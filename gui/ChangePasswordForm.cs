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
    public partial class ChangePasswordForm : Form
    {
        private string username;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public ChangePasswordForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserDao userDao = new UserDao();
            if (userDao.getPasswordByUsername(username).Equals(txtPassword.Text) == false)
            {
                MessageBox.Show("Old password is incorrect!");
                return;
            }

            if (txtNewPassword.Text.Equals(txtConfirmPassword.Text) == false)
            {
                MessageBox.Show("The confirm password doesn't match with new password");
                return;
            }
            userDao.changePassword(username, txtNewPassword.Text);
            MessageBox.Show("Change password successfully");
            this.Dispose();
        }
    }
}
