using PRODUCTS_MANAGEMENT.DAL;
using System.Data;
namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_Category 
    {
        /// <summary>
        /// Add new Category
        /// </summary>
        /// <param name="Cat_Name">the name of category</param> 
        /// <returns>returns the number of rows added</returns>
        public static int stp_ManipulateCategory(string flag,string Cat_Name,string description)
        {
            DataAccessLayer.Open();
            int count = DataAccessLayer.ExcuteNonQuery("stp_ManipulateCategory", CommandType.StoredProcedure,
                 DataAccessLayer.CreateParameter("@Flag", SqlDbType.Char, flag),
                DataAccessLayer.CreateParameter("@Cat_Name", SqlDbType.VarChar, Cat_Name),
                DataAccessLayer.CreateParameter("@description", SqlDbType.VarChar, description));
            DataAccessLayer.Close();
           return count;
        }

        public static DataTable stp_SelectAll_Category()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Category", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            
            return dt;
        }

        public static DataTable stp_SelectAll_CategoriesById(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_CategoriesById", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID",SqlDbType.Int,id));
            DataAccessLayer.Close();

            return dt;
        }


        /// <summary>
        /// select search category
        /// </summary>
        /// <param name="search">string value</param>
        /// <returns>data table</returns>
        public static DataTable stp_Search_Category(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Category", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.VarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        
        
    }
}
