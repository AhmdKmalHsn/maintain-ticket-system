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
    public partial class Ticket : Form
    {
        int type;//0  =>add ,1  =>update
        int id;//upadte or delete only use;
        string F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12;
        string Rows,Old,updated;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MYDBConnectionString);
        SqlCommand cmd;
        //SqlDataAdapter adapt;
        
        public void read(int id){
            SqlCommand cmd = new SqlCommand(@"SELECT [status]     
      ,[تاريخ العطل]
      ,[القسم]
      ,[كود الماكينة]
      ,[العطل]
      ,[العمل المطلوب]
      ,[A]
      ,[B]      
      ,[القائم بالعمل]
      ,[عدد قطع الغيار]
      ,[نوع قطع الغيار]
      ,[ملاحظات]
  FROM [MYDB].[dbo].[بيانات الإصلاح] where id=@id ", con);
            cmd.Parameters.Add("@id",id);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                //MessageBox.Show("" +reader[2].ToString());
                try { comboBox1.SelectedValue = int.Parse(reader[0].ToString()); }//1
                catch (Exception) { comboBox1.SelectedIndex = -1; } 
                dateTimePicker1.Text=reader[1].ToString(); //2
                try {comboBox2.SelectedValue=int.Parse(reader[2].ToString()); }//3
                catch (Exception) { comboBox2.SelectedIndex = -1; } 
                try {comboBox3.SelectedValue=int.Parse(reader[3].ToString()); }//4
                catch (Exception) { comboBox3.SelectedIndex = -1; }  
                try {comboBox4.SelectedValue=int.Parse(reader[4].ToString()); }//5
                catch (Exception) { comboBox4.SelectedIndex = -1; }  
                bunifuMetroTextbox7.Text=reader[5].ToString();//6
                dateTimePicker2.Text=reader[6].ToString();//7
                dateTimePicker3.Text=reader[7].ToString();//8
                try { comboBox5.SelectedValue = int.Parse(reader[8].ToString()); }//9
                catch (Exception) { comboBox5.SelectedIndex = -1; } 
                bunifuMetroTextbox11.Text=reader[9].ToString();//10
                bunifuMetroTextbox10.Text=reader[10].ToString();//11
                bunifuMetroTextbox13.Text=reader[11].ToString();//12
                F1 = reader[0].ToString().TrimEnd();
                F2 = reader[1].ToString().TrimEnd();
                F3 = reader[2].ToString().TrimEnd();
                F4 = reader[3].ToString().TrimEnd();
                F5 = reader[4].ToString().TrimEnd();
                F6 = reader[5].ToString().TrimEnd();
                F7 = reader[6].ToString().TrimEnd();
                F8 = reader[7].ToString().TrimEnd();
                F9 = reader[8].ToString().TrimEnd();
                F10 = reader[9].ToString().TrimEnd();
                F11 = reader[10].ToString().TrimEnd();
                F12 = reader[11].ToString().TrimEnd();
            }
            con.Close();
        }
        
        public Ticket(int n,int i)
        {
            InitializeComponent();
            
            type = n;
            if (n == 0)
            {
                bunifuFlatButton2.Text = "أضافة";
                bunifuFlatButton3.Visible = bunifuFlatButton4.Visible = false;
            }
            else
            {
                bunifuFlatButton2.Text = "تعديل";
                bunifuFlatButton1.Visible = false;
            }
            id = i;
            //read(i);
        }
        
        public Ticket(int n)
        {
            InitializeComponent();
            type = n;
            if (n == 0)
            {
                bunifuFlatButton2.Text = "أضافة";
                bunifuFlatButton3.Visible = bunifuFlatButton4.Visible = false;
            }
            else
            {
                bunifuFlatButton2.Text = "تعديل";
                bunifuFlatButton2.Visible = false;
            }
        }
       
        void LOGS(string crud)
        {
            ////////////////////setup//////////////////////
          
            if (F1 != comboBox1.Text)
            {
                Rows += "[status]";
                Old += F1 + " ";
                updated += comboBox1.Text +  " ";
            }
            if (F2 != dateTimePicker1.Text)
            {
                Rows +=  "[تاريخ العطل]";
                Old += F2 + "";
                updated += dateTimePicker1.Value +  " ";
            }
            if (F3 != comboBox2.Text)
            {
                Rows += "[القسم] ";
                Old += F3 + "";
                updated += comboBox2.Text +  " ";
            } 
                       if (F4 != comboBox3.Text)
            {
                Rows += "[كود الماكينة] ";
                Old += F4 + "";
                updated += comboBox3.Text +  " ";
            }
                       if (F5 != comboBox4.Text)
            {
                Rows += "[العطل] ";
                Old += F5 + "";
                updated += comboBox4.Text +  " ";
            }
                       if (F6 != bunifuMetroTextbox7.Text)
            {
                Rows +=  "[العمل المطلوب] ";
                Old += F6 + "";
                updated += bunifuMetroTextbox7.Text +  " ";
            }
                       if (F7 !=dateTimePicker2.Text )
            {
                Rows +=  "[A] وقت التوقف";
                Old += F7 + "";
                updated += dateTimePicker2.Value +  " ";
            }
                       if (F8 != dateTimePicker3.Text)
            {
                Rows +=  "[B] وقت التشغيل";
                Old += F8 + "";
                updated +=  dateTimePicker2.Value+  " ";
            }
                       if (F9 !=comboBox5.Text )
            {
                Rows +=  "[القائم بالعمل] ";
                Old += F9 + "";
                updated +=  comboBox5.Text+  " ";
            }
                       if (F10 !=bunifuMetroTextbox11.Text )
            {
                Rows +=  "[عدد قطع الغيار] ";
                Old += F10 + "";
                updated += bunifuMetroTextbox11.Text +  " ";
            }
                       if (F11 !=bunifuMetroTextbox10.Text )
            {
                Rows +=  "[نوع قطع الغيار] ";
                Old += F11 + "";
                updated += bunifuMetroTextbox10.Text+ " ";
            }
                       if (F12 !=  bunifuMetroTextbox13.Text)
            {
                Rows +=  "[ملاحظات] ";
                Old += F12 + "";
                updated +=  bunifuMetroTextbox13.Text +  " ";
            }
                       MessageBox.Show("r="+Rows.Length+" ,o="+Old.Length+" ,u="+updated.Length);
                       Ahmed.LOGS("Tickets", crud, ""+id, Rows, Old, updated);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            /* //MessageBox.Show(""+Ahmed.GetLocalIPAddress()+"\nRows:"+Rows+"\nold:"+Old+"\nUpdated:"+updated);*/
            if (type == 1)
            {
                cmd = new SqlCommand(@"update [MYDB].[dbo].[بيانات الإصلاح] set
         [status]=@val1    
        ,[تاريخ العطل]=@val2
        ,[القسم]=@val3
        ,[كود الماكينة]=@val4
        ,[العطل]=@val5
        ,[العمل المطلوب]=@val6
        ,[A]=@val7
        ,[B]=@val8      
        ,[القائم بالعمل]=@val9
        ,[عدد قطع الغيار]=@val10
        ,[نوع قطع الغيار]=@val11
        ,[ملاحظات]=@val12
         where [Id]=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@val1", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@val2", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@val3", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@val4", comboBox3.SelectedValue);
                cmd.Parameters.AddWithValue("@val5", comboBox4.SelectedValue);
                cmd.Parameters.AddWithValue("@val6", bunifuMetroTextbox7.Text);
                cmd.Parameters.AddWithValue("@val7", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@val8", dateTimePicker3.Value);
                cmd.Parameters.AddWithValue("@val9", comboBox5.SelectedValue);
                cmd.Parameters.AddWithValue("@val10", bunifuMetroTextbox11.Text);
                cmd.Parameters.AddWithValue("@val11", bunifuMetroTextbox10.Text);
                cmd.Parameters.AddWithValue("@val12", bunifuMetroTextbox13.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LOGS("update");
                MessageBox.Show("Record updated Successfully");
            }
            else
            {

                cmd = new SqlCommand("insert into [MYDB].[dbo].[بيانات الإصلاح] ("//                   
                     + @"[status]     
      ,[تاريخ العطل]
      ,[القسم]
      ,[كود الماكينة]
      ,[العطل]
      ,[العمل المطلوب]
      ,[A]
      ,[B]      
      ,[القائم بالعمل]
      ,[عدد قطع الغيار]
      ,[نوع قطع الغيار]
      ,[ملاحظات]) " +
           "values(@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9,@val10,@val11,@val12)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@val1", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@val2", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@val3", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@val4", comboBox3.SelectedValue);
                cmd.Parameters.AddWithValue("@val5", comboBox4.SelectedValue);
                cmd.Parameters.AddWithValue("@val6", bunifuMetroTextbox7.Text);
                cmd.Parameters.AddWithValue("@val7", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@val8", dateTimePicker3.Value);
                cmd.Parameters.AddWithValue("@val9", comboBox5.SelectedValue);
                cmd.Parameters.AddWithValue("@val10", bunifuMetroTextbox11.Text);
                cmd.Parameters.AddWithValue("@val11", bunifuMetroTextbox10.Text);
                cmd.Parameters.AddWithValue("@val12", bunifuMetroTextbox13.Text);
                try { cmd.ExecuteNonQuery(); }
                catch (Exception ex) { con.Close(); MessageBox.Show(ex.Message); }
                con.Close();
                LOGS("insert");
                MessageBox.Show("Record Inserted Successfully");

            } bunifuFlatButton2.Enabled = false;
        }
        
        private void Ticket_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
        
        }

        private void deptFilter(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedText);
            /*SqlDataAdapter adp1 = new SqlDataAdapter(@"SELECT *
  FROM [MYDB].[dbo].[المكن]
  where [القسم]=N'"+comboBox2.Text+"'", Properties.Settings.Default.MYDBConnectionString);
            
            DataTable dt1 = new DataTable();
           
            adp1.Fill(dt1);
            
            comboBox3.DataSource = dt1;
            
        */
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuFlatButton2.Enabled = true;

            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1; 
            comboBox4.SelectedIndex = -1; 
            comboBox5.SelectedIndex = -1;
            
            dateTimePicker1.Text = dateTimePicker2.Text = dateTimePicker3.Text = "";

            bunifuMetroTextbox7.Text =
            bunifuMetroTextbox11.Text =
            bunifuMetroTextbox10.Text =
            bunifuMetroTextbox13.Text = "";

        }

        private void shown(object sender, EventArgs e)
        {
           
        }

        private void tic(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'mYDBDataSet2.عمال' table. You can move, or remove it, as needed.
            this.عمالTableAdapter.Fill(this.mYDBDataSet2.عمال);
            // TODO: This line of code loads data into the 'mYDBDataSet2.المكن' table. You can move, or remove it, as needed.
            this.المكنTableAdapter.Fill(this.mYDBDataSet2.المكن);
            // TODO: This line of code loads data into the 'mYDBDataSet2.الأقسام' table. You can move, or remove it, as needed.
            this.الأقسامTableAdapter.Fill(this.mYDBDataSet2.الأقسام);
            // TODO: This line of code loads data into the 'mYDBDataSet2.أعطال' table. You can move, or remove it, as needed.
            this.أعطالTableAdapter.Fill(this.mYDBDataSet2.أعطال);
            // TODO: This line of code loads data into the 'mYDBDataSet1.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.mYDBDataSet1.Status);
            //comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = comboBox5.Text = "";
            comboBox2.SelectedIndex = comboBox3.SelectedIndex = comboBox4.SelectedIndex = comboBox5.SelectedIndex = -1;
            comboBox1.SelectedIndex = 1;
            comboColor();
            if (type == 1) read(id);
            timer1.Stop();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            { 
                id--;
                read(id); 
            }
            catch (Exception) {  }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                id++;
                read(id);
            }
            catch (Exception) { }
        }
        void comboColor(){
        switch(comboBox1.SelectedIndex){
                case 0: comboBox1.BackColor = Color.Red; break;
                case 1: comboBox1.BackColor = Color.DeepSkyBlue; break;
                case 2: comboBox1.BackColor = Color.Yellow; break;
                case 3: comboBox1.BackColor = Color.Lime; break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboColor();
        }
            
        }
}


