using ClinicProjectStartUp.model;
using ClinicProjectStartUp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpf.Core;
using MySql.Data.MySqlClient;
using System.Data;


namespace ClinicProjectStartUp.Common
{
    class WsApplication
    {
        public static Main main = null;
        public static AuthUser authuser = null;
        public static string pid = null;
        public static string d_id = null;
        public static string d_name = null;   
        public static string pname = null;
        public static string fd=null ;
        public static string td=null ;
        public static string pstatus;
        public static MySqlConnection ConnectionString()
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "127.0.0.1";
            conn_string.Port = 3307;
            conn_string.UserID = "root";
            conn_string.Password = "root";
            conn_string.Database = "clinicdb";
            MySqlConnection connection = new MySqlConnection(conn_string.ConnectionString);

            MySqlConnection MyCon = new MySqlConnection(conn_string.ToString());
            return MyCon;
        }
    }
    
}
