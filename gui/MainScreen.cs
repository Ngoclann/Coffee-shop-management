using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement.gui
{
    public partial class MainScreen : Form
    {
        string username;
        public MainScreen(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private Form getExistedForm(Type formType)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.GetType() == formType) return f;
            }
            return null;
        }

        private void imputDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stafffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = getExistedForm(typeof(StaffForm));
            if (form == null)
            {
                StaffForm staffForm = new StaffForm();
                staffForm.MdiParent = this;
                staffForm.Show();
            }
            else
            {
                form.Activate();
            }
            
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = getExistedForm(typeof(FormCustomer));
            if (form == null)
            {
                FormCustomer customerForm = new FormCustomer();
                customerForm.MdiParent = this;
                customerForm.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void providerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = getExistedForm(typeof(ProviderForm));
            if (form == null)
            {
                ProviderForm providerForm = new ProviderForm();
                providerForm.MdiParent = this;
                providerForm.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = getExistedForm(typeof(ProductForm));
            if (form == null)
            {
                ProductForm productForm = new ProductForm();
                productForm.MdiParent = this;
                productForm.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void addAcountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccountForm form = new AddAccountForm();
            form.MdiParent = this;
            form.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(username);
            form.MdiParent = this;
            form.Show();
        }

        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
