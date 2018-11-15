namespace PRODUCTS_MANAGEMENT.PL
{
    partial class frmMadeProductList
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMadeProduct = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint_All = new System.Windows.Forms.Button();
            this.btnPrint_Single = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMadeProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(224, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(354, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "مربع بحث";
            // 
            // dgvMadeProduct
            // 
            this.dgvMadeProduct.AllowUserToAddRows = false;
            this.dgvMadeProduct.AllowUserToDeleteRows = false;
            this.dgvMadeProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMadeProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMadeProduct.Location = new System.Drawing.Point(2, 76);
            this.dgvMadeProduct.MultiSelect = false;
            this.dgvMadeProduct.Name = "dgvMadeProduct";
            this.dgvMadeProduct.ReadOnly = true;
            this.dgvMadeProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMadeProduct.Size = new System.Drawing.Size(826, 364);
            this.dgvMadeProduct.TabIndex = 5;
            this.dgvMadeProduct.DoubleClick += new System.EventHandler(this.dgvMadeProduct_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint_All);
            this.groupBox2.Controls.Add(this.btnPrint_Single);
            this.groupBox2.Controls.Add(this.btnPreview);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Location = new System.Drawing.Point(5, 455);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(717, 56);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // btnPrint_All
            // 
            this.btnPrint_All.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPrint_All.Location = new System.Drawing.Point(8, 19);
            this.btnPrint_All.Name = "btnPrint_All";
            this.btnPrint_All.Size = new System.Drawing.Size(111, 29);
            this.btnPrint_All.TabIndex = 5;
            this.btnPrint_All.Text = "طباعة الكل";
            this.btnPrint_All.UseVisualStyleBackColor = true;
            this.btnPrint_All.Click += new System.EventHandler(this.btnPrint_All_Click);
            this.btnPrint_All.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnPrint_All.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnPrint_Single
            // 
            this.btnPrint_Single.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPrint_Single.Location = new System.Drawing.Point(125, 19);
            this.btnPrint_Single.Name = "btnPrint_Single";
            this.btnPrint_Single.Size = new System.Drawing.Size(111, 29);
            this.btnPrint_Single.TabIndex = 4;
            this.btnPrint_Single.Text = "طباعة منتج";
            this.btnPrint_Single.UseVisualStyleBackColor = true;
            this.btnPrint_Single.Click += new System.EventHandler(this.btnPrint_Single_Click);
            this.btnPrint_Single.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnPrint_Single.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPreview.Location = new System.Drawing.Point(242, 19);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(111, 29);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "صورة المنتج";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            this.btnPreview.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnPreview.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDelete.Location = new System.Drawing.Point(359, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف منتج";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnDelete.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSalmon;
            this.btnUpdate.Location = new System.Drawing.Point(476, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "تعديل المنتج";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddNew.Location = new System.Drawing.Point(593, 19);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(111, 29);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "اضافة منتج جديد";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.btnAddNew.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnAddNew.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClose.Location = new System.Drawing.Point(740, 471);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 29);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnClose.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(338, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "شاشة إدارة منتجات الورشة";
            // 
            // frmMadeProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 512);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvMadeProduct);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmMadeProductList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة عرض منتجات الورشة";
            this.Activated += new System.EventHandler(this.frmMadeProductList_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMadeProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvMadeProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint_All;
        private System.Windows.Forms.Button btnPrint_Single;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
    }
}