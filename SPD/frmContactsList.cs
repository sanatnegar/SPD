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
    public partial class frmContactsList : Form
    {
        public frmContactsList()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count != 0)
            {
                frmContactsEdit fo = new frmContactsEdit();
                fo.ID=long.Parse(this.dataGridView1[0,dataGridView1.CurrentRow.Index].Value.ToString());    
                fo.txtFName.Text=this.dataGridView1[1,dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtLName.Text = this.dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtTel1.Text = this.dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtTel2.Text = this.dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtCell1.Text = this.dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtCell2.Text = this.dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtWeb.Text = this.dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtEmail1.Text = this.dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtEmail2.Text = this.dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.ShowDialog();
            }
            else
            {
                MessageBox.Show("هیچ رکوردی وجود ندارد", "خطا", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmContactsAdd fo = new frmContactsAdd();
            fo.ShowDialog();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            UpdateDatagrid();
            
        }

        private void UpdateDatagrid()
        {
            BL_frmContactsList M = new BL_frmContactsList();
            M.FName = this.txtFName.Text.ToString();
            M.LName = this.txtLName.Text.ToString();
            this.dataGridView1.DataSource = M.SearchContacts();

            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

            this.dataGridView1.Columns[0].Visible = false;
            //this.dataGridView1.Columns[4].Visible = false;
            //this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[7].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;

            this.dataGridView1.Columns[1].HeaderText = "نام";
            this.dataGridView1.Columns[1].Width = 100;
            this.dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
            this.dataGridView1.Columns[2].Width = 200;
            this.dataGridView1.Columns[3].HeaderText = "تلفن ثابت 1";
            this.dataGridView1.Columns[3].Width = 150;
            this.dataGridView1.Columns[4].HeaderText = "تلفن ثابت 2";
            this.dataGridView1.Columns[4].Width = 150;
            this.dataGridView1.Columns[5].HeaderText = "همراه 1";
            this.dataGridView1.Columns[5].Width = 150;
            this.dataGridView1.Columns[6].HeaderText = "همراه 2";
            this.dataGridView1.Columns[6].Width = 150;


            

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count != 0)
            {
                if (MessageBox.Show("آیا از حذف اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Deleting seleted record
                    BL_frmContactsList M = new BL_frmContactsList();
                    M.ID=long.Parse(this.dataGridView1[0,dataGridView1.CurrentRow.Index].Value.ToString());
                    M.DeleteContact();
                }
            }
            else
            {
                MessageBox.Show("هیچ رکوردی وجود ندارد؟", "پیام", MessageBoxButtons.OK);
            }
        }
    }
}
