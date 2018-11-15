using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PRODUCTS_MANAGEMENT.DAL
{
    public static class DataAccessLayer
    {
        //public static string Con = @"Data Source=localhost; Initial Catalog= MyProductDB; Integrated Security=True";
        private static int iD;
        //public static SqlConnection cn;
        private static string Con = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        public static SqlConnection Cn = new SqlConnection(Con);

        public static int ID { get => iD; set => iD = value; }

        public static void Open()
        {
            if (Cn.State == ConnectionState.Closed)
            {
                Cn.Open();
            }
           
        }

        public static void Close()
        {

            if (Cn.State == ConnectionState.Open)
            {
                Cn.Close();
            }
        }


        public static object ExcuteScalar(string query, CommandType type, params SqlParameter[] arr)
        {

            SqlCommand cmd = new SqlCommand(query, Cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = type;
            object o = cmd.ExecuteScalar();
            return o;
        }

        public static int ExcuteNonQuery(string query, CommandType type, params SqlParameter[] arr)
        {

            SqlCommand cmd = new SqlCommand(query, Cn);
            cmd.CommandType = type;
            if (arr != null)
            {

                cmd.Parameters.AddRange(arr);

            }
          
            int n = cmd.ExecuteNonQuery();
            return n;
        }

        public static DataTable ExcuteTable(string query, CommandType type, params SqlParameter[] arr)
        {

            SqlCommand cmd = new SqlCommand(query, Cn);
            cmd.CommandType = type;
            if (arr !=null)
            {
               
                    cmd.Parameters.AddRange(arr);
                
            }
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
        {
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = name;
            pr.SqlDbType = type;
            pr.SqlValue = value;
            return pr;
        }

        private static void Initialize( string dbCall, CommandType ct)
        {


            SqlCommand cmd = new SqlCommand(dbCall,Cn);
            //requirements                           

          cmd.CommandType = ct;
          cmd.CommandText = dbCall;
          Cn.Open();
        }

        // method used to assign parameters from Sorted List, Recieves "procedure name and sorted list parameters"
        //public static int RunProcedure(string procedureName, SortedList paraVal)
        //{
        //   SqlCommand cmd = new SqlCommand();
        //    Initialize(CommandType.StoredProcedure, procedureName);
        //    for (int x = 0; x < paraVal.Count; x++)
        //        cmd.Parameters.AddWithValue(paraVal.GetKey(x).ToString(), paraVal.GetByIndex(x).ToString());
        //    return RunUpdate();
        //}


        //public static int RunPro(string procedureName, SqlParameter[] paraVal)
        //{
        //    Initialize(CommandType.StoredProcedure, procedureName);

        //    Cmd.Parameters.AddRange(paraVal);
        //    return RunUpdate();
        //}
        //// integer method for "Insert,Update and Delete" operations
        //private static int RunUpdate()
        //{
        //    try
        //    {
        //        int x = Cmd.ExecuteNonQuery();
        //        Close();
        //        return x;
        //    }
        //    catch (SqlException ex)
        //    {
        //        Close();
        //        return ex.Number;

        //    }
        //}

        //// method used to return int value , Recieves "Insert or Update or Delete statement as parameter"
        //public static int RunSql(string insDelUp)
        //{
        //    Initialize(CommandType.Text, insDelUp);
        //    return RunUpdate();
        //}


        //// method used to return DataTable Value, recieve "select statement as parameter"
        //public static DataTable RunQuery(string @select)
        //{
        //    Initialize(CommandType.Text, @select);
        //  DataTable  tbl = new DataTable();
        //    tbl.Load(Cmd.ExecuteReader());
        //    Close();
        //    return tbl;
        //}
        // Method to read Data from Database
        public static DataTable Selectdata(string storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = storedProcedure;
            sqlcmd.Connection = Cn;
            if (param != null)
            {
                for(int i = 0; i<param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        // Method to Indert, Update , and Delete Data from Database
        public static  void Executecommand(string storedProcedure, SqlParameter [] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = storedProcedure;
            sqlcmd.Connection = Cn;
            if (param != null)
            {
                // the same as for(int i = 0; i<param.Length; i++)
             //   {
              //      sqlcmd.Parameters.Add(param[i]);
              //  } but we use (addrange) instead of (add) to add the matrix without loob
                    sqlcmd.Parameters.AddRange(param);
                
            }
            sqlcmd.ExecuteNonQuery();
        }

      
    }
}

