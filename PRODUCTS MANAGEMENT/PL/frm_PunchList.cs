using System;
using System.Windows.Forms;
using System.Data;
using PRODUCTS_MANAGEMENT.BL;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_PunchList : Form
    {
        public static DataGridViewRow row = null;
        public frm_PunchList(string custname,string punchinfo)
        {
            InitializeComponent();
           
            if (punchinfo == "Show All")
            {
                this.Text = "كل فواتير العميل";
                DataTable dt = cls_Punches.stp_SelectAll_PunchInformationByCustName(custname);
                if (dt.Rows.Count == 0)
                {
                    return;
                }
                dgvPunchList.DataSource = dt;
            }

            else if (punchinfo == "Show Paid")
            {
                this.Text = "الفواتير المسدده للعميل";
                DataTable dt = cls_Punches.stp_Select_PaidPunchInformationByCustName(custname);
                if (dt.Rows.Count == 0)
                {
                    return;
                }
                dgvPunchList.DataSource = dt ;

            }
            else if (punchinfo == "Show UnPaid")
            {
                this.Text = "الفواتير الغير مسدده للعميل";
                DataTable dt = cls_Punches.stp_Select_NotPaidPunchInformationByCustName(custname);
                if (dt.Rows.Count == 0)
                {
                    return;
                }
                dgvPunchList.DataSource = dt;
            }  
           
            
        }

        private void dgvPunchList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPunchList.SelectedRows.Count > 0)
            {
                row = dgvPunchList.SelectedRows[0];
            }
            btnClose.Tag = string.Empty;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
