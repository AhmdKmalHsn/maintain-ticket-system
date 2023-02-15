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
    public partial class BreakDown : Form
    {
        int type;//0  =>add ,1  =>update
        int id;//upadte or delete only use;
        string F1="", F2="";
        string Rows="",Old="",updated="";
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MYDBConnectionString);
        SqlCommand cmd;
       // SqlDataAdapter adapt; 

        public BreakDown(int n,int i,string str1,string str2)
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
                Rows += "[نوع العطل]";
                Old += F1+" ";
                updated += bunifuMetroTextbox1.Text + " ";
            }
            if (F2 != bunifuMetroTextbox2.Text) {
                Rows += "[ملاحظات]";
                Old += F2 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
            ///////////////////insert/////////////////////
            Ahmed.LOGS("اعطال",crud,""+id,Rows,Old,updated);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuFlatButton2.Enabled = false;
            //MessageBox.Show(""+Ahmed.GetLocalIPAddress()+"\nRows:"+Rows+"\nold:"+Old+"\nUpdated:"+updated);
            if (type == 1) {
                cmd = new SqlCommand("update [أعطال] set"
                         + "[نوع العطل]=@val1,"
                         + "[ملاحظات]=@val2 where [كود العطل]=@id", con);
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

                cmd = new SqlCommand("insert into [أعطال]("
                     + "[نوع العطل],"
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

        private void BreakDown_Load(object sender, EventArgs e)
        {

        }

    }
}
