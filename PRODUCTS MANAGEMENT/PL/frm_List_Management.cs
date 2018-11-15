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
    public partial class frm_List_Management : Form
    {
        string List;
        public frm_List_Management(string _List)
        {
            InitializeComponent();
            List = _List;
            if (List=="Orders")
            {
                dgvListManagement.DataSource = cls_Order.stp_Search_Orders("");
                lblList.Text = "Orders List Screen";
            }
            else if (List=="RoRders")
            {
                dgvListManagement.DataSource = cls_ROrder.stp_Search_ROrders("");
                lblList.Text = "Return Orders List Screen";
            }
            else if (List=="Invoices")
            {
                dgvListManagement.DataSource = cls_Invoice.stp_Search_Invoices("");
                lblList.Text = "Invoices List Screen";
            }
            else if (List == "RInvoices")
            {
                dgvListManagement.DataSource = cls_RInvoice.stp_Search_RInvoices("");
                lblList.Text = "Return Invoices List Screen";
            }
            else if (List=="MadeOrders")
            {
                dgvListManagement.DataSource = cls_MadeOrder.stp_Search_MadeOrders("");
                lblList.Text = "Made Orders Invoices List Screen";
            }

            else if (List == "Services")
            {
                dgvListManagement.DataSource = cls_Service.stp_SelectAll_Service();
                lblList.Text = "Service Invoices List Screen";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
