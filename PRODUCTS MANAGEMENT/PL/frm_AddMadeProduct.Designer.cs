namespace PRODUCTS_MANAGEMENT.PL
{
    partial class frm_AddMadeProduct
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLargeUnit = new System.Windows.Forms.TextBox();
            this.txtSmallPrice = new System.Windows.Forms.TextBox();
            this.txtLargePrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSmallUnit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.txtCat_Id = new System.Windows.Forms.TextBox();
            this.txtReOrder = new System.Windows.Forms.TextBox();
            this.txtProNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtref = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblmassage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDetail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtLargeUnit);
            this.groupBox1.Controls.Add(this.txtSmallPrice);
            this.groupBox1.Controls.Add(this.txtLargePrice);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSmallUnit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboCat);
            this.groupBox1.Controls.Add(this.txtCat_Id);
            this.groupBox1.Controls.Add(this.txtReOrder);
            this.groupBox1.Controls.Add(this.txtProNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.picBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtref);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(631, 488);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج";
            // 
            // txtDetail
            // 
            this.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetail.Location = new System.Drawing.Point(180, 300);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetail.Size = new System.Drawing.Size(340, 176);
            this.txtDetail.TabIndex = 9;
            this.txtDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "المواصفات";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.Location = new System.Drawing.Point(67, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = ".......";
            this.toolTip1.SetToolTip(this.button1, "إضافة فئة جديدة");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.ColourChange);
            this.button1.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // txtLargeUnit
            // 
            this.txtLargeUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLargeUnit.Location = new System.Drawing.Point(392, 155);
            this.txtLargeUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLargeUnit.Name = "txtLargeUnit";
            this.txtLargeUnit.Size = new System.Drawing.Size(48, 20);
            this.txtLargeUnit.TabIndex = 4;
            this.txtLargeUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLargeUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLargeUnit_KeyDown);
            // 
            // txtSmallPrice
            // 
            this.txtSmallPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSmallPrice.Location = new System.Drawing.Point(226, 195);
            this.txtSmallPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSmallPrice.Name = "txtSmallPrice";
            this.txtSmallPrice.Size = new System.Drawing.Size(48, 20);
            this.txtSmallPrice.TabIndex = 7;
            this.txtSmallPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSmallPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSmallPrice_KeyDown);
            // 
            // txtLargePrice
            // 
            this.txtLargePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLargePrice.Location = new System.Drawing.Point(392, 195);
            this.txtLargePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLargePrice.Name = "txtLargePrice";
            this.txtLargePrice.Size = new System.Drawing.Size(48, 20);
            this.txtLargePrice.TabIndex = 6;
            this.txtLargePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLargePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLargePrice_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "سعر البيع للجمهور";
            // 
            // txtSmallUnit
            // 
            this.txtSmallUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSmallUnit.Location = new System.Drawing.Point(223, 150);
            this.txtSmallUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSmallUnit.Name = "txtSmallUnit";
            this.txtSmallUnit.Size = new System.Drawing.Size(48, 20);
            this.txtSmallUnit.TabIndex = 5;
            this.txtSmallUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSmallUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSmallUnit_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "عدد الوحدات";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "وحدة صغرى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "وحدة كبرى";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Location = new System.Drawing.Point(80, 58);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(241, 20);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "الباركود";
            // 
            // cboCat
            // 
            this.cboCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(230, 25);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(315, 21);
            this.cboCat.TabIndex = 1;
            this.cboCat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCat_KeyDown);
            // 
            // txtCat_Id
            // 
            this.txtCat_Id.Enabled = false;
            this.txtCat_Id.Location = new System.Drawing.Point(169, 25);
            this.txtCat_Id.Name = "txtCat_Id";
            this.txtCat_Id.ReadOnly = true;
            this.txtCat_Id.Size = new System.Drawing.Size(55, 20);
            this.txtCat_Id.TabIndex = 14;
            // 
            // txtReOrder
            // 
            this.txtReOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReOrder.Location = new System.Drawing.Point(262, 238);
            this.txtReOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReOrder.Name = "txtReOrder";
            this.txtReOrder.Size = new System.Drawing.Size(101, 20);
            this.txtReOrder.TabIndex = 8;
            this.txtReOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReOrder_KeyDown);
            // 
            // txtProNo
            // 
            this.txtProNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProNo.Location = new System.Drawing.Point(412, 58);
            this.txtProNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProNo.Name = "txtProNo";
            this.txtProNo.ReadOnly = true;
            this.txtProNo.Size = new System.Drawing.Size(133, 20);
            this.txtProNo.TabIndex = 1;
            this.txtProNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProNo_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "كود المنتج";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Image = global::PRODUCTS_MANAGEMENT.Properties.Resources.nopicture;
            this.picBox.Location = new System.Drawing.Point(6, 300);
            this.picBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(156, 180);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "إعادة الطلب";
            // 
            // txtref
            // 
            this.txtref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtref.Location = new System.Drawing.Point(80, 90);
            this.txtref.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtref.Name = "txtref";
            this.txtref.Size = new System.Drawing.Size(465, 20);
            this.txtref.TabIndex = 3;
            this.txtref.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtref_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم المنتج";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "فئة المنتج";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Orchid;
            this.btnClose.Location = new System.Drawing.Point(569, 526);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.ColourChange);
            this.btnClose.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 526);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 33);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = " ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.ColourChange);
            // 
            // lblmassage
            // 
            this.lblmassage.AutoSize = true;
            this.lblmassage.BackColor = System.Drawing.Color.PowderBlue;
            this.lblmassage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblmassage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblmassage.Location = new System.Drawing.Point(326, 531);
            this.lblmassage.Name = "lblmassage";
            this.lblmassage.Size = new System.Drawing.Size(109, 19);
            this.lblmassage.TabIndex = 16;
            this.lblmassage.Text = "                    ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orchid;
            this.btnSave.Location = new System.Drawing.Point(134, 526);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.ColourChange);
            this.btnSave.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(238, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 37);
            this.label13.TabIndex = 19;
            this.label13.Text = "شاشة منتجات الورشة";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "مساعدة";
            // 
            // frm_AddMadeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 561);
            this.ControlBox = false;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblmassage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddMadeProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة منتجات الورشة";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtLargeUnit;
        public System.Windows.Forms.TextBox txtSmallPrice;
        public System.Windows.Forms.TextBox txtLargePrice;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtSmallUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.TextBox txtCat_Id;
        public System.Windows.Forms.TextBox txtReOrder;
        public System.Windows.Forms.TextBox txtProNo;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtref;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblmassage;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}