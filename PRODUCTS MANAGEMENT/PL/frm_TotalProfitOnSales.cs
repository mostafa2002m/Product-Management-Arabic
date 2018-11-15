using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_TotalProfitOnSales : Form
    {

        frm_TotalReports frm = new frm_TotalReports(); 
        public frm_TotalProfitOnSales()
        {
            InitializeComponent();
            
            
        }

        private void btnTotalReturn_Click(object sender, EventArgs e)
        {

            try
            {
                frm.dgvInv.DataSource = null;
                frm.dgvOrder.DataSource = null;
                frm.dgvRinv.DataSource = null;
                frm.dgvRorder.DataSource = null;
                frm.dgvCost.DataSource = null;
                //frm.dgvPayment.DataSource = null;
                DataTable dtinv = cls_Invoice.stp_Search_Invoices("");
                DataTable dtorder = cls_Order.stp_Search_Orders("");
                DataTable dtcost = cls_Cost.stp_SelectAll_Costs();
                //DataTable dtPayment = cls_Debit.Search_Debit("");
                DataTable dtrinv = cls_RInvoice.stp_Search_RInvoices("");
                DataTable dtrorder = cls_ROrder.stp_Search_ROrders("");


                frm.dgvInv.DataSource = dtinv;
                frm.dgvOrder.DataSource = dtorder;
                //frm.dgvPayment.DataSource = dtPayment;
                frm.dgvCost.DataSource = dtcost;
                frm.dgvRinv.DataSource = dtrinv;
                frm.dgvRorder.DataSource = dtrorder;


                frm.txtTotalInv.Text =
                        (from DataGridViewRow row in frm.dgvInv.Rows
                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                         select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtTotalSales.Text = (from DataGridViewRow row in frm.dgvOrder.Rows
                                          where row.Cells[4].FormattedValue.ToString() != string.Empty
                                          select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtCosts.Text = (from DataGridViewRow row in frm.dgvCost.Rows
                                   where row.Cells[4].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();

                frm.txtRTotalInv.Text = (from DataGridViewRow row in frm.dgvRinv.Rows
                                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();

                frm.txtRtotalSales.Text = (from DataGridViewRow row in frm.dgvRorder.Rows
                                           where row.Cells[4].FormattedValue.ToString() != string.Empty
                                           select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();

                Calculat_AllReturn();


                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
           
        }



       private void btnآNetReturn_Click(object sender, EventArgs e)
        {
            try
            {
                frm_TotalReports frm = new frm_TotalReports();
                frm.dgvInv.DataSource = null;
                frm.dgvOrder.DataSource = null;
                frm.dgvRinv.DataSource = null;
                frm.dgvRorder.DataSource = null;
                frm.dgvCost.DataSource = null;

                DataTable dtinv = cls_Invoice.stp_Search_Invoices("");
                DataTable dtorder = cls_Order.stp_Search_Orders("");
                DataTable dtcost = cls_Cost.stp_SelectAll_Costs();
                DataTable dtrinv = cls_RInvoice.stp_Search_RInvoices("");
                DataTable dtrorder = cls_ROrder.stp_Search_ROrders("");

                frm.dgvInv.DataSource = dtinv;
                frm.dgvOrder.DataSource = dtorder;
                frm.dgvCost.DataSource = dtcost;
                frm.dgvRinv.DataSource = dtrinv;
                frm.dgvRorder.DataSource = dtrorder;

                frm.txtTotalInv.Text =
                        (from DataGridViewRow row in frm.dgvInv.Rows
                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                         select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtTotalSales.Text = (from DataGridViewRow row in frm.dgvOrder.Rows
                                          where row.Cells[4].FormattedValue.ToString() != string.Empty
                                          select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtCosts.Text = (from DataGridViewRow row in frm.dgvCost.Rows
                                     where row.Cells[4].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();

                frm.txtRTotalInv.Text = (from DataGridViewRow row in frm.dgvRinv.Rows
                                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();

                frm.txtRtotalSales.Text = (from DataGridViewRow row in frm.dgvRorder.Rows
                                           where row.Cells[4].FormattedValue.ToString() != string.Empty
                                           select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();

                //Calculat_NetReturn();
                frm.txtAllTotal.Text = (decimal.Parse(frm.txtTotalSales.Text) - decimal.Parse(frm.txtRtotalSales.Text) -
                    decimal.Parse(frm.txtTotalInv.Text) - decimal.Parse(frm.txtRTotalInv.Text) - decimal.Parse(frm.txtCosts.Text)).ToString();

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

       

        private void btnآNetReturnByDate_Click(object sender, EventArgs e)
        {
            try
            {
                frm_TotalReports frm = new frm_TotalReports();
                frm.dgvInv.DataSource = null;
                frm.dgvOrder.DataSource = null;
                frm.dgvCost.DataSource = null;
                frm.dgvRinv.DataSource = null;
                frm.dgvRorder.DataSource = null;
                DataTable dtinv = cls_Invoice.Print_Invoices_ByDate(dateTimePicker1.Value, dateTimePicker2.Value);
                DataTable dtorder = cls_Order.Print_Orders_ByDate(dateTimePicker1.Value, dateTimePicker2.Value);
                DataTable dtcost = cls_Cost.Print_Costs_ByDate(dateTimePicker3.Value, dateTimePicker4.Value);
                DataTable dtrinv = cls_RInvoice.Print_RInvoices_ByDate(dateTimePicker3.Value, dateTimePicker4.Value);
                DataTable dtrorder = cls_ROrder.Print_ROrders_ByDate(dateTimePicker3.Value, dateTimePicker4.Value);
                frm.dgvInv.DataSource = dtinv;

                frm.dgvOrder.DataSource = dtorder;
                frm.dgvCost.DataSource = dtcost;
                frm.dgvRinv.DataSource = dtrinv;

                frm.dgvRorder.DataSource = dtrorder;
                frm.txtTotalInv.Text =
                                    (from DataGridViewRow row in frm.dgvInv.Rows
                                     where row.Cells[4].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtTotalSales.Text = (from DataGridViewRow row in frm.dgvOrder.Rows
                                          where row.Cells[4].FormattedValue.ToString() != string.Empty
                                          select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtRTotalInv.Text = (from DataGridViewRow row in frm.dgvRinv.Rows
                                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();

                frm.txtCosts.Text = (from DataGridViewRow row in frm.dgvCost.Rows
                                     where row.Cells[4].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtRtotalSales.Text = (from DataGridViewRow row in frm.dgvRorder.Rows
                                           where row.Cells[4].FormattedValue.ToString() != string.Empty
                                           select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();

                //Calculat_NetReturn();

                frm.txtAllTotal.Text = (decimal.Parse(frm.txtTotalSales.Text) - decimal.Parse(frm.txtRtotalSales.Text) - decimal.Parse(frm.txtTotalInv.Text) -
                   decimal.Parse(frm.txtRTotalInv.Text) - decimal.Parse(frm.txtCosts.Text)).ToString();
                frm.ShowDialog();
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

        private void frm_TotalProfitOnSales_Load(object sender, EventArgs e)
        {

        }

        private void Calculat_AllReturn()
        {
            frm.txtAllTotal.Text = (decimal.Parse(frm.txtTotalSales.Text) -
                                    decimal.Parse(frm.txtRtotalSales.Text) -
                                    decimal.Parse(frm.txtTotalInv.Text) - 
                                    decimal.Parse(frm.txtRTotalInv.Text)).ToString();

        }
        private void Calculat_NetReturn()
        {
            frm.txtAllTotal.Text = (decimal.Parse(frm.txtTotalSales.Text) -
                                    decimal.Parse(frm.txtRtotalSales.Text) -
                                    decimal.Parse(frm.txtTotalInv.Text) -   
                                    decimal.Parse(frm.txtRTotalInv.Text) - 
                                    decimal.Parse(frm.txtCosts.Text)).ToString();
        }

        private void btnTotalReturnByDate_Click(object sender, EventArgs e)
        {
            try
            {
                frm.dgvInv.DataSource = null;
                frm.dgvOrder.DataSource = null;
                frm.dgvCost.DataSource = null;
                frm.dgvRinv.DataSource = null;
                frm.dgvRorder.DataSource = null;

                DataTable dtinv = cls_Invoice.Print_Invoices_ByDate(dateTimePicker1.Value, dateTimePicker2.Value);
                DataTable dtorder = cls_Order.Print_Orders_ByDate(dateTimePicker1.Value, dateTimePicker2.Value);
                DataTable dtcost = cls_Cost.Print_Costs_ByDate(dateTimePicker1.Value, dateTimePicker2.Value);
                DataTable dtrinv = cls_RInvoice.Print_RInvoices_ByDate(dateTimePicker1.Value, dateTimePicker2.Value);
                DataTable dtrorder = cls_ROrder.Print_ROrders_ByDate(dateTimePicker1.Value, dateTimePicker2.Value);

                frm.dgvInv.DataSource = dtinv;
                frm.dgvOrder.DataSource = dtorder;
                frm.dgvCost.DataSource = dtcost;
                frm.dgvRinv.DataSource = dtrinv;
                frm.dgvRorder.DataSource = dtrorder;

                frm.txtTotalInv.Text =
                                    (from DataGridViewRow row in frm.dgvInv.Rows
                                     where row.Cells[4].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtTotalSales.Text = (from DataGridViewRow row in frm.dgvOrder.Rows
                                          where row.Cells[4].FormattedValue.ToString() != string.Empty
                                          select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtRTotalInv.Text = (from DataGridViewRow row in frm.dgvRinv.Rows
                                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                                         select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();

                frm.txtCosts.Text = (from DataGridViewRow row in frm.dgvCost.Rows
                                     where row.Cells[4].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
                frm.txtRtotalSales.Text = (from DataGridViewRow row in frm.dgvRorder.Rows
                                           where row.Cells[4].FormattedValue.ToString() != string.Empty
                                           select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();

                Calculat_AllReturn();
                frm.ShowDialog();
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
