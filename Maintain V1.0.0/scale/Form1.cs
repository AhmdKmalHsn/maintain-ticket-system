using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
//using Microsoft.Office.Interop.Excel;
namespace scale
{
    public partial class Form1 : Form
    {
        static public int FirstTime=0;
        public static string users = "";
        
        SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.MYDBConnectionString);
        /*void logs() { 
        SqlCommand cmd = new SqlCommand(
  "INSERT INTO [dbo].[LOGS]("
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
, sqlcon);
            sqlcon.Open();
            cmd.Parameters.AddWithValue("@SectionName","تسجيل دخول"); 
            cmd.Parameters.AddWithValue("@ProcedureType","");
            //cmd.Parameters.AddWithValue("@ProcuedureTime","TIMESTAMP()" );
            cmd.Parameters.AddWithValue("@ROWID","0");
            cmd.Parameters.AddWithValue("@ROWS", "");
            cmd.Parameters.AddWithValue("@VALUESold","" );
            cmd.Parameters.AddWithValue("@VALUESupdate","" );
            cmd.Parameters.AddWithValue("@UserID",Session.User_Id);
            cmd.Parameters.AddWithValue("@UserIP", Ahmed.GetLocalIPAddress());
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            //MessageBox.Show("Record Inserted Successfully");
        }*/
        
        public Form1()
        {
            InitializeComponent();
            sqlcon = new SqlConnection(Properties.Settings.Default.MYDBConnectionString);
        }
                 
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            //if (Properties.Settings.Default.remember) //connect(Properties.Settings.Default.user, Properties.Settings.Default.pass);
            
           
        }
        int result = 0;
        
        void connect(string user,string pass) {
            try
            {
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand("SELECT count (*) FROM [Users] where user_id = N'" + user + "' and password = N'" + pass + "'", sqlcon);//  
                SqlCommand cmdSESSION = new SqlCommand(
                @"SELECT TOP (1) [user_id]
      ,[password]
      ,[masterDataPriv]
      ,[ticketPriv]
      ,[ReportsPriv]
      ,[settingPriv]
       FROM [MYDB].[dbo].[Users] where user_id = N'" + user + "'" ,sqlcon);
                if ( sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }
                result = Convert.ToInt32(cmd.ExecuteScalar());///////count user
 
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
                if (result > 0){
                    if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }
                    reader =cmdSESSION.ExecuteReader();
                    while(reader.Read()){
                        Session.User_Id = reader[0].ToString();
                        //Session.User_Id = reader[1].ToString();
                        Session.Master_Data = int.Parse(reader[2].ToString());
                        Session.Ticket = int.Parse(reader[3].ToString());
                        Session.Report = int.Parse(reader[4].ToString());
                        Session.Setting = int.Parse(reader[5].ToString());
                    }
                        reader.Close();
                        Session.sqlcon=sqlcon;
                        
                    if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
                    /*هنا يتم انشاء الجلسة ووضع المتيرات بها علي طول البرنامج*/
                    Ahmed.LOGS("تسجيل دخول", "insert", "", "", "", "");
                    this.MdiParent.MdiChildren[1].Show();
                    this.MdiParent.MdiChildren[1].Activate();    
            }
            else MessageBox.Show("من فضلك تأكد من اسم المستخدم والرقم السري");
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        void create()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Users] (user_id,password) VALUES(N'" + textBox1.Text + "',N'" + textBox2.Text + "')", sqlcon);//  
                if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }
                cmd.ExecuteNonQuery();///////count user 
                MessageBox.Show("تم انشاء المستخدم بنجاح");
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.user = textBox1.Text;
            Properties.Settings.Default.pass = textBox2.Text;
            Properties.Settings.Default.remember = checkBox1.Checked;
            Properties.Settings.Default.Save();
            connect(textBox1.Text,textBox2.Text);
        }

        private void keypress1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }

        private void keypress2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                connect(textBox1.Text, textBox2.Text);
            }
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tic(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void active(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.MdiParent.MdiChildren[5].Show();
            this.MdiParent.MdiChildren[5].Activate();
        }

    }
}
