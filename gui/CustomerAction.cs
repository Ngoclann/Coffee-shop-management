using CoffeeShopManagement.dal;
using CoffeeShopManagement.Entities;
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
    public partial class CustomerAction : Form
    {
        FormCustomer customerForm;
        string type;
        Customer customer;
        public CustomerAction(FormCustomer customerForm)
        {
            InitializeComponent();
            this.customerForm = customerForm;
            type = "Add";
            btnAction.Text = "Add";
        }

        public CustomerAction(Customer customer, FormCustomer customerForm)
        {
            InitializeComponent();
            this.customerForm = customerForm;
            this.customer = customer;
            type = "Edit";
            btnAction.Text = "Edit";
        }


        private void CustomerAction_Load(object sender, EventArgs e)
        {
            if (type.Equals("Edit"))
            {
                txtName.Text = customer.Name;
                txtAddress.Text = customer.Address;
                txtCode.Text = customer.Code;
                txtPhone.Text = customer.Phone;
                txtCode.ReadOnly = true;
            }
            else
                customer = new Customer();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = txtCode.Text = txtName.Text = txtPhone.Text = "";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {

            CustomerDao customerDao = new CustomerDao();
            customer.Code = txtCode.Text;
            customer.Address = txtAddress.Text;
            customer.Name = txtName.Text;
            customer.Phone = txtPhone.Text;
            if (type.Equals("Add"))
            {
                if (txtCode.Text.Equals(""))
                {
                    MessageBox.Show("StaffCode can not be empty!");
                    return;
                }
                if (customerDao.isExisted(customer.Code) == true)
                {
                    MessageBox.Show("This customerCode is existed, choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                customerDao.insert(customer);
                MessageBox.Show("Add successfully!");
            }
            else
            {
                if (type.Equals("Edit")) customerDao.edit(customer);
                MessageBox.Show("Edit successfully!");
            }
               
            customerForm.UpDataToGridView();
            this.Dispose();
        }
    }
}
