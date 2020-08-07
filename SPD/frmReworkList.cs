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
    public partial class rbOrigin : Form
    {
        public rbOrigin()
        {
            InitializeComponent();
        }

        private void txtOrigin_TextChanged(object sender, EventArgs e)
        {
            this.rbOriginCode.Checked = true;
            this.txtDestination.Text = "";
            this.txtReworkCode.Text = "";
            UpdateDataGrid();

        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            this.rbDestination.Checked = true;
            this.txtOrigin.Text = "";
            this.txtReworkCode.Text = "";
            UpdateDataGrid();
        }

        private void txtReworkCode_TextChanged(object sender, EventArgs e)
        {
            this.rbReworkCode.Checked = true;
            this.txtOrigin.Text = "";
            this.txtDestination.Text = "";
            UpdateDataGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmReworkAdd fo = new frmReworkAdd();
            fo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDataGrid()
        {
            BL_frmReworkList M = new BL_frmReworkList();
            
            if (this.rbOriginCode.Checked == true)
            {
                M.OriginCode = this.txtOrigin.Text.ToString();
                this.Datagridview1.DataSource = M.SelectByOrigin();
            }
            if (this.rbDestination.Checked == true)
            {
                M.DestinationCode = this.txtDestination.Text.ToString();
                this.Datagridview1.DataSource = M.SelectByDestination();
            }
            if (this.rbReworkCode.Checked == true)
            {
                M.ReworkCode = this.txtReworkCode.Text.ToString();
                this.Datagridview1.DataSource = M.SelectByReworkCode();
            }

            this.Datagridview1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.Datagridview1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            this.Datagridview1.Columns[0].Visible = false;
            //this.Datagridview1.Columns[3].Visible = false;
            this.Datagridview1.Columns[4].Visible = false;
            //this.Datagridview1.Columns[6].Visible = false;
            this.Datagridview1.Columns[7].Visible = false;
            this.Datagridview1.Columns[10].Visible = false;

            this.Datagridview1.Columns[1].HeaderText = " تاریخ";
            this.Datagridview1.Columns[2].HeaderText = "کد مبدا";
            
            this.Datagridview1.Columns[3].HeaderText = "شماره فنی مبدا";
            this.Datagridview1.Columns[3].Width = 150;
            this.Datagridview1.Columns[5].HeaderText = "کد مقصد";
            this.Datagridview1.Columns[6].HeaderText = "شماره فنی مقصد";
            this.Datagridview1.Columns[6].Width = 150;
            this.Datagridview1.Columns[8].HeaderText = "کد ریورک";
            this.Datagridview1.Columns[9].HeaderText = "تعداد";
                       
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Datagridview1.Rows.Count != 0)
            {
                frmReworkEdit fo = new frmReworkEdit();
                fo.txtFDate.Text = this.Datagridview1[1, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtOriginCode.Text = this.Datagridview1[2, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtOriginTechNo.Text = this.Datagridview1[3, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtOriginName.Text = this.Datagridview1[4, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtDestinationCode.Text = this.Datagridview1[5, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtDestinationTechNo.Text = this.Datagridview1[6, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtDestinationName.Text = this.Datagridview1[7, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtReworkCode.Text = this.Datagridview1[8, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtQuantity.Text = this.Datagridview1[9, Datagridview1.CurrentRow.Index].Value.ToString();
                fo.txtDescription.Text = this.Datagridview1[10, Datagridview1.CurrentRow.Index].Value.ToString();

                fo.ShowDialog();
            }
            else
            {
                MessageBox.Show("هیچ رکوردی وجود ندارد", "پیام", MessageBoxButtons.OK);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo )== DialogResult.Yes)
            {
                BL_frmReworkList M = new BL_frmReworkList();
                M.ReworkCode = this.Datagridview1[8, Datagridview1.CurrentRow.Index].Value.ToString();
                M.Delete();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
