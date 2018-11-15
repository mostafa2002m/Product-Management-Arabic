using PRODUCTS_MANAGEMENT.BL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class FrmOperationList : Form
    {
        public static int ID;
        public FrmOperationList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvOperation.DataSource = cls_Operation.stp_Search_Operation(txtSearch.Text);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new FrmAddOperation().ShowDialog();
        }

      

       

        private void frmOperation_List_Activated(object sender, EventArgs e)
        {
            dgvOperation.DataSource = cls_Operation.stp_SelectAll_Operation();
        }

   
    }
}
