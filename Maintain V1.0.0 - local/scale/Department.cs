using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace scale
{
    public partial class Department : Form
    {
        int type;//0  =>add ,1  =>update
        int id;//upadte or delete only use;
        string F1, F2;
        string Rows,Old,updated;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MYDBConnectionString);
        SqlCommand cmd;
       // SqlDataAdapter adapt; 

        public Department(int n,int i,string str1,string str2)
        {
            InitializeComponent();
            type = n;
            if (n == 0)bunifuFlatButton2.Text="أضافة";
            else bunifuFlatButton2.Text = "تعديل";
            bunifuMetroTextbox1.Text = str1;
            bunifuMetroTextbox2.Text = str2;
            id = i;
            F1 = str1;
            F2 = str2;
        }

        void LOGS(string crud) {
            ////////////////////setup//////////////////////
            if (F1 != bunifuMetroTextbox1.Text) {
                Rows += "[نوع القسم]";
                Old += F1+" ";
                updated += bunifuMetroTextbox1.Text + " ";
            }
            if (F2 != bunifuMetroTextbox2.Text) {
                Rows += "[ملاحظات]";
                Old += F2 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
            ///////////////////insert/////////////////////
            cmd = new SqlCommand(
  "INSERT INTO [LOGS]("
           //+"[ProcedureId]"
           +"[SectionName]"
           +",[ProcedureType]"
           +",[ProcuedureTime]"
           +",[ROWID]"
           +",[ROWS]"
           +",[VALUESold]"
           +",[VALUESupdate]"
           +",[UserID]"
           +",[UserIP])VALUES("
           //<ProcedureId, int,>
           +"@SectionName" 
           +",@ProcedureType"
           + ",CURRENT_TIMESTAMP"
           +",@ROWID"
           +",@ROWS"
           +",@VALUESold"
           +",@VALUESupdate"
           +",@UserID"
           +",@UserIP)"
, con);
            con.Open();
            cmd.Parameters.AddWithValue("@SectionName","الأقسام" ); 
            cmd.Parameters.AddWithValue("@ProcedureType",crud  );
            //cmd.Parameters.AddWithValue("@ProcuedureTime","TIMESTAMP()" );
            cmd.Parameters.AddWithValue("@ROWID", id);
            cmd.Parameters.AddWithValue("@ROWS", Rows);
            cmd.Parameters.AddWithValue("@VALUESold",Old );
            cmd.Parameters.AddWithValue("@VALUESupdate",updated );
            cmd.Parameters.AddWithValue("@UserID","" );
            cmd.Parameters.AddWithValue("@UserIP", Ahmed.GetLocalIPAddress());
            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("Record Inserted Successfully");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuFlatButton2.Enabled = false;
            //MessageBox.Show(""+Ahmed.GetLocalIPAddress()+"\nRows:"+Rows+"\nold:"+Old+"\nUpdated:"+updated);
            if (type == 1) {
                cmd = new SqlCommand("update [الأقسام] set"
                         + "[نوع القسم]=@val1,"
                         + "[ملاحظات]=@val2 where [كود القسم]=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@val1", bunifuMetroTextbox1.Text);
                cmd.Parameters.AddWithValue("@val2", bunifuMetroTextbox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LOGS("update");
                MessageBox.Show("Record updated Successfully");
            }
            else
            {

                cmd = new SqlCommand("insert into [الأقسام]("
                     + "[نوع القسم],"
                     + "[ملاحظات]) values(@val1,@val2)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@val1",bunifuMetroTextbox1.Text);
                cmd.Parameters.AddWithValue("@val2", bunifuMetroTextbox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LOGS("insert");
                MessageBox.Show("Record Inserted Successfully");
            }
            
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }

    }
}
