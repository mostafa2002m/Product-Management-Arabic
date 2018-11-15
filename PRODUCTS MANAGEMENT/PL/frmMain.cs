using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{

    public partial class frmMain : Form
    {
        // create static field from the sub form
        //private static frmMain _frm;
        // to check if the user enters a valid username and password
        public static bool CheckUser = false;
        public static int P_Id = 0;
        // create a new static Method executed from the Close Event
        public frmMain()
        {
            InitializeComponent();
        }
       
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            // destroy the main form
            //_frm = null;
        }

                 
        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (P_Id == 1)
            {
                //enable the menu through the getmainform method in main form

                tsmProduct.Enabled = tsmCustomer.Enabled = tsmUser.Enabled = tsmSupplier.Enabled = tsmBackup.Enabled =
                tsmRestore.Enabled = tsmReport.Enabled = tsmCost.Enabled = tsmTool.Enabled = tsp1.Enabled =
                tsmElectronicService.Enabled = tsmCarpenterService.Enabled= CheckUser;

                tsmCarpenterService.Visible = tsmElectronicService.Visible = tsmPunches.Visible = CheckUser;
                //false;

            }
            else if (P_Id == 2)
            {

                tsmProduct.Enabled = tsmCustomer.Enabled = tsmSupplier.Enabled = tsmBackup.Enabled = tsmRestore.Enabled =
                tsmReport.Enabled = tsmCarpenterService.Enabled = tsmElectronicService.Enabled = tsmCost.Enabled = true;
               tsmUser.Enabled = false;
               tsmCarpenterService.Visible =tsmElectronicService.Visible =tsmPunches.Visible = false;
            }
            else
            {
                tsmProduct.Enabled = tsmCustomer.Enabled = tsmSupplier.Enabled = tsmUser.Enabled = tsmBackup.Enabled =
                tsmCarpenterService.Visible = tsmElectronicService.Visible = tsmPunches.Visible = false;
            }
        }
        //private frmMain()
        //{
        //    throw new NotImplementedException();
        //}

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLogin().ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            foreach (Control ctrl in this.Controls)
            {
                this.Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.LightCyan;
                //if (ctrl is MdiClient)
                //{
                //    ctrl.BackColor = Color.LightGray;
                //}
            }
            // enable the menu through the getmainform method in main form

            // invoking the username as refernce for operations
            // frmMain.P_Id = 2;
                               tsmProduct.Enabled =
                               tsmCustomer.Enabled =
                               tsmSupplier.Enabled =
                               tsmBackup.Enabled =
                               tsmRestore.Enabled =
                               tsmReport.Enabled =
                               tsmCarpenterService.Enabled =
                               tsmElectronicService.Enabled =
                               tsmCost.Enabled =
                               tsmTool.Enabled =
                               tsp1.Enabled = 
                               tsmUser.Enabled = false;
            new FrmLogin().ShowDialog();
        }

        private void tsmInfo_Click(object sender, EventArgs e)
        {
            new frm_AddPharmacy().ShowDialog();
        }

        private void tsmFirstPeriod_Click(object sender, EventArgs e)
        {
            new FrmAddFirstPeriod().ShowDialog();
        }
        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"هل تريد الخروج من البرنامج؟", @"إنهاء البرنامج", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                return;

            }
            else
            {
                System.Environment.Exit(0);
            }
        }

      
        private void اضافةفاتورهجديدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmOrder().ShowDialog();
        }

        private void tsmCustManagement_Click(object sender, EventArgs e)
        {
            new FrmCustomerList().ShowDialog();
        }

       
        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders_List frm = new frmOrders_List();
            frm.ShowDialog();
        }

      
        private void ادارةالمستخدمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserList frm = new frmUserList();
            frm.ShowDialog();
        }

        private void إنشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_AddBackup().ShowDialog();
        }

        private void استعادةنسحةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_AddRestore().ShowDialog();
        }

        private void إدارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_CategoryManagement().ShowDialog();
        }

        private void إدارةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierList frm = new frmSupplierList();
            frm.ShowDialog();
        }

        private void اضافةأمرشراءجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddInvoice frm = new frm_AddInvoice();
            frm.ShowDialog();
        }

        private void إدارةالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoices_List frm = new frmInvoices_List();
            frm.ShowDialog();
        }

      
       private void ادارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmProducts_List().ShowDialog();

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            تسجيلالدخولToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            تسجيلالخروجToolStripMenuItem_Click(null, null);
        }

        private void tspAgent_Click(object sender, EventArgs e)
        {
            tsmCustManagement_Click(null, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            إدارةالموردينToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            اضافةفاتورهجديدهToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ادارةالمبيعاتToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            اضافةأمرشراءجديدToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            إدارةالمشترياتToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ادارةالمستخدمونToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            إنشاءنسخةاحتياطيةToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            استعادةنسحةاحتياطيةToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            toolStripMenuItem3_Click(null, null);
        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            ادارةمدفوعاتالعملاءToolStripMenuItem_Click(null, null);
        }

             
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_AddRInvoice().ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new FrmROrder().ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new frm_CreditManagement().ShowDialog();
        }

        private void ادارةمدفوعاتالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDebitManagement().ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void العائدعلىالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_TotalProfitOnSales().ShowDialog();
        }

        private void اضافةخدمةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
          new  frm_ServiceManagement().ShowDialog();
        }

        private void ادارةالخدماتالالكترونيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmOperationList().ShowDialog();
        }

        private void watsAppMassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_WatsApp().ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new frmProducts_List().ShowDialog();
        }

        private void بضاعةأولالمدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAddFirstPeriod().ShowDialog();
        }

        private void اصدارفاتورةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmOrderMade().ShowDialog();
        }

     
        private void tsmSupPayment_Click(object sender, EventArgs e)
        {
            new frm_CreditManagement().ShowDialog();
        }

        private void tsmPunchManagement_Click(object sender, EventArgs e)
        {
            FrmPunchManagement frm = new FrmPunchManagement();
            frm.ShowDialog();
        }

        private void tsmBarcodeMaker_Click(object sender, EventArgs e)
        {
            new RPT.frm_Report_Label().ShowDialog();
        }

        private void ارسالبريدألكترونيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEmail().ShowDialog();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            new frm_ServiceManagement().ShowDialog();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            new frmMadeProductList().ShowDialog();
        }

        private void stmPunchManagement_Click(object sender, EventArgs e)
        {
            new FrmPunchManagement().ShowDialog();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"هل تريد الخروج من البرنامج؟", @"إنهاء البرنامج", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                return;

            }
            else
            {
                Close();
            }
        }

        private void إدارةالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ExpenseManagement().ShowDialog();
        }

        private void سدادالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_CostManagement().ShowDialog();
        }

        private void tsmMadeOrderManagement_Click(object sender, EventArgs e)
        {
            new frm_OrderMade_List().ShowDialog();
        }

        private void تقاريرالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Report("Purchase").ShowDialog();
        }

        private void تقاريرالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Report("Sales").ShowDialog();
        }

        private void مردوداتالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Report("RPurchase").ShowDialog();
        }

        private void مردوداتالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Report("RSales").ShowDialog();
        }

        private void المدفوعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Report("Credit").ShowDialog();
        }

        private void المقبوضاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Report("Debit").ShowDialog();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            اضافةفاتورهجديدهToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            اضافةأمرشراءجديدToolStripMenuItem_Click(null, null);
        }

        private void tsmPos_Click(object sender, EventArgs e)
        {
            new frm_Pos().ShowDialog();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            tsmPos_Click(null, null);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsmPos_Click(null, null);
        }

        private void stStock_Click(object sender, EventArgs e)
        {
            new frm_AddStock().ShowDialog();
        }

        private void tsmBarcodeMaker_Click_1(object sender, EventArgs e)
        {
            new frm_AddBarcode().ShowDialog();
        }

        private void ارسالSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_AddSms().ShowDialog();
        }
    }
}


