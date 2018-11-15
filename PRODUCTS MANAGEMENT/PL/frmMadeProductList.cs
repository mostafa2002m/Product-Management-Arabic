using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using PRODUCTS_MANAGEMENT.BL;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frmMadeProductList : Form
    {
        public static int ID;
        public frmMadeProductList()
        {
            InitializeComponent();
            dgvMadeProduct.DataSource = cls_MadeProduct.stp_SelectAll_MadeProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvMadeProduct.DataSource = cls_MadeProduct.stp_Search_MadeProducts(txtSearch.Text);
        }

        private void dgvMadeProduct_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frm_AddMadeProduct("a").ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //frm = new frmAddProduct();
                if (dgvMadeProduct.Rows.Count == 0)
                {
                    MessageBox.Show(@"لا يوجد بيانات لتعديلها", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ID = int.Parse(dgvMadeProduct.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddMadeProduct("u").ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMadeProduct.Rows.Count == 0)
            {
                MessageBox.Show(@"لا يوجد بيانات لحذفها", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ID = int.Parse(dgvMadeProduct.SelectedRows[0].Cells[0].Value.ToString());
            new frm_AddMadeProduct("d").ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Product_Preview frm = new frm_Product_Preview();
                byte[] image = (byte[])cls_MadeProduct.stp_SelectImageProduct(Convert.ToInt32(this.dgvMadeProduct.CurrentRow.Cells[0].Value)).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                frm.picPreview.Image = Image.FromStream(ms);

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmMadeProductList_Activated(object sender, EventArgs e)
        {
            dgvMadeProduct.DataSource = cls_MadeProduct.stp_SelectAll_MadeProducts();
        }

        private void btnPrint_Single_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.rpt_Single_Product MyReport = new RPT.rpt_Single_Product();
                RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                MyReport.SetParameterValue("@Product_Id", this.dgvMadeProduct.CurrentRow.Cells[0].Value.ToString());
                MyForm.crystalReportViewer1.ReportSource = null;
                MyForm.crystalReportViewer1.ReportSource = MyReport;
                MyForm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_All_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.rpt_All_Products MyReport = new RPT.rpt_All_Products();
                RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                MyForm.crystalReportViewer1.ReportSource = null;
                MyForm.crystalReportViewer1.ReportSource = MyReport;
                MyForm.ShowDialog();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
