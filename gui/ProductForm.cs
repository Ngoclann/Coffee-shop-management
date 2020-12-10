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
using System.Windows.Controls;
using System.Windows.Forms;

namespace CoffeeShopManagement.gui
{
    public partial class ProductForm : Form
    {
        CategoryDao categoryDao = new CategoryDao();
        ProductDao productDao = new ProductDao();
        public ProductForm()
        {
            InitializeComponent();
        }

        public void upDataToComboBox()
        {
            cbxCategory.DataSource = categoryDao.getAll().Tables["category"];
            cbxCategory.DisplayMember = "categoryName";
            cbxCategory.ValueMember = "categoryCode";
            cbxCategory.SelectedItem = 0;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            upDataToComboBox();
            upDataToGridView();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            loadDetailData();
            buttonChoose.Enabled = false;
        }

        private void loadDetailData()
        {
            if (btnChoose.SelectedRows.Count > 0)
            {
                txtCode.Text = btnChoose.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = btnChoose.SelectedRows[0].Cells[1].Value.ToString();
                txtCost.Text = btnChoose.SelectedRows[0].Cells[2].Value.ToString();
                quantity.Text = btnChoose.SelectedRows[0].Cells[4].Value.ToString();
                txtSellPrice.Text = btnChoose.SelectedRows[0].Cells[3].Value.ToString();
                string image = btnChoose.SelectedRows[0].Cells[5].Value.ToString();
                if (image.StartsWith("D:"))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(image);
                    txtImage.Text = image;
                }
                else
                {
                    txtImage.Text = image;
                    pictureBox1.Image = System.Drawing.Image.FromFile("D:/Code/C#/CoffeeShopManagement/images/" + image);
                }
                
            }         
        }

        public void upDataToGridView()
        {
            String caterogyCode = cbxCategory.SelectedValue.ToString();
            btnChoose.DataSource = productDao.getAll(caterogyCode).Tables["products"];
        
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            upDataToGridView();
            loadDetailData();
        }

        private void txtQuantity_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            loadDetailData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnChoose.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose a product to delete");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this product", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    productDao.deleteByCode(txtCode.Text);
                    MessageBox.Show("Delete sucessfully");
                    upDataToGridView();
                    loadDetailData();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (buttonChoose.Enabled ==  false)
            {
                buttonChoose.Enabled = true;
                btnDelete.Enabled = btnUpdate.Enabled = false;
                txtCode.Text = txtCost.Text = txtName.Text = txtSellPrice.Text = quantity.Text = "";
            }
            else
            {
                Product product = new Product();
                product.Code = txtCode.Text;
                product.Categorycode = cbxCategory.SelectedValue.ToString();
                product.SellPrice = double.Parse(txtSellPrice.Text);
                product.PurchasePrice = double.Parse(txtCost.Text);
                product.Image = txtImage.Text;
                product.Name = txtName.Text;
                product.Quantity = int.Parse(quantity.Text);
                productDao.insert(product);
                btnDelete.Enabled = btnUpdate.Enabled = true;
                buttonChoose.Enabled = false;
                MessageBox.Show("Add successfully!");
                upDataToGridView();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                txtImage.Text = open.FileName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                DialogResult dialogResult = MessageBox.Show("Do you want to update this product", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Product product = new Product();
                    product.Code = txtCode.Text;
                    product.Categorycode = cbxCategory.SelectedValue.ToString();
                    product.SellPrice = double.Parse(txtSellPrice.Text);
                    product.PurchasePrice = double.Parse(txtCost.Text);
                    product.Image = txtImage.Text;
                    product.Name = txtName.Text;
                    product.Quantity = int.Parse(quantity.Text);
                    MessageBox.Show(product.ToString());
                    productDao.edit(product);
                    MessageBox.Show("Edit sucessfully");
                    upDataToGridView();
                }
        }
    }
}
