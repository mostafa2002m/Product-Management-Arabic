using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PRODUCTS_MANAGEMENT.DAL;

namespace PRODUCTS_MANAGEMENT.BL
{
    class cls_CashOut
    {
        public static DataTable stp_SelectLast_CashOut_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_CashOut_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int Add_CashOut(int cashid, DateTime cashdate, decimal amountpaid, string cashtype, int supid)
        {
            DataAccessLayer.Open();
            int dt = DataAccessLayer.ExcuteNonQuery("Add_CashOut", CommandType.StoredProcedure,
                 DataAccessLayer.CreateParameter("@Cash_Id", SqlDbType.Int, cashid),
                 DataAccessLayer.CreateParameter("@Cash_Date", SqlDbType.Date, cashdate),
                 DataAccessLayer.CreateParameter("@Amount_Paid", SqlDbType.Decimal, amountpaid),
                 DataAccessLayer.CreateParameter("@Cash_Type", SqlDbType.NVarChar, cashtype),
                 DataAccessLayer.CreateParameter("@Sup_Id", SqlDbType.Int, supid));
            DataAccessLayer.Close();
            return dt;
        }


    }
}
