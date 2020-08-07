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
    public partial class frmCustomerSupport : Form
    {
        public frmCustomerSupport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BL_frmCustomerSupport M = new BL_frmCustomerSupport();
            M.Code = this.txtProductCode.Text.ToString();
            M.TechNo = this.txtTechNo.Text.ToString();
            M.Name = this.txtName.Text.ToString();

            this.grdSearchResult.DataSource = M.SearchProduct();
            this.grdSearchResult.Columns[0].Visible = false;
            this.grdSearchResult.Columns[4].Visible = false;

            this.grdSearchResult.Columns[3].Width = 600;
            this.grdSearchResult.Columns[2].Width = 200;

            this.grdSearchResult.Columns[1].HeaderText = "کد محصول";
            this.grdSearchResult.Columns[2].HeaderText = "شماره فنی";
            this.grdSearchResult.Columns[3].HeaderText = "شرح محصول";

            
        }

        private void grdSearchResult_Click(object sender, EventArgs e)
        {
            if (this.grdSearchResult.Rows.Count != 0)
            {
                txtSelectedCode.Text = this.grdSearchResult[1, grdSearchResult.CurrentRow.Index].Value.ToString();
                txtSelectedTechNo.Text = this.grdSearchResult[2, grdSearchResult.CurrentRow.Index].Value.ToString();
                txtSelectedName.Text = this.grdSearchResult[3, grdSearchResult.CurrentRow.Index].Value.ToString();
            }
        }

        private void frmCustomerSupport_Load(object sender, EventArgs e)
        {
            string strItem;
            string strCustomerName;
            string strCustomerCode;

            this.cmbCustomers.Items.Add("همه مشتریان");
            DataTable dtCustomerNames = new DataTable();
            BL_frmCustomerSupport M = new BL_frmCustomerSupport();
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

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            string strCustomerCode;
            DataTable dtCustomerNames = new DataTable();
            BL_frmCustomerSupport M = new BL_frmCustomerSupport();
            dtCustomerNames = M.CustomerList();
            int intindex;

            if (this.txtSelectedCode.Text == "")
            {
                MessageBox.Show("هیچ محصولی انتخاب نشده است", "خطا", MessageBoxButtons.OK);
                return;
            }

            if (this.cmbCustomers.SelectedIndex == 0)
            {
                M.Code = this.txtSelectedCode.Text.ToString();
                this.grdSalesHistory.DataSource = M.SalesHistoryAll();
            }
            else
            {
                intindex = cmbCustomers.SelectedIndex - 1;
                strCustomerCode =Convert.ToString(dtCustomerNames.Rows[intindex][0]);
                //MessageBox.Show(strCustomerCode, "customer code", MessageBoxButtons.OK);
                M.Code = this.txtSelectedCode.Text.ToString();
                M.CustomerCode = strCustomerCode;
                this.grdSalesHistory.DataSource = M.SalesHistoryByCustomerCode();
            }

            this.grdSalesHistory.Columns[0].Visible = false;
            this.grdSalesHistory.Columns[1].Visible = false;
            //this.grdSalesHistory.Columns[2].Visible = false;
            this.grdSalesHistory.Columns[3].Visible = false;
            //this.grdSalesHistory.Columns[4].Visible = false;
            this.grdSalesHistory.Columns[5].Visible = false;
            this.grdSalesHistory.Columns[6].Visible = false;
            this.grdSalesHistory.Columns[7].Visible = false;
            this.grdSalesHistory.Columns[8].Visible = false;
            this.grdSalesHistory.Columns[9].Visible = false;
            this.grdSalesHistory.Columns[10].Visible = false;
            //this.grdSalesHistory.Columns[11].Visible = false;
            //this.grdSalesHistory.Columns[12].Visible = false;
            this.grdSalesHistory.Columns[13].Visible = false;
            this.grdSalesHistory.Columns[14].Visible = false;

            this.grdSalesHistory.Columns[2].HeaderText = "تاریخ";
            this.grdSalesHistory.Columns[4].HeaderText = "نام مشتری";
            this.grdSalesHistory.Columns[11].HeaderText = "تعداد";
            this.grdSalesHistory.Columns[12].HeaderText = "قیمت واحد";

            M.OriginCode = txtSelectedCode.Text.ToString();
            M.DestinationCode = txtSelectedCode.Text.ToString();

            this.grdSearchDestination.DataSource = M.SearchOrigin();

            this.grdSearchDestination.Columns[0].Visible = false;
            this.grdSearchDestination.Columns[1].Visible = false;
            this.grdSearchDestination.Columns[2].Visible = false;
            this.grdSearchDestination.Columns[3].Visible = false;
            this.grdSearchDestination.Columns[4].Visible = false;
            //this.grdSearchDestination.Columns[5].Visible = false;
            //this.grdSearchDestination.Columns[6].Visible = false;
            //this.grdSearchDestination.Columns[7].Visible = false;
            //this.grdSearchDestination.Columns[8].Visible = false;
            this.grdSearchDestination.Columns[9].Visible = false;
            this.grdSearchDestination.Columns[10].Visible = false;

            this.grdSearchDestination.Columns[5].HeaderText = "کد محصول";
            this.grdSearchDestination.Columns[5].Width = 70;
            this.grdSearchDestination.Columns[6].HeaderText = "شماره فنی";
            this.grdSearchDestination.Columns[6].Width = 100;
            this.grdSearchDestination.Columns[7].HeaderText = "شرح محصول";
            this.grdSearchDestination.Columns[7].Width = 240;
            this.grdSearchDestination.Columns[8].HeaderText = "کد ریورک";
            this.grdSearchDestination.Columns[8].Width = 80;

            this.grdSearchOrigin.DataSource = M.SearchDestination();

            this.grdSearchOrigin.Columns[0].Visible=false;
            this.grdSearchOrigin.Columns[1].Visible = false;
            //this.grdSearchOrigin.Columns[2].Visible = false;
            //this.grdSearchOrigin.Columns[3].Visible = false;
            //this.grdSearchOrigin.Columns[4].Visible = false;
            this.grdSearchOrigin.Columns[5].Visible = false;
            this.grdSearchOrigin.Columns[6].Visible = false;
            this.grdSearchOrigin.Columns[7].Visible = false;
            //this.grdSearchOrigin.Columns[8].Visible = false;
            this.grdSearchOrigin.Columns[9].Visible = false;
            this.grdSearchOrigin.Columns[10].Visible = false;

            this.grdSearchOrigin.Columns[2].HeaderText = "کد محصول";
            this.grdSearchOrigin.Columns[2].Width = 70;
            this.grdSearchOrigin.Columns[3].HeaderText = "شماره فنی";
            this.grdSearchOrigin.Columns[3].Width = 100;
            this.grdSearchOrigin.Columns[4].HeaderText = "شرح محصول";
            this.grdSearchOrigin.Columns[4].Width = 240;
            this.grdSearchOrigin.Columns[8].HeaderText = "کد ریورک";
            this.grdSearchOrigin.Columns[8].Width = 80;


        }
    }
}
