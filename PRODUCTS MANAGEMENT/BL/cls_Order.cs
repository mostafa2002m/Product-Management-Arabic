using PRODUCTS_MANAGEMENT.DAL;
using System;
using System.Data;

namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Order
    {
        public static DataTable stp_SelectLast_Order_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Order_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            
            return dt;
        }

        //public static int Insert_Order(int orderid, DateTime orderdate, decimal amount, int custid, string ordersalesman, DataTable InvDet)
        //{
        //    DataAccessLayer.Open();
        //    int i = DataAccessLayer.ExcuteNonQuery("stp_Insert_Order", CommandType.StoredProcedure,
        //        DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, orderid),
        //        DataAccessLayer.CreateParameter("@Order_Date", SqlDbType.Date, orderdate),
        //        DataAccessLayer.CreateParameter("@Total_Amount", SqlDbType.Decimal, amount),
        //        DataAccessLayer.CreateParameter("@Cust_Id", SqlDbType.Int, custid),
        //        DataAccessLayer.CreateParameter("@SalesMan", SqlDbType.NVarChar, ordersalesman),
        //        DataAccessLayer.CreateParameter("@InvDet", SqlDbType.Structured, InvDet));
        //    DataAccessLayer.Close();
        //    return i;

        //}

        public static int stp_Insert_Order(int orderid, DateTime orderdate, decimal amount, int custid, string ordersalesman, string ordertype)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_Insert_Order", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, orderid),
                DataAccessLayer.CreateParameter("@Order_Date", SqlDbType.Date, orderdate),
                DataAccessLayer.CreateParameter("@Total_Amount", SqlDbType.Decimal, amount),
                DataAccessLayer.CreateParameter("@Cust_Id", SqlDbType.Int, custid),
                DataAccessLayer.CreateParameter("@SalesMan", SqlDbType.NVarChar, ordersalesman),
                DataAccessLayer.CreateParameter("@Order_Type", SqlDbType.NVarChar, ordertype));
            DataAccessLayer.Close();
            return i;
        }
            public static int stp_Insert_OrderDetails(int invid, int prductid, decimal qty, decimal price, decimal discount)
            {
                DataAccessLayer.Open();
                int i = DataAccessLayer.ExcuteNonQuery("stp_Insert_OrderDetails", CommandType.StoredProcedure,
                    DataAccessLayer.CreateParameter("@Order_Id", System.Data.SqlDbType.Int, invid),
                    DataAccessLayer.CreateParameter("@Product_Id", System.Data.SqlDbType.Int, prductid),
                    DataAccessLayer.CreateParameter("@Qty", System.Data.SqlDbType.Decimal, qty),
                    DataAccessLayer.CreateParameter("@Price", System.Data.SqlDbType.Decimal, price),
                    DataAccessLayer.CreateParameter("@Discount", System.Data.SqlDbType.Decimal, discount));
                DataAccessLayer.Close();
                return i;
            }
        



        public static  DataTable stp_SelectOrder_Details_ForPrint()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectOrder_Details_ForPrint", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectOrder_Details(int Order_Id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectOrder_Details", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Id", SqlDbType.Int, Order_Id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable Verify_Qty(string Product_Id, int Entered_Qty)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Verify_Qty", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_Id", SqlDbType.Int, Product_Id),
                DataAccessLayer.CreateParameter("@Qty_Entered", SqlDbType.Int, Entered_Qty));
            DataAccessLayer.Close();
            return dt;

        }

        public static DataTable stp_Search_Orders(string Criterion)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Orders", CommandType.StoredProcedure,
               DataAccessLayer.CreateParameter("@Criterion", SqlDbType.NVarChar, Criterion));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable Print_Orders_ByDate(DateTime first, DateTime end)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Print_Orders_ByDate", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@DateFirst", SqlDbType.Date, first),
                DataAccessLayer.CreateParameter("@DateEnd", SqlDbType.Date, end));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable Print_Orders_ByCust_Id(int cust_Id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Print_Orders_ByCust_Id", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, cust_Id));
            DataAccessLayer.Close();
            return dt;
        }
    }

}
