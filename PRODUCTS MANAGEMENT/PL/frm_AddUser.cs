using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddUser : Form
    {
       string ch;
        public frm_AddUser(string _ch)
        {
            InitializeComponent();
            ch = _ch;
            btnSave.Enabled = false;
            groupBox1.Enabled = false;
            cls_Controls.BindCombo(ref cboType, "stp_SelectAll_Permission", "Per_Name", "Per_Id");
            if (ch=="a")
            {
                this.Text = "شاشة اضافة مستخدم";
                btnNew.Text = "إضافة";
                btnNew.Enabled = true;
                groupBox1.Enabled = true;
            }
            else if (ch=="u")
            {
                this.Text = "شاشة تعديل مستخدم";
                btnNew.Text = "";
                groupBox1.Enabled = true;
                btnSave.Enabled = true;
                btnSave.Text = "حفظ التعديلات";
                DataTable dt = cls_Login.stp_SelectUser_ByUserName(frmUserList.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtId.Text = dr["اسم المستخدم"].ToString();
                    txtPassword.Text = dr["كلمةالمرور"].ToString();
                    txtFullName.Text = dr["اسم الكامل"].ToString();
                    cboType.Text = dr["نوع المستخدم"].ToString();
                }
            }
            else if (ch=="d")
            {
                this.Text = "شاشة حذف مستخدم";
                btnNew.Text = "";
                btnSave.Text = "حفظ التعديلات";
                groupBox1.Enabled = true;
                btnSave.Enabled = true;


                DataTable dt = cls_Login.stp_SelectUser_ByUserName(frmUserList.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtId.Text = dr["اسم المستخدم"].ToString();
                    txtPassword.Text = dr["كلمةالمرور"].ToString();
                    txtFullName.Text = dr["اسم الكامل"].ToString();
                    cboType.Text = dr["نوع المستخدم"].ToString();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            txtId.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
            txtFullName.Clear();
            groupBox1.Enabled = true;
            cboType.SelectedIndex = -1;
            txtId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                if (txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("كلمة المرور غير متطابقة");
                    return;
                }

                if (ch=="a")
                {
                    int x = cls_Login.stp_ManipulateUser(ch,txtId.Text, txtPassword.Text, (int)(cboType.SelectedValue), txtFullName.Text);
                    if (x == 1)
                    {
                        MessageBox.Show(@"تمت الاضافة");
                    }


                }
                else if (ch=="u")
                {
                    cls_Login.stp_ManipulateUser(ch, frmUserList.ID, txtPassword.Text, (int)(cboType.SelectedValue), txtFullName.Text);
                    MessageBox.Show(@"تم التعديل");
                }
                else if (ch=="d")
                {
                    if (MessageBox.Show(@"هل تريد حقا حذف المستخدم الحالي", @"تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    { 
                        cls_Login.stp_ManipulateUser(ch, frmUserList.ID, txtPassword.Text, (int)(cboType.SelectedValue), txtFullName.Text);
                    MessageBox.Show(@"تم الحذف");
                    }
                }


                btnSave.Enabled = false;
                btnNew.Enabled = true;
                groupBox1.Enabled = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("الاسم مكرر");
                txtId.Focus();
                return;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
        

      
        private void txtConfirm_Validated(object sender, EventArgs e)
        {
            if (  txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show(@"تاكيد", "تاكيد كلمة المرور", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
