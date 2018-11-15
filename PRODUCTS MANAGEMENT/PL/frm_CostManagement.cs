using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_CostManagement : Form
    {
        public static int ID;
        public frm_CostManagement()
        {
            InitializeComponent();
            dgvCost.DataSource = cls_Cost.stp_SelectAll_Costs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frm_AddCosts("a").ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
