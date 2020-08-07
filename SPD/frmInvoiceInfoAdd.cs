using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using BL;
using System.Globalization;

namespace SPD
{
    public partial class frmInvoiceInfoAdd : Form
    {
        public void onlynumwithsinglepoint(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        public void OnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
        }

        public frmInvoiceInfoAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInvoiceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigits(sender, e);
        }

        private void txtcustomerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigits(sender, e);
        }

        private void txtRequestNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigits(sender, e);
        }

        private void txtInternalOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigits(sender, e);
        }

        private void txtcustomerCode_TextChanged(object sender, EventArgs e)
        {
            BL_frmInvoiceInfoAdd M = new BL_frmInvoiceInfoAdd();
            M.CustomerCode = txtcustomerCode.Text;
            string CustomerName=M.GetCustomerName();
            if (CustomerName != "")
            {
                txtCustomerName.Text = CustomerName;
            }
            else
            {
                txtCustomerName.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BL_frmInvoiceInfoAdd M = new BL_frmInvoiceInfoAdd();
            if (txtInvoiceNumber.Text.Length != 6)
            {
                MessageBox.Show("شماره باید 6 رقمی باشد.لطفا دوباره سعی کنید", "خطا", MessageBoxButtons.OK);
                return;
            }
            M.InvoiceNumber = txtInvoiceNumber.Text.ToString();
            if (M.isUnique()== false)
            {
                MessageBox.Show("کد فاکتور تکراری است", "خطا", MessageBoxButtons.OK);
                return;
            }
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("لطفا کد مشتری را به طور صحیح وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }

            //bool validfdate = ValidateParsianDate(txtDate.Text.ToString());
            bool validfdate = G.ValidateParsianDate(txtDate.Text.ToString());

            if (validfdate == false)
            {
                txtDate.BackColor = Color.Red;
                txtDate.ForeColor = Color.White;
                MessageBox.Show("تاریخ را بطور صحیح وارد کنید","خطا",MessageBoxButtons.OK);
                return;
            }
            else{
                txtDate.BackColor = Color.White;
                txtDate.ForeColor = Color.Black;
            }

            M.InvoiceNumber = txtInvoiceNumber.Text.ToString();
            M.FDate = txtDate.Text.ToString();
            M.CustomerCode = txtcustomerCode.Text.ToString();
            M.CustomerName = txtCustomerName.Text.ToString();
            M.RequestNumber = txtRequestNumber.Text.ToString();
            M.InternalOrderNumber = txtInternalOrderNumber.Text.ToString();
            M.TotalTax = 0;
            M.TotalPrice = 0;
            M.AddInvoiceInfo();

            MessageBox.Show("فاکتور ثبت شد", "پیام", MessageBoxButtons.OK);
            this.Close();
           
        }

        private void frmInvoiceInfoAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtInvoiceNumber_TextChanged(object sender, EventArgs e)
        {

        }
        
        

    }
}
