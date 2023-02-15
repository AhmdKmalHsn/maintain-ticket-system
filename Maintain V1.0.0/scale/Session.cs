using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace scale
{
    class Session
    {
        public static SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.MYDBConnectionString);
        public static string User_Id;
        public static int Master_Data, Setting, Ticket, Report;
        public static void dest(){
            User_Id = "";
            Master_Data=Setting=Ticket=Report=0;
            Properties.Settings.Default.remember = false;
        }

    }
}
