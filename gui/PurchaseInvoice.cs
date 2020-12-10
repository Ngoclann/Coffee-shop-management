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
    public partial class PurchaseInvoice : Form
    {
        StaffDao staffDao = new StaffDao();
        PurchaseDetailDao purchaseDetailDao = new PurchaseDetailDao();

        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        public void UpDataStaff()
        {
            cbxStaff.DataSource = staffDao.getAll().Tables["staff"];
            cbxStaff.DisplayMember = "staffCode";
            cbxStaff.ValueMember = "staffName";
        }

        public void UpDataToGridView()
        {
            string staffCode = cbxStaff.Text;
            dgvPurchaseItems.DataSource = purchaseDetailDao.getByStaffCode(staffCode).Tables["purchaseDetails"];
        }
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            UpDataStaff();
            UpDataToGridView();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dgvPurchaseItems.DataSource = purchaseDetailDao.getAll().Tables["purchaseDetails"]; ;
        }

        private void cbxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpDataToGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         /*   if (dgvPurchaseItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose one Purchase Bill to delete");
                return;
            }
            DialogResult confirm = MessageBox.Show("Do you want to delete this order", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                StaffDao staffDao = new StaffDao();
                for (int i = 0; i < PurchaseItems.SelectedRows.Count; i++)
                {
                    string staffCode = dgvStaff.SelectedRows[i].Cells[0].Value.ToString();
                    staffDao.deleteByCode(staffCode);
                }
                upDataToGridView();
            }  */
        }
    }
}
