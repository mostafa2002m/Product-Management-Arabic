using PRODUCTS_MANAGEMENT.BL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_Supplier_payments : Form
    {
      
        public frm_Supplier_payments(string PayType)
        {
            InitializeComponent();
            cls_Controls.BindCombo(ref cboNames, "stp_SelectAll_Supplier", "sup_Company", "Sup_Id");
            cboNames.SelectedIndex = -1;
            clearBoxes();
            //this.Text = PayType;
            btnSave.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void clearBoxes()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
        }

        private void frmCredit_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboNames_SelectedValueChanged(object sender, EventArgs e)
        {
        }
          
        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cls_Supplier.stp_SelectAll_SuppliersById(cboNames.Text);
                if (dt.Rows.Count == 0)
                {
                    return;
                }

                dt = cls_Supplier.stp_SelectAll_SuppliersById(cboNames.Text);
                txtSupId.Text = dt.Rows[0][0].ToString();
                
                txtSupId.Text = dt.Rows[0][0].ToString();
                DataTable dt1 = cls_Credit.stp_Select_Net_Credit_BySupId(Convert.ToInt32(txtSupId.Text));
                txtAllCredit.Text = dt1.Rows[0][0].ToString();
                txtAllPaid.Text = dt1.Rows[0][1].ToString();
                txtResault.Text = (Convert.ToDecimal(txtAllCredit.Text) - Convert.ToDecimal(txtAllPaid.Text)).ToString();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

       
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
            btnSave.Text = "حفظ جديد";
            txtId.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtAmount.Clear();
            txtSupId.Clear();
            cboNames.SelectedIndex=-1;
            txtResault.Clear();
            txtAllCredit.Clear();
            txtAllPaid.Clear();
            txtId.Text=cls_CashOut.stp_SelectLast_CashOut_Id().Rows[0][0].ToString();
            groupBox1.Enabled = true;
            cboNames.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                // check values
                if (txtId.Text == string.Empty || cboNames.SelectedIndex == -1 || txtAmount.Text == string.Empty)
                {
                    errorProvider1.SetError(cboNames, "تحقق من البيانات");
                    MessageBox.Show(@"تحقق من البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                if (rdbPay.Checked)
                {
                    Add_Payment_Method("سند دفعة لمورد");
                }
                else
                {
                    Add_Payment_Method("سند مردودات مشتريات");
                }
                   
                    MessageBox.Show(@"تم السداد");
               
                clearBoxes();
                cboNames.SelectedIndex = -1;
                btnAddNew.Enabled = true;
                btnSave.Enabled = false;
                groupBox1.Enabled = false;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }


        private void Add_Payment_Method(string paymethod)
        {
            //string paymethod = "سداد نقدي";


            try
            {
                DataTable dt = cls_CashOut.stp_SelectLast_CashOut_Id();
                int crid = Convert.ToInt32(dt.Rows[0][0].ToString());
                int x = cls_CashOut.Add_CashOut(crid, Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDecimal(txtAmount.Text), paymethod, int.Parse(txtSupId.Text));
                if (x == 1)
                {
                    lblMassege.Text = @"تمت العملية بنجاح";
                }
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
