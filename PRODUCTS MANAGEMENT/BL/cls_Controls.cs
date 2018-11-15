using PRODUCTS_MANAGEMENT.DAL;
using System;
using System.Data;
using System.IO;
using System.Collections;

using System.Windows.Forms;


namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Controls
    {
        public static string DoubleData = "DoubleData";
        public static string CheckDouble = "العنصر مكرر بالفاتورة";
        public static string NoData = "NoData";
        public static string InvalidData = "Invalid Data";
        public static string CheckData= "من فضلك تاكد من البيانات المدخلة ";
        public static string InvalidInventory = "NotEnough";
        public static string CheckInventory = "ادخل الكمية في حدود المخزون";
        public static string InvalidCustomerData = "CustomerData";
        public static string CheckCustomerData = "تحقق من بيانات العميل";
        public static string InvalidSupplierData = "SupplierData";
        public static string CheckSupplierData = "تحقق من بيانات المورد";
       
        
        /// <summary>
        /// ملا كومبوبوكس بالعناصر
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="query"></param>
        /// <param name="displayMem"></param>
        /// <param name="valueMem"></param>
        public static void BindCombo(ref ComboBox cmb, string query, string displayMem, string valueMem)
        {
            DataAccessLayer.Open();
            var dt = DataAccessLayer.ExcuteTable(query,CommandType.StoredProcedure);
            cmb.DataSource = dt; 
            cmb.DisplayMember = displayMem;
            cmb.ValueMember = valueMem;

        }

        /// <summary>
        /// دالة لحساب رصيد المورد من العمليات السابقة
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static decimal NetBalanceForSuppliers(string ID)
        {

            if (ID != string.Empty)
            {
                DataTable dt = cls_Credit.stp_Select_Net_Credit_BySupId(int.Parse(ID));
                decimal debit = Convert.ToDecimal(dt.Rows[0][0].ToString());
                decimal credit = Convert.ToDecimal(dt.Rows[0][1].ToString());
                decimal balance = debit - credit;
                return balance;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// دالة لحساب رصيد العميل من العمليات السابقة
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static decimal NetBalanceForCustomers(string ID)
        {

            if (ID != string.Empty)
            {
                DataTable dt = cls_Debit.stp_SelectNet_Debit_ByCustId(int.Parse(ID));
                decimal debit = Convert.ToDecimal(dt.Rows[0][0].ToString());
                decimal credit = Convert.ToDecimal(dt.Rows[0][1].ToString());
                decimal balance = debit - credit;
                return balance;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// حساب رصيدالمنتج بعد خصم الفاتوره
        /// </summary>
        /// <param name="balqty"></param>
        /// <param name="currqty"></param>
        /// <returns></returns>
        public static int ShowAvailableQty(int balqty,int currqty)
        {
           int avqty = balqty - currqty;
            return avqty;
        }
        /// <summary>
        ///حساب رصيد المخزون بعد اضافة منتج
        /// </summary>
        /// <param name="balqty"></param>
        /// <param name="currqty"></param>
        /// <returns></returns>
        public static int ShowAvailableQty1(int balqty, int currqty)
        {
            int avqty = balqty + currqty;
            return avqty;
        }
        /// <summary>
        /// حساب الضريبة
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static decimal CalculateTax(decimal price)
        {
            decimal tax = Convert.ToDecimal(price) * 5 / 100;
            return tax;
           
        }
        public static void PrintInvoice(int invid,Form MyForm,object MyReport, string proc)
        {

            try
            {


                ////RPT.rpt_PrintRInvoice MyReport = new RPT.rpt_PrintRInvoice();
                ////RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                //MyReport.SetDataSource(proc + "("+invid+")");
                //MyReport.Refresh();
                //MyForm.crystalReportViewer1.ReportSource = MyReport;
                //MyForm.ShowDialog();

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }

   
}
