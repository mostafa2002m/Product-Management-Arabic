using PRODUCTS_MANAGEMENT.DAL;
using System.Data;

namespace PRODUCTS_MANAGEMENT.BL
{
    class cls_Supplier
    {
        public static DataTable stp_SelectAll_Supplier()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Supplier", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }


        public static int stp_ManipulateSupplier(string flag, int supid, string supcompany,string supname, string supaddress, string supphone)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_ManipulateSupplier", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Flag", SqlDbType.Char, flag),
                DataAccessLayer.CreateParameter("@Sup_Id", SqlDbType.Int, supid),
                DataAccessLayer.CreateParameter("@Sup_Company", SqlDbType.VarChar, supcompany),
                DataAccessLayer.CreateParameter("@Sup_Name", SqlDbType.VarChar, supname),
                DataAccessLayer.CreateParameter("@Sup_Address", SqlDbType.VarChar, supaddress),
                DataAccessLayer.CreateParameter("@Sup_Phone", SqlDbType.VarChar, supphone));
            DataAccessLayer.Close();
            return i;
        }

      
        public static DataTable stp_SelectAll_SuppliersById(string select_Statement)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_SuppliersById", CommandType.StoredProcedure,
            DataAccessLayer.CreateParameter("@Sup_Name", SqlDbType.NVarChar, select_Statement));
            DataAccessLayer.Close();
            return dt;
        }


        public static DataTable stp_SelectLast_Supplier_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Supplier_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Search_Supplier(string Supplier_Id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Supplier", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Criterion", SqlDbType.NVarChar, Supplier_Id));
            DataAccessLayer.Close();

            return dt;
        }
        public static DataTable PrintAccountBySup(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("PrintAccountBySup", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_Select_SuppliersById(int id)
        {
            DataAccessLayer.Open();
            DataTable i = DataAccessLayer.ExcuteTable("stp_Select_SuppliersById", CommandType.StoredProcedure,
                  DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }

    }
}
