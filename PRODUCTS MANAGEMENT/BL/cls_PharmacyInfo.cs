using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRODUCTS_MANAGEMENT.DAL;
using System.Data;

namespace PRODUCTS_MANAGEMENT.BL
{
    class cls_PharmacyInfo
    {
        public  static  DataTable stp_Get_Last_Pharmacy_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Get_Last_Pharmacy_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Get_PharmacyInfo()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Get_PharmacyInfo", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int stp_Manipulate_PharmacyInfo(Char Flag ,int Ph_Id ,string Ph_Name, string Ph_Owner ,string Ph_Address ,
                                                    string Ph_Phone ,string Ph_Mobile ,string Ph_RCN ,string Ph_BankAccount ,
                                                    string Ph_Mail , byte[] Ph_Logo )
        {
            DataAccessLayer.Open();
            int x = DataAccessLayer.ExcuteNonQuery("stp_Manipulate_PharmacyInfo", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Flag", SqlDbType.Char, Flag),
                DataAccessLayer.CreateParameter("@Ph_Id", SqlDbType.Int, Ph_Id),
                DataAccessLayer.CreateParameter("@Ph_Name", SqlDbType.NVarChar, Ph_Name),
                DataAccessLayer.CreateParameter("@Ph_Owner", SqlDbType.NVarChar, Ph_Owner),
                DataAccessLayer.CreateParameter("@Ph_Address", SqlDbType.NVarChar, Ph_Address),
                DataAccessLayer.CreateParameter("@Ph_Phone", SqlDbType.NVarChar, Ph_Phone),
                DataAccessLayer.CreateParameter("@Ph_Mobile", SqlDbType.NVarChar, Ph_Mobile),
                DataAccessLayer.CreateParameter("Ph_RCN", SqlDbType.NVarChar, Ph_RCN),
                DataAccessLayer.CreateParameter("@Ph_BankAccount", SqlDbType.NVarChar, Ph_BankAccount),
                DataAccessLayer.CreateParameter("@Ph_Mail", SqlDbType.NVarChar, Ph_Mail),
                DataAccessLayer.CreateParameter("@Ph_Logo", SqlDbType.Image, Ph_Logo));
            DataAccessLayer.Close();
            return x;
         }
    }
}
