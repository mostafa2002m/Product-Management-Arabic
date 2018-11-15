using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class FrmOrderMade : Form
    {
        decimal _total;
        decimal NetValue = 0;
        int rowIndex = 0;
        char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

        public FrmOrderMade()
        {
            InitializeComponent();
            ClearData();
            LoadCustomer_Combo();
            txtOrder_SaleMan.Text = Program.User_FullName;
        }
        void ClearData()
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

            ClearBoxes();
            dgvDetails.Rows.Clear();
            dgvDetails.Refresh();


            btnAddNew.Enabled = true;
            btnSaveOrder.Enabled = false;
            btnUndoOrder.Enabled = false;

        }
        void ClearBoxes()
        {
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
           
            btnBrowse.Focus();
        }
        void ClearDownBoxes()
        {
            foreach (Control item in groupBox4.Controls)
            {
                if (item is TextBox)
                    item.Text = "0";
            }
        }
        void DetailsRefresh()
        {
            txtItems.Text = dgvDetails.Rows.Count.ToString();
        }
       
        
        private void LoadCustomer_Combo()
        {
            cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Customers", "Cust_Name", "Cust_Id");
            cboCust_Name.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOrderMade_Load(object sender, EventArgs e)
        {

        }
        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }
        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqty.Text != string.Empty)
            {
                txtPrice.Focus();
            }

        }
        private void txtqty_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
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
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)
            {

                txtDisc.Focus();
            }
        }
        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateNetValue();
        }
        private void txtDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }
        private void txtDisc_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateNetValue();
        }
        private void txtDisc_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            txtOrder_Id.Text = cls_MadeOrder.stp_SelectLast_MadeOrder_Id().Rows[0][0].ToString();
            btnAddNew.Enabled = false;
            btnSaveOrder.Enabled = true;
            btnUndoOrder.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //string x = "madeproduct";
            try
            {
                ClearBoxes();

                frm_Search frm = new frm_Search("MadeProduct");
                frm.ShowDialog();
                if (rdbLarge.Checked)
                {
                    txtProduct_Id.Text = frm.dgvSearch.CurrentRow.Cells[0].Value.ToString();
                    txtBarcode.Text = frm.dgvSearch.CurrentRow.Cells[1].Value.ToString();
                    txtProduct_Name.Text = frm.dgvSearch.CurrentRow.Cells[2].Value.ToString();
                    txtAvQty.Text = frm.dgvSearch.CurrentRow.Cells[3].Value.ToString();
                    txtLqty.Text = frm.dgvSearch.CurrentRow.Cells[5].Value.ToString();
                    txtPrice.Text = frm.dgvSearch.CurrentRow.Cells[6].Value.ToString();
                    txtSqty.Text = frm.dgvSearch.CurrentRow.Cells[7].Value.ToString();
                    txtLqtyPrice.Text = frm.dgvSearch.CurrentRow.Cells[6].Value.ToString();
                    txtSqtyPrice.Text = frm.dgvSearch.CurrentRow.Cells[8].Value.ToString();
                    txtqty.Focus();
                }
                else
                {
                    txtProduct_Id.Text = frm.dgvSearch.CurrentRow.Cells[0].Value.ToString();
                    txtBarcode.Text = frm.dgvSearch.CurrentRow.Cells[1].Value.ToString();
                    txtProduct_Name.Text = frm.dgvSearch.CurrentRow.Cells[2].Value.ToString();
                    txtAvQty.Text = frm.dgvSearch.CurrentRow.Cells[3].Value.ToString();
                    txtPrice.Text = frm.dgvSearch.CurrentRow.Cells[8].Value.ToString();
                    txtLqty.Text = frm.dgvSearch.CurrentRow.Cells[5].Value.ToString();
                    txtSqty.Text = frm.dgvSearch.CurrentRow.Cells[7].Value.ToString();
                    txtLqtyPrice.Text = frm.dgvSearch.CurrentRow.Cells[6].Value.ToString();
                    txtSqtyPrice.Text = frm.dgvSearch.CurrentRow.Cells[8].Value.ToString();

                    txtqty.Focus();
                }
                txtqty.Focus();
                _total = 0;
                //Calculate_Balance(txtProduct_Id.Text);
                txtDisc.Text = cls_Controls.CalculateTax(Convert.ToDecimal(txtPrice.Text)).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "No Item Selected");
            }
           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //if (cls_Order.Verify_Qty(txtProduct_Id.Text, Convert.ToInt32(txtqty.Text)).Rows.Count < 1)
                //{
                //    MessageBox.Show("لايوجد كمية متاحة من هذا المنتج");
                //    return;
                //}

                if (txtProduct_Id.Text == "" || txtqty.Text == "" || txtPrice.Text == "" ||
                      txtValue.Text == "" || txtProduct_Name.Text == "")
               
                    {
                        MessageBox.Show(@"تحقق من البيانات", @"انتبه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }
                   
               

                if (txtDisc.Text == string.Empty)
                {
                    txtDisc.Text = "0.0";
                }

                //// اذا كانت وحدة كبرى يتم ضرب الكمية الكبرى بالصغري
                //if (rdbLarge.Checked)
                //{
                //    txtqty.Text = (Math.Round(decimal.Parse(txtqty.Text),2) * Math.Round(decimal.Parse(txtSqty.Text),2)).ToString();
                //}


                dgvDetails.Rows.Add(txtProduct_Id.Text, txtProduct_Name.Text, txtqty.Text, txtPrice.Text, txtValue.Text, txtDisc.Text, NetValue);

                _total = 0;

                // حساب رصيدالمنتج بعد اضافته للفاتورة
                Calculate_BalanceQtyInInvoice(txtProduct_Id.Text);
                txtAvQty.Text = cls_Controls.ShowAvailableQty(Convert.ToInt32(txtAvQty.Text), Convert.ToInt32(txtCurrent.Text)).ToString();

                DetailsRefresh();
                ClearBoxes();
                txtBarcode.Focus();

                // كود مكتوب بـ linq للتجميع من داتا جريد
                txtOrder_Total.Text =
                    (from DataGridViewRow row in dgvDetails.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // check values
                if (txtOrder_Id.Text == string.Empty || txtCust_Id.Text == string.Empty)
                {
                    throw new Exception(cls_Controls.InvalidCustomerData);

                }
                if (dgvDetails.Rows.Count < 1)
                {
                    throw new Exception(cls_Controls.NoData);
                }

                bool Ins = true;
                Insert_OrderMade(Ins);
                if (Ins == true)
                {

                    if (rdbCash.Checked)
                    {

                        Add_Payment_Cash ("سداد فاتورة ورشة");
                        MessageBox.Show(@"تم السداد نقدا");
                        //  cashdrawer();
                    }
                   
                    else if (rdbPunch.Checked)

                    {

                        Add_Payment_Punch("أقساط");
                    }
                }
               


                PrintInvoice();
                btnAddNew.Enabled = true;
                btnSaveOrder.Enabled = false;
                btnUndoOrder.Enabled = false;
                ClearData();
                txtBalance.Text = string.Empty;
                txtItems.Text = string.Empty;


            }
            catch (Exception ex) when (ex.Message.Equals(cls_Controls.InvalidCustomerData))
            {

                MessageBox.Show(cls_Controls.CheckCustomerData);
            }

            catch (Exception ex) when (ex.Message.Equals(cls_Controls.NoData))
            {

                MessageBox.Show(cls_Controls.CheckData);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Insert_OrderMade(bool Ins)
        {
            try
            {
                int x = cls_MadeOrder.stp_Insert_MadeOrder(int.Parse(txtOrder_Id.Text), DateTime.Parse(dtpOrder_Date.Text), decimal.Parse(txtOrder_Total.Text), int.Parse(txtCust_Id.Text), txtOrder_SaleMan.Text,lblType.Text);
                if (x > 0)
                {
                    for (int i = 0; i < dgvDetails.Rows.Count; i++)
                    {
                        cls_MadeOrder.stp_Insert_MadeOrderDetails(Convert.ToInt32(txtOrder_Id.Text),
                                                              Convert.ToInt32(dgvDetails.Rows[i].Cells[0].Value.ToString()),
                                                              Convert.ToDecimal(dgvDetails.Rows[i].Cells[2].Value.ToString()),
                                                              Convert.ToDecimal(dgvDetails.Rows[i].Cells[3].Value.ToString()),
                                                              Convert.ToDecimal(dgvDetails.Rows[i].Cells[5].Value.ToString()));
                    }
                    MessageBox.Show("تم حفظ الفاتورة وبياناتها بنجاح");
                    Ins = true;
                }
                else
                {
                    MessageBox.Show("لا يمكن حفظ الفاتورة");
                    Ins = false;
                }

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
                cls_CashIn.Add_CashIn(dbid, DateTime.Parse(dtpOrder_Date.Text), decimal.Parse(txtOrder_Total.Text), paymethod, int.Parse(txtCust_Id.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Payment_Punch(string v)
        {
            new frm_AddPayment_Punch(txtCust_Id.Text, cboCust_Name.Text, txtOrder_Id.Text, txtOrder_Total.Text, "شاشة إعداد الأقساط").ShowDialog();
        }
        private void PrintInvoice()
        {
            try
            {

                // get last order to print
                DialogResult respnse = MessageBox.Show(@"طباعة الفاتورة", @"طباعة فاتورة الشراء", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respnse == DialogResult.Yes)
                {

                    this.Cursor = Cursors.WaitCursor;
                    int Order_No = int.Parse(txtOrder_Id.Text);
                    RPT.rpt_OrderMade MyReport = new RPT.rpt_OrderMade();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_MadeOrder.stp_SelectOrderMade_Details(Order_No));
                    MyReport.Refresh();
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    return;
                }
               
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
      
        private void تعديلسجلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDetails_DoubleClick(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    dgvDetails.Rows.RemoveAt(dgvDetails.CurrentRow.Index);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void حذفسجلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDetails.Rows.RemoveAt(dgvDetails.CurrentRow.Index);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgvDetails_Click(null, null);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            btnSaveOrder_Click(null, null);
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            btnClose_Click(null, null);
        }
        private void btnUndoOrder_Click(object sender, EventArgs e)
        {
            ClearData();
            ClearBoxes();
            txtBalance.Text = string.Empty;
            txtItems.Text = string.Empty;
            btnUndoOrder.Enabled = false;
            btnSaveOrder.Enabled = false;
        }
        private void dgvDetails_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtProduct_Id.Text = this.dgvDetails.CurrentRow.Cells[0].Value.ToString();
                txtProduct_Name.Text = this.dgvDetails.CurrentRow.Cells[1].Value.ToString();
                txtqty.Text = this.dgvDetails.CurrentRow.Cells[2].Value.ToString();
                txtPrice.Text = this.dgvDetails.CurrentRow.Cells[3].Value.ToString();
                txtValue.Text = this.dgvDetails.CurrentRow.Cells[4].Value.ToString();
                txtDisc.Text = this.dgvDetails.CurrentRow.Cells[5].Value.ToString();
                dgvDetails.Rows.RemoveAt(dgvDetails.CurrentRow.Index);
                DetailsRefresh();
                txtqty.Focus();
                _total = 0;
                Calculate_BalanceQtyInInvoice(txtProduct_Id.Text);
                txtAvQty.Text = cls_Controls.ShowAvailableQty(Convert.ToInt32(txtAvQty.Text), Convert.ToInt32(txtCurrent.Text)).ToString();

            }

            catch
            {
                return;
            }

        }
        private void dgvDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // كود مكتوب بـ linq للتجميع من داتا جريد
            txtOrder_Total.Text =
                (from DataGridViewRow row in dgvDetails.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                 select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();
            DetailsRefresh();
            decimal balance = cls_Controls.NetBalanceForCustomers((txtCust_Id.Text));
            txtBalance.Text = balance.ToString();
        }
        private void dgvDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetails.Rows.Count != 0)
                {
                    DataTable dt = cls_Product.stp_SelectAll_ProductsById(Convert.ToInt32(dgvDetails.CurrentRow.Cells[0].Value.ToString()));
                    txtAvQty.Text = dt.Rows[0][3].ToString();
                    txtLqty.Text = dt.Rows[0][5].ToString();
                    txtLqtyPrice.Text = dt.Rows[0][6].ToString();
                    txtSqty.Text = dt.Rows[0][7].ToString();
                    txtSqtyPrice.Text = dt.Rows[0][8].ToString();
                    Calculate_BalanceQtyInInvoice(dt.Rows[0][0].ToString());
                    txtAvQty.Text = cls_Controls.ShowAvailableQty1(Convert.ToInt32(txtAvQty.Text), Convert.ToInt32(txtCurrent.Text)).ToString();
                }
                else
                {
                    ClearDownBoxes();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void dgvDetails_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.dgvDetails.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.dgvDetails.CurrentCell = this.dgvDetails.Rows[e.RowIndex].Cells[1];
                    this.contextMenuStrip1.Show(this.dgvDetails, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dgvDetails_KeyDown(object sender, KeyEventArgs e)
        {
            dgvDetails_Click(null, null);
        }
        private void dgvDetails_KeyUp(object sender, KeyEventArgs e)
        {
            dgvDetails_Click(null, null);
        }
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtBarcode.Text != string.Empty)
                {
                    if (e.KeyCode == Keys.Enter && txtBarcode.Text != string.Empty)
                    {
                        DataTable dt = cls_Product.stp_SelectAll_ProductsByBarcode(txtBarcode.Text);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show(@"المنتج غير مسجل");
                            txtBarcode.Clear();
                            return;
                        }
                        if (rdbLarge.Checked)
                        {
                            txtProduct_Id.Text = dt.Rows[0]["رقم المنتج"].ToString();
                            txtProduct_Name.Text = dt.Rows[0]["اسم المنتج"].ToString();
                            txtPrice.Text = dt.Rows[0]["سعر كبرى"].ToString();
                            txtLqty.Text = dt.Rows[0]["وحدة كبرى"].ToString();
                            txtSqty.Text = dt.Rows[0]["وحدة صغرى"].ToString();
                            txtLqtyPrice.Text = dt.Rows[0]["سعر كبرى"].ToString();
                            txtSqtyPrice.Text = dt.Rows[0]["سعر صغرى"].ToString();
                            txtqty.Focus();
                        }
                        else
                        {
                            txtProduct_Id.Text = dt.Rows[0]["رقم المنتج"].ToString();
                            txtProduct_Name.Text = dt.Rows[0]["اسم المنتج"].ToString();
                            txtPrice.Text = dt.Rows[0]["سعر صغرى"].ToString();
                            txtLqty.Text = dt.Rows[0]["وحدة كبرى"].ToString();
                            txtSqty.Text = dt.Rows[0]["وحدة صغرى"].ToString();
                            txtLqtyPrice.Text = dt.Rows[0]["سعر كبرى"].ToString();
                            txtSqtyPrice.Text = dt.Rows[0]["سعر صغرى"].ToString();
                            txtqty.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void cboCust_Name_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = cls_Customer.stp_SelectCustomersByName(cboCust_Name.Text);
                // في حالة عدم توفر صوره للعميل
                if (dt.Rows[0][5] is DBNull)
                {
                    txtCust_Id.Text = dt.Rows[0][0].ToString();
                    txtName.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    // في حالة توفر الصورة
                    txtCust_Id.Text = dt.Rows[0][0].ToString();
                    txtName.Text = dt.Rows[0][1].ToString();
                    //picBox_Cust.Image = null;
                    //byte[] image = (byte[])dt.Rows[0][5];

                    //MemoryStream ms = new MemoryStream(image);
                    //picBox_Cust.Image = Image.FromStream(ms);
                    ////txtCust_Id.Text = dt.Rows[0][0].ToString();
                    ////txtCust_Id.Text = dt.Rows[0][0].ToString();
                }

                decimal balance = cls_Controls.NetBalanceForCustomers((txtCust_Id.Text));
                txtBalance.Text = balance.ToString();

            }
            catch
            {
                return;
            }
        }
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            new FrmAddCustomer("a").ShowDialog();
            LoadCustomer_Combo();
        }
        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = txtLqtyPrice.Text;
            txtqty.Focus();
        }
        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = txtSqtyPrice.Text;
            txtqty.Focus();
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





        void CalculateNetValue()
        {
            try
            {
                if (txtValue.Text != string.Empty && txtDisc.Text != string.Empty)
                {


                    NetValue = decimal.Parse(txtValue.Text) - decimal.Parse(txtDisc.Text);

                }
                else if (txtValue.Text != string.Empty)
                {

                    NetValue = decimal.Parse(txtValue.Text);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        

        }
        void CalculateAmount()
        {
            try
            {
                if (txtqty.Text != string.Empty && txtPrice.Text != string.Empty)
                {

                    txtValue.Text = (decimal.Parse(txtqty.Text) * decimal.Parse(txtPrice.Text)).ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void Calculate_BalanceQtyInInvoice(string p)
        {
            _total = 0;
            decimal realQty = 0;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvDetails.Rows[i].Cells[0].Value).ToString() == p)
                {
                    realQty = Convert.ToDecimal(dgvDetails.Rows[i].Cells[2].Value);
                    _total += realQty;
                    txtCurrent.Text = _total.ToString(CultureInfo.InvariantCulture);
                }

            }
        }
       

       
    }
}
