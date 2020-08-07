namespace SPD
{
    partial class frmInvoiceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceList));
            this.Datagridview1 = new System.Windows.Forms.DataGridView();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInoiceItemsEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFDate1 = new System.Windows.Forms.TextBox();
            this.rbFDate = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFDate2 = new System.Windows.Forms.TextBox();
            this.txtInvoiceNumber2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbInvoiceNumber = new System.Windows.Forms.RadioButton();
            this.txtInvoiceNumber1 = new System.Windows.Forms.TextBox();
            this.btnLast100Invoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // Datagridview1
            // 
            this.Datagridview1.AllowUserToAddRows = false;
            this.Datagridview1.AllowUserToDeleteRows = false;
            this.Datagridview1.AllowUserToResizeColumns = false;
            this.Datagridview1.AllowUserToResizeRows = false;
            this.Datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridview1.Location = new System.Drawing.Point(8, 64);
            this.Datagridview1.Name = "Datagridview1";
            this.Datagridview1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Datagridview1.Size = new System.Drawing.Size(856, 536);
            this.Datagridview1.TabIndex = 0;
            this.Datagridview1.TabStop = false;
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInvoice.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewInvoice.Location = new System.Drawing.Point(872, 120);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(240, 48);
            this.btnNewInvoice.TabIndex = 8;
            this.btnNewInvoice.Text = "ایجاد فاکتور جدید";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInvoice.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditInvoice.Location = new System.Drawing.Point(872, 176);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(240, 48);
            this.btnEditInvoice.TabIndex = 9;
            this.btnEditInvoice.Text = "نمایش / ویرایش اطلاعات فاکتور";
            this.btnEditInvoice.UseVisualStyleBackColor = true;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteInvoice.Location = new System.Drawing.Point(872, 288);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(240, 48);
            this.btnDeleteInvoice.TabIndex = 11;
            this.btnDeleteInvoice.Text = "حذف فاکتور";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(872, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(240, 48);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInoiceItemsEdit
            // 
            this.btnInoiceItemsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInoiceItemsEdit.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInoiceItemsEdit.Location = new System.Drawing.Point(872, 232);
            this.btnInoiceItemsEdit.Name = "btnInoiceItemsEdit";
            this.btnInoiceItemsEdit.Size = new System.Drawing.Size(240, 48);
            this.btnInoiceItemsEdit.TabIndex = 10;
            this.btnInoiceItemsEdit.Text = "نمایش / ویرایش اقلام فاکتور";
            this.btnInoiceItemsEdit.UseVisualStyleBackColor = true;
            this.btnInoiceItemsEdit.Click += new System.EventHandler(this.btnInoiceItemsEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(872, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(240, 48);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFDate1
            // 
            this.txtFDate1.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFDate1.Location = new System.Drawing.Point(648, 16);
            this.txtFDate1.MaxLength = 10;
            this.txtFDate1.Name = "txtFDate1";
            this.txtFDate1.Size = new System.Drawing.Size(124, 36);
            this.txtFDate1.TabIndex = 1;
            // 
            // rbFDate
            // 
            this.rbFDate.AutoSize = true;
            this.rbFDate.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbFDate.Location = new System.Drawing.Point(776, 16);
            this.rbFDate.Name = "rbFDate";
            this.rbFDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbFDate.Size = new System.Drawing.Size(90, 33);
            this.rbFDate.TabIndex = 0;
            this.rbFDate.TabStop = true;
            this.rbFDate.Text = "از تاریخ";
            this.rbFDate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(608, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "الی";
            // 
            // txtFDate2
            // 
            this.txtFDate2.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFDate2.Location = new System.Drawing.Point(480, 16);
            this.txtFDate2.MaxLength = 10;
            this.txtFDate2.Name = "txtFDate2";
            this.txtFDate2.Size = new System.Drawing.Size(124, 36);
            this.txtFDate2.TabIndex = 2;
            // 
            // txtInvoiceNumber2
            // 
            this.txtInvoiceNumber2.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtInvoiceNumber2.Location = new System.Drawing.Point(8, 16);
            this.txtInvoiceNumber2.MaxLength = 6;
            this.txtInvoiceNumber2.Name = "txtInvoiceNumber2";
            this.txtInvoiceNumber2.Size = new System.Drawing.Size(124, 36);
            this.txtInvoiceNumber2.TabIndex = 5;
            this.txtInvoiceNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(136, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "الی";
            // 
            // rbInvoiceNumber
            // 
            this.rbInvoiceNumber.AutoSize = true;
            this.rbInvoiceNumber.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbInvoiceNumber.Location = new System.Drawing.Point(304, 16);
            this.rbInvoiceNumber.Name = "rbInvoiceNumber";
            this.rbInvoiceNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbInvoiceNumber.Size = new System.Drawing.Size(97, 33);
            this.rbInvoiceNumber.TabIndex = 3;
            this.rbInvoiceNumber.TabStop = true;
            this.rbInvoiceNumber.Text = "از شماره";
            this.rbInvoiceNumber.UseVisualStyleBackColor = true;
            // 
            // txtInvoiceNumber1
            // 
            this.txtInvoiceNumber1.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtInvoiceNumber1.Location = new System.Drawing.Point(176, 16);
            this.txtInvoiceNumber1.MaxLength = 6;
            this.txtInvoiceNumber1.Name = "txtInvoiceNumber1";
            this.txtInvoiceNumber1.Size = new System.Drawing.Size(124, 36);
            this.txtInvoiceNumber1.TabIndex = 4;
            this.txtInvoiceNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber1_KeyPress);
            // 
            // btnLast100Invoice
            // 
            this.btnLast100Invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast100Invoice.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLast100Invoice.Location = new System.Drawing.Point(872, 64);
            this.btnLast100Invoice.Name = "btnLast100Invoice";
            this.btnLast100Invoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLast100Invoice.Size = new System.Drawing.Size(240, 48);
            this.btnLast100Invoice.TabIndex = 7;
            this.btnLast100Invoice.Text = "100 فاکتور آخر";
            this.btnLast100Invoice.UseVisualStyleBackColor = true;
            this.btnLast100Invoice.Click += new System.EventHandler(this.btnLast100Invoice_Click);
            // 
            // frmInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 609);
            this.Controls.Add(this.btnLast100Invoice);
            this.Controls.Add(this.txtInvoiceNumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbInvoiceNumber);
            this.Controls.Add(this.txtInvoiceNumber1);
            this.Controls.Add(this.txtFDate2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbFDate);
            this.Controls.Add(this.txtFDate1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInoiceItemsEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnEditInvoice);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.Datagridview1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoiceList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاکتورها";
            this.Activated += new System.EventHandler(this.frmInvoiceList_Activated);
            this.Load += new System.EventHandler(this.frmInvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datagridview1;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInoiceItemsEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFDate1;
        private System.Windows.Forms.RadioButton rbFDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFDate2;
        private System.Windows.Forms.TextBox txtInvoiceNumber2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbInvoiceNumber;
        private System.Windows.Forms.TextBox txtInvoiceNumber1;
        private System.Windows.Forms.Button btnLast100Invoice;
    }
}