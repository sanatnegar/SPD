namespace SPD
{
    partial class rbOrigin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rbOrigin));
            this.Datagridview1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.rbOriginCode = new System.Windows.Forms.RadioButton();
            this.rbDestination = new System.Windows.Forms.RadioButton();
            this.rbReworkCode = new System.Windows.Forms.RadioButton();
            this.txtReworkCode = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
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
            this.Datagridview1.Location = new System.Drawing.Point(8, 50);
            this.Datagridview1.Name = "Datagridview1";
            this.Datagridview1.Size = new System.Drawing.Size(976, 534);
            this.Datagridview1.TabIndex = 33;
            this.Datagridview1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(992, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "جستجو:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDestination.Location = new System.Drawing.Point(352, 8);
            this.txtDestination.MaxLength = 255;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(184, 36);
            this.txtDestination.TabIndex = 36;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // txtOrigin
            // 
            this.txtOrigin.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtOrigin.Location = new System.Drawing.Point(696, 8);
            this.txtOrigin.MaxLength = 10;
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(188, 36);
            this.txtOrigin.TabIndex = 35;
            this.txtOrigin.TextChanged += new System.EventHandler(this.txtOrigin_TextChanged);
            // 
            // rbOriginCode
            // 
            this.rbOriginCode.AutoSize = true;
            this.rbOriginCode.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbOriginCode.Location = new System.Drawing.Point(888, 8);
            this.rbOriginCode.Name = "rbOriginCode";
            this.rbOriginCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbOriginCode.Size = new System.Drawing.Size(92, 33);
            this.rbOriginCode.TabIndex = 42;
            this.rbOriginCode.TabStop = true;
            this.rbOriginCode.Text = "کد مبدا";
            this.rbOriginCode.UseVisualStyleBackColor = true;
            // 
            // rbDestination
            // 
            this.rbDestination.AutoSize = true;
            this.rbDestination.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbDestination.Location = new System.Drawing.Point(544, 8);
            this.rbDestination.Name = "rbDestination";
            this.rbDestination.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbDestination.Size = new System.Drawing.Size(102, 33);
            this.rbDestination.TabIndex = 43;
            this.rbDestination.TabStop = true;
            this.rbDestination.Text = "کد مقصد";
            this.rbDestination.UseVisualStyleBackColor = true;
            // 
            // rbReworkCode
            // 
            this.rbReworkCode.AutoSize = true;
            this.rbReworkCode.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbReworkCode.Location = new System.Drawing.Point(200, 8);
            this.rbReworkCode.Name = "rbReworkCode";
            this.rbReworkCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbReworkCode.Size = new System.Drawing.Size(107, 33);
            this.rbReworkCode.TabIndex = 45;
            this.rbReworkCode.TabStop = true;
            this.rbReworkCode.Text = "کد ریورک";
            this.rbReworkCode.UseVisualStyleBackColor = true;
            // 
            // txtReworkCode
            // 
            this.txtReworkCode.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtReworkCode.Location = new System.Drawing.Point(8, 8);
            this.txtReworkCode.MaxLength = 255;
            this.txtReworkCode.Name = "txtReworkCode";
            this.txtReworkCode.Size = new System.Drawing.Size(184, 36);
            this.txtReworkCode.TabIndex = 44;
            this.txtReworkCode.TextChanged += new System.EventHandler(this.txtReworkCode_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(992, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 78);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "حذف ریورک";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(992, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 78);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "افزودن ریورک";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(992, 302);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 78);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "خروج";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(992, 134);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 78);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "ویرایش ریورک";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rbOrigin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 591);
            this.Controls.Add(this.rbReworkCode);
            this.Controls.Add(this.txtReworkCode);
            this.Controls.Add(this.rbDestination);
            this.Controls.Add(this.rbOriginCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Datagridview1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rbOrigin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست ریورک";
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView Datagridview1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.RadioButton rbOriginCode;
        private System.Windows.Forms.RadioButton rbDestination;
        private System.Windows.Forms.RadioButton rbReworkCode;
        private System.Windows.Forms.TextBox txtReworkCode;
    }
}