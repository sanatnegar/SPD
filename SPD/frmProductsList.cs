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
    public partial class frmProductsList : Form
    {
        public frmProductsList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            BL_frmProductsList M = new BL_frmProductsList();
            M.Code = txtCode.Text.ToString();
            M.TechNo = txtTechNo.Text.ToString();
            M.Description = txtDescription.Text.ToString();
            this.Datagridview1.DataSource = M.Search();
            UpdateDatagrid();

            
        }
        private void UpdateDatagrid()
        {
            this.Datagridview1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.Datagridview1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            this.Datagridview1.Columns[0].Visible = false;
            this.Datagridview1.Columns[1].HeaderText = "کد محصول";
            this.Datagridview1.Columns[2].HeaderText = "شماره فنی";
            this.Datagridview1.Columns[2].Width = 200;
            this.Datagridview1.Columns[3].HeaderText = "شرح محصول";
            this.Datagridview1.Columns[3].Width = 450;
            //this.Datagridview1.Columns[4].HeaderText = "واحد";
            this.Datagridview1.Columns[4].Visible = false;
           
        }

        private void txtTechNo_TextChanged(object sender, EventArgs e)
        {
            BL_frmProductsList M = new BL_frmProductsList();
            M.Code = txtCode.Text.ToString();
            M.TechNo = txtTechNo.Text.ToString();
            M.Description = txtDescription.Text.ToString();
            this.Datagridview1.DataSource = M.Search();
            UpdateDatagrid();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            BL_frmProductsList M = new BL_frmProductsList();
            M.Code = txtCode.Text.ToString();
            M.TechNo = txtTechNo.Text.ToString();
            M.Description = txtDescription.Text.ToString();
            this.Datagridview1.DataSource = M.Search();
            UpdateDatagrid();

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductsAdd fo = new frmProductsAdd();
            fo.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Datagridview1.Rows.Count != 0)
            {
                frmProductsEdit fo = new frmProductsEdit();
                
                fo.txtCode.Text = this.Datagridview1[1, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtTechNumber.Text = this.Datagridview1[2, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtDescription.Text = this.Datagridview1[3, Datagridview1.CurrentRow.Index].Value.ToString();
                
                fo.ShowDialog();
            }
            else
            {
                MessageBox.Show("هیچ رکوردی وجود ندارد", "خطا", MessageBoxButtons.OK);
            }
            
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BL_frmProductsList M = new BL_frmProductsList();
                M.Code = this.Datagridview1[1, Datagridview1.CurrentRow.Index].Value.ToString();
                M.Delete();
            }
            
        }

        
    }
}
