using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_OrderMade_List : Form
    {
        public frm_OrderMade_List()
        {
            InitializeComponent();
            this.dgvMadeOrders.DataSource = cls_MadeOrder.stp_Search_MadeOrders("");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // get last order to print

            try
            {
                if (dgvMadeOrders.Rows.Count == 0)
                {
                    return;
                }
                this.Cursor = Cursors.WaitCursor;
                int Order_No = Convert.ToInt32(dgvMadeOrders.CurrentRow.Cells[0].Value);
                RPT.rpt_OrderMade MyReport = new RPT.rpt_OrderMade();
                RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                MyReport.SetDataSource(cls_MadeOrder.stp_SelectOrderMade_Details(Order_No));
                //MyReport.Refresh();
                MyForm.crystalReportViewer1.ReportSource = MyReport;
                MyForm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvMadeOrders.DataSource = cls_MadeOrder.stp_Search_MadeOrders(txtSearch.Text);
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
