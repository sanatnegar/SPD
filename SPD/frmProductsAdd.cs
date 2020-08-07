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
    public partial class frmProductsAdd : Form
    {
        public frmProductsAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductsAdd_Load(object sender, EventArgs e)
        {
            //this.cmbUnit.Items.Add("عدد");
            //this.cmbUnit.Items.Add("بسته");
            //this.cmbUnit.Items.Add("متر");
            //this.cmbUnit.Items.Add("کیلوگرم");
            //this.cmbUnit.Items.Add("گرم");
            //this.cmbUnit.Items.Add("لیتر");
            //this.cmbUnit.Items.Add("شیشه");
            //this.cmbUnit.SelectedIndex = 0;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (this.txtCode.Text == "" || this.txtTechNumber.Text == "" || this.txtDescription.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات محصول را بطور کامل وارد کنید", "خطا", MessageBoxButtons.OK);

            }
            if (this.txtCode.Text.Length < 6)
            {
                MessageBox.Show("طول کد محصول باید حداقل 6 کاراکتر باشد", "خطا", MessageBoxButtons.OK);
            }
            if (this.txtTechNumber.Text.Length < 8)
            {
                MessageBox.Show("طول شماره فنی باید حداقل 8 کاراکتر باشد", "خطا", MessageBoxButtons.OK);
            }

            BL_frmProductsAdd M = new BL_frmProductsAdd();
            M.Code = this.txtCode.Text.ToString();
            M.TechNo = this.txtTechNumber.Text.ToString();
            M.Description = this.txtDescription.Text.ToString();
            //M.Unit = this.cmbUnit.Text.ToString();

            if (M.isUnique() == false)
            {
                MessageBox.Show("کد محصول تکراری است", "خطا", MessageBoxButtons.OK);
                return;
            }

            M.Add();
            this.Close();

        }
    }
}
