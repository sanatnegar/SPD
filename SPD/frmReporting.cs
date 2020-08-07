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
    public partial class frmReporting : Form
    {
        public frmReporting()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtFDate1.Text == "" || txtFDate2.Text == "")
            {
                MessageBox.Show("لطفا محدوده تاریخ را وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }

            bool validfdate1 = G.ValidateParsianDate(txtFDate1.Text.ToString());
            bool validfdate2 = G.ValidateParsianDate(txtFDate2.Text.ToString());

            if (validfdate1 == false || validfdate2 == false)
            {
                txtFDate1.BackColor = Color.Red;
                txtFDate1.ForeColor = Color.White;
                txtFDate2.BackColor = Color.Red;
                txtFDate2.ForeColor = Color.White;
                MessageBox.Show("تاریخ را بطور صحیح وارد کنید", "خطا", MessageBoxButtons.OK);
                return;
            }
            else
            {
                txtFDate1.BackColor = Color.White;
                txtFDate1.ForeColor = Color.Black;
                txtFDate2.BackColor = Color.White;
                txtFDate2.ForeColor = Color.Black;
            }

            string strCustomerCode="";
            DataTable dtCustomerNames = new DataTable();
            BL_frmCustomerSupport M = new BL_frmCustomerSupport();
            dtCustomerNames = M.CustomerList();
            int intindex;

            if (this.cmbCustomers.SelectedIndex != 0)
            {
                intindex = cmbCustomers.SelectedIndex - 1;
                strCustomerCode = Convert.ToString(dtCustomerNames.Rows[intindex][0]);
                MessageBox.Show(strCustomerCode, "customer code", MessageBoxButtons.OK);
            }

            //گزارش کلی از کلیه مشتریان
            if (cmbReportType.SelectedIndex == 0 && cmbCustomers.SelectedIndex == 0)
            {
                BL_frmReporting M1 = new BL_frmReporting();
                M1.FDate1 = this.txtFDate1.Text.ToString();
                M1.FDate2 = this.txtFDate2.Text.ToString();
                this.dataGridView1.DataSource = M1.TotalizedAll();
                TotalizedDatagridUpdate();
                this.txtTotalPrice.Text = Convert.ToString(M1.GetSumTotalizedAll());
                this.txtTotalTax.Text = Convert.ToString(M1.GetTaxTotalizedAll());
                
            }
            // گزارش کلی از یک مشتری مشحض
            if (cmbReportType.SelectedIndex == 0 && cmbCustomers.SelectedIndex != 0)
            {
                BL_frmReporting M2 = new BL_frmReporting();
                M2.FDate1 = this.txtFDate1.Text.ToString();
                M2.FDate2 = this.txtFDate2.Text.ToString();
                M2.CustomerCode = strCustomerCode;
                this.dataGridView1.DataSource = M2.TotalizedByCustomer();
                TotalizedDatagridUpdate();
                this.txtTotalPrice.Text = Convert.ToString(M2.GetSumTotalizedByCustomer());
                this.txtTotalTax.Text = Convert.ToString(M2.GetTaxTotalizedByCustomer());
            }
            // گزارش جزئی از کلیه مشتریان
            if (cmbReportType.SelectedIndex == 1 && cmbCustomers.SelectedIndex == 0)
            {
                BL_frmReporting M3 = new BL_frmReporting();
                M3.FDate1 = this.txtFDate1.Text.ToString();
                M3.FDate2 = this.txtFDate2.Text.ToString();
                this.dataGridView1.DataSource = M3.DetailedAll();
                DetailedDatagridUpdate();
                this.txtTotalPrice.Text = Convert.ToString(M3.GetSumDetailedAll());
                //this.txtTotalPrice.Text="Error";
                this.txtTotalTax.Text = Convert.ToString(M3.GetTaxDetailedAll());
                //this.txtTotalTax.Text = "Error";

            }
            // گزراش جزئی از یک مشتری مشخص
            if(cmbReportType.SelectedIndex==1 && cmbCustomers.SelectedIndex!=0)
            {
                BL_frmReporting M4 = new BL_frmReporting();
                M4.FDate1 = this.txtFDate1.Text.ToString();
                M4.FDate2 = this.txtFDate2.Text.ToString();
                M4.CustomerCode = strCustomerCode;
                this.dataGridView1.DataSource = M4.DetailedByCustomer();
                DetailedDatagridUpdate();
                this.txtTotalPrice.Text = Convert.ToString(M4.GetSumDetailedByCustomer());
                //this.txtTotalPrice.Text = "Error";
                this.txtTotalTax.Text = Convert.ToString(M4.GetTaxDetailedByCustomer());
                //this.txtTotalTax.Text = "Error";
            }
        }
        
        private void frmReporting_Load(object sender, EventArgs e)
        {
            this.cmbReportType.Items.Add("کلی");
            this.cmbReportType.Items.Add("جزئی");
            this.cmbReportType.SelectedIndex = 0;

            LoadCustomers();
        }

        private void TotalizedDatagridUpdate()
        {
            this.dataGridView1.Columns[0].Visible = false;
            //this.dataGridView1.Columns[1].Visible = false;
            //this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            //this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            //this.dataGridView1.Columns[7].Visible = false;
            //this.dataGridView1.Columns[8].Visible = false;

            this.dataGridView1.Columns[1].HeaderText = "شماره فاکتور";
            this.dataGridView1.Columns[1].Width =110;
            this.dataGridView1.Columns[2].HeaderText = "تاریخ";
            this.dataGridView1.Columns[4].HeaderText = "نام مشتری";
            this.dataGridView1.Columns[7].HeaderText = "مالیات(ریال)";
            this.dataGridView1.Columns[8].HeaderText = "جمع کل(ریال)";
            this.dataGridView1.Columns[8].Width = 150;
        }
        private void DetailedDatagridUpdate()
        {
            this.dataGridView1.Columns[0].Visible = false;
            //this.dataGridView1.Columns[1].Visible = false;
            //this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            //this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;
            //this.dataGridView1.Columns[8].Visible = false;
            //this.dataGridView1.Columns[9].Visible = false;
            //this.dataGridView1.Columns[10].Visible = false;
            //this.dataGridView1.Columns[11].Visible = false;
            //this.dataGridView1.Columns[12].Visible = false;
            //this.dataGridView1.Columns[13].Visible = false;
            //this.dataGridView1.Columns[14].Visible = false;

            this.dataGridView1.Columns[1].HeaderText = "شماره فاکتور";
            this.dataGridView1.Columns[1].Width = 60;
            this.dataGridView1.Columns[2].HeaderText = "تاریخ";
            this.dataGridView1.Columns[2].Width = 80;
            this.dataGridView1.Columns[4].HeaderText = "نام مشتری";
            this.dataGridView1.Columns[4].Width = 120;
            this.dataGridView1.Columns[8].HeaderText = "کد محصول";
            this.dataGridView1.Columns[8].Width = 80;
            this.dataGridView1.Columns[9].HeaderText = "شرح محصول";
            this.dataGridView1.Columns[9].Width = 310;
            this.dataGridView1.Columns[10].HeaderText = "شماره فنی";
            this.dataGridView1.Columns[11].HeaderText = "تعداد";
            this.dataGridView1.Columns[11].Width = 50;
            this.dataGridView1.Columns[12].HeaderText = "قیمت واحد";
            this.dataGridView1.Columns[13].HeaderText = "مالیات(ریال)";
            this.dataGridView1.Columns[14].HeaderText = "قیمت(ریال)";
        }

        private void LoadCustomers()
        {
            string strItem;
            string strCustomerName;
            string strCustomerCode;

            this.cmbCustomers.Items.Add("همه مشتریان");
            DataTable dtCustomerNames = new DataTable();
            BL_frmReporting M = new BL_frmReporting();
            dtCustomerNames = M.CustomerList();
            int i;
            for (i = 0; i <= dtCustomerNames.Rows.Count - 1; i++)
            {
                strCustomerName = Convert.ToString(dtCustomerNames.Rows[i][1]);
                strCustomerCode = Convert.ToString(dtCustomerNames.Rows[i][0]);
                strItem = strCustomerName + "(" + strCustomerCode + ")";
                this.cmbCustomers.Items.Add(strItem);
            }
            this.cmbCustomers.SelectedIndex = 0;
        }
    }
}
