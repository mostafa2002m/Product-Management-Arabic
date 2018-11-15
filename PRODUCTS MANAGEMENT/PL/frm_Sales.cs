using System;
using System.Drawing;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_Sales : Form
    {
        public frm_Sales()
        {
            InitializeComponent();
        }

        private void btnProductSales_Click(object sender, EventArgs e)
        {
            new PL.FrmOrder().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmOrderMade().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
