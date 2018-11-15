using PRODUCTS_MANAGEMENT.DAL;
using System;
using System.Data;

namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Debit
    {
        public static DataTable stp_SelectLast_Debit_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Debit_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int Add_Debit(int debid, DateTime debdate, decimal amountpaid, string dbtype, int custid)
        {
            DataAccessLayer.Open();
            int dt = DataAccessLayer.ExcuteNonQuery("Add_Debit", CommandType.StoredProcedure,
                 DataAccessLayer.CreateParameter("@Deb_Id", SqlDbType.Int, debid),
                 DataAccessLayer.CreateParameter("@Deb_Date", SqlDbType.Date, debdate),
                 DataAccessLayer.CreateParameter("@Amount_Paid", SqlDbType.Decimal, amountpaid),
                 DataAccessLayer.CreateParameter("@Db_Type", SqlDbType.NVarChar, dbtype),
                 DataAccessLayer.CreateParameter("@Cust_Id", SqlDbType.Int, custid));
            DataAccessLayer.Close();
            return dt;
        }

        public static int Update_Debit(int debid, DateTime debdate, decimal amountpaid, string dbtype, int custid)
        {
            DataAccessLayer.Open();
            int dt = DataAccessLayer.ExcuteNonQuery("Update_Debit", CommandType.StoredProcedure,
                 DataAccessLayer.CreateParameter("@Deb_Id", SqlDbType.Int, debid),
                 DataAccessLayer.CreateParameter("@Deb_Date", SqlDbType.DateTime, debdate),
                 DataAccessLayer.CreateParameter("@Amount_Paid", SqlDbType.Decimal, amountpaid),
                 DataAccessLayer.CreateParameter("@Db_Type", SqlDbType.NVarChar, dbtype),
                 DataAccessLayer.CreateParameter("@Cust_Id", SqlDbType.Int, custid));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectAll_Debit()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Debit", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_SellectAll_Debit_ByCustId(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SellectAll_Debit_ByCustId", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectNet_Debit_ByCustId(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectNet_Debit_ByCustId", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Search_Debit(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Debit", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Search_CustomerTrans(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_CustomerTrans", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SearchSum_CustomerTrans(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SearchSum_CustomerTrans", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable PrintDebitAllCust()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("PrintDebitAllCust", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable PrintDebitByCust(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("PrintDebitByCust", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int Update_CustomerAccount(int id, decimal amount)
        {
            DataAccessLayer.Open();
            int x = DataAccessLayer.ExcuteNonQuery("Update_CustomerAccount", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@Amount", SqlDbType.Decimal, amount));
            DataAccessLayer.Close();
            return x;
        }

        public static DataTable Print_CustomerTrans_ByDate(DateTime first, DateTime end)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Print_CustomerTrans_ByDate", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@DateFirst", SqlDbType.Date, first),
                DataAccessLayer.CreateParameter("@DateEnd", SqlDbType.Date, end));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable Print_CustomerTrans_ByCustId(int cust_Id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Print_CustomerTrans_ByCustId", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, cust_Id));
            DataAccessLayer.Close();
            return dt;
        }
    }
}
