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
    public partial class Users : Form
    {
        string Id;
        int type;//0 for insert ,1 for update 
        string F1, F2, F3, F4, F5, F6;
        string Rows, Old, updated;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MYDBConnectionString);
        SqlCommand cmd;

        public Users(int x,string y)
        {
            InitializeComponent();
            this.Id = y;
            this.type = x;
            if(x==0)button1.Text = "اضافة";
            else button1.Text = "تعديل";
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mYDBDataSet9.Priv' table. You can move, or remove it, as needed.
            this.privTableAdapter3.Fill(this.mYDBDataSet9.Priv);
            // TODO: This line of code loads data into the 'mYDBDataSet8.Priv' table. You can move, or remove it, as needed.
            this.privTableAdapter2.Fill(this.mYDBDataSet8.Priv);
            // TODO: This line of code loads data into the 'mYDBDataSet7.Priv' table. You can move, or remove it, as needed.
            this.privTableAdapter1.Fill(this.mYDBDataSet7.Priv);
            // TODO: This line of code loads data into the 'mYDBDataSet6.Priv' table. You can move, or remove it, as needed.
            this.privTableAdapter.Fill(this.mYDBDataSet6.Priv);
            comboBox1.SelectedIndex = comboBox2.SelectedIndex = comboBox3.SelectedIndex = comboBox4.SelectedIndex = -1;
            read(Id);
        }

        void LOGS(string crud)
        {
            ////////////////////setup//////////////////////
            if (F1 != textBox1.Text)
            {
                Rows += "[user_Id]";
                Old += F1 + " ";
                updated += textBox1.Text + " ";
            }
            if (F2 != textBox2.Text)
            {
                Rows += "[password]";
                Old += F2 + "";
                updated += textBox2.Text + " ";
            }
            if (F3 != comboBox1.Text)
            {
                Rows += "[master_data]";
                Old += F3 + "";
                updated += comboBox1.Text + " ";
            }
            if (F4 != comboBox2.Text)
            {
                Rows += "[ticket]";
                Old += F4 + "";
                updated += comboBox2.Text + " ";
            }
            if (F5 != comboBox3.Text)
            {
                Rows += "[report]";
                Old += F5 + "";
                updated += comboBox3.Text + " ";
            }
            if (F6 != comboBox4.Text)
            {
                Rows += "[setting]";
                Old += F6 + "";
                updated += comboBox4.Text + " ";
            }
            ///////////////////insert/////////////////////
   
            
            Ahmed.LOGS("users", crud, Id, Rows, Old, updated);
        }

        
        public void read(string id)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT [user_id]
      ,[password]
      ,[masterDataPriv]
      ,[ticketPriv]
      ,[ReportsPriv]
      ,[settingPriv]
  FROM [Users] where [user_id]=@id ", con);
            cmd.Parameters.Add("@id", id);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //MessageBox.Show("" +reader[2].ToString());
                try { textBox1.Text = reader[0].ToString(); }//1
                catch (Exception) { }
                try { textBox2.Text = reader[1].ToString(); }//2
                catch (Exception) { }
                try { comboBox1.SelectedValue = int.Parse(reader[2].ToString()); }//3
                catch (Exception) { }
                try { comboBox2.SelectedValue = int.Parse(reader[3].ToString()); }//4
                catch (Exception) { }
                try { comboBox3.SelectedValue = int.Parse(reader[4].ToString()); }//5
                catch (Exception) { }
                try { comboBox4.SelectedValue = int.Parse(reader[5].ToString()); }//6
                catch (Exception) { }
               
                F1 = reader[0].ToString();
                F2 = reader[1].ToString();
                F3 = reader[2].ToString();
                F4 = reader[3].ToString();
                F5 = reader[4].ToString();
                F6 = reader[5].ToString();


            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (type == 1)
            {
     cmd = new SqlCommand(@"UPDATE [Users]
      SET [user_id] = @val1
      ,[password] = @val2
	  ,[masterDataPriv] =@val3
      ,[ticketPriv] = @val4
      ,[ReportsPriv] = @val5
      ,[settingPriv] = @val6"
                        + " where [user_id]=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@val1", textBox1.Text);
                cmd.Parameters.AddWithValue("@val2", textBox2.Text);
                cmd.Parameters.AddWithValue("@val3", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@val4", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@val5", comboBox3.SelectedValue);
                cmd.Parameters.AddWithValue("@val6", comboBox4.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();
                LOGS("update");
                MessageBox.Show("Record updated Successfully");
            }
            else
            {

                cmd = new SqlCommand(@"insert into [Users]([user_id] 
      ,[password]  
	  ,[masterDataPriv] 
      ,[ticketPriv] 
      ,[ReportsPriv]  
      ,[settingPriv])"
                    + " values(@val1,@val2,@val3,@val4,@val5,@val6)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@val1", textBox1.Text);
                cmd.Parameters.AddWithValue("@val2", textBox2.Text);
                cmd.Parameters.AddWithValue("@val3", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@val4", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@val5", comboBox3.SelectedValue);
                cmd.Parameters.AddWithValue("@val6", comboBox4.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();
                LOGS("insert");
                MessageBox.Show("Record Inserted Successfully");
            }
        }
    }
}
