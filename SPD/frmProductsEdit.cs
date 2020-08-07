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
    public partial class frmProductsEdit : Form
    {
        public long ID;
        
        public string Unit;

        public frmProductsEdit()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductsEdit_Load(object sender, EventArgs e)
        {
            //this.cmbUnit.Items.Add("عدد");//0
            //this.cmbUnit.Items.Add("بسته");//1
            //this.cmbUnit.Items.Add("متر");//2
            //this.cmbUnit.Items.Add("کیلوگرم");//3
            //this.cmbUnit.Items.Add("گرم");//4
            //this.cmbUnit.Items.Add("لیتر");//5
            //this.cmbUnit.Items.Add("شیشه");//6

            //switch (Unit)
            //{
            //    case "عدد":
            //        cmbUnit.SelectedIndex = 0;
            //        break;
            //    case "بسته":
            //        cmbUnit.SelectedIndex = 1;
            //        break;
            //    case "متر":
            //        cmbUnit.SelectedIndex = 2;
            //        break;
            //    case "کیلوگرم":
            //        cmbUnit.SelectedIndex = 3;
            //        break;
            //    case "گرم":
            //        cmbUnit.SelectedIndex = 4;
            //        break;
            //    case "لیتر":
            //        cmbUnit.SelectedIndex = 5;
            //        break;
            //    case "شیشه":
            //        cmbUnit.SelectedIndex = 6;
            //        break;
            //    default:
            //        cmbUnit.SelectedIndex = 0;
            //        break;
            //}


            //if (Unit.Contains("عدد"))//0
            //{
            //    cmbUnit.SelectedIndex = 0;
            //}
            //else if (Unit.Contains("بسته"))//1
            //{
            //    cmbUnit.SelectedIndex = 1;
            //}
            //else if (Unit.Contains("متر"))//2
            //{
            //    cmbUnit.SelectedIndex = 2;
            //}
            //else if (Unit.Contains("كيلوگرم‌"))//3
            //{
            //    cmbUnit.SelectedIndex = 3;
            //}
            //else if (Unit.Contains("گرم"))//4
            //{
            //    cmbUnit.SelectedIndex = 4;
            //}
            //else if (Unit.Contains("لیتر"))//5
            //{
            //    cmbUnit.SelectedIndex = 5;
            //}
            //else if (Unit.Contains("شیشه"))//6
            //{
            //    cmbUnit.SelectedIndex = 6;
            //}
            //else
            //{
            //    cmbUnit.SelectedIndex = 0;
            //}

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtTechNumber.Text == "" || this.txtDescription.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات محصول را بطور کامل وارد کنید", "خطا", MessageBoxButtons.OK);

            }
            
            if (this.txtTechNumber.Text.Length < 8)
            {
                MessageBox.Show("طول شماره فنی باید حداقل 8 کاراکتر باشد", "خطا", MessageBoxButtons.OK);
            }
            BL_frmProductsEdit M = new BL_frmProductsEdit();
            M.Code = this.txtCode.Text.ToString();
            M.TechNo = this.txtTechNumber.Text.ToString();
            M.Description = this.txtDescription.Text.ToString();
            M.Update();
            this.Close();
        }
    }
}
