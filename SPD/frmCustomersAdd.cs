using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;


namespace SPD
{
    public partial class frmCustomersAdd : Form
    {
        public frmCustomersAdd()
        {
            InitializeComponent();
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BL_frmCustomersAdd M = new BL_frmCustomersAdd();

            M.Code = txtCustomerCode.Text.ToString();
            M.FName = txtFName.Text.ToString();
            M.LName = txtLName.Text.ToString();
            M.City = txtCity.Text.ToString();
            M.CompanyName = txtCompanyName.Text.ToString();
            M.Cell = txtCell.Text.ToString();
            M.Tel = txtTel.Text.ToString();
            M.Address = txtAddress.Text.ToString();
            M.Email = txtEmail.Text.ToString();
            
            if (txtCustomerCode.Text == "")
            {
                MessageBox.Show("لطفا کد مشتری را وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }
            if (txtLName.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادکی مشتری را وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }
            if (M.isUnique() == false)
            {
                MessageBox.Show("کد مشتری تکراری است.لطفا دوباره سعی کنید.", "خطا", MessageBoxButtons.OK);
                return;
             }

            M.Add();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
    }
}
