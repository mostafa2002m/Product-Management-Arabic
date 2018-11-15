using System;
using System.Data;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;
using System.Drawing;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class FrmAddCustomer : Form
    {
        string ch;
        public FrmAddCustomer(string _ch)
        {
            InitializeComponent();
            ch = _ch;
            if (ch=="a")
            {
                groupBox1.Enabled = false;
                btnAddNew.Text = "إضافة";
                this.Text = "إضافة عميل جديد";
            }
            else if (ch=="u")
            {
                btnAddNew.Text = "تعديل";
                this.Text = "تعديل بيانات عميل";
                btnAddNew.Enabled = false;
                groupBox1.Enabled = true;
                DataTable dt = cls_Customer.stp_SelectCustomersById(FrmCustomerList.Id);
                foreach (DataRow dr in dt.Rows)
                {
                    
                    txtName.Text = dr["الاسم"].ToString();
                    txtAddress.Text = dr["العنوان"].ToString();
                    txtPhone.Text = dr["التليفون"].ToString();
                }
            }
            else if (ch=="d")
            {
                btnAddNew.Text = "حذف";
                this.Text = "حذف بيانات عميل";
                btnAddNew.Enabled = false;
                groupBox1.Enabled = true;
                DataTable dt = cls_Customer.stp_SelectCustomersById(FrmCustomerList.Id);
                foreach (DataRow dr in dt.Rows)
                {

                    txtName.Text = dr["الاسم"].ToString();
                    txtAddress.Text = dr["العنوان"].ToString();
                    txtPhone.Text = dr["التليفون"].ToString();
                }
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
            groupBox1.Enabled = true;
            txtAddress.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtSupId.Clear();
            txtEmail.Clear();
            txtName.Focus();
            lblmassage.Text = "";
            txtSupId.Text = cls_Customer.stp_SelectLast_Customer_Id().Rows[0][0].ToString();
        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty)
                {
                    MessageBox.Show(@"نحقق من البيانات");
                    txtName.Focus();
                    return;
                }
                if (ch=="a")
                {
                    cls_Customer.stp_ManipulateCustomer(ch,Convert.ToInt32(txtSupId.Text), txtName.Text, txtAddress.Text, txtPhone.Text);
                    MessageBox.Show(@"تمت الاضافة");
                    txtPhone.Text = txtAddress.Text = txtPhone.Text = string.Empty;
                    DialogResult respnse = MessageBox.Show(@"اضافة رصيد افتتاحي للعميل", @"إضافة رصيد افتتاحي ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respnse == DialogResult.Yes)
                    {
                        //Add_Payment();
                        new frm_Customer_payments("رصيد افتتاحي").ShowDialog();
                    }
                }
                else if (ch=="u")
                {
                    cls_Customer.stp_ManipulateCustomer(ch,FrmCustomerList.Id, txtName.Text, txtAddress.Text, txtPhone.Text);
                    MessageBox.Show(@"تم التعديل");
                    txtName.Text = txtAddress.Text = txtPhone.Text = string.Empty;
                }
               
               
                else if (ch=="d")
                {
                    if (MessageBox.Show(@"حذف البيانات", @"تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cls_Customer.stp_ManipulateCustomer(ch,FrmCustomerList.Id, txtName.Text, txtAddress.Text, txtPhone.Text);
                        MessageBox.Show(@"تم الحذف");
                        txtName.Text = txtAddress.Text = txtPhone.Text = string.Empty;
                    }
                }
                txtName.Text = txtAddress.Text = txtPhone.Text = txtEmail.Text = string.Empty;
                btnSave.Enabled = false;
                btnAddNew.Enabled = true;
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

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
