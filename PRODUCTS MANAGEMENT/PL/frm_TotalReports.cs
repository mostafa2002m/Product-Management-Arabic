using System;
using System.Data;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_TotalReports : Form
    {
        public frm_TotalReports()
        {
            InitializeComponent();
            

            //DataTable dtinv = cls_Invoice.Sp_SelectAllInvoices();
            //DataTable dtorder = cls_Order.Sp_SelectAllOrders();
            //DataTable dtrinv = cls_ReturnInvoice.Sp_SelectAllReturnInvoices();
            //DataTable dtrorder = cls_ReturnOrder.Sp_SelectAllReturnOrders();
            //dgvInv.DataSource = dtinv;

            //this.dgvOrder.DataSource = dtorder;

            //dgvRinv.DataSource = dtrinv;

            //dgvRorder.DataSource = dtrorder;
            //calculate();
            
            }
            private void calculate()
            {
                // txtTotalInv.Text =
                //    (from DataGridViewRow row in dgvInv.Rows
                //     where row.Cells[3].FormattedValue.ToString() != string.Empty
                //     select Convert.ToDecimal(row.Cells[3].FormattedValue)).Sum().ToString();
                //txtTotalSales.Text=(from DataGridViewRow row in dgvOrder .Rows
                //     where row.Cells[3].FormattedValue.ToString() != string.Empty
                //     select Convert.ToDecimal(row.Cells[3].FormattedValue)).Sum().ToString();
                //txtRTotalInv.Text = (from DataGridViewRow row in dgvRinv.Rows
                //     where row.Cells[3].FormattedValue.ToString() != string.Empty
                //     select Convert.ToDecimal(row.Cells[3].FormattedValue)).Sum().ToString();

                //txtRtotalSales.Text= (from DataGridViewRow row in dgvRorder .Rows
                //     where row.Cells[3].FormattedValue.ToString() != string.Empty
                //     select Convert.ToDecimal(row.Cells[3].FormattedValue)).Sum().ToString();

                //txtAllTotal.Text = (Convert.ToDecimal (txtTotalSales.Text ) - Convert.ToDecimal( txtRtotalSales.Text) - Convert.ToDecimal(txtTotalInv.Text) - Convert.ToDecimal(txtRTotalInv.Text)).ToString();
            }
            
            

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void frm_TotalReports_Load(object sender, EventArgs e)
        {
            label13.Text = txtTotalInv.Text;
            label14.Text = txtRTotalInv.Text;
            label15.Text = txtTotalSales.Text;
            label16.Text = txtRtotalSales.Text;
            label17.Text = txtCosts.Text;
            label18.Text = txtAllTotal.Text;
            DataTable dtCredit= cls_Credit.stp_SelectAll_Credit();
            label19.Text = dtCredit.Rows[0][4].ToString();
            DataTable dtDebit = cls_Debit.stp_SelectAll_Debit();
            label21.Text = dtDebit.Rows[0][4].ToString();
        }
    }
}
