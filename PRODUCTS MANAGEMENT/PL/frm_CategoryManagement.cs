using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_CategoryManagement : Form
    {
        public static int ID;
        public frm_CategoryManagement()
        {
            InitializeComponent();
            DataTable dt = cls_Category.stp_SelectAll_Category();
            dgvCategories.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_AddCategory frm = new frm_AddCategory("a");
            frm.ShowDialog();
            

        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtCat_Id.Text = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtCat_Name.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == string.Empty)
                {
                    MessageBox.Show(@"لقد تم اضافة دفعة  للعميل");
                    return;
                }

                DataTable dt = cls_Category.stp_Search_Category(txtSearch.Text);
                dgvCategories.DataSource = dt;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void texSearch(object sender, EventArgs e)
        {
            DataTable dt = cls_Category.stp_Search_Category(txtSearch.Text);
            dgvCategories.DataSource = dt;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ID = int.Parse(dgvCategories.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddCategory("u").ShowDialog();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ID = int.Parse(dgvCategories.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddCategory("d").ShowDialog();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
           
        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        RPT.frm_Reports frm = new RPT.frm_Reports();
        //        RPT.rpt_PrintAllCategories Report = new RPT.rpt_PrintAllCategories();
        //        Report.SetDataSource(cls_Category.Sp_SelectAllCategories());
        //        frm.crystalReportViewer1.ReportSource = Report;
        //        frm.ShowDialog();
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void frm_CategoryManagement_Activated(object sender, EventArgs e)
        {
            DataTable dt = cls_Category.stp_SelectAll_Category();
            dgvCategories.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

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
