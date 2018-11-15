using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddCategory : MetroFramework.Forms.MetroForm
    {
        string ch;
        public frm_AddCategory(string _ch)
        {
            InitializeComponent();
            ch = _ch;
            if (ch=="a")
            {
                this.Text = "اضافة فئة جديدة";
                btnAddNew.Text = "حفظ الفئة";
                txtCategoryName.Focus();
            }
            else if (ch=="u")
            {
                this.Text = "تعديل فئة الصنف";
                btnAddNew.Text = "حفظ التعديلات";
                DataTable dt = cls_Category.stp_SelectAll_CategoriesById(frm_CategoryManagement.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtCategoryName.Text = dr[1].ToString();
                    txtDescription.Text = dr[2].ToString();
                    txtCategoryName.Focus();
                }
            }
            else if (ch=="d")
            {
                this.Text = "حذف فئة الصنف";
                btnAddNew.Text = "حفظ التعديلات";
                DataTable dt = cls_Category.stp_SelectAll_CategoriesById(frm_CategoryManagement.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtCategoryName.Text = dr[1].ToString();
                    txtDescription.Text = dr[2].ToString();

                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategoryName.Text == string.Empty)
                {
                    MessageBox.Show(@"من فضلك ادخل تصنيف المنتج");
                    return;
                }

                if (ch=="a")
                {
                    int i = cls_Category.stp_ManipulateCategory(ch,txtCategoryName.Text,txtDescription.Text);
                    MessageBox.Show(@"تم اضافة عدد : " + i + @"من الصفوف");
                    txtCategoryName.Text = string.Empty;
                    txtDescription.Text = string.Empty;
                    txtCategoryName.Focus();
                }

                else if (ch == "u")
                {
                    int i = cls_Category.stp_ManipulateCategory(ch, txtCategoryName.Text, txtDescription.Text);
                    MessageBox.Show(@"تم تعديل عدد : " + i + @"من الصفوف");
                    txtCategoryName.Text = string.Empty;
                    txtDescription.Text = string.Empty;
                    txtCategoryName.Focus();
                }
                else if (ch == "d")
                {
                    if (MessageBox.Show(@"حذف السجل الحالي", @"حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int i = cls_Category.stp_ManipulateCategory(ch, txtCategoryName.Text, txtDescription.Text);
                        MessageBox.Show(@"تم حذف عدد : " + i + @"من الصفوف");
                        txtCategoryName.Text = string.Empty;
                        txtDescription.Text = string.Empty;
                        txtCategoryName.Focus();
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("الاسم مكرر");
                txtCategoryName.Focus();
                return;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
