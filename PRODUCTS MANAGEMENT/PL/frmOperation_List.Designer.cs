namespace PRODUCTS_MANAGEMENT.PL
{
    partial class FrmOperationList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOperation = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint_All = new System.Windows.Forms.Button();
            this.btnPrint_Single = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(327, 51);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(297, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "أدخل مجال البحث";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOperation);
            this.groupBox1.Location = new System.Drawing.Point(11, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(811, 285);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة المنتجات";
            // 
            // dgvOperation
            // 
            this.dgvOperation.AllowUserToAddRows = false;
            this.dgvOperation.AllowUserToDeleteRows = false;
            this.dgvOperation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOperation.Location = new System.Drawing.Point(2, 19);
            this.dgvOperation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvOperation.MultiSelect = false;
            this.dgvOperation.Name = "dgvOperation";
            this.dgvOperation.ReadOnly = true;
            this.dgvOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperation.Size = new System.Drawing.Size(807, 263);
            this.dgvOperation.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint_All);
            this.groupBox2.Controls.Add(this.btnPrint_Single);
            this.groupBox2.Controls.Add(this.btnPreview);
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Location = new System.Drawing.Point(11, 365);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(800, 58);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // btnPrint_All
            // 
            this.btnPrint_All.Location = new System.Drawing.Point(88, 25);
            this.btnPrint_All.Name = "btnPrint_All";
            this.btnPrint_All.Size = new System.Drawing.Size(111, 29);
            this.btnPrint_All.TabIndex = 5;
            this.btnPrint_All.Text = "طباعة الكل";
            this.btnPrint_All.UseVisualStyleBackColor = true;
            this.btnPrint_All.Visible = false;
            // 
            // btnPrint_Single
            // 
            this.btnPrint_Single.Location = new System.Drawing.Point(205, 25);
            this.btnPrint_Single.Name = "btnPrint_Single";
            this.btnPrint_Single.Size = new System.Drawing.Size(111, 29);
            this.btnPrint_Single.TabIndex = 4;
            this.btnPrint_Single.Text = "طباعة منتج";
            this.btnPrint_Single.UseVisualStyleBackColor = true;
            this.btnPrint_Single.Visible = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(322, 25);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(111, 29);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "صورة المنتج";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Visible = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddNew.Location = new System.Drawing.Point(673, 25);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(111, 29);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "اضافة منتج جديد";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Orange;
            this.btnClose.Location = new System.Drawing.Point(700, 429);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 33);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(320, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "شاشة إدارة المنتجات الخدمية";
            // 
            // FrmOperationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 468);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOperationList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة العمليات الخدمية";
            this.Activated += new System.EventHandler(this.frmOperation_List_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvOperation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint_All;
        private System.Windows.Forms.Button btnPrint_Single;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
    }
}