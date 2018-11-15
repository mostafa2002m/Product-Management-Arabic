using PRODUCTS_MANAGEMENT.DAL;
using System.Data;

namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_MadeProduct
    {
        DataTable dt = new DataTable();


        #region Methods

        public static int stp_ManipulateMadeProduct(string flag, int productid, string barcode, string Product_Name, string qtyinorder,
             byte[] image, int catid, string lunitqty, string sunitqty, string lunitprice, string sunitprice, string detail)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExcuteNonQuery("stp_ManipulateMadeProduct", CommandType.StoredProcedure,
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
                                    DataAccessLayer.CreateParameter("@Product_Detail", SqlDbType.NVarChar, detail));
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

        public static DataTable stp_SelectAll_MadeProducts()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_MadeProducts", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }


        public static DataTable stp_SelectAll_MadeProductsByBarcode(string barcode)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectAll_MadeProductsByBarcode", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@barcode",SqlDbType.NVarChar,barcode));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_SelectLast_MadeProduct_Id()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectLast_MadeProduct_Id", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable stp_Search_MadeProducts(string Product_Name)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_Search_MadeProducts", CommandType.StoredProcedure,
                 DataAccessLayer.CreateParameter("@Product_Name", SqlDbType.NVarChar, Product_Name));

            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable stp_SelectSingle_MadeProduct(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExcuteTable("stp_SelectSingle_MadeProduct", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Product_Id", SqlDbType.Int, id));
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
        #endregion

    }
}
