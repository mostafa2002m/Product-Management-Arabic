namespace PRODUCTS_MANAGEMENT.PL
{
    partial class frm_TotalProfitOnSales
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
            this.btnTotalReturn = new System.Windows.Forms.Button();
            this.btnTotalReturnByDate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnآNetReturn = new System.Windows.Forms.Button();
            this.btnآNetReturnByDate = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTotalReturn
            // 
            this.btnTotalReturn.BackColor = System.Drawing.Color.Violet;
            this.btnTotalReturn.Location = new System.Drawing.Point(12, 36);
            this.btnTotalReturn.Name = "btnTotalReturn";
            this.btnTotalReturn.Size = new System.Drawing.Size(212, 40);
            this.btnTotalReturn.TabIndex = 0;
            this.btnTotalReturn.Text = "اجمالي العائد على المبيعات";
            this.btnTotalReturn.UseVisualStyleBackColor = true;
            this.btnTotalReturn.Click += new System.EventHandler(this.btnTotalReturn_Click);
            this.btnTotalReturn.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnTotalReturn.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnTotalReturnByDate
            // 
            this.btnTotalReturnByDate.BackColor = System.Drawing.Color.Violet;
            this.btnTotalReturnByDate.Location = new System.Drawing.Point(12, 65);
            this.btnTotalReturnByDate.Name = "btnTotalReturnByDate";
            this.btnTotalReturnByDate.Size = new System.Drawing.Size(212, 40);
            this.btnTotalReturnByDate.TabIndex = 1;
            this.btnTotalReturnByDate.Text = "اجمالي العائد على المبيعات خلال فترة";
            this.btnTotalReturnByDate.UseVisualStyleBackColor = true;
            this.btnTotalReturnByDate.Click += new System.EventHandler(this.btnTotalReturnByDate_Click);
            this.btnTotalReturnByDate.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnTotalReturnByDate.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(258, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(498, 73);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "من";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "الى";
            // 
            // btnآNetReturn
            // 
            this.btnآNetReturn.BackColor = System.Drawing.Color.Violet;
            this.btnآNetReturn.Location = new System.Drawing.Point(12, 103);
            this.btnآNetReturn.Name = "btnآNetReturn";
            this.btnآNetReturn.Size = new System.Drawing.Size(212, 40);
            this.btnآNetReturn.TabIndex = 6;
            this.btnآNetReturn.Text = "صافي العائد على المبيعات";
            this.btnآNetReturn.UseVisualStyleBackColor = true;
            this.btnآNetReturn.Click += new System.EventHandler(this.btnآNetReturn_Click);
            this.btnآNetReturn.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnآNetReturn.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // btnآNetReturnByDate
            // 
            this.btnآNetReturnByDate.BackColor = System.Drawing.Color.Violet;
            this.btnآNetReturnByDate.Location = new System.Drawing.Point(12, 132);
            this.btnآNetReturnByDate.Name = "btnآNetReturnByDate";
            this.btnآNetReturnByDate.Size = new System.Drawing.Size(212, 40);
            this.btnآNetReturnByDate.TabIndex = 7;
            this.btnآNetReturnByDate.Text = "صافي العائد على المبيعات خلال فترة";
            this.btnآNetReturnByDate.UseVisualStyleBackColor = true;
            this.btnآNetReturnByDate.Click += new System.EventHandler(this.btnآNetReturnByDate_Click);
            this.btnآNetReturnByDate.MouseEnter += new System.EventHandler(this.ChangeColour);
            this.btnآNetReturnByDate.MouseLeave += new System.EventHandler(this.ColourChange);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(258, 139);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 8;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(498, 139);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "من";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "الى";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Violet;
            this.btnClose.Location = new System.Drawing.Point(623, 164);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 12;
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
            this.label6.Location = new System.Drawing.Point(308, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "شاشة تقارير النشاط";
            // 
            // frm_TotalProfitOnSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(710, 205);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.btnآNetReturnByDate);
            this.Controls.Add(this.btnآNetReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnTotalReturnByDate);
            this.Controls.Add(this.btnTotalReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TotalProfitOnSales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العائد على المبيعات";
            this.Load += new System.EventHandler(this.frm_TotalProfitOnSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotalReturn;
        private System.Windows.Forms.Button btnTotalReturnByDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnآNetReturn;
        private System.Windows.Forms.Button btnآNetReturnByDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
    }
}