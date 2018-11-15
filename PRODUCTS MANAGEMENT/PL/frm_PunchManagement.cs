using System;
using System.Data;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;
using System.Drawing;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class FrmPunchManagement : Form
    {
        public static int crid = 0;
        public FrmPunchManagement()
        {
            InitializeComponent();
            dgvPunch.DataSource = cls_Punches.stp_SelectAll_Punch();
            LoadCustomer_Combo();
        }

        private void LoadCustomer_Combo()
        {
            cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Customers", "Cust_Name", "Cust_Id");
            cboCust_Name.SelectedIndex = -1;
        }

        void ClearBoxes()
        {
            foreach (Control item in grbInformation.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
           
           
        }

        private void dgvPunch_Click(object sender, EventArgs e)
        {

            try
            {
               
                if (dgvPunch.Rows.Count == 0)
                {
                    return;
                }
                DataTable dt = cls_Punches.stp_SelectPunchInformationByTransID(Convert.ToInt32(dgvPunch.CurrentRow.Cells[1].Value));
                if (dt.Rows.Count < 0)
                {
                    dgvPunch.Columns.Clear();
                    return;
                }
                txtTransNo.Text = dt.Rows[0][0].ToString();
                dtpTransDate.Text = dt.Rows[0][1].ToString();
                txtOrderNo.Text = dt.Rows[0][2].ToString();
                txtCustNo.Text = dt.Rows[0][3].ToString();
                txtCustName.Text = dt.Rows[0][4].ToString();
                txtOrderValue.Text = dt.Rows[0][5].ToString();
                txtPackValue.Text = dt.Rows[0][6].ToString();
                txtPackTimes.Text = dt.Rows[0][7].ToString();
                txtDownPayment.Text = dt.Rows[0][8].ToString();
                dtpFirst.Text = dt.Rows[0][9].ToString();
                dtpLast.Text = dt.Rows[0][10].ToString();
                txtPhone.Text = dt.Rows[0][12].ToString();
                chkFinish.Checked = Convert.ToBoolean(dt.Rows[0][11]);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnToPayNow_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            dgvPunch.DataSource = cls_Punches.stp_SelectAll_Punch_ToPayNow();
        }

        private void btnAllPackages_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            dgvPunch.DataSource = cls_Punches.stp_SelectAll_Punch();
        }

        private void dgvPunch_DoubleClick(object sender, EventArgs e)
        {
            //int i = 0;
          

            try
            {
                if (Convert.ToBoolean(dgvPunch.CurrentRow.Cells[8].Value) == true)
                {
                    MessageBox.Show(@"لا يمكن سداد قسط تم سداده من قبل .. من فضلك اختر قسط آخر");
                    return;
                }
                DialogResult respnse = MessageBox.Show(@"هل تريد سداد هذا القسط",  @"سداد قسط", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respnse == DialogResult.Yes)
            {
                Add_Payment();
               
                         
            }
            btnToPayNow_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void Add_Payment()
        {
            try
            {
                string paymethod = "سداد قسط";
                DataTable dt = cls_Debit.stp_SelectLast_Debit_Id();
                crid = Convert.ToInt32(dt.Rows[0][0].ToString());
                int i = cls_CashIn.Add_CashIn(crid, Convert.ToDateTime(dgvPunch.CurrentRow.Cells[4].Value.ToString()),
                                       decimal.Parse(dgvPunch.CurrentRow.Cells[2].Value.ToString()), paymethod, int.Parse(txtCustNo.Text));
                if (i > 0)
                {
                    Update_PunchDetails(crid);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
           
           
        }


        private void Update_PunchDetails(int crid)
        {
            try
            {
                cls_Punches.update_Punch_Details(Convert.ToInt32(dgvPunch.CurrentRow.Cells[0].Value), Convert.ToInt32(dgvPunch.CurrentRow.Cells[1].Value), crid);

                MessageBox.Show(@"تمت عملية سداد القسط");
                DialogResult respnse1 = MessageBox.Show(@"هل تريد طباعة ايصال الدفع؟", @"سداد قسط", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respnse1 == DialogResult.Yes)
                    print_Punch();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void print_Punch()
        {
            try
            {
                
                this.Cursor = Cursors.WaitCursor;
                RPT.rpt_Print_Paid_Paunch MyReport = new RPT.rpt_Print_Paid_Paunch();
                RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                MyReport.SetDataSource(cls_Punches.Print_Paid_Paunch(Convert.ToInt32(txtTransNo.Text),Convert.ToInt32(dgvPunch.CurrentRow.Cells[0].Value)));
                MyReport.Refresh();
                MyForm.crystalReportViewer1.ReportSource = MyReport;
                MyForm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cboCust_Name_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && cboCust_Name.Text != string.Empty)
                {
                    DataTable dtCustNames = new DataTable();
                    dtCustNames = cls_Customer.stp_SelectCustomersByName(cboCust_Name.Text);
                    if (dtCustNames.Rows.Count == 0)
                    {
                        return;
                    }
                    txtId.Text = dtCustNames.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnShowAllPunches_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == string.Empty)
                {
                    MessageBox.Show(@"اختر اسم العميل أولا");
                    return;
                }
                new frm_PunchList(cboCust_Name.Text, "Show All").ShowDialog();
                if (frm_PunchList.row == null)
                {
                    MessageBox.Show("لا يوجد بيانات لعرضها");
                  
                    return;
                }
                else
                {
                    ShoInfo();
                    dgvPunch.DataSource = cls_Punches.stp_SelectAll_PunchByTransId(Convert.ToInt32(txtTransNo.Text));
                }
               
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void ShoInfo()
        {
            try
            {
               
                txtTransNo.Text = frm_PunchList.row.Cells[0].Value.ToString();
                dtpTransDate.Value = Convert.ToDateTime(frm_PunchList.row.Cells[1].Value);
                txtOrderNo.Text = frm_PunchList.row.Cells[2].Value.ToString();
                txtCustNo.Text = frm_PunchList.row.Cells[3].Value.ToString();
                txtCustName.Text = frm_PunchList.row.Cells[4].Value.ToString();
                txtOrderValue.Text = frm_PunchList.row.Cells[5].Value.ToString();
                txtPackValue.Text = frm_PunchList.row.Cells[6].Value.ToString();
                txtPackTimes.Text = frm_PunchList.row.Cells[7].Value.ToString();
                txtDownPayment.Text = frm_PunchList.row.Cells[8].Value.ToString();
                dtpFirst.Value = Convert.ToDateTime(frm_PunchList.row.Cells[9].Value);
                dtpLast.Value = Convert.ToDateTime(frm_PunchList.row.Cells[10].Value);
                chkFinish.Checked = Convert.ToBoolean(frm_PunchList.row.Cells[11].Value);
                txtPhone.Text = frm_PunchList.row.Cells[12].Value.ToString();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnShowPaid_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == string.Empty)
                {
                    MessageBox.Show(@"اختر اسم العميل أولا");
                    return;
                }
                new frm_PunchList(cboCust_Name.Text, "Show Paid").ShowDialog();
                if (frm_PunchList.row == null)
                {
                    MessageBox.Show("لا يوجد بيانات لعرضها");
                   
                    return;
                }
                else
                {
                    ShoInfo();
                    dgvPunch.DataSource = cls_Punches.stp_SelectAll_PunchByTransId(Convert.ToInt32(txtTransNo.Text));
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }

        }

        private void btnShowUnpaid_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == string.Empty)
                {
                    MessageBox.Show(@"اختر اسن العميل أولا");
                    return;
                }
                new frm_PunchList(cboCust_Name.Text, "Show UnPaid").ShowDialog();
                if (frm_PunchList.row == null)
                {
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                    return;
                }
                else
                {
                    ShoInfo();
                    dgvPunch.DataSource = cls_Punches.stp_SelectAll_PunchByTransId(Convert.ToInt32(txtTransNo.Text));
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
                if (cboCust_Name.Text != string.Empty)
                {
                    //DataTable dtCustNames = new DataTable();
                    DataTable dtCustNames = cls_Customer.stp_SelectCustomersByName(cboCust_Name.Text);
                    if (dtCustNames.Rows.Count == 0)
                    {
                        return;
                    }
                    txtId.Text = dtCustNames.Rows[0][0].ToString();
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
