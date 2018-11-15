using PRODUCTS_MANAGEMENT.DAL;
using System;
using System.Data;

namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Cost
    {

        public static DataTable stp_SelectLast_Cost_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Cost_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int stp_ManipulateCost(string flag,int costid, string costname, DateTime costdate, string costdesc, decimal costamount)
        {
            DataAccessLayer.Open();
            int i= DataAccessLayer.ExcuteNonQuery("stp_ManipulateCost", CommandType.StoredProcedure,
               DataAccessLayer.CreateParameter("@flag", SqlDbType.Char, flag),
                DataAccessLayer.CreateParameter("@Cost_Id",SqlDbType.Int,costid),
                DataAccessLayer.CreateParameter("@Cost_Name", SqlDbType.VarChar, costname),
                DataAccessLayer.CreateParameter("@Cost_Date", SqlDbType.Date, costdate),
                DataAccessLayer.CreateParameter("@Cost_Desc", SqlDbType.VarChar, costdesc),
                DataAccessLayer.CreateParameter("@Cost_Amount", SqlDbType.Decimal, costamount));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable stp_SelectAll_Costs()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Costs", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_SelectAll_CostsById(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_CostsById", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id",SqlDbType.Int,id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable Print_Costs_ByDate(DateTime first, DateTime second)
        {
            DataAccessLayer.Open();
            DataTable dt= DataAccessLayer.ExcuteTable("Print_Costs_ByDate", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@DateFirst", SqlDbType.Date, first),
                DataAccessLayer.CreateParameter("@DateEnd", SqlDbType.Date, second));
            DataAccessLayer.Close();
            return dt;
        }

        public static int stp_ManipulateExpense(string flag, string expensename, string description)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_ManipulateExpense", CommandType.StoredProcedure,
               DataAccessLayer.CreateParameter("@flag", SqlDbType.Char, flag),
                DataAccessLayer.CreateParameter("@Expense_Name", SqlDbType.VarChar, expensename),
                DataAccessLayer.CreateParameter("@Description", SqlDbType.VarChar,description));   
               

            DataAccessLayer.Close();
            return i;
        }

        public static DataTable stp_SelectAll_Expense()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Expense", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_SelectAll_ExpenseById(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_ExpenseById", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Search_Expense(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Expense", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

    }
}
