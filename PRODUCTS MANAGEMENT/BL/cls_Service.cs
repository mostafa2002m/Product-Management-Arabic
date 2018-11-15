using PRODUCTS_MANAGEMENT.DAL;
using System.Data;

namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Service
    {
        public static DataTable stp_SelectLast_Service_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Service_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int stp_ManipulateService(string flag,int no,string name,string detail,decimal price)
        {
            DataAccessLayer.Open();
            int x = DataAccessLayer.ExcuteNonQuery("stp_ManipulateService", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Flag", SqlDbType.Char, flag),
                DataAccessLayer.CreateParameter("@Service_Id", SqlDbType.Int, no),
                DataAccessLayer.CreateParameter("@Service_Name", SqlDbType.NVarChar, name),
                DataAccessLayer.CreateParameter("@Service_Detail", SqlDbType.NVarChar, detail),
                DataAccessLayer.CreateParameter("@Price", SqlDbType.Decimal, price)
                );
            DataAccessLayer.Close();
            return x;
        }

        public static DataTable stp_SelectAll_Service()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Service", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }


        public static DataTable stp_SelectServiceById(int ServiceId)
        {
            //    if (customerId <= 0)
            //    {
            //        MessageBox.Show(nameof(customerId));
            //    }

            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectServiceById", CommandType.StoredProcedure,
            DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, ServiceId));
            DataAccessLayer.Close();

            return dt;
        }
    }
}
