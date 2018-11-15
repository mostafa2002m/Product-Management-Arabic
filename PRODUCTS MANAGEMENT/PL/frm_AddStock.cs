using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddStock : Form
    {
        public frm_AddStock()
        {
            InitializeComponent();
            panel2.Enabled = false;
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            btnDelete.Enabled = false;
            dgvStock.DataSource = cls_Stock.stp_SellectAll_Stock();
        }
        void ClearData()
        {

            foreach (Control item in panel2.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
            //foreach (Control item in groupBox2.Controls)
            //{
            //    if (item is TextBox)
            //        item.Text = string.Empty;
            //}
            //foreach (Control item in groupBox3.Controls)
            //{
            //    if (item is TextBox)
            //        item.Text = string.Empty;
        }

        private void frm_AddStock_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearData();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnUndo.Enabled = true;
            panel2.Enabled = true;
            txtId.Text = cls_Stock.stp_SelectLast_Stock_Id().Rows[0][0].ToString();
            groupBox1.Enabled = false;
            txtName.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtId.Text == string.Empty || txtName.Text == string.Empty || txtAddress.Text == string.Empty || txtPhone.Text == string.Empty || cbotype.Text == null)
                {
                    MessageBox.Show(@"تحقق من البيانات");
                    return;
                }
                cls_Stock.stp_ManipulateStock( Convert.ToInt32(txtId.Text), txtName.Text, txtAddress.Text, txtPhone.Text, cbotype.Text);
                MessageBox.Show(@"تم الاضافة بنجاح");
                panel2.Enabled = false;
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnUndo.Enabled = false;
                btnDelete.Enabled = false;
                dgvStock.DataSource = cls_Stock.stp_SellectAll_Stock();
                ClearData();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && txtName.Text !=string.Empty)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtAddress.Text != string.Empty)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txtPhone.Text != string.Empty)
            {
                btnSave.Focus();
            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStock.DataSource = cls_Stock.stp_Search_Stock(txtSearch.Text);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

            ClearData();
            panel2.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            btnDelete.Enabled = false;
            
        }

        private void dgvStock_DoubleClick(object sender, EventArgs e)
        {

            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnUndo.Enabled = true;
            panel2.Enabled = true;
            txtName.Focus();
            try
            {
                txtId.Text = dgvStock.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvStock.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = dgvStock.CurrentRow.Cells[2].Value. ToString();
                txtPhone.Text = dgvStock.CurrentRow.Cells[3].Value.ToString();
                cbotype.Text = dgvStock.CurrentRow.Cells[4].Value.ToString();
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
                if (MessageBox.Show("هل تريد حذف السجل الحالي؟", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls_Stock.stp_Delete_Stock(Convert.ToInt32(dgvStock.CurrentRow.Cells[0].Value.ToString()));
                    ClearData();
                    dgvStock.DataSource= dgvStock.DataSource = cls_Stock.stp_SellectAll_Stock();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
