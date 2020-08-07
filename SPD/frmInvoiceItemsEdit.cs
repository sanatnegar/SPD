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

namespace SPD
{
    public partial class frmInvoiceItemsEdit : Form
    {
        public long ID;
        public string InvoiceNumber;
        public string FDate;
        public string CustomerCode;
        public string CustomerName;
        public string RequestNumber;
        public string InternalOrderNumber;

        public frmInvoiceItemsEdit()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            BL_frmInvoiceItemsEdit M = new BL_frmInvoiceItemsEdit();
            M.ProductCode = txtProductCode.Text.ToString();
            M.CustomerCode = this.CustomerCode;
            //M.CustomerCode = txtCustomerNumber.Text.ToString();
            txtProductDescrition.Text = M.getProductName();
            txtTechNumber.Text = M.getProductTechNo();
            //Datagridview1.DataSource = M.AllHistory();

            if (chkJustThisCustomer.Checked == true)
            {
                Datagridview1.DataSource = M.ThisCustomerHistory();
            }
            else
            {
                Datagridview1.DataSource = M.AllHistory();
            }

            this.Datagridview1.DefaultCellStyle.Font = new Font("B Yekan", 10);
            this.Datagridview1.ColumnHeadersDefaultCellStyle.Font = new Font("B Yekan", 9.75F, FontStyle.Bold);

            this.Datagridview1.Columns[0].HeaderText = "تاریخ";
            this.Datagridview1.Columns[0].Width = 150;
            this.Datagridview1.Columns[1].HeaderText = "نام مشتری";
            this.Datagridview1.Columns[1].Width = 150;
            this.Datagridview1.Columns[2].HeaderText = "تعداد";
            this.Datagridview1.Columns[2].Width = 150;
            this.Datagridview1.Columns[3].HeaderText = "قیمت واحد";
            this.Datagridview1.Columns[3].Width = 150;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            long quantity;
            long unitprice;
            double tax;
            double price;
            if (txtQuantity.Text != "")
            {
                quantity = long.Parse(txtQuantity.Text);

            }
            else
            {
                quantity = 0;
            }
            if (txtUnitPrice.Text != "")
            {
                unitprice = long.Parse(txtUnitPrice.Text);
            }
            else
            {
                unitprice = 0;
            }

            tax = quantity * unitprice * 0.09;
            price = (quantity * unitprice) + tax;
            txtTax.Text = Convert.ToString(tax);
            txtPrice.Text = Convert.ToString(price);
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            long quantity;
            long unitprice;
            double tax;
            double price;
            if (txtQuantity.Text != "")
            {
                quantity = long.Parse(txtQuantity.Text);
            }
            else
            {
                quantity = 0;
            }
            if (txtUnitPrice.Text != "")
            {
                unitprice = long.Parse(txtUnitPrice.Text);
            }
            else
            {
                unitprice = 0;
            }

            tax = quantity * unitprice * 0.09;
            price = (quantity * unitprice) + tax;
            txtTax.Text = Convert.ToString(tax);
            txtPrice.Text = Convert.ToString(price);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BL_frmInvoiceItemsEdit M = new BL_frmInvoiceItemsEdit();
            M.ID = this.ID;
            M.InvoiceNumber = this.InvoiceNumber;
            M.FDate = this.FDate;
            M.CustomerCode = this.CustomerCode;
            M.CustomerName = this.CustomerName;
            M.RequestNumber = this.RequestNumber;
            M.InternalOerderNumber = this.InternalOrderNumber;
            //-------------------------------------------
            M.DraftNumber = this.txtDraftNumber.Text.ToString();
            M.ProductCode = this.txtProductCode.Text.ToString();
            M.ProductDescription = this.txtProductDescrition.Text.ToString();
            M.ProductTechNumber = this.txtTechNumber.Text.ToString();
            M.Quantity = long.Parse(this.txtQuantity.Text.ToString());
            M.UnitPrice = long.Parse(this.txtUnitPrice.Text.ToString());
            M.Tax=double.Parse(this.txtTax.Text.ToString());
            M.Price = double.Parse(this.txtPrice.Text.ToString());
            M.UpdateItem();
            this.Close();
        }

        private void frmInvoiceItemsEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
