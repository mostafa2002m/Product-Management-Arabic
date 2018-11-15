using PRODUCTS_MANAGEMENT.DAL;
using System;
using System.Data;
namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Punches
    {
        public static DataTable stp_SelectLast_Trans_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Trans_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();

            return dt;
        }

        public static int Add_Punch(int Trans_Id ,DateTime Trans_Date,int Order_No,int Cust_No,decimal Total_Value,
                                        decimal Punch_Amount,int Punch_Times,decimal Down_Payment,DateTime StartDate,
                                        DateTime EndDate ,bool Tran_Finished)
        {
            DataAccessLayer.Open();
           int x= DataAccessLayer.ExcuteNonQuery("Add_Punch",CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Trans_Id",SqlDbType.Int,Trans_Id),
                DataAccessLayer.CreateParameter("@Trans_Date", SqlDbType.DateTime, Trans_Date),
                DataAccessLayer.CreateParameter("@Order_No",SqlDbType.Int,Order_No),
                DataAccessLayer.CreateParameter("@Cust_No",SqlDbType.Int,Cust_No),
                DataAccessLayer.CreateParameter("@Total_Value",SqlDbType.Decimal,Total_Value),
                DataAccessLayer.CreateParameter("@Punch_Amount",SqlDbType.Decimal,Punch_Amount),
                DataAccessLayer.CreateParameter("@Punch_Times",SqlDbType.Int,Punch_Times),
                DataAccessLayer.CreateParameter("@Down_Payment",SqlDbType.Decimal,Down_Payment),
                DataAccessLayer.CreateParameter("@StartDate",SqlDbType.DateTime,StartDate),
                DataAccessLayer.CreateParameter("@EndDate",SqlDbType.DateTime,EndDate),
                DataAccessLayer.CreateParameter("@Tran_Finished",SqlDbType.Bit,Tran_Finished));
            DataAccessLayer.Close();
            return x;
        }

        public static int Add_Punch_Details(int Punch_No ,int Trans_No ,decimal Punch_Amount ,DateTime Punch_Date ,DateTime Paid_Date,
                                        int Deb_No ,int Punch_Delay ,decimal New_Sum ,bool Paid )
        {
            DataAccessLayer.Open();
            int x = DataAccessLayer.ExcuteNonQuery("Add_Punch_Details", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Punch_No", SqlDbType.Int, Punch_No),
                DataAccessLayer.CreateParameter("@Trans_No", SqlDbType.Int, Trans_No),
                DataAccessLayer.CreateParameter("@Punch_Amount", SqlDbType.Decimal, Punch_Amount),
                DataAccessLayer.CreateParameter("@Punch_Date", SqlDbType.DateTime, Punch_Date),
                DataAccessLayer.CreateParameter("@Paid_Date", SqlDbType.DateTime, Paid_Date),
                DataAccessLayer.CreateParameter("@Deb_No", SqlDbType.Int, Deb_No),
                DataAccessLayer.CreateParameter("@Punch_Delay", SqlDbType.Int, Punch_Delay),
                DataAccessLayer.CreateParameter("@New_Sum", SqlDbType.Decimal, New_Sum),
                DataAccessLayer.CreateParameter("@Paid", SqlDbType.Bit, Paid));
            DataAccessLayer.Close();
            return x;
        }

        public static int update_Punch_Details(int Punch_No, int Trans_No, int Deb_No)

        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("update_Punch_Details", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Punch_No", SqlDbType.Int, Punch_No),
             DataAccessLayer.CreateParameter("@Trans_No", SqlDbType.Int, Trans_No),
                DataAccessLayer.CreateParameter("@Deb_No", SqlDbType.Int, Deb_No));
            //DataAccessLayer.CreateParameter("@Punch_Dely",SqlDbType.Int,Punch_Delay),

            DataAccessLayer.Close();
            return i;

        }
        public static DataTable stp_SelectAll_Punch()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Punch", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectAll_PunchByTransId(int trans_No)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_PunchByTransId", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("trans_No",SqlDbType.Int,trans_No));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectPunchInformationByTransID(int Trans_Id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectPunchInformationByTransID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Trans_Id", SqlDbType.Int, Trans_Id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectAll_PunchInformationByCustName(string Cust_Name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_PunchInformationByCustName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Cust_Name", SqlDbType.NVarChar, Cust_Name));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Select_PaidPunchInformationByCustName(string Cust_Name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Select_PaidPunchInformationByCustName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Cust_Name", SqlDbType.NVarChar, Cust_Name));
            DataAccessLayer.Close();
            return dt;
        }


        public static DataTable stp_Select_NotPaidPunchInformationByCustName(string Cust_Name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Select_NotPaidPunchInformationByCustName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Cust_Name", SqlDbType.NVarChar, Cust_Name));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_SelectAll_Punch_ToPayNow()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Punch_ToPayNow", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
       

        public static DataTable Print_Paid_Paunch(int transid,int punchno)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Print_Paid_Paunch", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@trans_Id", SqlDbType.Int, transid),
                DataAccessLayer.CreateParameter("@Punch_No", SqlDbType.Int, punchno));
            DataAccessLayer.Close();
            return dt;
        }
    }
}
