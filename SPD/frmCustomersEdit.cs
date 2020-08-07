using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;
using System.Data.OleDb;

namespace SPD
{
    public partial class frmCustomersEdit : Form
    {
        public frmCustomersEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BL_frmCustomersEdit M = new BL_frmCustomersEdit();
            M.Code = txtCustomerCode.Text.ToString();
            M.FName = txtFName.Text.ToString();
            M.LName = txtLName.Text.ToString();
            M.CompanyName = txtCompany.Text.ToString();
            M.City = txtCity.Text.ToString();
            M.Cell = txtCell.Text.ToString();
            M.Tel = txtTel.Text.ToString();
            M.Address = txtAddress.Text.ToString();
            M.Email = txtEmail.Text.ToString();

            M.Update();
            MessageBox.Show("بروز رسانی با موفقیت انجام شد", "", MessageBoxButtons.OK);
        }

        
    }
}
