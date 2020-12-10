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
    public partial class ProviderForm : Form
    {
        ProviderDao providerDao = new ProviderDao();
        MaterialDAO materialDao = new MaterialDAO();
        public ProviderForm()
        {
            InitializeComponent();
        }

        public void loadDataProvider()
        {
            cbxProvider.DataSource = providerDao.getAll().Tables["providers"];
            cbxProvider.DisplayMember = "providerName";
            cbxProvider.ValueMember = "providerCode";
            cbxProvider.SelectedIndex = 0;
        }

        public void loadDataToTextBox()
        {
                txtCode.Text = cbxProvider.SelectedValue.ToString();
                DataSet ds = providerDao.getByCode(txtCode.Text);
                if (ds.Tables["providers"].Rows.Count >= 1)
                {
                txtAddress.Text = ds.Tables["providers"].Rows[0].ItemArray[2].ToString();
                txtPhone.Text = ds.Tables["providers"].Rows[0].ItemArray[3].ToString();
                }
                        
        }

        public void loadDataMaterial()
        {
            string providerCode = cbxProvider.SelectedValue.ToString();
            dgvMaterial.DataSource = materialDao.getAll(providerCode).Tables["materials"];
        }
        private void ProviderForm_Load(object sender, EventArgs e)
        {
            loadDataProvider();
            loadDataMaterial();
            loadDataToTextBox();
            txtName.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataMaterial();
            loadDataToTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to delete this provider", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                providerDao.deleteByCode(cbxProvider.SelectedValue.ToString());
                loadDataProvider();
                loadDataMaterial();
                loadDataToTextBox();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Visible == false)
            {
                btnDelete.Enabled = btnUpdate.Enabled = false;
                cbxProvider.Visible = false;
                txtName.Visible = true;
                txtPhone.Text = txtName.Text = txtCode.Text = txtAddress.Text = "";
                dgvMaterial.DataSource = "";
            }
            else
            {
                btnDelete.Enabled = btnUpdate.Enabled = true;
                cbxProvider.Visible = true;
                txtName.Visible = false;
                Provider provider = new Provider(txtCode.Text, txtName.Text, txtAddress.Text, txtPhone.Text);
                providerDao.insert(provider);
                MessageBox.Show("Add provider successfully!");
                loadDataProvider();
                loadDataMaterial();
                loadDataToTextBox();
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Visible == false)
            {
                btnAdd.Enabled = btnDelete.Enabled = false;
                cbxProvider.Visible = false;
                txtName.Visible = true;
                txtName.Text = cbxProvider.Text;
                txtPhone.ReadOnly = txtAddress.ReadOnly = false;

            }
            else
            {
                Provider provider = new Provider(txtCode.Text, txtName.Text, txtAddress.Text, txtPhone.Text);
                providerDao.edit(provider);
                MessageBox.Show("Edit provider successfully!");
                btnAdd.Enabled = btnDelete.Enabled = true;
                txtPhone.ReadOnly = txtAddress.ReadOnly = true;
                cbxProvider.Visible = true;
                txtName.Visible = false;
            }
        }
    }
}
