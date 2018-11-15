using System;
using System.IO;
using System.Windows.Forms;


namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frmOrders_List : Form
    {
      
        public frmOrders_List()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
            this.dgvOrders.DataSource = cls_Order.stp_Search_Orders("");
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvOrders.DataSource = cls_Order.stp_Search_Orders(txtSearch.Text);
            }
            catch (Exception)
            {
                
                return;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // get last order to print
            if (cboType.SelectedIndex ==0)
            {
                PrintInvoice();
            }
            else
            {
                PrintRInvoice();
            }

        }

        private void cboType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex ==1)
            {
                this.dgvOrders.DataSource = cls_ROrder.stp_Search_ROrders("");

                label6.Text = "شاشة إدارة مردودات المبيعات";
            }
            else
            {
                this.dgvOrders.DataSource = cls_Order.stp_Search_Orders("");
                label6.Text = "شاشة إدارة المبيعات";
            }
        }


        private void PrintInvoice()
        {
            // get last order to print
            DialogResult respnse = MessageBox.Show(@"طباعة فاتورة مبيعات؟", @"طباعة فاتورة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respnse == DialogResult.Yes)
            {
                try
                {

                    this.Cursor = Cursors.WaitCursor;
                    int Order_No = int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString());
                    RPT.rpt_Orders MyReport = new RPT.rpt_Orders();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_Order.stp_SelectOrder_Details(Order_No));
                    MyReport.Refresh();
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
        private void PrintRInvoice()
        {
            // get last order to print
            DialogResult respnse = MessageBox.Show(@"طباعة فاتورة مردودات مبيعات؟", @"طباعة فاتورة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respnse == DialogResult.Yes)
            {
                try
                {

                    this.Cursor = Cursors.WaitCursor;
                    int Order_No = int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString());
                    RPT.rpt_PrintROrder MyReport = new RPT.rpt_PrintROrder();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_ROrder.stp_SelectROrder_Details(Order_No));
                    MyReport.Refresh();
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
    }
}
