using PRODUCTS_MANAGEMENT.DAL;
using System;
using System.Data;

namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_MadeOrder
    {
        public static DataTable stp_SelectLast_MadeOrder_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_MadeOrder_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();

            return dt;
        }

        //    public static int Insert_MadeOrder(int orderid, DateTime orderdate, decimal amount, int custid, string ordersalesman, DataTable @InvDet)
        //    {
        //        DataAccessLayer.Open();
        //        int i = DataAccessLayer.ExcuteNonQuery("stp_Insert_MadeOrder", CommandType.StoredProcedure,
        //            DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, orderid),
        //            DataAccessLayer.CreateParameter("@Order_Date", SqlDbType.Date, orderdate),
        //            DataAccessLayer.CreateParameter("@Total_Amount", SqlDbType.Decimal, amount),
        //            DataAccessLayer.CreateParameter("@Cust_Id", SqlDbType.Int, custid),
        //            DataAccessLayer.CreateParameter("@SalesMan", SqlDbType.NVarChar, ordersalesman),
        //            DataAccessLayer.CreateParameter("@InvDet", SqlDbType.Structured, InvDet));
        //        DataAccessLayer.Close();
        //        return i;

        //    }



        //}
        public static int stp_Insert_MadeOrder(int orderid, DateTime orderdate, decimal amount, int custid, string ordersalesman,string order_type)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_Insert_MadeOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, orderid),
                DataAccessLayer.CreateParameter("@Order_Date", SqlDbType.Date, orderdate),
                DataAccessLayer.CreateParameter("@Total_Amount", SqlDbType.Decimal, amount),
                DataAccessLayer.CreateParameter("@Cust_Id", SqlDbType.Int, custid),
                DataAccessLayer.CreateParameter("@SalesMan", SqlDbType.NVarChar, ordersalesman),
                DataAccessLayer.CreateParameter("@order_type", SqlDbType.NVarChar, order_type));
            DataAccessLayer.Close();
            return i;
        }
        public static int stp_Insert_MadeOrderDetails(int invid, int prductid, decimal qty, decimal price, decimal discount)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_Insert_MadeOrderDetails", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", System.Data.SqlDbType.Int, invid),
                DataAccessLayer.CreateParameter("@Product_Id", System.Data.SqlDbType.Int, prductid),
                DataAccessLayer.CreateParameter("@Qty", System.Data.SqlDbType.Decimal, qty),
                DataAccessLayer.CreateParameter("@Price", System.Data.SqlDbType.Decimal, price),
                DataAccessLayer.CreateParameter("@Discount", System.Data.SqlDbType.Decimal, discount));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable stp_SelectAll_MadeProducts()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_MadeProducts", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectOrderMade_Details_ForPrint()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectOrderMade_Details_ForPrint", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectOrderMade_Details(int Order_Id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectOrderMade_Details", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id));
            DataAccessLayer.Close();
            return dt;
        }
            public static DataTable stp_Search_MadeOrders(string Criterion)
            {
                DataAccessLayer.Open();
                DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_MadeOrders", CommandType.StoredProcedure,
                   DataAccessLayer.CreateParameter("@Criterion", SqlDbType.NVarChar, Criterion));
                DataAccessLayer.Close();
                return dt;
            }

        }
}