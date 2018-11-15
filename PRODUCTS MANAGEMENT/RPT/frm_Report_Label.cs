using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using PRODUCTS_MANAGEMENT.PL;
using PRODUCTS_MANAGEMENT.BL;
namespace PRODUCTS_MANAGEMENT.RPT
{
    public partial class frm_Report_Label : Form
    {
        ReportDocument crystal = new ReportDocument();
        public frm_Report_Label()
        {
            InitializeComponent();
        }

        private void frm_Report_Label_Load(object sender, EventArgs e)
        {
            //crystal.Load(@"D:\MyProgramms\Loreet\PRODUCTS MANAGEMENT\RPT\rpt_Barcode_Label.rpt");
            crystal.Load(Application.StartupPath + "\\rpt_Barcode_Label.rpt");
        }

        private void btnChooseBarcoe_Click(object sender, EventArgs e)
        {
            frm_Search frm = new frm_Search("Product");
            frm.ShowDialog();
            txtBarcode.Text = frm.dgvSearch.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text= frm.dgvSearch.SelectedRows[0].Cells[2].Value.ToString();


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBarcode.Text == "" || numericUpDown1.Value == 0)
                {
                    return;
                }
                DataTable dt = cls_Product.Barcod_Label_Report(txtBarcode.Text, (int)numericUpDown1.Value);
                crystal.SetDataSource(dt);
                crystalReportViewer1.ReportSource = crystal;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
