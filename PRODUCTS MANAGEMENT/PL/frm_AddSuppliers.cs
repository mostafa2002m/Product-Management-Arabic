using PRODUCTS_MANAGEMENT.BL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddSuppliers : Form
    {
        string ch;
        public frm_AddSuppliers(string _ch)
        {
            InitializeComponent();
            btnSave.Enabled = false;
            groupBox1.Enabled = false;
            ch = _ch;
            if (ch=="a")
            {
                this.Text = "إضافة مورد جديد";
                btnAddNew.Text = "إضافة";
                groupBox1.Enabled = false;
            }
            else if (ch=="u")
            {

                this.Text = "تعديل بيانات مورد";
                btnAddNew.Text = "تعديل";
                btnAddNew.Enabled = false;
                btnSave.Enabled = true;
                groupBox1.Enabled = true;
                DataTable dt = cls_Supplier.stp_Select_SuppliersById(frmSupplierList.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtSupId.Text = dr["Sup_Id"].ToString();
                    txtCompany.Text = dr["Sup_Company"].ToString();
                    txtName.Text = dr["Sup_Name"].ToString();
                    txtAddress.Text = dr["Sup_Address"].ToString();
                    txtPhone.Text = dr["Sup_Phone"].ToString();
                }
            }

            else if (ch=="d")
            {
                this.Text = "حذف بيانات مورد";
                btnAddNew.Text = "حذف";
                btnAddNew.Enabled = false;
                btnSave.Enabled = true;
                groupBox1.Enabled = true;
                DataTable dt = cls_Supplier.stp_Select_SuppliersById(frmSupplierList.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtSupId.Text = dr["Sup_Id"].ToString();
                    txtCompany.Text=dr["Sup_Company"].ToString();
                    txtName.Text = dr["Sup_Name"].ToString();
                    txtAddress.Text = dr["Sup_Address"].ToString();
                    txtPhone.Text = dr["Sup_Phone"].ToString();
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
            txtCompany.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtSupId.Clear();
            txtEmail.Clear();
            txtCompany.Focus();
            lblmassage.Text = "";
            txtSupId.Text = cls_Supplier.stp_SelectLast_Supplier_Id().Rows[0][0].ToString();
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show(@"تحقق من البيانات");
                txtName.Focus();
                return;
            }
            if (ch == "a")
            {
                cls_Supplier.stp_ManipulateSupplier(ch,Convert.ToInt32(txtSupId.Text), txtCompany.Text, txtName.Text, txtAddress.Text, txtPhone.Text);
                MessageBox.Show(@"تمت الاضافة");
                DialogResult respnse = MessageBox.Show(@"اضافة رصيد افتتاحي للعميل", @"إضافة رصيد افتتاحي ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respnse == DialogResult.Yes)
                {
                    //Add_Payment();
                    new frm_Supplier_payments("رصيد افتتاحي").ShowDialog();
                }

            }
            else if (ch == "u")
            {
                cls_Supplier.stp_ManipulateSupplier(ch,frmSupplierList.ID, txtCompany.Text, txtName.Text, txtAddress.Text, txtPhone.Text);
                MessageBox.Show(@"تم التعديل");
              
            }
  
       
            else if (ch=="d")
            {
                if (MessageBox.Show(@"هل تريد حقا حذف المورد الحالي", @"تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                cls_Supplier.stp_ManipulateSupplier(ch, frmSupplierList.ID, txtCompany.Text, txtName.Text, txtAddress.Text, txtPhone.Text);
                MessageBox.Show(@"تم الحذف");
                             
            }
            txtCompany.Text = txtName.Text = txtAddress.Text = txtPhone.Text = txtEmail.Text = string.Empty;
            btnSave.Enabled = false;
            btnAddNew.Enabled = true;
            groupBox1.Enabled = false;
        }

       
        private bool IsValidData()
        {
            return

         ProductMaintainance.Validator.IsPresent(txtCompany) &&
         ProductMaintainance.Validator.IsPresent(txtName);
        
        }

    
        private void chkAccount_CheckedChanged(object sender, EventArgs e)
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
