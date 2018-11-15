namespace PRODUCTS_MANAGEMENT.PL
{
    partial class frm_Customer_payments
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
            this.rdbSettelment = new System.Windows.Forms.RadioButton();
            this.rdbPay = new System.Windows.Forms.RadioButton();
            this.lblMassege = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAllPaid = new System.Windows.Forms.TextBox();
            this.txtAllCredit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSupId = new System.Windows.Forms.TextBox();
            this.txtResault = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbSettelment
            // 
            this.rdbSettelment.AutoSize = true;
            this.rdbSettelment.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.rdbSettelment.Location = new System.Drawing.Point(391, 48);
            this.rdbSettelment.Name = "rdbSettelment";
            this.rdbSettelment.Size = new System.Drawing.Size(58, 29);
            this.rdbSettelment.TabIndex = 24;
            this.rdbSettelment.TabStop = true;
            this.rdbSettelment.Text = "تسوية";
            this.rdbSettelment.UseVisualStyleBackColor = true;
            // 
            // rdbPay
            // 
            this.rdbPay.AutoSize = true;
            this.rdbPay.Checked = true;
            this.rdbPay.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.rdbPay.Location = new System.Drawing.Point(278, 48);
            this.rdbPay.Name = "rdbPay";
            this.rdbPay.Size = new System.Drawing.Size(84, 29);
            this.rdbPay.TabIndex = 23;
            this.rdbPay.TabStop = true;
            this.rdbPay.Text = "دفعة مسددة";
            this.rdbPay.UseVisualStyleBackColor = true;
            // 
            // lblMassege
            // 
            this.lblMassege.AutoSize = true;
            this.lblMassege.BackColor = System.Drawing.Color.Azure;
            this.lblMassege.Font = new System.Drawing.Font("Simplified Arabic", 10F);
            this.lblMassege.Location = new System.Drawing.Point(215, 382);
            this.lblMassege.Name = "lblMassege";
            this.lblMassege.Size = new System.Drawing.Size(192, 25);
            this.lblMassege.TabIndex = 22;
            this.lblMassege.Text = "                                             ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Violet;
            this.btnClose.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(531, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 43);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnClose.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Violet;
            this.btnSave.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(424, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 43);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnSave.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Violet;
            this.btnAddNew.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.Location = new System.Drawing.Point(78, 374);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(91, 43);
            this.btnAddNew.TabIndex = 19;
            this.btnAddNew.Text = "جديد";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.btnAddNew.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnAddNew.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAllPaid);
            this.groupBox1.Controls.Add(this.txtAllCredit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSupId);
            this.groupBox1.Controls.Add(this.txtResault);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.cboNames);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Simplified Arabic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(16, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox1.Size = new System.Drawing.Size(607, 256);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات السند";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(535, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "رقم المورد";
            // 
            // txtAllPaid
            // 
            this.txtAllPaid.Enabled = false;
            this.txtAllPaid.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtAllPaid.Location = new System.Drawing.Point(216, 209);
            this.txtAllPaid.Name = "txtAllPaid";
            this.txtAllPaid.ReadOnly = true;
            this.txtAllPaid.Size = new System.Drawing.Size(179, 23);
            this.txtAllPaid.TabIndex = 14;
            this.txtAllPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAllCredit
            // 
            this.txtAllCredit.Enabled = false;
            this.txtAllCredit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtAllCredit.Location = new System.Drawing.Point(403, 209);
            this.txtAllCredit.Name = "txtAllCredit";
            this.txtAllCredit.ReadOnly = true;
            this.txtAllCredit.Size = new System.Drawing.Size(169, 23);
            this.txtAllCredit.TabIndex = 13;
            this.txtAllCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(436, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "اجمالي الدين";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(261, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "اجمالي المدفوعات";
            // 
            // txtSupId
            // 
            this.txtSupId.Enabled = false;
            this.txtSupId.Location = new System.Drawing.Point(421, 72);
            this.txtSupId.Name = "txtSupId";
            this.txtSupId.ReadOnly = true;
            this.txtSupId.Size = new System.Drawing.Size(114, 30);
            this.txtSupId.TabIndex = 10;
            this.txtSupId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResault
            // 
            this.txtResault.Enabled = false;
            this.txtResault.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtResault.Location = new System.Drawing.Point(26, 209);
            this.txtResault.Name = "txtResault";
            this.txtResault.ReadOnly = true;
            this.txtResault.Size = new System.Drawing.Size(183, 23);
            this.txtResault.TabIndex = 9;
            this.txtResault.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(216, 109);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(114, 30);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboNames
            // 
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(7, 69);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(335, 31);
            this.cboNames.TabIndex = 0;
            this.cboNames.SelectedIndexChanged += new System.EventHandler(this.cboNames_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 30);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(421, 36);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(114, 30);
            this.txtId.TabIndex = 5;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(82, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "الرصيد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(347, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "قيمة الدفعة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(350, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(355, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(539, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم السند";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(241, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 37);
            this.label13.TabIndex = 25;
            this.label13.Text = "شاشة سندات القبض";
            // 
            // frm_Customerpayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(634, 422);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rdbSettelment);
            this.Controls.Add(this.rdbPay);
            this.Controls.Add(this.lblMassege);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customerpayments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddDebit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbSettelment;
        private System.Windows.Forms.RadioButton rdbPay;
        private System.Windows.Forms.Label lblMassege;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAllPaid;
        private System.Windows.Forms.TextBox txtAllCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSupId;
        private System.Windows.Forms.TextBox txtResault;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboNames;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
    }
}