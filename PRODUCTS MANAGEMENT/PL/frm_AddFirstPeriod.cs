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
    public partial class FrmAddFirstPeriod : Form
    {
        decimal NetValue = 0;
        char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
        public FrmAddFirstPeriod()
        {
            InitializeComponent();
            ClearData();
            LoadCustomer_Combo();
            txtOrder_SaleMan.Text = Program.User_FullName;
            errorProvider1.Clear();
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


            //picBox_Cust.Image = null;

            dtpOrder_Date.ResetText();


            ClearBoxes();
            dgvDetails.DataSource = null;
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            txtOrder_Id.Text = cls_Invoice.stp_SelectLast_Invoice_Id().Rows[0][0].ToString();
            btnAddNew.Enabled = false;
            btnSaveOrder.Enabled = true;
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
                    txtdiscount.Text = "0";

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

                    txtdiscount.Text = cls_Controls.CalculateTax(Convert.ToDecimal(txtPrice.Text)).ToString();
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

                txtdiscount.Focus();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) &&  e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateNetValue();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (btnSaveOrder.Enabled)
            {
                if (MessageBox.Show(@"هل تريد الخروج؟", @"تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    this.Close();
                else
                    return;
            }
            else
                this.Close();
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

                //cls_Invoice.Insert_Invoice(int.Parse(txtOrder_Id.Text), dtpOrder_Date.Value, Convert.ToDecimal(txtOrder_Total.Text), int.Parse(txtCust_Id.Text), txtOrder_SaleMan.Text, InvDet);
                insert_Invoice();
                insert_InvoiceDetails();
                if (rdbCash.Checked)
                {

                    Add_Payment_Cash("سداد أول المدة");
                    MessageBox.Show(@"تم الحفظ والسداد ");
                }
                
                MessageBox.Show(@"تم الحفظ");
              
                btnAddNew.Enabled = true;
                btnSaveOrder.Enabled = false;
                btnUndoOrder.Enabled = false;
                PrintInvoice();
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
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void insert_Invoice()
        {
            cls_Invoice.stp_Insert_Invoice(int.Parse(txtOrder_Id.Text), dtpOrder_Date.Value, Convert.ToDecimal(txtOrder_Total.Text), int.Parse(txtCust_Id.Text), txtOrder_SaleMan.Text,lblType.Text);
        }
        private void insert_InvoiceDetails()
        {
            for (int i = 0; i < dgvDetails.Rows.Count ; i++)
            {
                cls_Invoice.stp_Insert_InvoiceDetails(Convert.ToInt32(txtOrder_Id.Text),
                                                      Convert.ToInt32(dgvDetails.Rows[i].Cells[0].Value.ToString()),
                                                      Convert.ToDecimal(dgvDetails.Rows[i].Cells[2].Value.ToString()),
                                                      Convert.ToDecimal(dgvDetails.Rows[i].Cells[3].Value.ToString()),
                                                      Convert.ToDecimal(dgvDetails.Rows[i].Cells[5].Value.ToString()));
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

        private void PrintInvoice()
        {
            try
            {
                if (MessageBox.Show(@"طباعة الفاتورة؟", @"طباعة فاتورة أول المده", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;// get last order to print
                    int Inv_No = int.Parse(txtOrder_Id.Text);
                    RPT.rpt_Invoices MyReport = new RPT.rpt_Invoices();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_Invoice.Stp_SelectInvoice_Details(Inv_No));
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
                txtCust_Id.Text = dt.Rows[0]["Sup_Id"].ToString();
                txtCust_Sex.Text = dt.Rows[0]["Sup_Name"].ToString();
                txtBalance.Text = cls_Controls.NetBalanceForCustomers((txtCust_Id.Text)).ToString();
            

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

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            new frm_AddSuppliers("a").ShowDialog();
            LoadCustomer_Combo();
        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
                                                                                                                            
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }

            
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtdiscount_KeyUp(object sender, KeyEventArgs e)
        {
            //CalculateAmount();
            CalculateNetValue();
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
                        txtdiscount.Text = cls_Controls.CalculateTax(Convert.ToDecimal(txtPrice.Text)).ToString();
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
                        txtdiscount.Text = cls_Controls.CalculateTax(Convert.ToDecimal(txtPrice.Text)).ToString();
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
                        txtdiscount.Text = "0";
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
                        txtdiscount.Text = "0";
                    }
                }

                // any case do the following :-
                txtqty.Text = "1";
                txtqty.Focus();
                // compute inventory & order balance

                CalculateAmount();

                //استدعاء دالة لاظهار قيم مربعات النصوص اسفل الفاتورة
                Calculate_Totals();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void frm_AddFirstPeriod_Activated(object sender, EventArgs e)
        {
            //LoadCustomer_Combo();
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

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvDetails.Rows.Count - 1; i++)
                {
                    dgvDetails.Rows.RemoveAt(dgvDetails.CurrentRow.Index);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            new frm_AddProduct("a").ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtqty.Text == string.Empty || txtPrice.Text == string.Empty)
                {
                   MessageBox.Show(@"تحقق من البيانات", @"انتبه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                
                // كود للتحقق من عدم تكرار ادخال نفس المنتج في نفس الفاتوره
                for (int i = 0; i < dgvDetails.Rows.Count - 1; i++)
                {
                    if (dgvDetails.Rows[i].Cells[0].Value.ToString() == txtProduct_Id.Text)
                    {
                        MessageBox.Show(@"Product Exists", @"Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                if (txtdiscount.Text == string.Empty)
                {
                    txtdiscount.Text = "0.0";
                }

                CalculateNetValue();
                dgvDetails.Rows.Add(txtProduct_Id.Text, txtProduct_Name.Text, txtqty.Text, txtPrice.Text, txtValue.Text, txtdiscount.Text, NetValue);


                Calculate_Totals();
                ClearBoxes();
                int nRowIndex = dgvDetails.Rows.Count - 1;
                dgvDetails.CurrentCell = dgvDetails.Rows[nRowIndex].Cells[0];
                DetailsRefresh();
                btnBrowse.Focus();


                // كود مكتوب بـ linq للتجميع من داتا جريد
                Calculate_Totals();

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

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int Selected_Row;

                if (e.RowIndex >= 0)
                {
                    Selected_Row = e.RowIndex;
                    DataGridViewRow grv = dgvDetails.Rows[Selected_Row];
                    txtProduct_Id.Text = grv.Cells[0].Value.ToString();
                    txtProduct_Name.Text = grv.Cells[1].Value.ToString();
                    txtqty.Text = grv.Cells[2].Value.ToString();
                    txtPrice.Text = grv.Cells[3].Value.ToString();
                    txtValue.Text = grv.Cells[4].Value.ToString();
                    txtdiscount.Text = grv.Cells[5].Value.ToString();
                    dgvDetails.Rows.RemoveAt(Selected_Row);
                    DetailsRefresh();
                    txtqty.Focus();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void dgvDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // لحساي المبلغ الاجمالي للفاتورة فور حذف صنف من الفاتورة
            // كود مكتوب بـ linq للتجميع من داتا جريد
            txtOrder_Total.Text =
                (from DataGridViewRow row in dgvDetails.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                 select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();
            DetailsRefresh();
            txtBalance.Text = cls_Controls.NetBalanceForCustomers((txtCust_Id.Text)).ToString();
            
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
                    txtdiscount.Text = this.dgvDetails.CurrentRow.Cells[5].Value.ToString();
                    dgvDetails.Rows.RemoveAt(dgvDetails.CurrentRow.Index);

                    DetailsRefresh();
                    txtqty.Focus();
                }
            }

            catch
            {
                return;
            }
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
                    Calculate_Totals();
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

        void DetailsRefresh()
        {
            txtItems.Text = dgvDetails.Rows.Count.ToString();
        }

      
        void CalculateNetValue()
        {
            if (txtValue.Text != string.Empty && txtdiscount.Text != string.Empty)
            {

                NetValue = Convert.ToDecimal(txtValue.Text) + Convert.ToDecimal(txtdiscount.Text);

            }
            else if (txtValue.Text != string.Empty)
            {
                NetValue = Convert.ToDecimal(txtValue.Text);

            }

        }

        void CalculateAmount()
        {
            try
            {
                if (txtqty.Text != string.Empty && txtPrice.Text != string.Empty && txtdiscount.Text != "0")
                {

                    txtValue.Text = (decimal.Parse(txtqty.Text) * decimal.Parse(txtPrice.Text)).ToString();
                    txtdiscount.Text = (Convert.ToDecimal(txtValue.Text) * 5 / 100).ToString();

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
     
        void Calculate_Totals()
        {
            // كود مكتوب بـ linq للتجميع من داتا جريد
            txtOrder_Total.Text =
                (from DataGridViewRow row in dgvDetails.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                 select Convert.ToDecimal(row.Cells[6].FormattedValue)).Sum().ToString();
            txtCurrent.Text = (from DataGridViewRow row in dgvDetails.Rows
                               where row.Cells[0].FormattedValue.ToString() == dgvDetails.CurrentCell.Value.ToString()
                               select Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();
        }
    }
}
