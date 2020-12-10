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
    public partial class FormCustomer : Form
    {
        CustomerDao customerDao = new CustomerDao();
        public FormCustomer()
        {
            InitializeComponent();
        }

        public void UpDataToGridView()
        {
            dgvCustomer.DataSource = null;
            dgvCustomer.Rows.Clear();         
            DataSet ds = customerDao.getAll();
            dgvCustomer.DataSource = ds.Tables["customers"];
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            UpDataToGridView();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose one Customer to delete");
                return;
            }
            DialogResult confirm = MessageBox.Show("Do you want to delete this provider", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                for (int i = 0; i < dgvCustomer.SelectedRows.Count; i++)
                {
                    string customerCode = dgvCustomer.SelectedRows[i].Cells[0].Value.ToString();
                    customerDao.deleteByCode(customerCode);
                }
                UpDataToGridView();
            }
                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerAction customerAction = new CustomerAction(this);
            customerAction.Show(this);
        }

        private void bt_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose one Customer to update information");
                return;
            }
            Customer customer = new Customer();
            customer.Code = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
            customer.Name = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
            customer.Address = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
            customer.Phone = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
            CustomerAction customerAction = new CustomerAction(customer, this);
            customerAction.Show();
        }
    }
}
