using PRODUCTS_MANAGEMENT.DAL;
using System.Data;
namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Login 
    {

               
       public static DataTable STP_LOGIN(string UserName, string Password)
        
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("STP_LOGIN", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@User_Name", SqlDbType.NVarChar, UserName),
                DataAccessLayer.CreateParameter("@User_Password", SqlDbType.NVarChar, Password));
            DataAccessLayer.Close();
            return dt;

           }

       public static int stp_ManipulateUser(string flag,string username,string password,int PERID,string fullname)
       
        {
            DataAccessLayer.Open();
            int x = DataAccessLayer.ExcuteNonQuery("stp_ManipulateUser", CommandType.StoredProcedure,
              DataAccessLayer.CreateParameter("@Flag", SqlDbType.Char, flag),
                DataAccessLayer.CreateParameter("@User_Name", SqlDbType.NVarChar, username),
              DataAccessLayer.CreateParameter("@User_Password", SqlDbType.NVarChar, password),
              DataAccessLayer.CreateParameter("@Per_Id", SqlDbType.Int, PERID),
              DataAccessLayer.CreateParameter("@User_FullName", SqlDbType.NVarChar, fullname));
           DataAccessLayer.Close();
           return x;
                      
        }
        public static DataTable stp_SelectAll_User()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_User", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectAll_Permission()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Permission", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Search_Users(string Criterion)
       {
           DataAccessLayer.Open();
           DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Users", CommandType.StoredProcedure,
               DataAccessLayer.CreateParameter("@criterion", SqlDbType.NVarChar, Criterion));
           DataAccessLayer.Close();
           return dt;
       }

       public static DataTable stp_SelectUser_ByUserName(string username)
       {
           DataAccessLayer.Open();
           DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectUser_ByUserName", CommandType.StoredProcedure,
               DataAccessLayer.CreateParameter("@UserName", SqlDbType.NVarChar, username));
           DataAccessLayer.Close();
           return dt;
       }
    
    }
    }
