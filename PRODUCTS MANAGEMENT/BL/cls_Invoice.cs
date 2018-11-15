using PRODUCTS_MANAGEMENT.DAL;
using System;
using System.Data;

namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Invoice
    {

        public static DataTable stp_SelectLast_Invoice_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Invoice_Id", CommandType.StoredProcedure);

            DataAccessLayer.Close();
            return dt;
        }

        //public static int Insert_Invoice1(int invid, DateTime invdate, decimal invamount, int supid, string invbuyer, DataTable InvDet)
        //{
        //    DataAccessLayer.Open();
        //    int i = DataAccessLayer.ExcuteNonQuery("stp_Insert_Invoice",CommandType.StoredProcedure,
        //        DataAccessLayer.CreateParameter("@Inv_Id", System.Data.SqlDbType.Int, invid),
        //        DataAccessLayer.CreateParameter("@Inv_Date", System.Data.SqlDbType.Date, invdate),
        //        DataAccessLayer.CreateParameter("@Total_Amount", System.Data.SqlDbType.Decimal, invamount),
        //        DataAccessLayer.CreateParameter("@Sup_Id", System.Data.SqlDbType.Int, supid),
        //        DataAccessLayer.CreateParameter("@Inv_Buyer", System.Data.SqlDbType.NVarChar, invbuyer),
        //        DataAccessLayer.CreateParameter("@InvDet",SqlDbType.Structured,InvDet));
        //    DataAccessLayer.Close();
        //    return i;
        //}

        public static int stp_Insert_Invoice(int invid, DateTime invdate, decimal invamount, int supid, string invbuyer,string invtype)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_Insert_Invoice", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Inv_Id", System.Data.SqlDbType.Int, invid),
                DataAccessLayer.CreateParameter("@Inv_Date", System.Data.SqlDbType.Date, invdate),
                DataAccessLayer.CreateParameter("@Total_Amount", System.Data.SqlDbType.Decimal, invamount),
                DataAccessLayer.CreateParameter("@Sup_Id", System.Data.SqlDbType.Int, supid),
                DataAccessLayer.CreateParameter("@Inv_Buyer", System.Data.SqlDbType.NVarChar, invbuyer),
                DataAccessLayer.CreateParameter("@Inv_Type", System.Data.SqlDbType.NVarChar, invtype));
            DataAccessLayer.Close();
            return i;
        }
        public static int stp_Insert_InvoiceDetails(int invid, int prductid, decimal qty, decimal price, decimal discount)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_Insert_InvoiceDetails", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Inv_Id", System.Data.SqlDbType.Int, invid),
                DataAccessLayer.CreateParameter("@Product_Id", System.Data.SqlDbType.Int, prductid),
                DataAccessLayer.CreateParameter("@Qty", System.Data.SqlDbType.Decimal, qty),
                DataAccessLayer.CreateParameter("@Price", System.Data.SqlDbType.Decimal, price),
                DataAccessLayer.CreateParameter("@Discount", System.Data.SqlDbType.Decimal, discount));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable Stp_SelectInvoice_Details(int Inv_Id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectInvoice_Details", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Inv_Id", SqlDbType.Int, Inv_Id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectInvoice_DetailsForPrint()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectInvoice_DetailsForPrint", CommandType.StoredProcedure);

            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Search_Invoices(string Criterion)
        {
            DataAccessLayer.Open();
            DataTable dt =DataAccessLayer.ExcuteTable("stp_Search_Invoices", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Criterion",SqlDbType.NVarChar,Criterion));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable Print_Invoices_ByDate(DateTime first, DateTime end)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Print_Invoices_ByDate", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@DateFirst", SqlDbType.Date, first),
                DataAccessLayer.CreateParameter("@DateEnd", SqlDbType.Date, end));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable Print_Invoices_BySupId(int sup_Id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Print_Invoices_BySupId", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, sup_Id));
            DataAccessLayer.Close();
            return dt;
        }
    }
}
