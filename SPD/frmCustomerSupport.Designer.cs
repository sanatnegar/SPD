namespace SPD
{
    partial class frmCustomerSupport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerSupport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSelectedName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSelectedTechNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSelectedCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTechNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdSearchResult = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalesHistory = new System.Windows.Forms.Button();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdSalesHistory = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdSearchOrigin = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdSearchDestination = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchResult)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesHistory)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchOrigin)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSelectedName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSelectedTechNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSelectedCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtTechNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grdSearchResult);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1112, 208);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجوی محصول";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "شرح محصول";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(572, 21);
            this.txtName.TabIndex = 16;
            // 
            // txtSelectedName
            // 
            this.txtSelectedName.Location = new System.Drawing.Point(88, 184);
            this.txtSelectedName.Name = "txtSelectedName";
            this.txtSelectedName.ReadOnly = true;
            this.txtSelectedName.Size = new System.Drawing.Size(572, 21);
            this.txtSelectedName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "شرح محصول";
            // 
            // txtSelectedTechNo
            // 
            this.txtSelectedTechNo.Location = new System.Drawing.Point(736, 184);
            this.txtSelectedTechNo.Name = "txtSelectedTechNo";
            this.txtSelectedTechNo.ReadOnly = true;
            this.txtSelectedTechNo.Size = new System.Drawing.Size(132, 21);
            this.txtSelectedTechNo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(872, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "شماره فنی";
            // 
            // txtSelectedCode
            // 
            this.txtSelectedCode.Location = new System.Drawing.Point(944, 184);
            this.txtSelectedCode.Name = "txtSelectedCode";
            this.txtSelectedCode.ReadOnly = true;
            this.txtSelectedCode.Size = new System.Drawing.Size(100, 21);
            this.txtSelectedCode.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1048, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "کد محصول";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(8, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTechNo
            // 
            this.txtTechNo.Location = new System.Drawing.Point(736, 24);
            this.txtTechNo.Name = "txtTechNo";
            this.txtTechNo.Size = new System.Drawing.Size(132, 21);
            this.txtTechNo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(872, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "شماره فنی";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(944, 24);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 21);
            this.txtProductCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1048, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "کد محصول";
            // 
            // grdSearchResult
            // 
            this.grdSearchResult.AllowUserToAddRows = false;
            this.grdSearchResult.AllowUserToDeleteRows = false;
            this.grdSearchResult.AllowUserToResizeColumns = false;
            this.grdSearchResult.AllowUserToResizeRows = false;
            this.grdSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchResult.Location = new System.Drawing.Point(8, 48);
            this.grdSearchResult.Name = "grdSearchResult";
            this.grdSearchResult.Size = new System.Drawing.Size(1096, 126);
            this.grdSearchResult.TabIndex = 0;
            this.grdSearchResult.Click += new System.EventHandler(this.grdSearchResult_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalesHistory);
            this.groupBox2.Controls.Add(this.cmbCustomers);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.grdSalesHistory);
            this.groupBox2.Location = new System.Drawing.Point(8, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1112, 232);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "سوابق فروش";
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.Location = new System.Drawing.Point(784, 16);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Size = new System.Drawing.Size(75, 31);
            this.btnSalesHistory.TabIndex = 12;
            this.btnSalesHistory.Text = "جستجو";
            this.btnSalesHistory.UseVisualStyleBackColor = true;
            this.btnSalesHistory.Click += new System.EventHandler(this.btnSalesHistory_Click);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(864, 24);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(177, 21);
            this.cmbCustomers.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1048, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "مشتری";
            // 
            // grdSalesHistory
            // 
            this.grdSalesHistory.AllowUserToAddRows = false;
            this.grdSalesHistory.AllowUserToDeleteRows = false;
            this.grdSalesHistory.AllowUserToResizeColumns = false;
            this.grdSalesHistory.AllowUserToResizeRows = false;
            this.grdSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalesHistory.Location = new System.Drawing.Point(8, 48);
            this.grdSalesHistory.Name = "grdSalesHistory";
            this.grdSalesHistory.Size = new System.Drawing.Size(1096, 176);
            this.grdSalesHistory.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdSearchOrigin);
            this.groupBox3.Location = new System.Drawing.Point(568, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 208);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "سوابق تبدیل به این محصول";
            // 
            // grdSearchOrigin
            // 
            this.grdSearchOrigin.AllowUserToAddRows = false;
            this.grdSearchOrigin.AllowUserToDeleteRows = false;
            this.grdSearchOrigin.AllowUserToResizeColumns = false;
            this.grdSearchOrigin.AllowUserToResizeRows = false;
            this.grdSearchOrigin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchOrigin.Location = new System.Drawing.Point(8, 24);
            this.grdSearchOrigin.Name = "grdSearchOrigin";
            this.grdSearchOrigin.Size = new System.Drawing.Size(536, 176);
            this.grdSearchOrigin.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdSearchDestination);
            this.groupBox4.Location = new System.Drawing.Point(8, 464);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(552, 208);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "سوابق تبدیل این محصول به دیگر محصولات";
            // 
            // grdSearchDestination
            // 
            this.grdSearchDestination.AllowUserToAddRows = false;
            this.grdSearchDestination.AllowUserToDeleteRows = false;
            this.grdSearchDestination.AllowUserToResizeColumns = false;
            this.grdSearchDestination.AllowUserToResizeRows = false;
            this.grdSearchDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchDestination.Location = new System.Drawing.Point(8, 24);
            this.grdSearchDestination.Name = "grdSearchDestination";
            this.grdSearchDestination.Size = new System.Drawing.Size(536, 176);
            this.grdSearchDestination.TabIndex = 0;
            // 
            // frmCustomerSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 682);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerSupport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پاسخ به مشتری";
            this.Load += new System.EventHandler(this.frmCustomerSupport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchResult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesHistory)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchOrigin)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchDestination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdSearchResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdSalesHistory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTechNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalesHistory;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSelectedName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSelectedTechNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSelectedCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdSearchOrigin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grdSearchDestination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
    }
}