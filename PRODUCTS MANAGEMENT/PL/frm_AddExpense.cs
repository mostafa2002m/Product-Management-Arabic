using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddExpense : Form
    {
        string ch;
        public frm_AddExpense(string _ch)
        {
            InitializeComponent();
            ch = _ch;
            btnSave.Enabled = false;
            groupBox1.Enabled = false;
            if (ch == "a")
            {
                groupBox1.Enabled = true;
                btnAddNew.Text = "إضافة";
                this.Text = "إضافة بند صرف جديد";
            }
            else if (ch == "u")
            {
                btnAddNew.Text = "تعديل";
                this.Text = "تعديل بند صرف";
                btnAddNew.Enabled = false;
                btnSave.Enabled = true;
                groupBox1.Enabled = true;
                DataTable dt = cls_Cost.stp_SelectAll_ExpenseById(frm_ExpenseManagement.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtExpenseName.Text = dr["Expense_Name"].ToString();
                    txtDescription.Text= dr["Description"].ToString();
                }
            }

            else if (ch == "d")
            {
                btnAddNew.Text = "حذف";
                this.Text = "حذف بند صرف";
                btnAddNew.Enabled = false ;
                btnSave.Enabled = true;
                groupBox1.Enabled = true;
                DataTable dt = cls_Cost.stp_SelectAll_ExpenseById(frm_ExpenseManagement.ID);
                foreach (DataRow dr in dt.Rows)
                {


                    txtExpenseName.Text = dr["Expense_Name"].ToString();
                    txtDescription.Text = dr["Description"].ToString();

                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
            txtExpenseName.Clear();
            txtDescription.Clear();
            groupBox1.Enabled = true;
            txtExpenseName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtExpenseName.Text == string.Empty || txtDescription.Text == string.Empty)
                {
                    MessageBox.Show(@"تحقق من البيانات");
                    return;
                }


                if (ch == "a")
                {

                    cls_Cost.stp_ManipulateExpense(ch, txtExpenseName.Text, txtDescription.Text);


                    MessageBox.Show(@"تمت الاضافة بنجاح ");
                    
                }

                else if (ch == "u")
                {

                    cls_Cost.stp_ManipulateExpense(ch, txtExpenseName.Text, txtDescription.Text);
                    MessageBox.Show(@"تم التعديل بنجاح ");
                }
                else if (ch == "d")
                {
                    cls_Cost.stp_ManipulateExpense(ch, txtExpenseName.Text, txtDescription.Text);
                    MessageBox.Show(@"تم الحذف بنجاح ");
                }

                groupBox1.Enabled = false;
                txtExpenseName.Text = string.Empty;
                txtDescription.Text = string.Empty;
                btnAddNew.Enabled = true;
                btnSave.Enabled = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل الاضافة", ex.Message);
            }
        }
    }
    }
