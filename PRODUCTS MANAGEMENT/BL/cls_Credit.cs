using PRODUCTS_MANAGEMENT.DAL;
using System;
using System.Data;

namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Credit
    {

        public static DataTable stp_SelectLast_Credit_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Credit_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int Add_Credit(int crid,DateTime crdate,decimal cramount,string crtype,int supid)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("Add_Credit", System.Data.CommandType.StoredProcedure,
               DataAccessLayer.CreateParameter("@Cr_Id", System.Data.SqlDbType.Int, crid),
               DataAccessLayer.CreateParameter("@Cr_Date", System.Data.SqlDbType.Date, crdate),
               DataAccessLayer.CreateParameter("@Amount_Paid", System.Data.SqlDbType.Decimal, cramount),
               DataAccessLayer.CreateParameter("@Cr_Type", System.Data.SqlDbType.NVarChar, crtype),
               DataAccessLayer.CreateParameter("@Sup_Id", System.Data.SqlDbType.Int, supid));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable stp_Select_Net_Credit_BySupId(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectNet_Credit_BySupId", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectAll_Credit()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Credit", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable PrintCreditAllSup()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("PrintCreditAllSup", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable PrintCreditBySup(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("PrintCreditBySup", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Search_Credit(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Credit", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Search_SupplierTrans(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_SupplierTrans", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_SearchSum_SupplierTrans(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SearchSum_SupplierTrans", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int Update_SupplierAccount(int id, decimal amount)
        {
            DataAccessLayer.Open();
            int x = DataAccessLayer.ExcuteNonQuery("Update_SupplierAccount", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@Amount", SqlDbType.Decimal, amount));
            DataAccessLayer.Close();
            return x;
        }

        public static DataTable Print_SupplierTrans_ByDate(DateTime first, DateTime end)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Print_SupplierTrans_ByDate", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@DateFirst", SqlDbType.Date, first),
                DataAccessLayer.CreateParameter("@DateEnd", SqlDbType.Date, end));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable Print_SupplierTrans_BySupId(int cust_Id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Print_SupplierTrans_BySupId", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, cust_Id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectAll_SupplierTrans()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_SupplierTrans", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

    }
}
