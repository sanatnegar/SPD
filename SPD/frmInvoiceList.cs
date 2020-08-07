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
    public partial class frmInvoiceList : Form
    {
        public frmInvoiceList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            frmInvoiceInfoAdd frminvoiceadd = new frmInvoiceInfoAdd();
            frminvoiceadd.ShowDialog();
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            if (Datagridview1.Rows.Count != 0)
            {
                frmInvoiceInfoEdit frminvoiceinfoedit = new frmInvoiceInfoEdit();
                frminvoiceinfoedit.txtInvoiceNumber.Text = this.Datagridview1[1, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceinfoedit.txtDate.Text = this.Datagridview1[2, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceinfoedit.txtcustomerCode.Text = this.Datagridview1[3, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceinfoedit.txtCustomerName.Text = this.Datagridview1[4, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceinfoedit.txtRequestNumber.Text = this.Datagridview1[5, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceinfoedit.txtInternalOrderNumber.Text = this.Datagridview1[6, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceinfoedit.ShowDialog();
            }
            else
            {
                MessageBox.Show("هیچ رکوردی وجود ندارد", "پیام", MessageBoxButtons.OK);
            }
            
        }

        private void frmInvoiceList_Load(object sender, EventArgs e)
        {
           
            BL_frmInvoiceList M = new BL_frmInvoiceList();
            this.Datagridview1.DataSource = M.SelectAllReverse();
            UpdateDataGrid();
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (this.Datagridview1.Rows.Count != 0)
            {
                BL_frmInvoiceList M = new BL_frmInvoiceList();
                M.InvoiceNumber = this.Datagridview1[1, Datagridview1.CurrentRow.Index].Value.ToString();

                if (MessageBox.Show("آیا از حذف فاکتور اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    M.DeleteInvoice();
                    frmInvoiceList_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("هیچ رکوردی برای حذف وجود ندارد.", "پیام", MessageBoxButtons.OK);
            }
        }

        private void frmInvoiceList_Activated(object sender, EventArgs e)
        {
            frmInvoiceList_Load(null, null);
        }

        private void btnInoiceItemsEdit_Click(object sender, EventArgs e)
        {
            if (Datagridview1.Rows.Count != 0)
            {
                frmInvoiceItems frminvoiceitems = new frmInvoiceItems();
                frminvoiceitems.txtInvoiceNumber.Text = this.Datagridview1[1, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceitems.txtInvoiceDate.Text = this.Datagridview1[2, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceitems.txtCustomerCode.Text = this.Datagridview1[3, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceitems.txtCustomerName.Text = this.Datagridview1[4, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceitems.txtRequestNumber.Text = this.Datagridview1[5, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceitems.txtInternalOrderNumber.Text = this.Datagridview1[6, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceitems.txtTotalTax.Text = this.Datagridview1[7, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceitems.txtTotalPrice.Text = this.Datagridview1[8, Datagridview1.CurrentRow.Index].Value.ToString();
                frminvoiceitems.ShowDialog();
            }
            else
            {
                MessageBox.Show("هیچ رکوردی وجود ندارد", "پیام", MessageBoxButtons.OK);
            }
            
        }

        private void btnLast100Invoice_Click(object sender, EventArgs e)
        {
            BL_frmInvoiceList M = new BL_frmInvoiceList();
            this.Datagridview1.DataSource = M.SelectLast100();
            UpdateDataGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbFDate.Checked == true)
            {
                if (txtFDate1.Text == "" || txtFDate2.Text == "")
                {
                    MessageBox.Show("لطفا محدوده تاریخ را وارد کنید", "خطا", MessageBoxButtons.OK);
                    return;
                }
                
                bool validfdate1 = G.ValidateParsianDate(txtFDate1.Text.ToString());
                bool validfdate2 = G.ValidateParsianDate(txtFDate2.Text.ToString());

                if (validfdate1 == false || validfdate2==false)
                {
                    txtFDate1.BackColor = Color.Red;
                    txtFDate1.ForeColor = Color.White;
                    txtFDate2.BackColor = Color.Red;
                    txtFDate2.ForeColor = Color.White;
                    MessageBox.Show("تاریخ را بطور صحیح وارد کنید","خطا",MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    txtFDate1.BackColor = Color.White;
                    txtFDate1.ForeColor = Color.Black;
                    txtFDate2.BackColor = Color.White;
                    txtFDate2.ForeColor = Color.Black;
                }

                BL_frmInvoiceList A=new BL_frmInvoiceList();
                A.FD1=txtFDate1.Text.ToString();
                A.FD2=txtFDate2.Text.ToString();
                this.Datagridview1.DataSource = A.SelectByDate();
                UpdateDataGrid();
            }
            if (rbInvoiceNumber.Checked == true)
            {
                if(txtInvoiceNumber1.Text=="" || txtInvoiceNumber2.Text=="" || txtInvoiceNumber1.Text.Length !=6 || txtInvoiceNumber2.Text.Length!=6)
                {
                    MessageBox.Show("لطفا محدود شماره فاکتورها را به درستی وارد کنید","خطا",MessageBoxButtons.OK);
                    return;
                }
                BL_frmInvoiceList B=new BL_frmInvoiceList();
                B.IN1=txtInvoiceNumber1.Text.ToString();
                B.IN2=txtInvoiceNumber2.Text.ToString();
                this.Datagridview1.DataSource = B.SelectByInvoiceNumber();
                UpdateDataGrid();
            }
        }

        private void txtInvoiceNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtInvoiceNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void UpdateDataGrid()
        {
            this.Datagridview1.DefaultCellStyle.Font = new Font("B Yekan", 10);
            this.Datagridview1.ColumnHeadersDefaultCellStyle.Font = new Font("B Yekan", 9.75F, FontStyle.Bold);
            this.Datagridview1.Columns[0].Visible = false;
            this.Datagridview1.Columns[1].HeaderText = "شماره فاکتور";
            this.Datagridview1.Columns[2].HeaderText = "تاریخ";
            this.Datagridview1.Columns[3].HeaderText = "کد مشتری";
            this.Datagridview1.Columns[4].HeaderText = "نام مشتری";
            this.Datagridview1.Columns[5].HeaderText = "شماره درخواست";
            this.Datagridview1.Columns[6].HeaderText = "سفارش داخلی";
            this.Datagridview1.Columns[7].HeaderText = "مالیات";
            this.Datagridview1.Columns[8].HeaderText = "جمع کل";
        }

        
    }
}
