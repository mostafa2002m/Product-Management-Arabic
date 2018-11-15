using PRODUCTS_MANAGEMENT.DAL;
using System.Data;

namespace PRODUCTS_MANAGEMENT.PL
{
    class cls_BackRestore
    {
        public static void Backup_DB(string path)
        {
            DataAccessLayer.Open();
            string Query = string.Format("Backup Database MyProductDB To Disk= '{0}'", path);
            DataAccessLayer.ExcuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();
        }

        public static void Restore_DB(string path)
        {
            //DataAccessLayer. = @"Data Source=.\SQLEXPRESS; Initial Catalog= master; Integrated Security=True";
            DataAccessLayer.Open();
            string Query = string.Format("Alter Database MyProductDB set OffLine with RollBack Immediate;Restore Database MyProductDB From Disk= '{0}'", path);
            DataAccessLayer.ExcuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();
        }
    }
}
