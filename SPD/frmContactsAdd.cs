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
    public partial class frmContactsAdd : Form
    {
        public frmContactsAdd()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (this.txtLName.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی یا نام شرکت را وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }
            if (this.txtTel1.Text != "" ||
                this.txtTel2.Text != "" ||
                this.txtCell1.Text != "" ||
                this.txtCell2.Text != "" ||
                this.txtWeb.Text != "" ||
                this.txtEmail1.Text != "" ||
                this.txtEmail2.Text != "")
            {
                BL_frmContactsAdd M = new BL_frmContactsAdd();
                M.FName = this.txtFName.Text.ToString();
                M.LName = this.txtLName.Text.ToString();
                M.Tel1 = this.txtTel1.Text.ToString();
                M.Tel2 = this.txtTel2.Text.ToString();
                M.Cell1 = this.txtCell1.Text.ToString();
                M.Cell2 = this.txtCell2.Text.ToString();
                M.Web = this.txtWeb.Text.ToString();
                M.Email1 = this.txtEmail1.Text.ToString();
                M.Email2 = this.txtEmail2.Text.ToString();
                M.AddContact();
                this.Close();
            }
            else
            {
                MessageBox.Show("حداقل یکی از فیلدهای اطلاعات تماس را پر کنید", "خطا", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtTel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtCell1_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtCell2_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        
    }
}
