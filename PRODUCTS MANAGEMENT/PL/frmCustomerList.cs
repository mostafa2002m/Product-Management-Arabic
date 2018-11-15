using System;
using System.Data;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;
using System.Drawing;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class FrmCustomerList : Form
    {
        public static int Id;
        public FrmCustomerList()
        {
            InitializeComponent();
            Display(cls_Customer.stp_SelectAll_Customers());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new FrmAddCustomer("a").ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            if (dgvCustomers.Rows.Count == 0)
            {
                MessageBox.Show(@"لا يوجد بيانات لتعديلها", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Id = int.Parse(dgvCustomers.SelectedRows[0].Cells[0].Value.ToString());
            new FrmAddCustomer("u").ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.Rows.Count == 0)
            {
                MessageBox.Show(@"لا يوجد بيانات لحذفها", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Id = int.Parse(dgvCustomers.SelectedRows[0].Cells[0].Value.ToString());
            new FrmAddCustomer("d").ShowDialog();
            
        }


        public void Display(DataTable dt)
        {
            dgvCustomers.DataSource = dt;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Display(cls_Customer.stp_Search_Customers(txtSearch.Text));
        }

    



#pragma warning disable IDE1006 // Naming Styles

    }
}
