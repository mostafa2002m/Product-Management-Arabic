using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class FrmDebitManagement : Form
    {
        public FrmDebitManagement()
        {
            InitializeComponent();
            dgvDebit.DataSource = cls_Debit.stp_SearchSum_CustomerTrans("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvDebit.DataSource = cls_Debit.stp_SearchSum_CustomerTrans(txtSearch.Text);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frm_Customer_payments("سداد نقدي").ShowDialog();
        }

        private void btnPrintSelected_Click(object sender, EventArgs e)
        {
           if (dgvDebit.Rows.Count == 0)
            {
                MessageBox.Show(@"لا يوجد");
                   return;
            }
            try
           {
            this.Cursor = Cursors.WaitCursor;
            int id =Convert.ToInt32(dgvDebit.CurrentRow.Cells[0].Value);
            RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
            RPT.rpt_Print_CustomerTransById Report = new RPT.rpt_Print_CustomerTransById();
            Report.SetDataSource(cls_Debit.Print_CustomerTrans_ByCustId(id));
            frm.crystalReportViewer1.ReportSource=Report;
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

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
                RPT.rpt_PrintAll_CustomerTrans Report = new RPT.rpt_PrintAll_CustomerTrans();
                Report.SetDataSource(cls_Debit.stp_Search_CustomerTrans(""));
                frm.crystalReportViewer1.ReportSource = Report;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch (IOException ex)
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
