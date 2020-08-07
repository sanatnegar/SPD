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
    public partial class frmInvoiceItems : Form
    {
        public frmInvoiceItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmInvoiceItemsAdd M = new frmInvoiceItemsAdd();
            
            M.InvoiceNumber = this.txtInvoiceNumber.Text.ToString();
            M.FDate = this.txtInvoiceDate.Text.ToString();
            M.CustomerCode = this.txtCustomerCode.Text.ToString();
            M.CustomerName = this.txtCustomerName.Text.ToString();
            M.InternalOrderNumber = this.txtInternalOrderNumber.Text.ToString();

            M.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvoiceItems_Load(object sender, EventArgs e)
        {
            BL_frmInvoiceItems frminvoiceitems = new BL_frmInvoiceItems();
            frminvoiceitems.InvoiceNumber = this.txtInvoiceNumber.Text.ToString();
            this.dataGridView1.DataSource = frminvoiceitems.SelectAllItems();
            this.txtTotalTax.Text = frminvoiceitems.GetTotalTax().ToString();
            this.txtTotalPrice.Text = frminvoiceitems.GetTotalPrice().ToString();

            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 9);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);

            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;

            this.dataGridView1.Columns[7].HeaderText = "شماره حواله";
            this.dataGridView1.Columns[7].Width = 50;

            this.dataGridView1.Columns[8].HeaderText = "کد محصول";
            this.dataGridView1.Columns[8].Width = 60;

            this.dataGridView1.Columns[9].HeaderText = "نام محصول";
            this.dataGridView1.Columns[9].Width = 255;

            this.dataGridView1.Columns[10].HeaderText = "شماره فنی";

            this.dataGridView1.Columns[11].HeaderText = "تعداد";
            this.dataGridView1.Columns[11].Width = 35;

            this.dataGridView1.Columns[12].HeaderText = "قیمت واحد";
            this.dataGridView1.Columns[12].Width = 95;

            this.dataGridView1.Columns[13].HeaderText = "مالیات";
            this.dataGridView1.Columns[13].Width = 95;

            this.dataGridView1.Columns[14].HeaderText = "قیمت";
            this.dataGridView1.Columns[14].Width = 95;

        }

        private void frmInvoiceItems_Activated(object sender, EventArgs e)
        {
            frmInvoiceItems_Load(null, null);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            long ID;
            ID = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            if (MessageBox.Show("آیا از حذف اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BL_frmInvoiceItems M = new BL_frmInvoiceItems();
                M.ItemID = ID;
                M.InvoiceNumber = this.txtInvoiceNumber.Text.ToString();
                M.DeleteItem();
                frmInvoiceItems_Load(null, null);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                frmInvoiceItemsEdit M = new frmInvoiceItemsEdit();
                M.ID = long.Parse(this.dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                M.InvoiceNumber = this.dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                M.FDate = this.dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                M.CustomerCode = this.dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                M.CustomerName = this.dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                M.RequestNumber = this.dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                M.InternalOrderNumber = this.dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
                M.txtDraftNumber.Text = this.dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
                M.txtProductCode.Text = this.dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
                M.txtProductDescrition.Text = this.dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString();
                M.txtTechNumber.Text = this.dataGridView1[10, dataGridView1.CurrentRow.Index].Value.ToString();
                M.txtQuantity.Text = this.dataGridView1[11, dataGridView1.CurrentRow.Index].Value.ToString();
                M.txtUnitPrice.Text = this.dataGridView1[12, dataGridView1.CurrentRow.Index].Value.ToString();
                
                M.ShowDialog();

            }
            else
            {
                MessageBox.Show("رکوردی برای ویرایش وجود ندارد", "خطا", MessageBoxButtons.OK);
            }

            
        }
    }
}
