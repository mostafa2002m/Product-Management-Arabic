using PRODUCTS_MANAGEMENT.BL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frmSupplierList : Form
    {
        public static int ID;
        public frmSupplierList()
        {
            InitializeComponent();
            Display(cls_Supplier.stp_SelectAll_Supplier());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           Display(cls_Supplier.stp_Search_Supplier(txtSearch.Text));
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frm_AddSuppliers("a").ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvSuppliers.Rows.Count == 0)
                {
                    MessageBox.Show(@"لا يوجد بيانات لتعديلها", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ID = int.Parse(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddSuppliers("u").ShowDialog();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvSuppliers.Rows.Count == 0)
                {
                    MessageBox.Show(@"لا يوجد بيانات لحذفها", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ID = int.Parse(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddSuppliers("d").ShowDialog();
              
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

       private void btnPrintSingleAccountSupplier_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Cursor = Cursors.WaitCursor;

            //    int id = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells[0].Value);
            //    RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
            //    RPT.rpt_PrintAccountBySup Report = new RPT.rpt_PrintAccountBySup();
            //    Report.SetDataSource(Suppliers.PrintAccountBySup(id));
            //    frm.crystalReportViewer1.ReportSource = Report;
            //    frm.ShowDialog();
            //    this.Cursor = Cursors.Default;
            //}
            //catch (IOException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnPrint_AllSupplierTrans(object sender, EventArgs e)
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
        public void Display(DataTable dt)
        {
            dgvSuppliers.DataSource = dt;
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

        private void btnPrint_All_Click(object sender, EventArgs e)
        {

        }
    }
}
