using System;
using System.Data;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.DAL;

namespace PRODUCTS_MANAGEMENT.BL
{
    class cls_Customer 
    {

        public static DataTable stp_SelectLast_Customer_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Customer_Id", CommandType.StoredProcedure);

            DataAccessLayer.Close();
            return dt;
        }

    
        public static int stp_ManipulateCustomer(string flag,int custid,string name, string address, string phone)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_ManipulateCustomer", CommandType.StoredProcedure,
                 DataAccessLayer.CreateParameter("@Flag", SqlDbType.Char,flag),
                  DataAccessLayer.CreateParameter("@Cust_Id", SqlDbType.Int, custid),
                DataAccessLayer.CreateParameter("@Cust_Name", SqlDbType.VarChar, name),
                DataAccessLayer.CreateParameter("@Cust_Address", SqlDbType.VarChar, address),
                DataAccessLayer.CreateParameter("@Cust_Phone", SqlDbType.VarChar, phone));
            DataAccessLayer.Close();
            return i;
        }
        
       
         public static DataTable stp_SelectAll_Customers()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Customers", CommandType.StoredProcedure);
           DataAccessLayer.Close();
            return dt;
        }

          public static DataTable stp_SelectCustomersByName(string selectStatement)
          {
              DataAccessLayer.Open();
              DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectCustomersByName", CommandType.StoredProcedure,
                  DataAccessLayer.CreateParameter("@Cust_Name",SqlDbType.NVarChar,selectStatement));
              DataAccessLayer.Close();
              return dt;
          }
         

        public static DataTable stp_Search_Customers(string search)
       
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Customers", CommandType.StoredProcedure,
            DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar,search));
            DataAccessLayer.Close();
           
            return dt;
        }
       public static DataTable stp_SelectCustomersById(int customerId)
       {
           if (customerId <= 0)
            {
               MessageBox.Show(nameof(customerId));
            }

           DataAccessLayer.Open();
           DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectCustomersById", CommandType.StoredProcedure,
           DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, customerId));
           DataAccessLayer.Close();

           return dt;
       }

        

       
    }

}

   
