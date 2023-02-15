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
    public partial class Machine : Form
    {
        int type;//0  =>add ,1  =>update
        int id;//upadte or delete only use;
        string F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12, F13;
        string Rows,Old,updated;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MYDBConnectionString);
        SqlCommand cmd;
       // SqlDataAdapter adapt; 
        public void read(int Id){
            SqlCommand cmd = new SqlCommand(@"select 
                          [نوع الماكينة/ المرفق]
                         ,[ملاحظات]
                         ,[أسم الماكينة]
                         ,[القسم]
                         ,CAST([تاريخ بدء التشغيل] AS DATE)
                         ,[الشركة المصنعة-البلد]
                         ,[القدرة-الجهد]
                         ,[مرفقات الماكينة(صور-كتالوج)]
                         ,[كمية الزيت]
                         ,[مواعيد التشحيم]
                         ,[نوع الشحم]
                         ,[كمية الشحم]
                         ,[ميعاد العمرات] from [المكن] where [كود الماكينة/ المرفق]=@id ", con);
            cmd.Parameters.Add("@id",Id);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                bunifuMetroTextbox1.Text=F1=reader[0].ToString(); 
                bunifuMetroTextbox2.Text=F2=reader[1].ToString(); 
                bunifuMetroTextbox3.Text=F3=reader[2].ToString();
                bunifuMetroTextbox4.Text=F4=reader[3].ToString(); 
                bunifuDatepicker1.Text=F5=reader[4].ToString(); 
                bunifuMetroTextbox6.Text=F6=reader[5].ToString();
                bunifuMetroTextbox7.Text=F7=reader[6].ToString();
                bunifuMetroTextbox8.Text=F8=reader[7].ToString(); 
                bunifuMetroTextbox9.Text=F9=reader[8].ToString();
                bunifuMetroTextbox10.Text=F10=reader[9].ToString();
                bunifuMetroTextbox11.Text=F11=reader[10].ToString();
                bunifuMetroTextbox12.Text=F12=reader[11].ToString();
                bunifuMetroTextbox13.Text=F13=reader[12].ToString();
            }
            con.Close();
        }
        public Machine(int n,int i,string str1,string str2)
        {
            InitializeComponent();
            type = n;
            if (n == 0)bunifuFlatButton2.Text="أضافة";
            else bunifuFlatButton2.Text = "تعديل";
            //bunifuMetroTextbox1.Text = str1;
            //bunifuMetroTextbox2.Text = str2;
            id = i;
            read(i);
            
            //F1 = str1;
            //F2 = str2;
        }

        void LOGS(string crud)
        {
            ////////////////////setup//////////////////////
            if (F1 != bunifuMetroTextbox1.Text)
            {
                Rows += "[نوع الماكينة/ المرفق]";
                Old += F1 + " ";
                updated += bunifuMetroTextbox1.Text + " ";
            }
            if (F2 != bunifuMetroTextbox2.Text)
            {
                Rows += "[ملاحظات]";
                Old += F2 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
            if (F3 != bunifuMetroTextbox3.Text)
            {
                Rows +="[أسم الماكينة]";
                Old += F3 + "";
                updated += bunifuMetroTextbox3.Text + " ";
            }
                       if (F4 != bunifuMetroTextbox4.Text)
            {
                Rows +="[القسم]";
                Old += F4 + "";
                updated += bunifuMetroTextbox4.Text + " ";
            }
                       if (F5 != bunifuDatepicker1.Text)
            {
                Rows +="[تاريخ بدء التشغيل]";
                Old += F5 + "";
                updated += bunifuDatepicker1.Text + " ";
            }
                       if (F6 != bunifuMetroTextbox6.Text)
            {
                Rows += "[الشركة المصنعة-البلد]";
                Old += F6 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
                       if (F7 != bunifuMetroTextbox7.Text)
            {
                Rows += "[القدرة-الجهد]";
                Old += F7 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
                       if (F8 != bunifuMetroTextbox8.Text)
            {
                Rows += "[مرفقات الماكينة(صور-كتالوج)]";
                Old += F8 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
                       if (F9 != bunifuMetroTextbox9.Text)
            {
                Rows += "[كمية الزيت]";
                Old += F9 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
                       if (F10 != bunifuMetroTextbox10.Text)
            {
                Rows += "[مواعيد التشحيم]";
                Old += F10 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
                       if (F11 != bunifuMetroTextbox11.Text)
            {
                Rows += "[نوع الشحم]";
                Old += F11 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
                       if (F12 != bunifuMetroTextbox12.Text)
            {
                Rows += "[كمية الشحم]";
                Old += F12 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
                       if (F13 != bunifuMetroTextbox13.Text)
            {
                Rows += "[ميعاد العمرات]";
                Old += F13 + "";
                updated += bunifuMetroTextbox2.Text + " ";
            }
            ///////////////////insert/////////////////////
             Ahmed.LOGS("الماكينات", crud,""+ id, Rows, Old, updated);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuFlatButton2.Enabled = false;
            //MessageBox.Show(""+Ahmed.GetLocalIPAddress()+"\nRows:"+Rows+"\nold:"+Old+"\nUpdated:"+updated);
            if (type == 1) {
                cmd = new SqlCommand("update [المكن] set"
                         + "[نوع الماكينة/ المرفق]=@val1"
                         + ",[ملاحظات]=@val2"
                         + @",[أسم الماكينة]=@val3
                         ,[القسم]=@val4
                         ,[تاريخ بدء التشغيل]=@val5
                         ,[الشركة المصنعة-البلد]=@val6
                         ,[القدرة-الجهد]=@val7
                         ,[مرفقات الماكينة(صور-كتالوج)]=@val8
                         ,[كمية الزيت]=@val9
                         ,[مواعيد التشحيم]=@val10
                         ,[نوع الشحم]=@val11
                         ,[كمية الشحم]=@val12
                         ,[ميعاد العمرات]=@val13"
                         + " where [كود الماكينة/ المرفق]=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@val1", bunifuMetroTextbox1.Text);
                cmd.Parameters.AddWithValue("@val2", bunifuMetroTextbox2.Text);
                cmd.Parameters.AddWithValue("@val3", bunifuMetroTextbox3.Text);
                cmd.Parameters.AddWithValue("@val4", bunifuMetroTextbox4.Text);
                cmd.Parameters.AddWithValue("@val5", bunifuDatepicker1.Value);
                cmd.Parameters.AddWithValue("@val6", bunifuMetroTextbox6.Text);
                cmd.Parameters.AddWithValue("@val7", bunifuMetroTextbox7.Text);
                cmd.Parameters.AddWithValue("@val8", bunifuMetroTextbox8.Text);
                cmd.Parameters.AddWithValue("@val9", bunifuMetroTextbox9.Text);
                cmd.Parameters.AddWithValue("@val10", bunifuMetroTextbox10.Text);
                cmd.Parameters.AddWithValue("@val11", bunifuMetroTextbox11.Text);
                cmd.Parameters.AddWithValue("@val12", bunifuMetroTextbox12.Text);
                cmd.Parameters.AddWithValue("@val13", bunifuMetroTextbox13.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LOGS("update");
                MessageBox.Show("Record updated Successfully");
            }
            else
            {

                cmd = new SqlCommand("insert into [المكن]("//
                     + "[نوع الماكينة/ المرفق]"
                     + ",[ملاحظات]"
                     + @",[أسم الماكينة]
                         ,[القسم]
                         ,[تاريخ بدء التشغيل]
                         ,[الشركة المصنعة-البلد]
                         ,[القدرة-الجهد]
                         ,[مرفقات الماكينة(صور-كتالوج)]
                         ,[كمية الزيت]
                         ,[مواعيد التشحيم]
                         ,[نوع الشحم]
                         ,[كمية الشحم]
                         ,[ميعاد العمرات]) "+
           "values(@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9,@val10,@val11,@val12,@val13)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@val1",bunifuMetroTextbox1.Text);
                cmd.Parameters.AddWithValue("@val2", bunifuMetroTextbox2.Text);
                cmd.Parameters.AddWithValue("@val3", bunifuMetroTextbox3.Text);
                cmd.Parameters.AddWithValue("@val4", bunifuMetroTextbox4.Text);
                cmd.Parameters.AddWithValue("@val5", bunifuDatepicker1.Value);
                cmd.Parameters.AddWithValue("@val6", bunifuMetroTextbox6.Text);
                cmd.Parameters.AddWithValue("@val7", bunifuMetroTextbox7.Text);
                cmd.Parameters.AddWithValue("@val8", bunifuMetroTextbox8.Text);
                cmd.Parameters.AddWithValue("@val9", bunifuMetroTextbox9.Text);
                cmd.Parameters.AddWithValue("@val10", bunifuMetroTextbox10.Text);
                cmd.Parameters.AddWithValue("@val11", bunifuMetroTextbox11.Text);
                cmd.Parameters.AddWithValue("@val12", bunifuMetroTextbox12.Text);
                cmd.Parameters.AddWithValue("@val13", bunifuMetroTextbox13.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LOGS("insert");
                MessageBox.Show("Record Inserted Successfully");
            }
            
        }

        private void Machine_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

    }
}
