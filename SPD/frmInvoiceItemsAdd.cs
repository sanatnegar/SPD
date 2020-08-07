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
    public partial class frmInvoiceItemsAdd : Form
    {
        public string InvoiceNumber;
        public string FDate;
        public string CustomerCode;
        public string CustomerName;
        public string RequestNumber;
        public string InternalOrderNumber;
                
        public frmInvoiceItemsAdd()
        {
            InitializeComponent();
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            BL_frmInvoiceItemsAdd M = new BL_frmInvoiceItemsAdd();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvoiceItemsAdd_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(CustomerCode, "CustomerCode", MessageBoxButtons.OK);
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtDraftNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtProductDescrition.Text == "" || this.txtTechNumber.Text == "")
            {
                MessageBox.Show("لطفا کد محصول را بطور صحیح وارد کنید","خطا",MessageBoxButtons.OK);
                return;
            }

            if (this.txtQuantity.Text == "" || long.Parse(this.txtQuantity.Text) == 0)
            {
                MessageBox.Show("لطفا تعداد را بطور صحیح وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }

            if (this.txtUnitPrice.Text == "" || long.Parse(this.txtUnitPrice.Text) == 0)
            {
                MessageBox.Show("لطفا قیمت واحد را بطور صحیح وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }

            BL_frmInvoiceItemsAdd M = new BL_frmInvoiceItemsAdd();
            M.InvoiceNumber = this.InvoiceNumber;
            M.FDate = this.FDate;
            M.CustomerCode = this.CustomerCode;
            M.CustomerName = this.CustomerName;
            M.RequestNumber = this.RequestNumber;
            M.InternalOerderNumber = this.InternalOrderNumber;
            //-------------------------------------------------
            M.DraftNumber = this.txtDraftNumber.Text.ToString();
            M.ProductCode = this.txtProductCode.Text.ToString();
            M.ProductDescription = this.txtProductDescrition.Text.ToString();
            M.ProductTechNumber = this.txtTechNumber.Text.ToString();
            M.Quantity = long.Parse(txtQuantity.Text);
            M.UnitPrice = long.Parse(txtUnitPrice.Text);
            M.Tax = double.Parse(txtTax.Text.ToString());
            M.Price = double.Parse(txtPrice.Text.ToString());

            M.AddItem();
            
            //MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK);
            this.Close();
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

        private void chkJustThisCustomer_CheckedChanged(object sender, EventArgs e)
        {
            BL_frmInvoiceItemsAdd M = new BL_frmInvoiceItemsAdd();
            M.ProductCode = txtProductCode.Text.ToString();
            M.CustomerCode = this.CustomerCode;

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

        private void Datagridview1_DoubleClick(object sender, EventArgs e)
        {
            if (this.Datagridview1.Rows.Count != 0)
            {
                this.txtUnitPrice.Text = Datagridview1[3, Datagridview1.CurrentRow.Index].Value.ToString();
            }
        }

       

        
    }
}
