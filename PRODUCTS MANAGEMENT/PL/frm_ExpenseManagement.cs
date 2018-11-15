using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_ExpenseManagement : Form
    {
        public static int ID;
        public frm_ExpenseManagement()
        {
            InitializeComponent();
            dgvExpense.DataSource = cls_Cost.stp_Search_Expense("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frm_AddExpense("a").ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                ID = int.Parse(dgvExpense.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddExpense("u").ShowDialog();
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
                ID = int.Parse(dgvExpense.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddExpense("d").ShowDialog();
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

        private void frm_ExpenseManagement_Activated(object sender, EventArgs e)
        {
            dgvExpense.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvExpense.DataSource = cls_Cost.stp_Search_Expense("");
        }
    }
}
