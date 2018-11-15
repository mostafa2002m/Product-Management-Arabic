namespace PRODUCTS_MANAGEMENT.PL
{
    partial class frm_AddUser
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblmassage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConfirm);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(20, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المستخدم";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(6, 177);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(256, 27);
            this.cboType.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "نوع المستخدم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "تأكيد كلمة المرور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "كلمة المرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "الاسم بالكامل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم المستخدم";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(6, 141);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(256, 27);
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.Validated += new System.EventHandler(this.txtConfirm_Validated);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 27);
            this.txtPassword.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(6, 69);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(256, 27);
            this.txtFullName.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(256, 27);
            this.txtId.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Violet;
            this.btnNew.Location = new System.Drawing.Point(12, 312);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(62, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnNew.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Violet;
            this.btnClose.Location = new System.Drawing.Point(383, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnClose.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Violet;
            this.btnSave.Location = new System.Drawing.Point(80, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnSave.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // lblmassage
            // 
            this.lblmassage.AutoSize = true;
            this.lblmassage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblmassage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblmassage.ForeColor = System.Drawing.Color.DeepPink;
            this.lblmassage.Location = new System.Drawing.Point(221, 51);
            this.lblmassage.Name = "lblmassage";
            this.lblmassage.Size = new System.Drawing.Size(123, 14);
            this.lblmassage.TabIndex = 3;
            this.lblmassage.Text = "                             ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(173, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "شاشة المستخدمين";
            // 
            // frm_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(465, 347);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblmassage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblmassage;
        protected System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox cboType;
        public System.Windows.Forms.TextBox txtConfirm;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtFullName;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
    }
}