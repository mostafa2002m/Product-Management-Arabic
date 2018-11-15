using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using PRODUCTS_MANAGEMENT.BL;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class FrmOrder : Form
    {
       
        private decimal _netValue = 0;
        private char _d = char.Parse(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
       

        public FrmOrder()
        
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

      

        private void LoadCustomer_Combo()
        {
            cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Customers", "Cust_Name", "Cust_Id");
            cboCust_Name.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnSaveOrder.Enabled)
            {
                if (MessageBox.Show(@"هل تريد الخروج", @"تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Close();
                }
                else
                    return;
            }
            Close();
            
        }

        private void frmOrder_Load(object sender, EventArgs e)
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
            if (txtqty.Text != "")
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            txtOrder_Id.Text = cls_Order.stp_SelectLast_Order_Id().Rows[0][0].ToString();
            btnAddNew.Enabled = false;
            btnSaveOrder.Enabled = true;
            btnUndoOrder.Enabled = true;
            btnUndoOrder.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            
           

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                ClearBoxes();
                frm_Search frm = new frm_Search("Product");
                frm.ShowDialog();
                if ((bool)(frm.dgvSearch.CurrentRow.Cells[10].Value) == false)
                {


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


                    }
                    // ------- Tax = 0
                    txtDisc.Text = "0";

                }
                else
                {
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


                    }

                        txtDisc.Text = cls_Controls.CalculateTax(Convert.ToDecimal(txtPrice.Text)).ToString();
                }
                // any case do the following :-
                txtqty.Text = "1";
                txtqty.Focus();
                // compute inventory & order balance
                CalculateAmount();
                //استدعاء دالة لاظهار قيم مربعات النصوص اسفل الفاتورة
                Calculate_BalanceQtyInInvoice(txtProduct_Id.Text);
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
                if (txtProduct_Id.Text == string.Empty && txtProduct_Name.Text == string.Empty && txtqty.Text == string.Empty && txtPrice.Text == string.Empty)
                {
                    
                    throw new Exception("لا يوجد بيانات لاضافتها");
                }
                if (cls_Order.Verify_Qty(txtProduct_Id.Text, Convert.ToInt32(txtqty.Text) + Convert.ToInt32(txtCurrent.Text)).Rows.Count < 1)
                {
                    throw new Exception(@"الرصيد لا يكفي");
                 
                }



                if (txtDisc.Text == string.Empty)
                {
                    txtDisc.Text = @"0.0";
                }

                //// اذا كانت وحدة كبرى يتم ضرب الكمية الكبرى بالصغري
                //if (rdbLarge.Checked)
                //{
                //    txtqty.Text = (Math.Round(decimal.Parse(txtqty.Text),2) * Math.Round(decimal.Parse(txtSqty.Text),2)).ToString();
                //}
                CalculateNetValue();

                dgvDetails.Rows.Add(txtProduct_Id.Text, txtProduct_Name.Text, txtqty.Text, txtPrice.Text, txtValue.Text, txtDisc.Text, _netValue);

                //استدعاء دالة لاظهار قيم مربعات النصوص اسفل الفاتورة
                Calculate_BalanceQtyInInvoice(txtProduct_Id.Text);
                txtAvQty.Text = cls_Controls.ShowAvailableQty(Convert.ToInt32(txtAvQty.Text), Convert.ToInt32(txtCurrent.Text)).ToString();

                int nRowIndex = dgvDetails.Rows.Count - 1;
                dgvDetails.CurrentCell = dgvDetails.Rows[nRowIndex].Cells[0];
                ClearBoxes();
                txtBarcode.Focus();



                // كود مكتوب بـ linq للتجميع من داتا جريد
                txtOrder_Total.Text =
                        (from DataGridViewRow row in dgvDetails.Rows
                         let formattedValue = row.Cells[6].FormattedValue
                         where formattedValue != null && formattedValue.ToString() != string.Empty
                         select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString(CultureInfo.CurrentCulture);



            }
            catch (Exception ex)when (ex.Message.Equals("لا يوجد بيانات لاضافتها"))
            {

                MessageBox.Show("من فضلك تحقق من ادخال البيانات");
            }
            catch (Exception ex) when (ex.Message.Equals("الرصيد لا يكفي"))
            {

                MessageBox.Show("ادخل كمية تتناسب مع رصيد المخزون");
                txtqty.Focus();
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
                if (txtOrder_Id.Text == string.Empty || txtCust_Id.Text == string.Empty )
                {
                    throw new Exception("أدخل بيانات العميل");
                  
                }
                if (dgvDetails.Rows.Count < 1)
                {
                    throw new Exception("لايوجد بيانات فانورة ");
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

                        Add_Payment_Cash("سداد فاتورة مستودع");
                        MessageBox.Show(@"تم السداد نقدا");
                        //  cashdrawer();
                    }
                    //else
                    //{
                    //    Add_Payment_Debit("فاتورة مبيعات");
                    //    MessageBox.Show(@"تم الحفظ وتعديل المديونية");
                    //}
                }
               
                MessageBox.Show(@"لقد تم اضافة دفعة من العميل");

                PrintInvoice();
                btnAddNew.Enabled = true;
                btnSaveOrder.Enabled = false;
                btnUndoOrder.Enabled = false;
                ClearData();
                txtBalance.Text = string.Empty;
                txtItems.Text = string.Empty;


            }
            catch (Exception ex)when(ex.Message.Equals("أدخل بيانات العميل"))
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
        private void Insert_Order(bool INS)
        {

            try
            {
                int x = cls_Order.stp_Insert_Order(int.Parse(txtOrder_Id.Text), DateTime.Parse(dtpOrder_Date.Text), decimal.Parse(txtOrder_Total.Text), int.Parse(txtCust_Id.Text), txtOrder_SaleMan.Text,lblType.Text);
                if (x > 0)
                {
                    for (int i = 0; i < dgvDetails.Rows.Count; i++)
                    {
                        cls_Order.stp_Insert_OrderDetails(Convert.ToInt32(txtOrder_Id.Text),
                                                              Convert.ToInt32(dgvDetails.Rows[i].Cells[0].Value.ToString()),
                                                              Convert.ToDecimal(dgvDetails.Rows[i].Cells[2].Value.ToString()),
                                                              Convert.ToDecimal(dgvDetails.Rows[i].Cells[3].Value.ToString()),
                                                              Convert.ToDecimal(dgvDetails.Rows[i].Cells[5].Value.ToString()));
                    }
                    MessageBox.Show("تم حفظ الفاتورة وبياناتها بنجاح");
                    INS = true;
                }
                else
                {
                    INS = false;
                    throw new Exception("لا يمكن حفظ الفاتورة");
                    
                }

            }
            catch(Exception ex) when(ex.Message.Equals("لا يمكن حفظ الفاتورة"))
            {
                MessageBox.Show("تحقق من أدخال البيانات بشكل صحيح");
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
        private void PrintInvoice()
        {
            try
            {
                // get last order to print
                if (MessageBox.Show(@"طباعة الفاتورة؟", @"طباعة فاتورة مبيعات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 

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
        private void btnPrintOrder_Click(object sender, EventArgs e)
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnAddNew_Click(null, null);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            btnSaveOrder_Click(null, null);
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            btnPrintOrder_Click(null, null);
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            btnClose_Click(null, null);
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            btnClose_Click(null, null);
        }
        private void btnUndoOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حقا الغاء بيانات الفاتورة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dgvDetails.Rows.Clear();
                    dgvDetails.Refresh();
                    ClearData();
                    ClearBoxes();
                    txtCurrent.Text = txtBalance.Text = txtOrder_Total.Text = txtAvQty.Text = txtLqty.Text = txtSqty.Text =
                    txtLqtyPrice.Text = txtSqty.Text = txtSqtyPrice.Text = string.Empty;
                    btnAddNew.Enabled = true;
                    btnUndoOrder.Enabled = false;
                    btnSaveOrder.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!this.dgvDetails.Rows[this.rowIndex].IsNewRow)
            //    {
            //        this.dgvDetails.Rows.RemoveAt(this.rowIndex);
            //    }
            //    foreach (Control item in groupBox4.Controls)
            //    {
            //        if (item is TextBox)
            //            item.Text = string.Empty;
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }
        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
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
                if (MessageBox.Show("هل تريد حقا الغاء بيانات الفاتورة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    //اعادة ضبط كميات المنتجات بالفاتورة
                    txtCurrent.Text = txtBalance.Text = txtOrder_Total.Text = txtAvQty.Text = txtLqty.Text = txtSqty.Text =
                    txtLqtyPrice.Text = txtSqty.Text = txtSqtyPrice.Text = string.Empty;
                    txtqty.Focus();
                    // كود مكتوب بـ linq للتجميع من داتا جريد
                    txtOrder_Total.Text =
                        (from DataGridViewRow row in dgvDetails.Rows
                         where row.Cells[6].FormattedValue.ToString() != string.Empty
                         select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();
                    dgvDetails.Rows.Clear();
                    dgvDetails.Refresh();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void حذفالحاليToolStripMenuItem_Click(object sender, EventArgs e)
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
                //استدعاء دالة لاظهار قيم مربعات النصوص اسفل الفاتورة
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
                 let value = row.Cells[6].FormattedValue
                 where value != null && value.ToString() != string.Empty
                 select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();
            DetailsRefresh();
            txtBalance.Text = cls_Controls.NetBalanceForCustomers((txtCust_Id.Text)).ToString();
            //txtBalance.Text = balance.ToString();
            // compute Rest And Paid Minus Order Total

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
                if (e.KeyCode != Keys.Enter || txtBarcode.Text == string.Empty) return;
                DataTable dt = cls_Product.stp_SelectAll_ProductsByBarcode(txtBarcode.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(@"Product Not Exist");
                    txtBarcode.Clear();
                    return;
                }

                if ((bool)dt.Rows[0]["Taxed"] == true)
                {
                    if (rdbLarge.Checked)
                    {
                        txtProduct_Id.Text = dt.Rows[0]["Product_Id"].ToString();
                        txtProduct_Name.Text = dt.Rows[0]["Product_Name"].ToString();
                        txtPrice.Text = dt.Rows[0]["L.Price"].ToString();
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
                        txtProduct_Id.Text = dt.Rows[0]["Product_Id"].ToString();
                        txtProduct_Name.Text = dt.Rows[0]["Product_Name"].ToString();
                        txtPrice.Text = dt.Rows[0]["S.Price"].ToString();
                        txtLqty.Text = dt.Rows[0]["Large Unit"].ToString();
                        txtSqty.Text = dt.Rows[0]["Small Unit"].ToString();
                        txtLqtyPrice.Text = dt.Rows[0]["L.Price"].ToString();
                        txtSqtyPrice.Text = dt.Rows[0]["S.Price"].ToString();
                        txtAvQty.Text = dt.Rows[0]["Balance"].ToString();
                        // ------- Compute Tax
                        txtDisc.Text = cls_Controls.CalculateTax(Convert.ToDecimal(txtPrice.Text)).ToString();

                    }
                }

                else if ((bool)dt.Rows[0]["Taxed"] == false)
                {
                    if (rdbLarge.Checked)
                    {
                        txtProduct_Id.Text = dt.Rows[0]["Product_Id"].ToString();
                        txtProduct_Name.Text = dt.Rows[0]["Product_Name"].ToString();
                        txtPrice.Text = dt.Rows[0]["L.Price"].ToString();
                        txtLqty.Text = dt.Rows[0]["Large Unit"].ToString();
                        txtSqty.Text = dt.Rows[0]["Small Unit"].ToString();
                        txtLqtyPrice.Text = dt.Rows[0]["L.Price"].ToString();
                        txtSqtyPrice.Text = dt.Rows[0]["S.Price"].ToString();
                        txtAvQty.Text = dt.Rows[0]["Balance"].ToString();
                        // ------- Tax = 0
                        txtDisc.Text = "0";
                    }
                    else
                    {
                        txtProduct_Id.Text = dt.Rows[0]["Product_Id"].ToString();
                        txtProduct_Name.Text = dt.Rows[0]["Product_Name"].ToString();
                        txtPrice.Text = dt.Rows[0]["S.Price"].ToString();
                        txtLqty.Text = dt.Rows[0]["Large Unit"].ToString();
                        txtSqty.Text = dt.Rows[0]["Small Unit"].ToString();
                        txtLqtyPrice.Text = dt.Rows[0]["L.Price"].ToString();
                        txtSqtyPrice.Text = dt.Rows[0]["S.Price"].ToString();
                        txtAvQty.Text = dt.Rows[0]["Balance"].ToString();
                        // ------- Tax = 0
                        txtDisc.Text = "0";
                    }
                }

                // any case do the following :-
                txtqty.Text = "1";
                txtqty.Focus();
                // compute inventory & order balance

                CalculateAmount();

                //استدعاء دالة لاظهار قيم مربعات النصوص اسفل الفاتورة
                txtAvQty.Text = cls_Controls.ShowAvailableQty1(Convert.ToInt32(txtAvQty.Text), Convert.ToInt32(txtCurrent.Text)).ToString();
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
                    txtCust_Name.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    // في حالة توفر الصورة
                    txtCust_Id.Text = dt.Rows[0][0].ToString();
                    txtCust_Name.Text = dt.Rows[0][1].ToString();
                    //picBox_Cust.Image = null;
                    //byte[] image = (byte[])dt.Rows[0][5];

                    //MemoryStream ms = new MemoryStream(image);
                    //picBox_Cust.Image = Image.FromStream(ms);
                    ////txtCust_Id.Text = dt.Rows[0][0].ToString();
                    ////txtCust_Id.Text = dt.Rows[0][0].ToString();
                }

                txtBalance.Text = cls_Controls.NetBalanceForCustomers((txtCust_Id.Text)).ToString();
               

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

     

     
        //دالة لحساب كمية من منتج معين بالفاتورة الحالية
        private void Calculate_BalanceQtyInInvoice(string p)
        {
            decimal _total = 0;
            decimal realQty = 0;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvDetails.Rows[i].Cells[0].Value).ToString() == p)
                {
                    realQty = Convert.ToDecimal(dgvDetails.Rows[i].Cells[2].Value);
                    _total += realQty;
                    txtCurrent.Text = _total.ToString();
                }

            }
        }
        
        void CalculateNetValue()
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

            }
            
       
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        // دالة لحساب قيمة المنتج ناتج عدد الوحدات في سعر الوحدة
        private void CalculateAmount()
        {
            try
            {
                if (txtqty.Text != string.Empty && txtPrice.Text != string.Empty && txtDisc.Text != "0")
                {

                    txtValue.Text = (decimal.Parse(txtqty.Text) * decimal.Parse(txtPrice.Text)).ToString();
                    txtDisc.Text = (Convert.ToDecimal(txtValue.Text) * 5 / 100).ToString();

                }
                else
                {
                    txtValue.Text = (decimal.Parse(txtqty.Text) * decimal.Parse(txtPrice.Text)).ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //دالة لحساب عدد العناصر في الفاتورة الحالية
        void DetailsRefresh()
        {
            txtItems.Text = dgvDetails.Rows.Count.ToString();
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

        /*  private void cashdrawer()
         {
            BL.USB cUSB = new BL.USB();
           cUSB.OpenPort(); // Open the USB Port
         cUSB.WritePort(Strings.Chr(12));   // Clear pole display
         cUSB.WritePort(Strings.Chr(27) + Strings.Chr(61) + 
         Strings.Chr(1));   // Send print through pole display
         cUSB.WritePort(Strings.Chr(27) + Strings.Chr(64));   // Initialize printer
         cUSB.WritePort(Strings.Chr(27) + Strings.Chr(114) + Strings.Chr(1));   // Select Red color to print
         cUSB.WritePort(string.Format("{0,-10}{1,7:-0.000} {2,10:0.00}{3,13:-0.00}", tempitemid, tempunits, 
         tempunitprice, tempsubtotal) + Strings.Chr(10));   // Print text and new line
         cUSB.WritePort(Strings.Chr(27) + Strings.Chr(114) + Strings.Chr(0));   // Set color to default Black
         cUSB.WritePort(Strings.Chr(27) + Strings.Chr(61) + Strings.Chr(2));   // De-select printer and enable pole display
         cUSB.ClosePort();  // Close the USB Port
         }*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 




    }
}
