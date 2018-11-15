using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frmUserList : Form
    {
        public static string ID;
        public frmUserList()
        {
            InitializeComponent();
            dgvUsers.DataSource = cls_Login.stp_SelectAll_User();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frm_AddUser("a").ShowDialog();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ID = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
            new frm_AddUser("u").ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                ID = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
                new frm_AddUser("d").ShowDialog();
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvUsers.DataSource = cls_Login.stp_Search_Users(txtSearch.Text);
        }

       
        private void frmUserList_Activated(object sender, EventArgs e)
        {
            dgvUsers.DataSource = cls_Login.stp_SelectAll_User();
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
