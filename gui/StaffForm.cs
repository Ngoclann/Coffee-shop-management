using CoffeeShopManagement.dal;
using CoffeeShopManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement.gui
{
    public partial class StaffForm : Form
    {   
        
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            upDataToGridView();
        }

        public void upDataToGridView()
        {
            dgvStaff.DataSource = null;
            dgvStaff.Rows.Clear();
            StaffDao staffDao = new StaffDao();
            DataSet ds = staffDao.getAll();
            dgvStaff.DataSource = ds.Tables["staff"];
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose one Staff to delete");
                return;
            }
            DialogResult confirm = MessageBox.Show("Do you want to delete this provider", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                StaffDao staffDao = new StaffDao();
                for (int i = 0; i < dgvStaff.SelectedRows.Count; i++)
                {
                    string staffCode = dgvStaff.SelectedRows[i].Cells[0].Value.ToString();
                    staffDao.deleteByCode(staffCode);
                }
                upDataToGridView();
            }
               
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StaffAction staffAction = new StaffAction(this);
            staffAction.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose one Staff to update information");
                return;
            }
            Staff staff = new Staff();
            staff.Code = dgvStaff.SelectedRows[0].Cells[0].Value.ToString();
            staff.Name = dgvStaff.SelectedRows[0].Cells[1].Value.ToString();
            staff.Address = dgvStaff.SelectedRows[0].Cells[2].Value.ToString();
            staff.Sex = dgvStaff.SelectedRows[0].Cells[3].Value.ToString();
            staff.Dob = dgvStaff.SelectedRows[0].Cells[4].Value.ToString();
            staff.Phone = dgvStaff.SelectedRows[0].Cells[5].Value.ToString();
            StaffAction staffAction = new StaffAction(staff, this);
            staffAction.Show();
        }
    }
}
