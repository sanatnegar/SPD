namespace SPD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCustomers = new System.Windows.Forms.ToolStripButton();
            this.tsbProducts = new System.Windows.Forms.ToolStripButton();
            this.tsbFactorRegister = new System.Windows.Forms.ToolStripButton();
            this.tsbReporting = new System.Windows.Forms.ToolStripButton();
            this.tsbRework = new System.Windows.Forms.ToolStripButton();
            this.tsbCustomerSupport = new System.Windows.Forms.ToolStripButton();
            this.tsbPhoneBook = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCustomers,
            this.tsbProducts,
            this.tsbFactorRegister,
            this.tsbReporting,
            this.tsbRework,
            this.tsbCustomerSupport,
            this.tsbPhoneBook,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCustomers
            // 
            this.tsbCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCustomers.Image = ((System.Drawing.Image)(resources.GetObject("tsbCustomers.Image")));
            this.tsbCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCustomers.Name = "tsbCustomers";
            this.tsbCustomers.Size = new System.Drawing.Size(54, 54);
            this.tsbCustomers.Text = "toolStripButton1";
            this.tsbCustomers.ToolTipText = "لیست مشتریان";
            this.tsbCustomers.Click += new System.EventHandler(this.tsbCustomers_Click);
            // 
            // tsbProducts
            // 
            this.tsbProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsbProducts.Image")));
            this.tsbProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProducts.Name = "tsbProducts";
            this.tsbProducts.Size = new System.Drawing.Size(54, 54);
            this.tsbProducts.Text = "toolStripButton1";
            this.tsbProducts.Click += new System.EventHandler(this.tsbProducts_Click);
            // 
            // tsbFactorRegister
            // 
            this.tsbFactorRegister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFactorRegister.Image = ((System.Drawing.Image)(resources.GetObject("tsbFactorRegister.Image")));
            this.tsbFactorRegister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFactorRegister.Name = "tsbFactorRegister";
            this.tsbFactorRegister.Size = new System.Drawing.Size(54, 54);
            this.tsbFactorRegister.Text = "فاکتورها";
            this.tsbFactorRegister.ToolTipText = "فاکتور جدید";
            this.tsbFactorRegister.Click += new System.EventHandler(this.tsbFactorRegister_Click);
            // 
            // tsbReporting
            // 
            this.tsbReporting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReporting.Image = ((System.Drawing.Image)(resources.GetObject("tsbReporting.Image")));
            this.tsbReporting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReporting.Name = "tsbReporting";
            this.tsbReporting.Size = new System.Drawing.Size(54, 54);
            this.tsbReporting.Text = "toolStripButton3";
            this.tsbReporting.ToolTipText = "گزارشگیری کلی";
            this.tsbReporting.Click += new System.EventHandler(this.tsbReporting_Click);
            // 
            // tsbRework
            // 
            this.tsbRework.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRework.Image = ((System.Drawing.Image)(resources.GetObject("tsbRework.Image")));
            this.tsbRework.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRework.Name = "tsbRework";
            this.tsbRework.Size = new System.Drawing.Size(54, 54);
            this.tsbRework.Text = "toolStripButton4";
            this.tsbRework.ToolTipText = "سوابق ریورک";
            this.tsbRework.Click += new System.EventHandler(this.tsbRework_Click);
            // 
            // tsbCustomerSupport
            // 
            this.tsbCustomerSupport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCustomerSupport.Image = ((System.Drawing.Image)(resources.GetObject("tsbCustomerSupport.Image")));
            this.tsbCustomerSupport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCustomerSupport.Name = "tsbCustomerSupport";
            this.tsbCustomerSupport.Size = new System.Drawing.Size(54, 54);
            this.tsbCustomerSupport.Text = "پشتیبانی";
            this.tsbCustomerSupport.Click += new System.EventHandler(this.tsbCustomerSupport_Click);
            // 
            // tsbPhoneBook
            // 
            this.tsbPhoneBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPhoneBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbPhoneBook.Image")));
            this.tsbPhoneBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPhoneBook.Name = "tsbPhoneBook";
            this.tsbPhoneBook.Size = new System.Drawing.Size(54, 54);
            this.tsbPhoneBook.Text = "toolStripButton5";
            this.tsbPhoneBook.ToolTipText = "دفترچه تلفن";
            this.tsbPhoneBook.Click += new System.EventHandler(this.tsbPhoneBook_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(54, 54);
            this.tsbExit.Text = "toolStripButton6";
            this.tsbExit.ToolTipText = "خروج";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 566);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم جامع واحد بازاریابی و فروش یدک شرکت الکتریک خودرو شرق";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCustomers;
        private System.Windows.Forms.ToolStripButton tsbFactorRegister;
        private System.Windows.Forms.ToolStripButton tsbReporting;
        private System.Windows.Forms.ToolStripButton tsbRework;
        private System.Windows.Forms.ToolStripButton tsbPhoneBook;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton tsbProducts;
        private System.Windows.Forms.ToolStripButton tsbCustomerSupport;
    }
}

