namespace PRODUCTS_MANAGEMENT.PL
{
    partial class FrmPunchManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPunch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTransDate = new System.Windows.Forms.DateTimePicker();
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkFinish = new System.Windows.Forms.CheckBox();
            this.dtpLast = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFirst = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPackTimes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPackValue = new System.Windows.Forms.TextBox();
            this.btnToPayNow = new System.Windows.Forms.Button();
            this.btnAllPackages = new System.Windows.Forms.Button();
            this.cboCust_Name = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowAllPunches = new System.Windows.Forms.Button();
            this.btnShowPaid = new System.Windows.Forms.Button();
            this.btnShowUnpaid = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPunch)).BeginInit();
            this.grbInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPunch);
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الأقساط";
            // 
            // dgvPunch
            // 
            this.dgvPunch.AllowUserToAddRows = false;
            this.dgvPunch.AllowUserToDeleteRows = false;
            this.dgvPunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPunch.Location = new System.Drawing.Point(3, 16);
            this.dgvPunch.MultiSelect = false;
            this.dgvPunch.Name = "dgvPunch";
            this.dgvPunch.ReadOnly = true;
            this.dgvPunch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPunch.Size = new System.Drawing.Size(986, 317);
            this.dgvPunch.TabIndex = 0;
            this.dgvPunch.Click += new System.EventHandler(this.dgvPunch_Click);
            this.dgvPunch.DoubleClick += new System.EventHandler(this.dgvPunch_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(917, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم العملية";
            // 
            // txtTransNo
            // 
            this.txtTransNo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtTransNo.Location = new System.Drawing.Point(858, 13);
            this.txtTransNo.Name = "txtTransNo";
            this.txtTransNo.Size = new System.Drawing.Size(57, 23);
            this.txtTransNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(811, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاريخها";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtOrderNo.Location = new System.Drawing.Point(474, 9);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(57, 23);
            this.txtOrderNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(537, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "رقم الفاتورة";
            // 
            // txtCustNo
            // 
            this.txtCustNo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtCustNo.Location = new System.Drawing.Point(351, 10);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.Size = new System.Drawing.Size(57, 23);
            this.txtCustNo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(414, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "رقم العميل";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtCustName.Location = new System.Drawing.Point(138, 12);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(145, 23);
            this.txtCustName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(289, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "اسم العميل";
            // 
            // txtOrderValue
            // 
            this.txtOrderValue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtOrderValue.Location = new System.Drawing.Point(6, 13);
            this.txtOrderValue.Name = "txtOrderValue";
            this.txtOrderValue.Size = new System.Drawing.Size(57, 23);
            this.txtOrderValue.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(66, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "قيمة الفاتورة";
            // 
            // dtpTransDate
            // 
            this.dtpTransDate.Location = new System.Drawing.Point(605, 12);
            this.dtpTransDate.Name = "dtpTransDate";
            this.dtpTransDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTransDate.TabIndex = 13;
            // 
            // grbInformation
            // 
            this.grbInformation.Controls.Add(this.txtPhone);
            this.grbInformation.Controls.Add(this.label12);
            this.grbInformation.Controls.Add(this.chkFinish);
            this.grbInformation.Controls.Add(this.dtpLast);
            this.grbInformation.Controls.Add(this.label11);
            this.grbInformation.Controls.Add(this.dtpFirst);
            this.grbInformation.Controls.Add(this.label10);
            this.grbInformation.Controls.Add(this.label9);
            this.grbInformation.Controls.Add(this.txtDownPayment);
            this.grbInformation.Controls.Add(this.label8);
            this.grbInformation.Controls.Add(this.txtPackTimes);
            this.grbInformation.Controls.Add(this.label7);
            this.grbInformation.Controls.Add(this.txtPackValue);
            this.grbInformation.Controls.Add(this.label1);
            this.grbInformation.Controls.Add(this.txtOrderValue);
            this.grbInformation.Controls.Add(this.dtpTransDate);
            this.grbInformation.Controls.Add(this.label6);
            this.grbInformation.Controls.Add(this.txtTransNo);
            this.grbInformation.Controls.Add(this.txtCustName);
            this.grbInformation.Controls.Add(this.label2);
            this.grbInformation.Controls.Add(this.label5);
            this.grbInformation.Controls.Add(this.label3);
            this.grbInformation.Controls.Add(this.txtCustNo);
            this.grbInformation.Controls.Add(this.txtOrderNo);
            this.grbInformation.Controls.Add(this.label4);
            this.grbInformation.Location = new System.Drawing.Point(21, 46);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(980, 110);
            this.grbInformation.TabIndex = 14;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "بيانات العملية";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(139, 38);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(145, 23);
            this.txtPhone.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(290, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "الجوال";
            // 
            // chkFinish
            // 
            this.chkFinish.AutoSize = true;
            this.chkFinish.Location = new System.Drawing.Point(11, 70);
            this.chkFinish.Name = "chkFinish";
            this.chkFinish.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFinish.Size = new System.Drawing.Size(44, 18);
            this.chkFinish.TabIndex = 25;
            this.chkFinish.Text = "انتهى";
            this.chkFinish.UseVisualStyleBackColor = true;
            // 
            // dtpLast
            // 
            this.dtpLast.Location = new System.Drawing.Point(61, 67);
            this.dtpLast.Name = "dtpLast";
            this.dtpLast.Size = new System.Drawing.Size(200, 20);
            this.dtpLast.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(267, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "ت.آخر قسط";
            // 
            // dtpFirst
            // 
            this.dtpFirst.Location = new System.Drawing.Point(339, 67);
            this.dtpFirst.Name = "dtpFirst";
            this.dtpFirst.Size = new System.Drawing.Size(200, 20);
            this.dtpFirst.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(545, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "ت.آأول قسط";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(673, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "المقدم";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtDownPayment.Location = new System.Drawing.Point(614, 68);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(57, 23);
            this.txtDownPayment.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(795, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "العدد";
            // 
            // txtPackTimes
            // 
            this.txtPackTimes.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtPackTimes.Location = new System.Drawing.Point(736, 68);
            this.txtPackTimes.Name = "txtPackTimes";
            this.txtPackTimes.Size = new System.Drawing.Size(57, 23);
            this.txtPackTimes.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(917, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "القسط";
            // 
            // txtPackValue
            // 
            this.txtPackValue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtPackValue.Location = new System.Drawing.Point(858, 68);
            this.txtPackValue.Name = "txtPackValue";
            this.txtPackValue.Size = new System.Drawing.Size(57, 23);
            this.txtPackValue.TabIndex = 15;
            // 
            // btnToPayNow
            // 
            this.btnToPayNow.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnToPayNow.ForeColor = System.Drawing.Color.Maroon;
            this.btnToPayNow.Location = new System.Drawing.Point(196, 506);
            this.btnToPayNow.Name = "btnToPayNow";
            this.btnToPayNow.Size = new System.Drawing.Size(97, 29);
            this.btnToPayNow.TabIndex = 15;
            this.btnToPayNow.Text = "أقساط مسنحقة الدفع";
            this.btnToPayNow.UseVisualStyleBackColor = true;
            this.btnToPayNow.Click += new System.EventHandler(this.btnToPayNow_Click);
            this.btnToPayNow.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnToPayNow.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnAllPackages
            // 
            this.btnAllPackages.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnAllPackages.ForeColor = System.Drawing.Color.Maroon;
            this.btnAllPackages.Location = new System.Drawing.Point(86, 506);
            this.btnAllPackages.Name = "btnAllPackages";
            this.btnAllPackages.Size = new System.Drawing.Size(97, 29);
            this.btnAllPackages.TabIndex = 16;
            this.btnAllPackages.Text = "جميع الاقساط";
            this.btnAllPackages.UseVisualStyleBackColor = true;
            this.btnAllPackages.Click += new System.EventHandler(this.btnAllPackages_Click);
            this.btnAllPackages.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnAllPackages.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // cboCust_Name
            // 
            this.cboCust_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCust_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCust_Name.FormattingEnabled = true;
            this.cboCust_Name.Location = new System.Drawing.Point(120, 10);
            this.cboCust_Name.Name = "cboCust_Name";
            this.cboCust_Name.Size = new System.Drawing.Size(248, 22);
            this.cboCust_Name.TabIndex = 17;
            this.cboCust_Name.SelectedValueChanged += new System.EventHandler(this.cboCust_Name_SelectedValueChanged);
            this.cboCust_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCust_Name_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(27, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "اختر اسم العميل";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(990, 507);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 29);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "خــروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnClose.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnShowAllPunches
            // 
            this.btnShowAllPunches.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAllPunches.ForeColor = System.Drawing.Color.Maroon;
            this.btnShowAllPunches.Location = new System.Drawing.Point(503, 7);
            this.btnShowAllPunches.Name = "btnShowAllPunches";
            this.btnShowAllPunches.Size = new System.Drawing.Size(97, 29);
            this.btnShowAllPunches.TabIndex = 20;
            this.btnShowAllPunches.Text = "جميع الاقساط";
            this.btnShowAllPunches.UseVisualStyleBackColor = true;
            this.btnShowAllPunches.Click += new System.EventHandler(this.btnShowAllPunches_Click);
            this.btnShowAllPunches.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnShowAllPunches.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnShowPaid
            // 
            this.btnShowPaid.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowPaid.ForeColor = System.Drawing.Color.Maroon;
            this.btnShowPaid.Location = new System.Drawing.Point(615, 7);
            this.btnShowPaid.Name = "btnShowPaid";
            this.btnShowPaid.Size = new System.Drawing.Size(97, 29);
            this.btnShowPaid.TabIndex = 21;
            this.btnShowPaid.Text = "الاقساط المسددة";
            this.btnShowPaid.UseVisualStyleBackColor = true;
            this.btnShowPaid.Click += new System.EventHandler(this.btnShowPaid_Click);
            this.btnShowPaid.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnShowPaid.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnShowUnpaid
            // 
            this.btnShowUnpaid.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowUnpaid.ForeColor = System.Drawing.Color.Maroon;
            this.btnShowUnpaid.Location = new System.Drawing.Point(718, 6);
            this.btnShowUnpaid.Name = "btnShowUnpaid";
            this.btnShowUnpaid.Size = new System.Drawing.Size(97, 29);
            this.btnShowUnpaid.TabIndex = 22;
            this.btnShowUnpaid.Text = "الأقساط الحالية";
            this.btnShowUnpaid.UseVisualStyleBackColor = true;
            this.btnShowUnpaid.Click += new System.EventHandler(this.btnShowUnpaid_Click);
            this.btnShowUnpaid.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnShowUnpaid.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtId.Location = new System.Drawing.Point(374, 9);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(57, 23);
            this.txtId.TabIndex = 23;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(889, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 37);
            this.label14.TabIndex = 24;
            this.label14.Text = "شاشة إدارة الأقساط";
            // 
            // FrmPunchManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1109, 541);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnShowUnpaid);
            this.Controls.Add(this.btnShowPaid);
            this.Controls.Add(this.btnShowAllPunches);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboCust_Name);
            this.Controls.Add(this.btnAllPackages);
            this.Controls.Add(this.btnToPayNow);
            this.Controls.Add(this.grbInformation);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPunchManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة إدارة الأقساط";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPunch)).EndInit();
            this.grbInformation.ResumeLayout(false);
            this.grbInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTransDate;
        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.CheckBox chkFinish;
        private System.Windows.Forms.DateTimePicker dtpLast;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFirst;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPackTimes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPackValue;
        private System.Windows.Forms.Button btnToPayNow;
        private System.Windows.Forms.Button btnAllPackages;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboCust_Name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowAllPunches;
        private System.Windows.Forms.Button btnShowPaid;
        private System.Windows.Forms.Button btnShowUnpaid;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label14;
    }
}