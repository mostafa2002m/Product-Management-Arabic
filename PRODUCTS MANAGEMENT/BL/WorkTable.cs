using System.Data;
using System.Data.SqlClient;

namespace PRODUCTS_MANAGEMENT
{
    public class WorkTable
    {
        private SqlConnection conn = new SqlConnection();
        private SqlCommand cmd= new SqlCommand();
        protected DataTable tbl = new DataTable();
        private DataTable tblWork = new DataTable();
        protected int pos;

        public WorkTable()
        {
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Product_DB;Integrated Security=True";
            cmd.Connection = conn;
        }
       
        // this method for (Add,Update and Delete) records using select statement
        public string RunDML(string stmt)
        {
            cmd.CommandText = stmt;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "OK";
            }
            catch (SqlException ex)
            {
                conn.Close();
                return "Error" + ex.Message;
            }
        }

        // this method for (Add,Update and Delete) records using Stored Procedure with SqlParameters
        public string RunPRO(string Stored_Procedure, SqlParameter[] param)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Stored_Procedure;

            if (param !=null)
            {
                cmd.Parameters.AddRange(param);
            }
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "OK";
            }
            catch (SqlException ex)
            {
                conn.Close();
                return "Error" + ex.Message;
            }
        }
        
        public DataTable RunQuery(string select)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =select ;
            tbl = new DataTable();
            try
            {
                conn.Open();
                tbl.Load(cmd.ExecuteReader());
                conn.Close();
                return tbl;
            }
            catch 
            {
                conn.Close();
                return new DataTable();
            }

        }

        public void Move2Next()
        {
            if (pos < tbl.Rows.Count -1)

            {
                pos++; 
                setData();
            }
        }

        public void Move2Previous()
        {
            if (pos > 0)
            {
                pos--;
                setData();
            }
        }


        public void Move2First()
        {
            pos = 0;
            setData();
        }

        public void Move2Last()
        {
            pos = tbl.Rows.Count -1;
            setData();
        }
        public string CurrentPosition()
        {
            return (pos + 1).ToString() + "of" + tbl.Rows.Count;
        }
        
        protected virtual void setData()
{
 	
}

        public bool Find(string PK)
        {
           
            int no=   tbl.Rows.IndexOf(tbl.Rows.Find(PK));
         if (no!=-1)
         {
             pos = no;
             setData();
             return true;
         }
         else
         {
             return false;
         }
        }
    }
    }
