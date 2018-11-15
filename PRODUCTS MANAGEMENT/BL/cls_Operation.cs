using PRODUCTS_MANAGEMENT.DAL;
using System;
using System.Data;

namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Operation
    {
        public static DataTable stp_SelectLast_Operation_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Operation_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int stp_Insert_Operation(int opno, DateTime opdate,int custid,string user,decimal amount,string ordertype, DataTable invdet)
        {
            DataAccessLayer.Open();
            int x = DataAccessLayer.ExcuteNonQuery("stp_Insert_Operation", CommandType.StoredProcedure,
                  DataAccessLayer.CreateParameter("@Oper_Id", SqlDbType.Int, opno),
                  DataAccessLayer.CreateParameter("@Oper_Date", SqlDbType.Date,opdate),
                  DataAccessLayer.CreateParameter("@Cust_Id", SqlDbType.Int, custid),
                  DataAccessLayer.CreateParameter("@SalesMan", SqlDbType.NVarChar,user),
                  DataAccessLayer.CreateParameter("@Total_Amount", SqlDbType.Decimal,amount),
                  DataAccessLayer.CreateParameter("@order_type", SqlDbType.NVarChar, ordertype),
                  DataAccessLayer.CreateParameter("@InvDet", SqlDbType.Structured, invdet));
            DataAccessLayer.Close();
            return x;
        }

       
       
        public static DataTable stp_SelectAll_Operation()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Operation", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }



        public static DataTable stp_Search_Operation(string id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Operation", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Criterion",SqlDbType.NVarChar,id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable Get_Single_Operation(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Get_Single_Operation", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.NVarChar, id));
            DataAccessLayer.Close();
            return dt;
        }

    }
}
