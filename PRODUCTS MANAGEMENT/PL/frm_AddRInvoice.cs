using PRODUCTS_MANAGEMENT.BL;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddRInvoice : Form
    {
        public decimal NetValue=0; 
        public int InvoiceNo = 0;
        char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
        public frm_AddRInvoice()
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
            cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Supplier", "Sup_Company", "Sup_Id");
            cboCust_Name.SelectedIndex = -1;
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqty.Text != string.Empty)
            {
                txtPrice.Focus();
            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtqty_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtqty.Text != string.Empty)
            {
                CalculateAmount();
                CalculateNetValue();
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)
            {

                txtDisc.Focus();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateNetValue();
        }

        private void txtDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)
            {

                btnAdd.Focus();
            }

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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            txtOrder_Id.Text =cls_RInvoice.stp_SelectLast_RInvoice_Id().Rows[0][0].ToString();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnSaveOrder.Enabled)
            {
                if (MessageBox.Show(@"خروج؟", @"تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    this.Close();
                else
                    return;
            }
            this.Close();
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // check values
                if (txtOrder_Id.Text == string.Empty || txtCust_Id.Text == string.Empty)
                {
                    throw new Exception(cls_Controls.InvalidSupplierData);

                }
                if (dgvDetails.Rows.Count < 1)
                {
                    throw new Exception(cls_Controls.NoData);
                }
                #region
                //DataTable InvDet = new DataTable();
                //InvDet.Columns.Add("Product_Id");
                //InvDet.Columns.Add("Qty");
                //InvDet.Columns.Add("Price");
                //InvDet.Columns.Add("Discount");
                //InvDet.Columns.Add("Amount");

                //foreach (DataGridViewRow dr in dgvDetails.Rows)
                //{
                //    InvDet.Rows.Add(dr.Cells[0].Value, dr.Cells[2].Value, dr.Cells[3].Value, dr.Cells[5].Value, dr.Cells[6].Value);
                //}

                //cls_RInvoice.Insert_RInvoice(int.Parse(txtOrder_Id.Text), dtpOrder_Date.Value, Convert.ToDecimal(txtOrder_Total.Text), int.Parse(txtCust_Id.Text), txtOrder_SaleMan.Text, InvDet);
                #endregion
                bool Ins = true;
                insert_RInvice(Ins);
                if (Ins == true)
                {
                    if (rdbCash.Checked)
                    {

                        //    Add_Payment_Debit("سداد مردودات مبيعات");
                        //    MessageBox.Show(@"تم السداد نقدا");
                        //    //  cashdrawer();
                        //}
                        //else
                        //{
                        Add_Payment_Cash("سداد مردودات مشتريات");
                        MessageBox.Show(@"تم السداد نقدا");
                    }
                }
                
                InvoiceNo = Convert.ToInt32(txtOrder_Id.Text);
                btnAddNew.Enabled = true;
                btnSaveOrder.Enabled = false;
                btnUndoOrder.Enabled = false;
                PrintInvoice();
                txtBalance.Text = string.Empty;
                txtItems.Text = string.Empty;
                ClearData();
                txtBalance.Text = string.Empty;
                txtItems.Text = string.Empty;


            }

            catch (Exception ex) when (ex.Message.Equals(cls_Controls.InvalidSupplierData))
            {

                MessageBox.Show(cls_Controls.CheckSupplierData);
            }

            catch (Exception ex) when (ex.Message.Equals(cls_Controls.NoData))
            {

                MessageBox.Show(cls_Controls.CheckData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
                return;
            }
        }
        private void insert_RInvice(bool INS)
        {
            try
            { 
            int x=   cls_RInvoice.stp_Insert_RInvoices(int.Parse(txtOrder_Id.Text), dtpOrder_Date.Value, Convert.ToDecimal(txtOrder_Total.Text), int.Parse(txtCust_Id.Text), txtOrder_SaleMan.Text,lblType.Text);
            if (x > 0)
            {
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    cls_RInvoice.stp_Insert_RInvoiceDetails(Convert.ToInt32(txtOrder_Id.Text),
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
                MessageBox.Show("لا يمكن حفظ الفاتورة");
                INS = false;
                return;
            }
        }
       
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
         }


        private void Add_Payment_Cash(string paymethod)
        {
            try
            {

                DataTable dt = cls_CashOut.stp_SelectLast_CashOut_Id();
                int crid = Convert.ToInt32(dt.Rows[0][0].ToString());
                cls_CashOut.Add_CashOut(crid, Convert.ToDateTime(dtpOrder_Date.Value), Convert.ToDecimal(txtOrder_Total.Text), paymethod, int.Parse(txtCust_Id.Text));
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }







        private void dgvDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                 // لحساب المبلغ الاجمالي للفاتورة فور حذف صنف من الفاتورة
            // كود مكتوب بـ linq للتجميع من داتا جريد
            txtOrder_Total.Text =
                (from DataGridViewRow row in dgvDetails.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                 select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();
                DetailsRefresh();
                txtBalance.Text = cls_Controls.NetBalanceForSuppliers((txtCust_Id.Text)).ToString();
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            // كود مكتوب بـ linq للتجميع من داتا جريد
            txtOrder_Total.Text =
                (from DataGridViewRow row in dgvDetails.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                 select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void dgvDetails_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetails.Rows.Count < 1)
                {
                    return;
                }
                else
                {
                    txtProduct_Id.Text = this.dgvDetails.CurrentRow.Cells[0].Value.ToString();
                    txtProduct_Name.Text = this.dgvDetails.CurrentRow.Cells[1].Value.ToString();
                    txtqty.Text = this.dgvDetails.CurrentRow.Cells[2].Value.ToString();
                    txtPrice.Text = this.dgvDetails.CurrentRow.Cells[3].Value.ToString();
                    txtValue.Text = this.dgvDetails.CurrentRow.Cells[4].Value.ToString();
                    txtDisc.Text = this.dgvDetails.CurrentRow.Cells[5].Value.ToString();
                    dgvDetails.Rows.RemoveAt(dgvDetails.CurrentRow.Index);
                    txtAvQty.Text = cls_Controls.ShowAvailableQty(Convert.ToInt32(txtAvQty.Text), Convert.ToInt32(txtCurrent.Text)).ToString();
                    txtqty.Focus();
                }
            }

            catch
            {
                return;
            }
        }

        private void PrintInvoice()
        {
            try
            {
                if (MessageBox.Show(@"طباعة الفاتورة؟", @"طباعة فاتورة مبيعات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {



                    this.Cursor = Cursors.WaitCursor;
                    int Inv_No = int.Parse(txtOrder_Id.Text);
                    RPT.rpt_PrintRInvoice MyReport = new RPT.rpt_PrintRInvoice();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_RInvoice.stp_SelectRInvoice_Details(Inv_No));
                    MyReport.Refresh();
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();

                    //cls_Controls.PrintInvoice(Inv_No,MyForm, MyReport, "cls_RInvoice.stp_SelectRInvoice_Details" );
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
                Show_Status_Boxes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cboCust_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = cls_Supplier.stp_SelectAll_SuppliersById(cboCust_Name.Text);
                // في حالة عدم توفر صوره للعميل
                //if (dt.Rows[0][6] is DBNull)
                //{
                //    txtCust_Id.Text = dt.Rows[0][0].ToString();
                //    txtCust_Sex.Text = dt.Rows[0][2].ToString();
                //    txtCust_Address.Text = dt.Rows[0][3].ToString();
                //    txtCust_Phone.Text = dt.Rows[0][4].ToString();
                //    txtCust_Email.Text = dt.Rows[0][5].ToString();
                //    //picBox_Cust.Image = null;
                //    return;
                //}
                // في حالة توفر الصورة
                txtCust_Id.Text = dt.Rows[0][0].ToString();
                txtCust_Name.Text = dt.Rows[0][2].ToString();

                txtBalance.Text = cls_Controls.NetBalanceForSuppliers((txtCust_Id.Text)).ToString();

                // في حالة اظهار الصوره
                //picBox_Cust.Image = null;
                //byte[] image = (byte[])dt.Rows[0][6];

                //MemoryStream ms = new MemoryStream(image);
                //picBox_Cust.Image = Image.FromStream(ms);

            }
            catch
            {
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtqty.Text == string.Empty || txtPrice.Text == string.Empty)
                {
                    throw new Exception(cls_Controls.InvalidData);
                    

                }

                // كود للتحقق من عدم تكرار ادخال نفس المنتج في نفس الفاتوره
                for (int i = 0; i < dgvDetails.Rows.Count - 1; i++)
                {
                    if (dgvDetails.Rows[i].Cells[0].Value.ToString() == txtProduct_Id.Text)
                    {
                        throw new Exception(cls_Controls.DoubleData);
                    }

                }
                if (txtDisc.Text == string.Empty)
                {
                    txtDisc.Text = "0.0";
                }

                CalculateNetValue();
                dgvDetails.Rows.Add(txtProduct_Id.Text, txtProduct_Name.Text, txtqty.Text, txtPrice.Text, txtValue.Text, txtDisc.Text, NetValue);


                //استدعاء دالة لاظهار قيم مربعات النصوص اسفل الفاتورة
                Calculate_BalanceQtyInInvoice(txtProduct_Id.Text);
                Show_Status_Boxes();
                ClearBoxes();
                int nRowIndex = dgvDetails.Rows.Count - 1;
                dgvDetails.CurrentCell = dgvDetails.Rows[nRowIndex].Cells[0];
                DetailsRefresh();
                btnBrowse.Focus();


                // كود مكتوب بـ linq للتجميع من داتا جريد
                txtOrder_Total.Text =
                    (from DataGridViewRow row in dgvDetails.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();

            }
            catch (Exception ex) when (ex.Message.Equals(cls_Controls.InvalidData))
            {

                MessageBox.Show(cls_Controls.CheckData);
            }
            catch (Exception ex) when (ex.Message.Equals(cls_Controls.DoubleData))
            {

                MessageBox.Show(cls_Controls.CheckDouble);
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
                ClearBoxes();
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
        void Show_Status_Boxes()
        {

            // حساب رصيدالمنتج بعد اضافته للفاتورة
            txtAvQty.Text = (Convert.ToInt32(txtAvQty.Text) - Convert.ToInt32(txtCurrent.Text)).ToString();

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
                    txtCurrent.Text = _total.ToString(CultureInfo.InvariantCulture);
                }

            }
        }
        
        void CalculateNetValue()
        {
            try
            {
                if (txtValue.Text != string.Empty && txtDisc.Text != string.Empty)
                {

                    NetValue = Convert.ToDecimal(txtValue.Text)+ Convert.ToDecimal(txtDisc.Text);

                }
                else if (txtValue.Text != string.Empty)
                {
                    NetValue = Convert.ToDecimal(txtValue.Text);

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

                    txtValue.Text = (Convert.ToDecimal(txtqty.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        void DetailsRefresh()
        {
            txtItems.Text = dgvDetails.Rows.Count.ToString();
        }
        
    }
}
