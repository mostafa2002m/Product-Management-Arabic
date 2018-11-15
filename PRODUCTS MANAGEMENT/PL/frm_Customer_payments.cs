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
    public partial class frm_Customer_payments : Form
    {
        public frm_Customer_payments(string PayType)
        {
            InitializeComponent();
            cls_Controls.BindCombo(ref cboNames, "stp_SelectAll_Customers", "Cust_Name", "Cust_Id");
            cboNames.SelectedIndex = -1;
            ClearBoxes();
            this.Text = PayType;
            btnSave.Enabled = false;
            groupBox1.Enabled = false;
        }
        private void ClearBoxes()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
            btnSave.Text = @"حفظ جديد";
            txtId.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtAmount.Clear();
            txtSupId.Clear();
            cboNames.SelectedIndex = -1;
            txtResault.Clear();
            txtAllCredit.Clear();
            txtAllPaid.Clear();
            txtId.Text = cls_Debit.stp_SelectLast_Debit_Id().Rows[0][0].ToString();
            groupBox1.Enabled = true;
            cboNames.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = true;
            btnSave.Enabled = false;
            // check values
            if (txtId.Text == string.Empty || cboNames.SelectedIndex == -1 || txtAmount.Text == string.Empty)
            {
                MessageBox.Show(@"تحقق من البيانات", @"تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rdbPay.Checked)
            {
                Add_Payment_Method("سند دفعة من عميل");
            }
            else
            {
                Add_Payment_Method("سند مردودات مبيعات");
            }

            MessageBox.Show(@"تم السداد");

            ClearBoxes();
            cboNames.SelectedIndex = -1;

        }


        private void Add_Payment_Method(string paymethod)
        {



            try
            {
                DataTable dt = cls_CashIn.stp_SelectLast_CashIn_Id();
                int dib = Convert.ToInt32(dt.Rows[0][0].ToString());
                int x = cls_CashIn.Add_CashIn(dib, Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDecimal(txtAmount.Text), paymethod, int.Parse(txtSupId.Text));
                if (x > 0)

                {
                    lblMassege.Text = @"تمت العملية بنجاح";
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cls_Customer.stp_SelectCustomersByName(cboNames.Text);
                if (dt.Rows.Count == 0)
                {
                    return;
                }


                txtSupId.Text = dt.Rows[0][0].ToString();
                DataTable dt1 = cls_Debit.stp_SelectNet_Debit_ByCustId(Convert.ToInt32(txtSupId.Text));
                txtAllCredit.Text = dt1.Rows[0][0].ToString();
                txtAllPaid.Text = dt1.Rows[0][1].ToString();
                txtResault.Text = (Convert.ToDecimal(txtAllCredit.Text) - Convert.ToDecimal(txtAllPaid.Text)).ToString();


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

