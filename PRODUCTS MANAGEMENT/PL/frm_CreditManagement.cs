using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_CreditManagement : Form
    {
        public frm_CreditManagement()
        {
            InitializeComponent();
            dgvCredit.DataSource = cls_Credit.stp_SelectAll_SupplierTrans();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCredit.DataSource = cls_Credit.stp_SearchSum_SupplierTrans(txtSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           new frm_Supplier_payments("سداد نقدي").ShowDialog();
        }

        private void btnPrintSelected_Click(object sender, EventArgs e)
        {
            if (dgvCredit.Rows.Count == 0)
            {
                MessageBox.Show(@"لا يوجد");
                return;
            }
            try
            { 
            this.Cursor = Cursors.WaitCursor;
            int id = Convert.ToInt32(dgvCredit.CurrentRow.Cells[0].Value);
            RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
            RPT.rpt_Print_SupplierTransById Report = new RPT.rpt_Print_SupplierTransById();
            Report.SetDataSource(cls_Credit.Print_SupplierTrans_BySupId(id));
            frm.crystalReportViewer1.ReportSource = Report;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
                RPT.rpt_PrintAll_SupplierTrans Report = new RPT.rpt_PrintAll_SupplierTrans();
                Report.SetDataSource(cls_Credit.stp_Search_SupplierTrans(""));
                frm.crystalReportViewer1.ReportSource = Report;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
