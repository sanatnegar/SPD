using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbCustomers_Click(object sender, EventArgs e)
        {
            frmCustomersList customers = new frmCustomersList();
            customers.ShowDialog();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbFactorRegister_Click(object sender, EventArgs e)
        {
            frmInvoiceList frmInvoicelist = new frmInvoiceList();
            frmInvoicelist.ShowDialog();
        }

        private void tsbProducts_Click(object sender, EventArgs e)
        {
            frmProductsList fo = new frmProductsList();
            fo.ShowDialog();
        }

        private void tsbRework_Click(object sender, EventArgs e)
        {
            rbOrigin fo = new rbOrigin();
            fo.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //string appPath;
            //appPath = Application.StartupPath;
            //MessageBox.Show(appPath, "پیام", MessageBoxButtons.OK);
        }

        private void tsbPhoneBook_Click(object sender, EventArgs e)
        {
            frmContactsList fo = new frmContactsList();
            fo.ShowDialog();
        }

        private void tsbCustomerSupport_Click(object sender, EventArgs e)
        {
            frmCustomerSupport fo = new frmCustomerSupport();
            fo.ShowDialog();
        }

        private void tsbReporting_Click(object sender, EventArgs e)
        {
            frmReporting fo = new frmReporting();
            fo.ShowDialog();
        }
    }
}
