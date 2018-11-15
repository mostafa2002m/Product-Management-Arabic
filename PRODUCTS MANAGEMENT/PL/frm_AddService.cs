using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddService : Form
    {
        public string ch;
        public frm_AddService(string _ch)
        {
            InitializeComponent();
            ch = _ch;

            btnNew.Enabled = false;
            btnSave.Enabled = false;
            groupBox1.Enabled = false;
            if (ch=="a")
            {
                this.Text = "شاشة اضافة خدمة";
                btnNew.Text = "إضافة";
                btnNew.Enabled = true;
                groupBox1.Enabled = true;
            }
            else if (ch=="u")
            {
                this.Text = "شاشة تعديل خدمة";
                btnNew.Text = "تعديل";
                btnNew.Enabled = true;
                groupBox1.Enabled = true;
                DataTable dt = cls_Service.stp_SelectServiceById(frm_ServiceManagement.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtNo.Text = dr["Service_Id"].ToString();
                    txtName.Text = dr["Service_Name"].ToString();
                    txtDetail.Text = dr["Service_Detail"].ToString();

                  
                }
            }
            else if (ch=="d")
            {
                this.Text = "شاشة تعديل خدمة";
                btnNew.Text = "حذف";
                btnNew.Enabled = true;
                groupBox1.Enabled = true;
                DataTable dt = cls_Service.stp_SelectServiceById(frm_ServiceManagement.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtNo.Text = dr["Service_Id"].ToString();
                    txtName.Text = dr["Service_Name"].ToString();
                    txtDetail.Text = dr["Service_Detail"].ToString();

                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNo.Text = cls_Service.stp_SelectLast_Service_Id().Rows[0][0].ToString();
            txtName.Enabled = true;
            txtName.Focus();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                 if (txtName.Text == string.Empty)
            {
                MessageBox.Show(@"تحقق من ادخال البيانات");
                return;
            }
                if (ch=="a")
                {
                    cls_Service.stp_ManipulateService(ch, int.Parse(txtNo.Text), txtName.Text, txtDetail.Text,Convert.ToDecimal(txtPrice.Text));
                    MessageBox.Show(@"تمت الاضافة");
                }
                else if (ch=="u")
                {
                    cls_Service.stp_ManipulateService(ch, int.Parse(txtNo.Text), txtName.Text, txtDetail.Text, Convert.ToDecimal(txtPrice.Text));
                    MessageBox.Show(@"تم التعدبل");
                }
                else if (ch=="d")
                {
                    if (MessageBox.Show(@"هل تريد حقا حذف المستخدم الحالي", @"تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cls_Service.stp_ManipulateService(ch, int.Parse(txtNo.Text), txtName.Text, txtDetail.Text, Convert.ToDecimal(txtPrice.Text));
                        MessageBox.Show(@"تم الحدف");
                    }
                    
                }
               
               
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                txtNo.Text = txtName.Text = string.Empty;
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeColour(object sender, EventArgs e)
        {
            Button bColour = (Button)sender;
            bColour.BackColor = Color.LightSteelBlue;
        }

        private void ColourChange(object sender, EventArgs e)
        {
            Button bColour = (Button)sender;
            bColour.BackColor = Color.FromKnownColor(KnownColor.Control);
        }
    }
}
