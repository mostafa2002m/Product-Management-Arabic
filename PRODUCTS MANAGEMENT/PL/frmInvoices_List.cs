using System;
using System.IO;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frmInvoices_List : Form
    {
       
        public frmInvoices_List()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
            this.dgvOrders.DataSource = cls_Invoice.stp_Search_Invoices("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvOrders.DataSource = cls_Invoice.stp_Search_Invoices(txtSearch.Text);
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // get last order to print
            if (cboType.SelectedIndex == 0)
            {
                PrintInvoice();
            }
            else
            {
                PrintRInvoice();
            }

          
         

        }

        private void PrintInvoice()
        {
            DialogResult respnse = MessageBox.Show(@"طباعة الفاتورة", @"طباعة فاتورة الشراء", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respnse == DialogResult.Yes)
            {
                // get last order to print

                try
                {

                    this.Cursor = Cursors.WaitCursor;
                    int Inv_No = int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString());
                    RPT.rpt_Invoices MyReport = new RPT.rpt_Invoices();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_Invoice.Stp_SelectInvoice_Details(Inv_No));
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
            DialogResult respnse = MessageBox.Show(@"طباعة الفاتورة", @"طباعة فاتورة مردودات الشراء", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respnse == DialogResult.Yes)
            {
                
                try
                {

                    this.Cursor = Cursors.WaitCursor;
                    int Inv_No =int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString());
                    RPT.rpt_PrintRInvoice MyReport = new RPT.rpt_PrintRInvoice();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_RInvoice.stp_SelectRInvoice_Details(Inv_No));
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

        private void cboType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 1)
            {
                this.dgvOrders.DataSource = cls_RInvoice.stp_Search_RInvoices("");
                label6.Text = "شاشة إدارة مردودات المشتريات";
            }
            else
            {
                this.dgvOrders.DataSource = cls_Invoice.stp_Search_Invoices("");
                label6.Text = "شاشة إدارة المشتريات";
            }
        }
    }
}
