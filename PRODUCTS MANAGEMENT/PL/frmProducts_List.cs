using PRODUCTS_MANAGEMENT.BL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frmProducts_List : Form
    {
        public static int ID;
        
        public frmProducts_List()
        {
            InitializeComponent();
            dgvProducts.DataSource = cls_Product.stp_SelectAll_Products();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = cls_Product.stp_Search_Products(txtSearch.Text);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frm_AddProduct("a").ShowDialog();
                       
           
        }

        private void btnPrint_Single_Click(object sender, EventArgs e)
        {
           try 
	        {	        
		     RPT.rpt_Single_Product MyReport = new RPT.rpt_Single_Product();
             RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
             MyReport.SetParameterValue("@Product_Id", this.dgvProducts.CurrentRow.Cells[0].Value.ToString());
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

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                //frm = new frmAddProduct();
                if (dgvProducts.Rows.Count == 0)
                {
                    MessageBox.Show(@"لا يوجد بيانات لتعديلها", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ID = int.Parse(dgvProducts.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddProduct("u").ShowDialog();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Product_Preview frm = new frm_Product_Preview();
                byte[] image = (byte[])cls_Product.stp_SelectImageProduct(Convert.ToInt32(this.dgvProducts.CurrentRow.Cells[0].Value)).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                frm.picPreview.Image = Image.FromStream(ms);

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           

                if (dgvProducts.Rows.Count == 0)
                {
                    MessageBox.Show(@"لا يوجد بيانات لحذفها", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ID = int.Parse(dgvProducts.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddProduct("d").ShowDialog();

           
        }

        private void frmProducts_List_Load(object sender, EventArgs e)
        {

        }

        private void frmProducts_List_Activated(object sender, EventArgs e)
        {
            dgvProducts.DataSource = cls_Product.stp_SelectAll_Products();
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
