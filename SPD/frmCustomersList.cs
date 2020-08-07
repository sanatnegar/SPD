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
    public partial class frmCustomersList : Form
    {
        
        public frmCustomersList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCustomersAdd frmaddcustomer = new frmCustomersAdd();
            frmaddcustomer.ShowDialog();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            
            BL_frmCustomersList M = new BL_frmCustomersList();
            this.dataGridView1.DataSource = M.SelectAll();

            this.dataGridView1.DefaultCellStyle.Font = new Font("B Yekan", 10);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("B Yekan", 9.75F, FontStyle.Bold);
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].HeaderText = "کد مشتری";
            this.dataGridView1.Columns[2].HeaderText = "نام";
            this.dataGridView1.Columns[3].HeaderText = "نام خانوادگی";
            this.dataGridView1.Columns[3].Width = 150;
            this.dataGridView1.Columns[4].HeaderText = "نام شرکت";
            this.dataGridView1.Columns[4].Width = 200;
            this.dataGridView1.Columns[5].HeaderText = "شهر";
            this.dataGridView1.Columns[6].HeaderText = "همراه";
            this.dataGridView1.Columns[7].HeaderText = "تلفن";
            this.dataGridView1.Columns[8].HeaderText = "آدرس";
            this.dataGridView1.Columns[8].Width = 250;
            this.dataGridView1.Columns[9].HeaderText = "ایمیل";
            this.dataGridView1.Columns[9].Width = 250;
        }

        private void frmCustomers_Activated(object sender, EventArgs e)
        {
            
                frmCustomers_Load(null, null);
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                frmCustomersEdit frmeditcustomer = new frmCustomersEdit();
                frmeditcustomer.txtCustomerCode.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                frmeditcustomer.txtFName.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                frmeditcustomer.txtLName.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                frmeditcustomer.txtCompany.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                frmeditcustomer.txtCity.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                frmeditcustomer.txtCell.Text=dataGridView1[6,dataGridView1.CurrentRow.Index].Value.ToString();
                frmeditcustomer.txtTel.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
                frmeditcustomer.txtAddress.Text = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
                frmeditcustomer.txtEmail.Text = dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString();
                frmeditcustomer.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                BL_frmCustomersList M = new BL_frmCustomersList();
                M.Code = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                if (MessageBox.Show("آیا از حذف اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    M.Delete();
                    frmCustomers_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("هیچ رکوردی وجود ندارد", "پیام", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
