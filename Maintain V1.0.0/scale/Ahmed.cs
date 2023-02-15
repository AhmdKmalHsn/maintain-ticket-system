using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;

namespace scale
{
    class Ahmed
    {

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        public static void LOGS(
            string SectionName
           ,string ProcedureType
           ,string ROWID
           ,string ROWS
           ,string VALUESold
           ,string VALUESupdate
           ) 
        {
            SqlCommand cmd = new SqlCommand(
            "INSERT INTO [dbo].[LOGS]("
           + "[SectionName]"
           + ",[ProcedureType]"
           + ",[ProcuedureTime]"
           + ",[ROWID]"
           + ",[ROWS]"
           + ",[VALUESold]"
           + ",[VALUESupdate]"
           + ",[UserID]"
           + ",[UserIP])VALUES("
           + "@SectionName"
           + ",@ProcedureType"
           + ",CURRENT_TIMESTAMP"
           + ",@ROWID"
           + ",@ROWS"
           + ",@VALUESold"
           + ",@VALUESupdate"
           + ",@UserID"
           + ",@UserIP)"
           ,Session.sqlcon);
            Session.sqlcon.Open();
            cmd.Parameters.AddWithValue("@SectionName",SectionName );
            cmd.Parameters.AddWithValue("@ProcedureType",ProcedureType);
            //cmd.Parameters.AddWithValue("@ProcuedureTime","TIMESTAMP()" );
            cmd.Parameters.AddWithValue("@ROWID", ROWID);
            cmd.Parameters.AddWithValue("@ROWS",ROWS);
            cmd.Parameters.AddWithValue("@VALUESold",VALUESold);
            cmd.Parameters.AddWithValue("@VALUESupdate",VALUESupdate);
            cmd.Parameters.AddWithValue("@UserID", Session.User_Id);
            cmd.Parameters.AddWithValue("@UserIP", Ahmed.GetLocalIPAddress());
            try
            {
                cmd.ExecuteNonQuery(); 
            }catch(Exception){}
            Session.sqlcon.Close();
        }
    }
}
