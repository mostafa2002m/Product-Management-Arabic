namespace PRODUCTS_MANAGEMENT.PL
{
    partial class frm_AddPayment_Punch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtordervalue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPackNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDown = new System.Windows.Forms.DateTimePicker();
            this.dtpPackageStart = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPackage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtPunchId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpPackageEnd = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtcustid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtorderid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcustname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtordervalue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(121, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 47);
            this.panel1.TabIndex = 1;
            // 
            // txtcustid
            // 
            this.txtcustid.Enabled = false;
            this.txtcustid.Location = new System.Drawing.Point(572, 15);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.ReadOnly = true;
            this.txtcustid.Size = new System.Drawing.Size(77, 20);
            this.txtcustid.TabIndex = 16;
            this.txtcustid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(81, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "المبلغ";
            // 
            // txtorderid
            // 
            this.txtorderid.Enabled = false;
            this.txtorderid.Location = new System.Drawing.Point(143, 15);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.ReadOnly = true;
            this.txtorderid.Size = new System.Drawing.Size(77, 20);
            this.txtorderid.TabIndex = 14;
            this.txtorderid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(226, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "رقم الفاتورة";
            // 
            // txtcustname
            // 
            this.txtcustname.Enabled = false;
            this.txtcustname.Location = new System.Drawing.Point(317, 14);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.ReadOnly = true;
            this.txtcustname.Size = new System.Drawing.Size(196, 20);
            this.txtcustname.TabIndex = 12;
            this.txtcustname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(519, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "الاسم";
            // 
            // txtordervalue
            // 
            this.txtordervalue.Enabled = false;
            this.txtordervalue.Location = new System.Drawing.Point(3, 15);
            this.txtordervalue.Name = "txtordervalue";
            this.txtordervalue.ReadOnly = true;
            this.txtordervalue.Size = new System.Drawing.Size(77, 20);
            this.txtordervalue.TabIndex = 10;
            this.txtordervalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(655, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "رقم العميل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(368, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "تاريخ القسط الأول";
            // 
            // txtPackNo
            // 
            this.txtPackNo.Location = new System.Drawing.Point(279, 261);
            this.txtPackNo.Name = "txtPackNo";
            this.txtPackNo.ReadOnly = true;
            this.txtPackNo.Size = new System.Drawing.Size(77, 20);
            this.txtPackNo.TabIndex = 14;
            this.txtPackNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(175, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "عدد الاقساط";
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(279, 227);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(59, 20);
            this.txtPackage.TabIndex = 12;
            this.txtPackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(130, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "قيمة القسط الشهري";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(279, 174);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(59, 20);
            this.txtDownPayment.TabIndex = 10;
            this.txtDownPayment.Text = "0";
            this.txtDownPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(123, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "دفعة مقدمة";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(412, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "تاريخها";
            // 
            // dtpDown
            // 
            this.dtpDown.Location = new System.Drawing.Point(504, 177);
            this.dtpDown.Name = "dtpDown";
            this.dtpDown.Size = new System.Drawing.Size(200, 20);
            this.dtpDown.TabIndex = 18;
            // 
            // dtpPackageStart
            // 
            this.dtpPackageStart.Location = new System.Drawing.Point(501, 227);
            this.dtpPackageStart.Name = "dtpPackageStart";
            this.dtpPackageStart.Size = new System.Drawing.Size(200, 20);
            this.dtpPackageStart.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(970, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnClose.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPackage);
            this.groupBox1.Location = new System.Drawing.Point(47, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 264);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل القسط الشهري";
            // 
            // dgvPackage
            // 
            this.dgvPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column3,
            this.Column9,
            this.Column10,
            this.Column7});
            this.dgvPackage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPackage.Location = new System.Drawing.Point(3, 16);
            this.dgvPackage.Name = "dgvPackage";
            this.dgvPackage.ReadOnly = true;
            this.dgvPackage.Size = new System.Drawing.Size(960, 245);
            this.dgvPackage.TabIndex = 0;
            this.dgvPackage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackage_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "م";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "رقم العملية";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "القسط";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ت الاستحقاق";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ت السداد";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "رقم السداد";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "التاخير";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "الرصيد";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "السداد";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(18, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 29);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "إحسب القسط";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnCalculate.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // txtPunchId
            // 
            this.txtPunchId.Enabled = false;
            this.txtPunchId.Location = new System.Drawing.Point(227, 59);
            this.txtPunchId.Name = "txtPunchId";
            this.txtPunchId.ReadOnly = true;
            this.txtPunchId.Size = new System.Drawing.Size(77, 20);
            this.txtPunchId.TabIndex = 24;
            this.txtPunchId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(131, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "رقم العملية";
            // 
            // dtpPackageEnd
            // 
            this.dtpPackageEnd.Location = new System.Drawing.Point(500, 263);
            this.dtpPackageEnd.Name = "dtpPackageEnd";
            this.dtpPackageEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpPackageEnd.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(364, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "تاريخ القسط الأخير";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(18, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 29);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "حفظ البيانات";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnSave.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(710, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 136);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(456, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "شاشة لائحة الأقساط";
            // 
            // frm_AddPayment_Punch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1075, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpPackageEnd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPunchId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpPackageStart);
            this.Controls.Add(this.dtpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPackNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPackage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddPayment_Punch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtordervalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPackNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDown;
        private System.Windows.Forms.DateTimePicker dtpPackageStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPackage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPunchId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpPackageEnd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.Label label1;
    }
}