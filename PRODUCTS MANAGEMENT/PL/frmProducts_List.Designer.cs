namespace PRODUCTS_MANAGEMENT.PL
{
    partial class frmProducts_List
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint_All = new System.Windows.Forms.Button();
            this.btnPrint_Single = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "أدخل مجال البحث";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(266, 62);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(297, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(11, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(811, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة المنتجات";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(14, 119);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(800, 275);
            this.dgvProducts.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint_All);
            this.groupBox2.Controls.Add(this.btnPrint_Single);
            this.groupBox2.Controls.Add(this.btnPreview);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Location = new System.Drawing.Point(11, 420);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(800, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // btnPrint_All
            // 
            this.btnPrint_All.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPrint_All.Location = new System.Drawing.Point(88, 25);
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
            this.btnPrint_Single.Location = new System.Drawing.Point(205, 25);
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
            this.btnPreview.Location = new System.Drawing.Point(322, 25);
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
            this.btnDelete.Location = new System.Drawing.Point(439, 25);
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
            this.btnUpdate.Location = new System.Drawing.Point(556, 25);
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
            this.btnAddNew.Location = new System.Drawing.Point(673, 25);
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
            this.btnClose.Location = new System.Drawing.Point(695, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 29);
            this.btnClose.TabIndex = 8;
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
            this.label6.Location = new System.Drawing.Point(329, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "شاشة إدارة الأصناف";
            // 
            // frmProducts_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 512);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts_List";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة إدارة المنتجات";
            this.Activated += new System.EventHandler(this.frmProducts_List_Activated);
            this.Load += new System.EventHandler(this.frmProducts_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint_All;
        private System.Windows.Forms.Button btnPrint_Single;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label6;
    }
}