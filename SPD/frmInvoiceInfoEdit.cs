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
    public partial class frmInvoiceInfoEdit : Form
    {
        public frmInvoiceInfoEdit()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcustomerCode_TextChanged(object sender, EventArgs e)
        {
            BL_frmInvoiceInfoEdit M = new BL_frmInvoiceInfoEdit();
            M.CustomerCode = txtcustomerCode.Text;
            string CustomerName = M.GetCustomerName();
            if (CustomerName != "")
            {
                txtCustomerName.Text = CustomerName;
            }
            else
            {
                txtCustomerName.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("لطفا کد مشتری را به طور صحیح وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }

            bool validfdate = isValidDate(txtDate);

            if (validfdate == false)
            {
                MessageBox.Show("تاریخ را بطور صحیح وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }
            BL_frmInvoiceInfoEdit M = new BL_frmInvoiceInfoEdit();
            M.InvoiceNumber = txtInvoiceNumber.Text.ToString();
            M.FDate = txtDate.Text.ToString();
            M.CustomerCode = txtcustomerCode.Text.ToString();
            M.CustomerName = txtCustomerName.Text.ToString();
            M.RequesyNumber = txtRequestNumber.Text.ToString();
            M.InternalOerderNumber = txtInternalOrderNumber.Text.ToString();
            M.UpdateInvoiceInfo();

            MessageBox.Show("فاکتور بروزرسانی شد", "پیام", MessageBoxButtons.OK);
            this.Close();

            
        }

        private bool isLeap(int Year)
        {
            int Remaining;
            Remaining = Year % 33;
            bool result=false;
            
            switch (Remaining)
            {
                case 1:
                    
                    break;
                case 5:
                    result= true;
                    break;

                case 9:
                    result=true;
                    break;
                case 13:
                    result= true;
                    break;
                case 18:
                    result= true;
                    break;
                case 22:
                    result=true;
                    break;
                case 26:
                    result= true;
                    break;
                case 30:
                    result=true;
                    break;
                default:
                    result= false;
                    break;
            }
            return result;
            
        }

        private bool isValidDate(TextBox txtFDate)
        {
            string strDate;
            bool blnE1;
            bool blnE2;
            bool blnE3;
            bool blnE4;
            bool blnE5;
            bool blnE6;
            bool blnE7;
            bool blnE8;
            bool blnE9;
            bool blnE10;
            bool blnE11;
            
            
            string strMonth;
            string strDay;
            string strYear;

            strDate=txtFDate.Text.ToString();
            strDate=strDate.Trim();
            if (txtFDate.Text == "")
            {
                txtFDate.ForeColor = Color.Black;
                txtFDate.BackColor = Color.White;
                return true;
            }
            else
            {
                if (strDate.Length == 10)
                {
                    strYear = strDate.Substring(0, 4);
                    strMonth = strDate.Substring(5, 2);
                    strDay = strDate.Substring(8, 2);
                }
                else
                {
                    strYear = "0000";
                    strMonth = "00";
                    strDay = "00";
                }

                if (strYear.Length < 4)
                {
                    blnE9 = true;
                }
                else
                {
                    blnE9 = false;
                }

                if (strMonth.Length < 2)
                {
                    blnE10 = true;
                }
                else
                {
                    blnE10 = false;
                }

                if (strDay.Length < 2)
                {
                    blnE11 = true;
                }
                else
                {
                    blnE11 = false;
                }

                if (strDate.Substring(4, 1) != "/")
                {
                    blnE1 = true;
                }
                else
                {
                    blnE1 = false;
                }

                if (strDate.Substring(7, 1) != "/")
                {
                    blnE2 = true;
                }
                else
                {
                    blnE2 = false;
                }

                if (Int32.Parse(strYear) == 0 || Int32.Parse(strMonth) == 0 || Int32.Parse(strDay) == 0)
                {
                    blnE3 = true;
                }
                else
                {
                    blnE3 = false;
                }

                if (Int32.Parse(strYear) < 1343 || Int32.Parse(strYear) > 1472)
                {
                    blnE4 = true;
                }
                else
                {
                    blnE4 = false;
                }

                if (Int32.Parse(strMonth) < 1 || Int32.Parse(strMonth) > 12)
                {
                    blnE5 = true;
                }
                else
                {
                    blnE5 = false;
                }

                if (Int32.Parse(strDay) < 1 || Int32.Parse(strDay) > 31)
                {
                    blnE6 = true;
                }
                else
                {
                    blnE6 = false;
                }

                if (Int32.Parse(strMonth) > 6 && Int32.Parse(strMonth) > 30)
                {
                    blnE7 = true;
                }
                else
                {
                    blnE7 = false;
                }

                if (isLeap(Int32.Parse(strYear)) == false && Int32.Parse(strMonth) == 12 && Int32.Parse(strDay) > 29)
                {
                    blnE8 = true;
                }
                else
                {
                    blnE8 = false;
                }

                if (blnE1 == true ||
                    blnE2 == true ||
                    blnE3 == true ||
                    blnE4 == true ||
                    blnE5 == true ||
                    blnE6 == true ||
                    blnE7 == true ||
                    blnE8 == true ||
                    blnE9 == true ||
                    blnE10 == true ||
                    blnE11 == true)
                {
                    txtFDate.BackColor = Color.Red;
                    txtFDate.ForeColor = Color.White;
                    return false;
                }
                else
                {
                    txtFDate.BackColor = Color.White;
                    txtFDate.ForeColor = Color.Black;
                    return true;
                }

            }

            }

        private void frmInvoiceInfoEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
