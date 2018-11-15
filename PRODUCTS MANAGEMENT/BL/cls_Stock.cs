using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRODUCTS_MANAGEMENT.DAL;
using System.Data;
namespace PRODUCTS_MANAGEMENT.BL
{
    class cls_Stock
    {
        public static DataTable stp_SelectLast_Stock_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Stock_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int stp_ManipulateStock( int st_Id, string st_Name, string st_address, string st_phone, string st_type)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_ManipulateStock", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@st_id", SqlDbType.Int, st_Id),
                DataAccessLayer.CreateParameter("@st_name", SqlDbType.NVarChar, st_Name),
                DataAccessLayer.CreateParameter("@st_Address", SqlDbType.NVarChar, st_address),
                DataAccessLayer.CreateParameter("@st_phone", SqlDbType.NVarChar, st_phone),
                DataAccessLayer.CreateParameter("@st_type", SqlDbType.NVarChar, st_type));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable stp_SellectAll_Stock()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SellectAll_Stock", CommandType.StoredProcedure);
            DataAccessLayer.Close();

            return dt;
        }

        public static DataTable stp_Search_Stock(string search)

        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Stock", CommandType.StoredProcedure,
            DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();

            return dt;
        }
        public static DataTable stp_Delete_Stock(int st_id)

        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Delete_Stock", CommandType.StoredProcedure,
            DataAccessLayer.CreateParameter("@st_id", SqlDbType.Int, st_id));
            DataAccessLayer.Close();

            return dt;
        }

    }
}