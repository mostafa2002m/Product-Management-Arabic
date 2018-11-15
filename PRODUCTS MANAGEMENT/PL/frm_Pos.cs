using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;
using System.Globalization;
using System.IO;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_Pos : Form
    {


        private decimal _total;
        private decimal _netValue = 0;
        char _d = char.Parse(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

        public decimal Total { get => _total; set => _total = value; }

        public frm_Pos()
        {
            InitializeComponent();


        }

        private void ClearData()
        {
            foreach (Control item in pnlOrder.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is DateTimePicker)
                {
                    item.Text = string.Empty;
                }
            }

            foreach (Control item in pnlOperation.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is DateTimePicker)
                {
                    item.Text = string.Empty;
                }
            }
            foreach (Control item in pnlTotal.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is DateTimePicker)
                {
                    item.Text = string.Empty;
                }
            }
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is DateTimePicker)
                {
                    item.Text = string.Empty;
                }
            }

           
          
            pnlBoxes.Enabled = false;
            pnlDgv.Enabled = false;
            pnlOperation.Enabled = false;
            pnlOrder.Enabled = false;
            pnlTotal.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;

            dtpInvDate.ResetText();


            dgvPos.Rows.Clear();
            dgvPos.Refresh();

        }
        private void ClearBoxes()
        {
            foreach (Control item in pnlBoxes.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is DateTimePicker)
                {
                    item.Text = string.Empty;
                }
                cboProductName.SelectedIndex = -1;
            }


        }
        void ClearDownBoxes()
        {
            foreach (Control item in grpInfo.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is DateTimePicker)
                {
                    item.Text = "0";
                }
            }
        }
        private void DetailsRefresh()
        {
            txtItems.Text = dgvPos.Rows.Count.ToString();
        }
        private void LoadCustomer_Combo()
        {
            cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Customers", "Cust_Name", "Cust_Id");
            cboCust_Name.SelectedIndex = 0;
            DataTable dt = cls_Customer.stp_SelectCustomersByName(cboCust_Name.Text);
            // في حالة عدم توفر صوره للعميل
            if (dt.Rows.Count > 0)
            {
                txtCust_Id.Text = dt.Rows[0][0].ToString();
                //txtCust_Name.Text = dt.Rows[0][1].ToString();

                decimal balance = cls_Controls.NetBalanceForCustomers((txtCust_Id.Text));
                txtBalance.Text = balance.ToString();

                return;
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frm_Pos_Load(object sender, EventArgs e)
        {

            cls_Controls.BindCombo(ref cboProductName, "stp_SelectAll_Products", "اسم المنتج", "رقم المنتج");

            ClearData();
            ClearBoxes();
            txtUser.Text = Program.User_FullName;
            LoadCustomer_Combo();
            cboProductName.SelectedIndex = -1;
            cboType.SelectedIndex = 0;
        }
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQty.Text != string.Empty)
            {
                txtPrice.Focus();
            }
        }
        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtQty.Text != "")
            {
                CalculateAmount();
                CalculateNetValue();
            }

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

                btnAdd.Focus();
            }
        }
        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateNetValue();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkBarcode.Checked)
                {

                    txtBarcode.Focus();
                }
                else
                {
                    cboProductName.Focus();
                }
                ClearBoxes();
                txtOrder_Id.Text = cls_Order.stp_SelectLast_Order_Id().Rows[0][0].ToString();
                btnNew.Enabled = false;
                btnSave.Enabled = true;
                btnClear.Enabled = true;
                pnlBoxes.Enabled = true;
                pnlDgv.Enabled = true;
                pnlOperation.Enabled = true;
                pnlOrder.Enabled = true;
                pnlTotal.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void cboProductName_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboProductName.SelectedIndex == -1) return;
                DataTable dt = cls_Product.stp_SelectProductByName(cboProductName.Text);
                if (dt.Rows.Count > 0)
                {

                    if ((bool)dt.Rows[0]["Taxed"] == true)
                    {
                        txtProductId.Text = dt.Rows[0]["Product_Id"].ToString();
                        cboProductName.Text = dt.Rows[0]["Product_Name"].ToString();
                        txtPrice.Text = dt.Rows[0]["sunitprice"].ToString();
                        txtLqty.Text = dt.Rows[0]["lunitqty"].ToString();
                        txtSqty.Text = dt.Rows[0]["sunitqty"].ToString();
                        txtLqtyPrice.Text = dt.Rows[0]["lunitprice"].ToString();
                        txtSqtyPrice.Text = dt.Rows[0]["sunitprice"].ToString();
                        txtAvQty.Text = dt.Rows[0]["Qte_In_Stock"].ToString();

                        // ------- Compute Tax
                        txtDisc.Text = cls_Controls.CalculateTax(Convert.ToDecimal(txtPrice.Text)).ToString();



                    }
                    #region
                    //if (rdbLarge.Checked)
                    //{
                    //    txtProductId.Text = dt.Rows[0]["رقم المنتج"].ToString();
                    //    cboProductName.SelectedValue = dt.Rows[0]["اسم المنتج"].ToString();
                    //    txtPrice.Text = dt.Rows[0]["سعر كبرى"].ToString();
                    //    txtLqty.Text = dt.Rows[0]["وحدة كبرى"].ToString();
                    //    txtSqty.Text = dt.Rows[0]["وحدة صغرى"].ToString();
                    //    txtLqtyPrice.Text = dt.Rows[0]["سعر كبرى"].ToString();
                    //    txtSqtyPrice.Text = dt.Rows[0]["سعر صغرى"].ToString();
                    //    txtqty.Focus();
                    //}
                    #endregion
                    else
                    {

                        txtProductId.Text = dt.Rows[0]["Product_Id"].ToString();
                        cboProductName.Text = dt.Rows[0]["Product_Name"].ToString();
                        txtPrice.Text = dt.Rows[0]["sunitprice"].ToString();
                        txtLqty.Text = dt.Rows[0]["lunitqty"].ToString();
                        txtSqty.Text = dt.Rows[0]["sunitqty"].ToString();
                        txtLqtyPrice.Text = dt.Rows[0]["lunitprice"].ToString();
                        txtSqtyPrice.Text = dt.Rows[0]["sunitprice"].ToString();
                        txtAvQty.Text = dt.Rows[0]["Qte_In_Stock"].ToString();
                        // ------- Tax = 0
                        txtDisc.Text = "0";

                    }
                    // any case do the following :-
                    txtQty.Text = "1";
                    txtQty.Focus();
                    // compute inventory & order balance

                    CalculateAmount();
                    // compute inventory & order balance
                    Total = 0;
                    CalculateAmount();
                    Calculate_BalanceQtyInInvoice(txtProductId.Text);
                    if (txtCurrent.Text == string.Empty)
                    {
                        txtCurrent.Text = "0";
                    }
                    //استدعاء دالة لاظهار قيم مربعات النصوص اسفل الفاتورة
                   // ShowAvailableQty
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void cboProductName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (cboProductName.SelectedIndex == -1) return;
                DataTable dt = cls_Product.stp_SelectProductByName(cboProductName.Text);
                if (dt.Rows.Count > 0)
                {

                    if ((bool)dt.Rows[0]["Taxed"] == true)
                    {
                        txtProductId.Text = dt.Rows[0]["Product_Id"].ToString();
                        cboProductName.Text = dt.Rows[0]["Product_Name"].ToString();
                        txtPrice.Text = dt.Rows[0]["sunitprice"].ToString();
                        txtLqty.Text = dt.Rows[0]["lunitqty"].ToString();
                        txtSqty.Text = dt.Rows[0]["sunitqty"].ToString();
                        txtLqtyPrice.Text = dt.Rows[0]["lunitprice"].ToString();
                        txtSqtyPrice.Text = dt.Rows[0]["sunitprice"].ToString();
                        txtAvQty.Text = dt.Rows[0]["Qte_In_Stock"].ToString();

                        // ------- Compute Tax
                        txtDisc.Text = cls_Controls.CalculateTax(Convert.ToDecimal(txtPrice.Text)).ToString();



                    }
                    #region
                    //if (rdbLarge.Checked)
                    //{
                    //    txtProductId.Text = dt.Rows[0]["رقم المنتج"].ToString();
                    //    cboProductName.SelectedValue = dt.Rows[0]["اسم المنتج"].ToString();
                    //    txtPrice.Text = dt.Rows[0]["سعر كبرى"].ToString();
                    //    txtLqty.Text = dt.Rows[0]["وحدة كبرى"].ToString();
                    //    txtSqty.Text = dt.Rows[0]["وحدة صغرى"].ToString();
                    //    txtLqtyPrice.Text = dt.Rows[0]["سعر كبرى"].ToString();
                    //    txtSqtyPrice.Text = dt.Rows[0]["سعر صغرى"].ToString();
                    //    txtqty.Focus();
                    //}
                    #endregion
                    else
                    {

                        txtProductId.Text = dt.Rows[0]["Product_Id"].ToString();
                        cboProductName.Text = dt.Rows[0]["Product_Name"].ToString();
                        txtPrice.Text = dt.Rows[0]["sunitprice"].ToString();
                        txtLqty.Text = dt.Rows[0]["lunitqty"].ToString();
                        txtSqty.Text = dt.Rows[0]["sunitqty"].ToString();
                        txtLqtyPrice.Text = dt.Rows[0]["lunitprice"].ToString();
                        txtSqtyPrice.Text = dt.Rows[0]["sunitprice"].ToString();
                        txtAvQty.Text = dt.Rows[0]["Qte_In_Stock"].ToString();
                        // ------- Tax = 0
                        txtDisc.Text = "0";

                    }
                    // any case do the following :-
                    txtQty.Text = "1";
                    txtQty.Focus();
                    // compute inventory & order balance

                    CalculateAmount();

                  
                    //استدعاء دالة لاظهار قيم مربعات النصوص اسفل الفاتورة
                    Calculate_BalanceQtyInInvoice(txtProductId.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductId.Text == "" || txtQty.Text == "" || txtPrice.Text == "" ||
                       txtValue.Text == "" || cboProductName.SelectedIndex == -1)
                {
                   throw new Exception(cls_Controls.InvalidData);
                    
                }
                if (cls_Order.Verify_Qty(txtProductId.Text, Convert.ToInt32(txtQty.Text) + Convert.ToInt32(txtCurrent.Text)).Rows.Count < 1)
                {
                   throw new Exception(cls_Controls.InvalidInventory);
                    
                }




                if (txtDisc.Text == string.Empty)
                {
                    txtDisc.Text = @"0.0";
                }
                #region
                //// اذا كانت وحدة كبرى يتم ضرب الكمية الكبرى بالصغري
                //if (rdbLarge.Checked)
                //{
                //    txtqty.Text = (Math.Round(decimal.Parse(txtqty.Text),2) * Math.Round(decimal.Parse(txtSqty.Text),2)).ToString();
                //}
                #endregion
                CalculateNetValue();
                dgvPos.Rows.Add(txtProductId.Text, cboProductName.Text, txtQty.Text, txtPrice.Text, txtValue.Text, txtDisc.Text, _netValue);


                //استدعاء دالة لاظهار قيم مربعات النصوص اسفل الفاتورة
                Calculate_BalanceQtyInInvoice(txtProductId.Text);
                txtAvQty.Text = cls_Controls.ShowAvailableQty(Convert.ToInt32(txtAvQty.Text), Convert.ToInt32(txtCurrent.Text)).ToString();

                int nRowIndex = dgvPos.Rows.Count - 1;
                dgvPos.CurrentCell = dgvPos.Rows[nRowIndex].Cells[0];

                DetailsRefresh();
                ClearBoxes();
                txtBarcode.Focus();

                // كود مكتوب بـ linq للتجميع من داتا جريد
                txtOrder_Total.Text =
                    (from DataGridViewRow row in dgvPos.Rows
                     let formattedValue = row.Cells[6].FormattedValue
                     where formattedValue != null && formattedValue.ToString() != string.Empty
                     select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString(CultureInfo.CurrentCulture);
                // compute Rest And Paid Minus Order Total
                txtPaid_TextChanged(null, null);
            }

            catch(Exception ex)when (ex.Message.Equals(cls_Controls.InvalidData))
            {
                MessageBox.Show(cls_Controls.CheckData);
            }
            catch (Exception ex) when (ex.Message.Equals(cls_Controls.InvalidInventory))
            {
                MessageBox.Show(cls_Controls.CheckInventory);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // check values
                if (txtOrder_Id.Text == string.Empty || txtCust_Id.Text == string.Empty)
                {
                    throw new Exception(cls_Controls.InvalidCustomerData);

                }
                if (dgvPos.Rows.Count < 1)
                {
                    throw new Exception(cls_Controls.NoData);
                }

                #region
                //DataTable invDet = new DataTable();
                //invDet.Columns.Add("Product_Id");
                //invDet.Columns.Add("Qty");
                //invDet.Columns.Add("Price");
                //invDet.Columns.Add("Discount");
                //invDet.Columns.Add("Amount");

                //foreach (DataGridViewRow dr in dgvDetails.Rows)
                //{
                //    invDet.Rows.Add(dr.Cells[0].Value, dr.Cells[2].Value, dr.Cells[3].Value, dr.Cells[5].Value, dr.Cells[6].Value);
                //}

                //cls_Order.Insert_Order(int.Parse(txtOrder_Id.Text),DateTime.Parse(dtpOrder_Date.Text), decimal.Parse(txtOrder_Total.Text), int.Parse(txtCust_Id.Text), txtOrder_SaleMan.Text, invDet);
                #endregion
                bool Ins = true;
                Insert_Order(Ins);
                if (Ins == true)
                {
                    if (rdbCash.Checked)
                    {

                        Add_Payment_Cash("سداد فاتورة مبيعات");
                        MessageBox.Show(@"تم السداد نقدا");
                        //  cashdrawer();
                    }
                    //else
                    //{
                    //    Add_Payment_Debit("فاتورة مبيعات");
                    //    MessageBox.Show(@"تم الحفظ وتعديل المديونية");
                    //}
                }
                else
                    return;




                MessageBox.Show(@"لقد تم اضافة دفعة  للعميل");

                PrintInvoice();
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnClear.Enabled = false;
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
        private void Insert_Order(bool INS)
        {

            try
            {
                int x = cls_Order.stp_Insert_Order(int.Parse(txtOrder_Id.Text), DateTime.Parse(dtpInvDate.Text), decimal.Parse(txtOrder_Total.Text), int.Parse(txtCust_Id.Text), txtUser.Text,lblType.Text);
                if (x > 0)
                {
                    for (int i = 0; i < dgvPos.Rows.Count; i++)
                    {
                        cls_Order.stp_Insert_OrderDetails(Convert.ToInt32(txtOrder_Id.Text),
                                                              Convert.ToInt32(dgvPos.Rows[i].Cells[0].Value.ToString()),
                                                              Convert.ToDecimal(dgvPos.Rows[i].Cells[2].Value.ToString()),
                                                              Convert.ToDecimal(dgvPos.Rows[i].Cells[3].Value.ToString()),
                                                              Convert.ToDecimal(dgvPos.Rows[i].Cells[5].Value.ToString()));
                    }
                    MessageBox.Show("تم حفظ الفاتورة وبياناتها بنجاح");
                    INS = true;
                }
                else
                {
                    MessageBox.Show("لا يمكن حفظ الفاتورة");
                    INS = false;
                    return;
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
                cls_CashIn.Add_CashIn(dbid, DateTime.Parse(dtpInvDate.Text), decimal.Parse(txtOrder_Total.Text), paymethod, int.Parse(txtCust_Id.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void PrintInvoice()
        {
            try
            {
                // get last order to print
                DialogResult respnse = MessageBox.Show(@"طباعة الفاتورة؟", @"طباعة فاتورة مبيعات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respnse == DialogResult.Yes)
                {

                    this.Cursor = Cursors.WaitCursor;
                    int orderNo = int.Parse(txtOrder_Id.Text);
                    RPT.rpt_Orders myReport = new RPT.rpt_Orders();
                    RPT.frm_Rpt_Product myForm = new RPT.frm_Rpt_Product();
                    myReport.SetDataSource(cls_Order.stp_SelectOrder_Details(orderNo));
                    myReport.Refresh();
                    myForm.crystalReportViewer1.ReportSource = myReport;
                    myForm.ShowDialog();
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // get last order to print

            try
            {

                this.Cursor = Cursors.WaitCursor;
                int orderNo = int.Parse(txtOrder_Id.Text);
                RPT.rpt_Orders myReport = new RPT.rpt_Orders();
                RPT.frm_Rpt_Product myForm = new RPT.frm_Rpt_Product();
                myReport.SetDataSource(cls_Order.stp_SelectOrder_Details(orderNo));
                myReport.Refresh();
                myForm.crystalReportViewer1.ReportSource = myReport;
                myForm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPos_DoubleClick(sender, e);
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
                dgvPos.Rows.RemoveAt(dgvPos.CurrentRow.Index);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgvPos_Click(null, null);
        }
        private void حذفالكلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقا الغاء بيانات الفاتورة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    //اعادة ضبط كميات المنتجات بالفاتورة
                    txtCurrent.Text = txtBalance.Text = txtOrder_Total.Text = txtAvQty.Text = txtLqty.Text = txtSqty.Text =
                txtLqtyPrice.Text = txtSqty.Text = txtSqtyPrice.Text = string.Empty;
                    txtQty.Focus();
                    // كود مكتوب بـ linq للتجميع من داتا جريد
                    txtOrder_Total.Text =
                        (from DataGridViewRow row in dgvPos.Rows
                         where row.Cells[6].FormattedValue.ToString() != string.Empty
                         select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();
                    dgvPos.Rows.Clear();
                    dgvPos.Refresh();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقا الغاء بيانات الفاتورة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dgvPos.Rows.Clear();
                    dgvPos.Refresh();
                    ClearData();
                    ClearBoxes();
                    txtCurrent.Text = txtBalance.Text = txtOrder_Total.Text = txtAvQty.Text = txtLqty.Text = txtSqty.Text =
                    txtLqtyPrice.Text = txtSqty.Text = txtSqtyPrice.Text = txtPaid.Text = txtRest.Text = string.Empty;
                    btnNew.Enabled = true;
                    btnClear.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dgvPos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtProductId.Text = this.dgvPos.CurrentRow.Cells[0].Value.ToString();
                cboProductName.Text = this.dgvPos.CurrentRow.Cells[1].Value.ToString();
                txtQty.Text = this.dgvPos.CurrentRow.Cells[2].Value.ToString();
                txtPrice.Text = this.dgvPos.CurrentRow.Cells[3].Value.ToString();
                txtValue.Text = this.dgvPos.CurrentRow.Cells[4].Value.ToString();
                txtDisc.Text = this.dgvPos.CurrentRow.Cells[5].Value.ToString();
                dgvPos.Rows.RemoveAt(dgvPos.CurrentRow.Index);
                DetailsRefresh();
                txtQty.Focus();
                //استدعاء دالة لاظهار قيم مربعات النصوص اسفل الفاتورة
                txtAvQty.Text = cls_Controls.ShowAvailableQty(Convert.ToInt32(txtAvQty.Text), Convert.ToInt32(txtCurrent.Text)).ToString();
                Calculate_BalanceQtyInInvoice(txtProductId.Text);
               

            }

            catch
            {
                return;
            }

        }
        private void dgvPos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Customers", "Cust_Name", "Cust_Id");
            cboCust_Name.SelectedIndex = 0;
            DataTable dt = cls_Customer.stp_SelectCustomersByName(cboCust_Name.Text);
            // في حالة عدم توفر صوره للعميل
            if (dt.Rows.Count > 0)
            {
                txtCust_Id.Text = dt.Rows[0][0].ToString();
                //txtCust_Name.Text = dt.Rows[0][1].ToString();

                decimal balance = cls_Controls.NetBalanceForCustomers((txtCust_Id.Text));
                txtBalance.Text = balance.ToString();

                return;
            }

        }
        private void dgvPos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPos.Rows.Count != 0)
                {
                    DataTable dt = cls_Product.stp_SelectAll_ProductsById(Convert.ToInt32(dgvPos.CurrentRow.Cells[0].Value.ToString()));
                    txtAvQty.Text = dt.Rows[0][3].ToString();
                    txtLqty.Text = dt.Rows[0][5].ToString();
                    txtLqtyPrice.Text = dt.Rows[0][6].ToString();
                    txtSqty.Text = dt.Rows[0][7].ToString();
                    txtSqtyPrice.Text = dt.Rows[0][8].ToString();
                    Calculate_BalanceQtyInInvoice(dt.Rows[0][0].ToString());
                    txtAvQty.Text = cls_Controls.ShowAvailableQty(Convert.ToInt32(txtAvQty.Text), Convert.ToInt32(txtCurrent.Text)).ToString();
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
        private void dgvPos_KeyDown(object sender, KeyEventArgs e)
        {
            dgvPos_Click(null, null);
        }
        private void dgvPos_KeyUp(object sender, KeyEventArgs e)
        {
            dgvPos_Click(null, null);
        }
        private void chkBarcode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBarcode.Checked)
            {

                txtBarcode.Focus();
            }
            else
            {
                cboProductName.Focus();
            }
        }
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode != Keys.Enter || txtBarcode.Text == string.Empty) return;
                DataTable dt = cls_Product.stp_SelectAll_ProductsByBarcode(txtBarcode.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(@"Product Not Registered");
                    txtBarcode.Clear();
                    txtBarcode.Focus();
                    return;
                }
                //if (rdbLarge.Checked)
                //{
                //    txtProductId.Text = dt.Rows[0]["رقم المنتج"].ToString();
                //    cboProductName.SelectedValue = dt.Rows[0]["اسم المنتج"].ToString();
                //    txtPrice.Text = dt.Rows[0]["سعر كبرى"].ToString();
                //    txtLqty.Text = dt.Rows[0]["وحدة كبرى"].ToString();
                //    txtSqty.Text = dt.Rows[0]["وحدة صغرى"].ToString();
                //    txtLqtyPrice.Text = dt.Rows[0]["سعر كبرى"].ToString();
                //    txtSqtyPrice.Text = dt.Rows[0]["سعر صغرى"].ToString();
                //    txtqty.Focus();
                //}
                //else
                //{
                if ((bool)dt.Rows[0]["Taxed"] == true)
                {

                    txtProductId.Text = dt.Rows[0]["Product_Id"].ToString();
                    cboProductName.Text = dt.Rows[0]["Product_Name"].ToString();
                    txtPrice.Text = dt.Rows[0]["S.Price"].ToString();
                    txtLqty.Text = dt.Rows[0]["Large Unit"].ToString();
                    txtSqty.Text = dt.Rows[0]["Small Unit"].ToString();
                    txtLqtyPrice.Text = dt.Rows[0]["L.Price"].ToString();
                    txtSqtyPrice.Text = dt.Rows[0]["S.Price"].ToString();
                    txtAvQty.Text = dt.Rows[0]["Balance"].ToString();
                    // ------- Compute Tax
                    txtDisc.Text = cls_Controls.CalculateTax(Convert.ToDecimal(txtPrice.Text)).ToString();

                }
                else
                {
                    txtProductId.Text = dt.Rows[0]["Product_Id"].ToString();
                    cboProductName.Text = dt.Rows[0]["Product_Name"].ToString();
                    txtPrice.Text = dt.Rows[0]["S.Price"].ToString();
                    txtLqty.Text = dt.Rows[0]["Large Unit"].ToString();
                    txtSqty.Text = dt.Rows[0]["Small Unit"].ToString();
                    txtLqtyPrice.Text = dt.Rows[0]["L.Price"].ToString();
                    txtSqtyPrice.Text = dt.Rows[0]["S.Price"].ToString();
                    txtAvQty.Text = dt.Rows[0]["Balance"].ToString();
                    // ------- Tax = 0
                    txtDisc.Text = "0";

                }
                // any case do the following :-
                txtBarcode.Clear();
                txtBarcode.Focus();
                txtQty.Text = "1";
                txtQty.Focus();
                // compute inventory & order balance
                Total = 0;
                CalculateAmount();
                Calculate_BalanceQtyInInvoice(txtProductId.Text);
                txtCurrent.Text = Total.ToString();
                txtAvQty.Text = (Convert.ToInt32(txtAvQty.Text) - Convert.ToInt32(txtCurrent.Text)).ToString();

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

                }
                else
                {
                    // في حالة توفر الصورة
                    txtCust_Id.Text = dt.Rows[0][0].ToString();

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
        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPaid.Text == "")
                {
                    txtRest.Text = txtOrder_Total.Text;
                    return;
                }
                txtRest.Text = (Convert.ToDecimal(txtOrder_Total.Text) - Convert.ToDecimal(txtPaid.Text)).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    
        // قيمة المنتج (السعر xالكمية(
        private void CalculateNetValue()
    {
        try
        {

            if (txtValue.Text != string.Empty && txtDisc.Text != string.Empty)
            {
                    _netValue = decimal.Parse(txtValue.Text) + decimal.Parse(txtDisc.Text);

                }
            else if (txtValue.Text != string.Empty)
            {

                _netValue = decimal.Parse(txtValue.Text);

            }
            else
            {
                return;
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }

    }
        //دالة لحساب كمية المنتج في سعر المنتج
        private void CalculateAmount()
        {
            try
            {
                if (txtQty.Text != string.Empty && txtPrice.Text != string.Empty && txtDisc.Text != "0")
                {

                    txtValue.Text = (decimal.Parse(txtQty.Text) * decimal.Parse(txtPrice.Text)).ToString();
                    txtDisc.Text = (Convert.ToDecimal(txtValue.Text) * 5 / 100).ToString();

                }
                else
                {
                    txtValue.Text = (decimal.Parse(txtQty.Text) * decimal.Parse(txtPrice.Text)).ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
   
        //دالة لحساب كمية من منتج معين بالفاتورة الحالية
        private void Calculate_BalanceQtyInInvoice(string p)
        {
            _total = 0;
            decimal realQty = 0;
            for (int i = 0; i < dgvPos.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvPos.Rows[i].Cells[0].Value).ToString() == p)
                {
                    realQty = Convert.ToDecimal(dgvPos.Rows[i].Cells[2].Value);
                    _total += realQty;
                    txtCurrent.Text = _total.ToString(CultureInfo.InvariantCulture);
                }

            }
        }
        #region
        //private void txtDisc_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtDisc_KeyUp(object sender, KeyEventArgs e)
        //{
        //    CalculateNetValue();
        //}

        //private void txtDisc_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        btnAdd.Focus();
        //    }
        //}

        //private void txtOrder_Total_TextChanged(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        txtTax.Text = "5"; txtTotal.Text = string.Empty;
        //        if (txtTax.Text != string.Empty && txtOrder_Total.Text != string.Empty)
        //        {
        //            txtTax.Text = (Convert.ToDecimal(txtOrder_Total.Text) * (Convert.ToDecimal(txtTax.Text)) / 100).ToString();
        //            txtTotal.Text = (Convert.ToDecimal(txtOrder_Total.Text) + Convert.ToDecimal(txtTax.Text)).ToString();
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
        #endregion



        //دالة لضبط عدد العناصر المدخلة للفاتورة

        private void frm_Pos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control == true && e.KeyCode == Keys.N)
                {
                    btnNew.PerformClick();
                }
               
                 if (e.Control == true && e.KeyCode == Keys.S)
                {
                    btnSave.PerformClick();
                }
                 if (e.Control == true && e.KeyCode == Keys.U)
                {
                    DialogResult respnse = MessageBox.Show(@"هل أنت متأكد من مسح الفاتورة؟", @"مسح الفاتورة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respnse == DialogResult.Yes)
                        btnClear.PerformClick();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}