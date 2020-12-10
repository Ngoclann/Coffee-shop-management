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
    public partial class StaffAction : Form
    {
        private Staff staff;
        private string type;
        private StaffForm staffForm;


        public StaffAction(StaffForm staffForm)
        {
            InitializeComponent();
            this.staffForm =  staffForm;
            this.type = "Add";
        }

        public StaffAction(Staff staff, StaffForm staffForm)
        {
            InitializeComponent();
            this.staff = staff;
            this.type = "Edit";
            this.staffForm = staffForm;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Text = txtName.Text = txtPhone.Text = txtAddress.Text = "";
        }

        private void StaffAction_Load(object sender, EventArgs e)
        {
            btnAction.Text = type;
            if (type.Equals("Edit"))
            {
                txtName.Text = staff.Name;
                txtAddress.Text = staff.Address;
                txtCode.Text = staff.Code;
                txtPhone.Text = staff.Phone;
                if (staff.Sex.Equals("Male")) radMale.Checked = true;
                else radioButton1.Checked = true;
                txtCode.ReadOnly = true;
            }
            else
                staff = new Staff();

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            StaffDao staffDao = new StaffDao();
            staff.Code = txtCode.Text;
            staff.Address = txtAddress.Text;
            staff.Dob = dateTimePicker1.Value.ToLongDateString();
            if (radMale.Checked) staff.Sex = "Male";
                else
                    staff.Sex = "FeMale";
            staff.Name = txtName.Text;
            staff.Phone = txtPhone.Text;
            if (type.Equals("Add"))
            {
                if (txtCode.Text.Equals(""))
                {
                    MessageBox.Show("StaffCode can not be empty!");
                    return;
                }
                if (staffDao.isExisted(staff.Code) == true)
                {
                    MessageBox.Show("This staffCode is existed, choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                staffDao.insert(staff);
                MessageBox.Show("Add successfully!");
            }
            else
            {
                MessageBox.Show("Edit successfully!");
                if (type.Equals("Edit")) staffDao.edit(staff);
            }           
            staffForm.upDataToGridView();
            this.Dispose();
        }
    }
}
