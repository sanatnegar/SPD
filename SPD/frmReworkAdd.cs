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
    public partial class frmReworkAdd : Form
    {
        public frmReworkAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOriginCode_TextChanged(object sender, EventArgs e)
        {
            BL_frmReworkAdd M = new BL_frmReworkAdd();
            M.Code = txtOriginCode.Text.ToString();
            txtOriginName.Text = M.GetName();
            txtOriginTechNo.Text = M.GetTechNo();
        }

        private void txtDestinationCode_TextChanged(object sender, EventArgs e)
        {
            BL_frmReworkAdd M = new BL_frmReworkAdd();
            M.Code = txtDestinationCode.Text.ToString();
            txtDestinationName.Text = M.GetName();
            txtDestinationTechNo.Text = M.GetTechNo();
        }

        private void btnAddRework_Click(object sender, EventArgs e)
        {
            bool validfdate = G.ValidateParsianDate(txtFDate.Text.ToString());

            if (this.txtFDate.Text!="" && validfdate == false)
            {
                txtFDate.BackColor = Color.Red;
                txtFDate.ForeColor = Color.White;
                MessageBox.Show("تاریخ را بطور صحیح وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }
            else
            {
                txtFDate.BackColor = Color.White;
                txtFDate.ForeColor = Color.Black;
            }


            if (this.txtOriginTechNo.Text == "" || this.txtDestinationTechNo.Text=="")
            {
                MessageBox.Show("لطفا کد محصولات را بطور صحیح وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }

            if (this.txtQuantity.Text == "" || long.Parse(this.txtQuantity.Text) == 0)
            {
                MessageBox.Show("لطفا تعداد را بطور صحیح وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }

            if (txtReworkCode.Text == "")
            {
                MessageBox.Show("لطفا کد ریورک را وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }

            BL_frmReworkAdd M = new BL_frmReworkAdd();


            M.ReworkCode = this.txtReworkCode.Text.ToString();
            if (M.isUnique() == false)
            {
                MessageBox.Show("کد ریورک تکراری است", "خطا", MessageBoxButtons.OK);
                return;
            }

            M.FDate = this.txtFDate.Text.ToString();
            M.OriginCode = this.txtOriginCode.Text.ToString();
            M.OriginTechNo = this.txtOriginTechNo.Text.ToString();
            M.OriginName = this.txtOriginName.Text.ToString();
            M.DestinationCode = this.txtDestinationCode.Text.ToString();
            M.DestinationTechNo = this.txtDestinationTechNo.Text.ToString();
            M.DestinationName = this.txtDestinationName.Text.ToString();
            M.Quantity = this.txtQuantity.Text.ToString();
            M.ReworkCode = this.txtReworkCode.Text.ToString();
            M.Description = this.txtDescription.Text.ToString();
            M.AddRework();
            this.Close();
            
        }
    }
}
