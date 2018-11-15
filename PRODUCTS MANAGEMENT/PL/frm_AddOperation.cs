using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;
using PRODUCTS_MANAGEMENT.BL;
using System.Drawing;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class FrmAddOperation : Form
    {

       
        decimal _netValue = 0;
        char _d = char.Parse(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

        public FrmAddOperation()
        {
            InitializeComponent();
            ClearData();
            txtSales_Man.Text = Program.User_FullName;

        }


        private void ClearData()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }


            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            dtpOrder_Date.ResetText();
            rdbCash.Checked = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnUndo.Enabled = false;

        }

        void ClearBoxes()
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }

            btnChoose_Service.Focus();
        }
        void ClearDownBoxes()
        {
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                    item.Text = "0";
            }
        }
        private void DetailsRefresh()
        {
            //txtItems.Text = dgvPos.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddOperation_Load(object sender, EventArgs e)
        {

        }
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }
        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtQty.Text != "")
            {
                CalculateAmount();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                if (txtItem_Id.Text == string.Empty)
                {
                    MessageBox.Show("Enter Product");
                    return;
                }
                if (txtQty.Text == string.Empty || double.Parse(txtQty.Text) <= 0)
                {
                    MessageBox.Show("enter qty");
                    return;
                }
                txtPrice.Focus();
            }
        }


        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            Calculate_Amount();
            CalculateNetValue();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQty.Text != string.Empty)
            {
                txtDisc.Focus();
            }
        }

        private void txtDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void txtDisc_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateNetValue();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearData();
            txtNo.Text = cls_Operation.stp_SelectLast_Operation_Id().Rows[0][0].ToString();
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnUndo.Enabled = true;
            btnChoose_Customer.Focus();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItem_Id.Text == "" || txtQty.Text == "" || txtPrice.Text == "" ||
                      txtValue.Text == "" || txtService_Name.Text == "")
            {
                
                    MessageBox.Show(@"تحقق من البيانات", @"انتبه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

            }
            if (txtDisc.Text == string.Empty)
            {
                txtDisc.Text = @"0.0";
            }
            dgvOperation.Rows.Add(txtItem_Id.Text, txtService_Name.Text, txtQty.Text, txtPrice.Text, txtValue.Text, txtDisc.Text, _netValue);

           

            int nRowIndex = dgvOperation.Rows.Count - 1;
            dgvOperation.CurrentCell = dgvOperation.Rows[nRowIndex].Cells[0];
            ClearBoxes();
            txtQty.Focus();

            // كود مكتوب بـ linq للتجميع من داتا جريد
            txtTotal.Text =
                (from DataGridViewRow row in dgvOperation.Rows
                 let formattedValue = row.Cells[6].FormattedValue
                 where formattedValue != null && formattedValue.ToString() != string.Empty
                 select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString(CultureInfo.CurrentCulture);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                // check values
                if (txtNo.Text == string.Empty || txtCust_Id.Text == string.Empty)
                {
                    throw new Exception("أدخل بيانات العميل");

                }
                if (dgvOperation.Rows.Count < 1)
                {
                    throw new Exception("لايوجد بيانات فانورة ");
                }

                DataTable invDet = new DataTable();
                invDet.Columns.Add("Product_Id");
                invDet.Columns.Add("Qty");
                invDet.Columns.Add("Price");
                invDet.Columns.Add("Discount");
                invDet.Columns.Add("Amount");
                foreach (DataGridViewRow dr in dgvOperation.Rows)
                {
                    invDet.Rows.Add(dr.Cells[0].Value, dr.Cells[2].Value, dr.Cells[3].Value, dr.Cells[5].Value, dr.Cells[6].Value);
                }
                bool Ins = true;
                if (rdbCash.Checked)
                {
                    Add_Operation(invDet);

                    Add_Payment_Cash("سداد فاتورة خدمة");
                    MessageBox.Show(@"تم الحفظ");

                    //  cashdrawer();
                }

                
                MessageBox.Show(@"تم الحفظ وتعديل المديونية");



                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnUndo.Enabled = false;
                ClearData();
                MessageBox.Show(@"لقد تم اضافة دفعة  للعميل");
            }
            catch (Exception ex) when (ex.Message.Equals("أدخل بيانات العميل"))
            {

                MessageBox.Show("من فضلك أدخل بيانات العميل");
            }

            catch (Exception ex) when (ex.Message.Equals("لايوجد بيانات فانورة "))
            {

                MessageBox.Show("من فضلك أدخل بيانات الفاتورة");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Add_Operation(DataTable invDet)
        {
            try
            {
                cls_Operation.stp_Insert_Operation(Convert.ToInt32(txtNo.Text), dtpOrder_Date.Value, Convert.ToInt32(txtCust_Id.Text), txtSales_Man.Text, Convert.ToDecimal(txtTotal.Text),lblType.Text, invDet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Add_Payment_Cash(string paymethod)
        {
            try
            {
                DataTable dt = cls_CashIn.stp_SelectLast_CashIn_Id();
                int dbid = Convert.ToInt32(dt.Rows[0][0].ToString());
                cls_CashIn.Add_CashIn(dbid, DateTime.Parse(dtpOrder_Date.Text), decimal.Parse(txtTotal.Text), paymethod, int.Parse(txtCust_Id.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvOperation_DoubleClick(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void جذفعنصرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvOperation.Rows.RemoveAt(dgvOperation.CurrentRow.Index);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgvOperation_Click(null, null);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقا الغاء بيانات الفاتورة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    //اعادة ضبط كميات المنتجات بالفاتورة
                    txtTotal.Text = txtAllSales.Text = txtDaySales.Text =
                    txtBalance.Text = txtAllOperation.Text = txtDayOperation.Text = string.Empty;
                    txtQty.Focus();
                    // كود مكتوب بـ linq للتجميع من داتا جريد
                    txtTotal.Text =
                        (from DataGridViewRow row in dgvOperation.Rows
                         where row.Cells[6].FormattedValue.ToString() != string.Empty
                         select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();
                    dgvOperation.Rows.Clear();
                    dgvOperation.Refresh();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOperation_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // كود مكتوب بـ linq للتجميع من داتا جريد
            txtTotal.Text =
                (from DataGridViewRow row in dgvOperation.Rows
                 let formattedValue = row.Cells[6].FormattedValue
                 where formattedValue != null && formattedValue.ToString() != string.Empty
                 select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString(CultureInfo.CurrentCulture);
            txtBalance.Text = cls_Controls.NetBalanceForCustomers((txtCust_Id.Text)).ToString();
        }

        private void dgvOperation_DoubleClick(object sender, EventArgs e)
        {
            txtItem_Id.Text = dgvOperation.CurrentRow.Cells[0].Value.ToString();
            txtService_Name.Text = dgvOperation.CurrentRow.Cells[1].Value.ToString();
            txtQty.Text = dgvOperation.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dgvOperation.CurrentRow.Cells[3].Value.ToString();
            txtDisc.Text = dgvOperation.CurrentRow.Cells[5].Value.ToString();
            txtValue.Text = dgvOperation.CurrentRow.Cells[6].Value.ToString();
            dgvOperation.Rows.RemoveAt(dgvOperation.CurrentRow.Index);
            dgvOperation.Refresh();
            txtQty.Focus();
           
        }
        private void dgvOperation_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dgvOperation.Rows.Count != 0)
            //    {

            //        txtAllSales.Text = dgvOperation.CurrentRow.;
            //        txtLqty.Text = dt.Rows[0][5].ToString();
            //        txtLqtyPrice.Text = dt.Rows[0][6].ToString();
            //        txtSqty.Text = dt.Rows[0][7].ToString();
            //        txtSqtyPrice.Text = dt.Rows[0][8].ToString();
            //        Calculate_BalanceQtyInInvoice(dt.Rows[0][0].ToString());
            //        Show_Status_Boxes();
            //    }
            //    else
            //    {
            //        ClearBoxes();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}

        }
        private void dgvOperation_KeyDown(object sender, KeyEventArgs e)
        {
            dgvOperation_Click(null, null);
        }
        private void dgvOperation_KeyUp(object sender, KeyEventArgs e)
        {
            dgvOperation_Click(null, null);
        }
        private void btnChoose_Customer_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            frm_Search frm = new frm_Search("Customer");
            frm.ShowDialog();
            if (frm.dgvSearch.Rows.Count == 0)
            {
                return;
            }
            else
            {
                txtCust_Id.Text = frm.dgvSearch.CurrentRow.Cells[0].Value.ToString();
                txtCust_Name.Text = frm.dgvSearch.CurrentRow.Cells[1].Value.ToString();
                txtBalance.Text = cls_Controls.NetBalanceForCustomers((txtCust_Id.Text)).ToString();
                
            }
        }
        private void btnChoose_Service_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            frm_Search frm = new frm_Search("Service");
            frm.ShowDialog();
            if (frm.dgvSearch.Rows.Count == 0)
            {
                return;
            }
            else
            {
                txtItem_Id.Text = frm.dgvSearch.CurrentRow.Cells[0].Value.ToString();
                txtService_Name.Text = frm.dgvSearch.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = frm.dgvSearch.CurrentRow.Cells[3].Value.ToString();
                txtQty.Focus();

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

        private void Calculate_Amount()
        {
            if (txtPrice.Text == string.Empty)
            {
                txtPrice.Text = "0";
            }
            txtValue.Text = (Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();
        }
        private void Calculate_Balance(string p)
        {
            decimal _total = 0;
            decimal realQty;
            for (int i = 0; i < dgvOperation.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvOperation.Rows[i].Cells[0].Value).ToString() == p)
                {
                    realQty = Convert.ToDecimal(dgvOperation.Rows[i].Cells[2].Value);
                    _total += realQty;

                }

            }
        }
        void CalculateNetValue()
        {
            if (txtValue.Text != string.Empty && txtDisc.Text != string.Empty)
            {


                _netValue = decimal.Parse(txtValue.Text) - decimal.Parse(txtDisc.Text);

            }
            else if (txtValue.Text != string.Empty)
            {

                _netValue = decimal.Parse(txtValue.Text);

            }

        }
        void CalculateAmount()
        {
            try
            {
                if (txtQty.Text != string.Empty && txtPrice.Text != string.Empty)
                {

                    txtValue.Text = (decimal.Parse(txtQty.Text) * decimal.Parse(txtPrice.Text)).ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        
    }
}
