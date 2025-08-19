
using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace webCinestar_webForm_1808.Controllers
{
    public class Db
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        

        public Db(string cnn)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings[cnn].ConnectionString);
            cmd = new SqlCommand("", cn);
            da = new SqlDataAdapter(cmd);
        }


        internal void Sentecial(string sql)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
        }
            
            internal object getDataTable()
        {
             DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
