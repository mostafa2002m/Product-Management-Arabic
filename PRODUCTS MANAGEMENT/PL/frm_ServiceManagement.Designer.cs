namespace PRODUCTS_MANAGEMENT.PL
{
    partial class frm_ServiceManagement
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint_All = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint_Single = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnPrint_All);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnPrint_Single);
            this.groupBox2.Controls.Add(this.btnPreview);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Location = new System.Drawing.Point(12, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Violet;
            this.btnAdd.Location = new System.Drawing.Point(658, 19);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 33);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "اضافة خدمة جديدة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnAdd.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnPrint_All
            // 
            this.btnPrint_All.BackColor = System.Drawing.Color.Violet;
            this.btnPrint_All.Location = new System.Drawing.Point(34, 19);
            this.btnPrint_All.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint_All.Name = "btnPrint_All";
            this.btnPrint_All.Size = new System.Drawing.Size(148, 33);
            this.btnPrint_All.TabIndex = 5;
            this.btnPrint_All.Text = "طباعة الكل";
            this.btnPrint_All.UseVisualStyleBackColor = true;
            this.btnPrint_All.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnPrint_All.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Violet;
            this.btnClose.Location = new System.Drawing.Point(34, 58);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 33);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnClose.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnPrint_Single
            // 
            this.btnPrint_Single.BackColor = System.Drawing.Color.Violet;
            this.btnPrint_Single.Location = new System.Drawing.Point(190, 19);
            this.btnPrint_Single.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint_Single.Name = "btnPrint_Single";
            this.btnPrint_Single.Size = new System.Drawing.Size(148, 33);
            this.btnPrint_Single.TabIndex = 4;
            this.btnPrint_Single.Text = "تقرير حركة العملاء";
            this.btnPrint_Single.UseVisualStyleBackColor = true;
            this.btnPrint_Single.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnPrint_Single.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Violet;
            this.btnPreview.Location = new System.Drawing.Point(190, 58);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(148, 33);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "تقرير حركات عميل";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnPreview.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Violet;
            this.btnDelete.Location = new System.Drawing.Point(346, 19);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف خدمة";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnDelete.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Violet;
            this.btnUpdate.Location = new System.Drawing.Point(502, 19);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 33);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "تعديل بيانات خدمة";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Violet;
            this.btnAddNew.Location = new System.Drawing.Point(897, 29);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(148, 33);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "اضافة عميل جديد";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 310);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvService);
            this.groupBox3.Location = new System.Drawing.Point(9, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(816, 352);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvService.Location = new System.Drawing.Point(3, 16);
            this.dgvService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvService.MultiSelect = false;
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvService.Size = new System.Drawing.Size(810, 333);
            this.dgvService.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(247, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(395, 22);
            this.txtSearch.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "أدخل مجال البحث";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(334, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = "شاشة إدارة الخدمات";
            // 
            // frm_ServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 524);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ServiceManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الخدمات";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint_All;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint_Single;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Label label6;
    }
}