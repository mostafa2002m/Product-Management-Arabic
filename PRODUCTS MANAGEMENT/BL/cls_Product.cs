using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PRODUCTS_MANAGEMENT.DAL;

namespace PRODUCTS_MANAGEMENT.BL
{
    class cls_Product
    {

        public static int stp_ManipulateProduct(string flag,int productid, string barcode, string Product_Name, string qtyinorder,
            byte[] image, int catid, string lunitqty, string sunitqty, string lunitprice, string sunitprice, string detail,bool taxed)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_ManipulateProduct", CommandType.StoredProcedure,
                 DataAccessLayer.CreateParameter("@Flag", SqlDbType.Char, flag),
                  DataAccessLayer.CreateParameter("@Product_Id", SqlDbType.Int, productid),
                    DataAccessLayer.CreateParameter("@Barcode", SqlDbType.NVarChar, barcode),
                    DataAccessLayer.CreateParameter("@Product_Name", SqlDbType.NVarChar, Product_Name),
                      DataAccessLayer.CreateParameter("@Qte_In_Order", SqlDbType.NVarChar, qtyinorder),
                          DataAccessLayer.CreateParameter("@Product_Image", SqlDbType.Image, image),
                            DataAccessLayer.CreateParameter("@Cat_Id", SqlDbType.Int, catid),
                              DataAccessLayer.CreateParameter("@LUnitQty", SqlDbType.NVarChar, lunitqty),
                                DataAccessLayer.CreateParameter("@SUnitQty", SqlDbType.NVarChar, sunitqty),
                                  DataAccessLayer.CreateParameter("@LUnitPrice", SqlDbType.NVarChar, lunitprice),
                                    DataAccessLayer.CreateParameter("@SUnitPrice", SqlDbType.NVarChar, sunitprice),
                                    DataAccessLayer.CreateParameter("@Product_Detail", SqlDbType.NVarChar, detail),
                                   DataAccessLayer.CreateParameter("@taxed", SqlDbType.Bit, taxed));
            DataAccessLayer.Close();
            return i;

        }

          
        public static DataTable Verify_Product(string ID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("Verify_Product", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_Id ", SqlDbType.NVarChar, ID));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectImageProduct(int ID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectImageProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_Id", SqlDbType.Int, ID));

            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectAll_Products()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_Products", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_SelectAll_ProductsById(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_ProductsById", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Id",SqlDbType.Int,id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_SelectAll_ProductsByBarcode(string barcode)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_ProductsByBarcode", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@barcode", SqlDbType.NVarChar, barcode));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_SelectLast_Product_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_Product_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Search_Products(string Product_Name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_Products", CommandType.StoredProcedure,
                 DataAccessLayer.CreateParameter("@Product_Name", SqlDbType.NVarChar, Product_Name));

            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_SelectSingle_Product(int  id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectSingle_Product", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_Id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }


        public static DataTable stp_SelectProductByName(string proname)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectProductByName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_Name", SqlDbType.NVarChar, proname));
            DataAccessLayer.Close();
            return dt;
        }



        public static DataTable Barcod_Label_Report(string Barcod, int Label_Num)
        {
            string sql = string.Format("select * from Products where Barcode = '{0}'", Barcod);
            for (int i = 0; i < Label_Num - 1; i++)
            {
                sql += string.Format("Union All select * from Products where Barcode = '{0}'", Barcod);
            }
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable(sql, CommandType.Text);
            DataAccessLayer.Close();
            return dt;

        }

    }
}
