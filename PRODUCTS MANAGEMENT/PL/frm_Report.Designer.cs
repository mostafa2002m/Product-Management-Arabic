namespace PRODUCTS_MANAGEMENT.PL
{
    partial class frm_Report
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnEnquire = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cboCust_Name = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.rdbDate = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupbox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.dtpEnd);
            this.groupbox1.Controls.Add(this.dtpStart);
            this.groupbox1.Controls.Add(this.btnEnquire);
            this.groupbox1.Controls.Add(this.btnClose);
            this.groupbox1.Controls.Add(this.btnPrint);
            this.groupbox1.Controls.Add(this.cboCust_Name);
            this.groupbox1.Controls.Add(this.txtId);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.rdbId);
            this.groupbox1.Controls.Add(this.rdbDate);
            this.groupbox1.Controls.Add(this.rdbAll);
            this.groupbox1.Location = new System.Drawing.Point(27, 15);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(915, 92);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "اختيار طريقة العرض";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Location = new System.Drawing.Point(422, 58);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(157, 20);
            this.dtpEnd.TabIndex = 11;
            // 
            // dtpStart
            // 
            this.dtpStart.Enabled = false;
            this.dtpStart.Location = new System.Drawing.Point(589, 58);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(172, 20);
            this.dtpStart.TabIndex = 10;
            // 
            // btnEnquire
            // 
            this.btnEnquire.Location = new System.Drawing.Point(7, 10);
            this.btnEnquire.Name = "btnEnquire";
            this.btnEnquire.Size = new System.Drawing.Size(75, 23);
            this.btnEnquire.TabIndex = 9;
            this.btnEnquire.Text = "استعلام";
            this.btnEnquire.UseVisualStyleBackColor = true;
            this.btnEnquire.Click += new System.EventHandler(this.btnEnquire_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 62);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(6, 35);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cboCust_Name
            // 
            this.cboCust_Name.Enabled = false;
            this.cboCust_Name.FormattingEnabled = true;
            this.cboCust_Name.Location = new System.Drawing.Point(142, 57);
            this.cboCust_Name.Name = "cboCust_Name";
            this.cboCust_Name.Size = new System.Drawing.Size(176, 21);
            this.cboCust_Name.TabIndex = 8;
            this.cboCust_Name.SelectedIndexChanged += new System.EventHandler(this.cboCust_Name_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(324, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(57, 20);
            this.txtId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "إلى";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "من";
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Font = new System.Drawing.Font("Traditional Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.rdbId.Location = new System.Drawing.Point(195, 19);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(109, 25);
            this.rdbId.TabIndex = 2;
            this.rdbId.Text = "حسب المورد/العميل";
            this.rdbId.UseVisualStyleBackColor = true;
            this.rdbId.CheckedChanged += new System.EventHandler(this.rdbId_CheckedChanged);
            // 
            // rdbDate
            // 
            this.rdbDate.AutoSize = true;
            this.rdbDate.Font = new System.Drawing.Font("Traditional Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.rdbDate.Location = new System.Drawing.Point(547, 19);
            this.rdbDate.Name = "rdbDate";
            this.rdbDate.Size = new System.Drawing.Size(83, 25);
            this.rdbDate.TabIndex = 1;
            this.rdbDate.Text = "حسب التاريخ";
            this.rdbDate.UseVisualStyleBackColor = true;
            this.rdbDate.CheckedChanged += new System.EventHandler(this.rdbDate_CheckedChanged);
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Font = new System.Drawing.Font("Traditional Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.rdbAll.Location = new System.Drawing.Point(785, 19);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(48, 25);
            this.rdbAll.TabIndex = 0;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "الكل";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.dgvReport);
            this.groupbox2.Location = new System.Drawing.Point(8, 118);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(950, 261);
            this.groupbox2.TabIndex = 1;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "نتيجة البحث";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(3, 16);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(944, 242);
            this.dgvReport.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(361, 388);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 2;
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 415);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupbox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Report_Load);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.RadioButton rdbId;
        private System.Windows.Forms.RadioButton rdbDate;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cboCust_Name;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnEnquire;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}