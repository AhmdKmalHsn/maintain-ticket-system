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
using System.Threading;
//using iTextSharp.text.pdf;
//using iTextSharp.text;

namespace scale
{
    public partial class Form3 : Form
    {
        int ch = 0,i=0;
        //bool c = false;
        
        public Form3()
        {
            InitializeComponent();
        }
        
        void _show(){
            switch(this.ch){
                case 1: read("where [حالة الطلب] IS NOT NULL"); break;
                case 2: read("where [حالة الطلب]=N'ملغي'"); break;
                case 3: read("where [حالة الطلب]=N'جاري'"); break;
                case 4: read("where [حالة الطلب]=N'انتظار'"); break;
                case 5: read("where [حالة الطلب]=N'تم اصلاحه'"); break;
            }
            check_Statu();
            counterset();
        }        
        void read(string where)
        {
            
            string q = "select top(1000) * from [MYDB].[dbo].[TicketView] "+where+" order by id desc";//+" and id<"+i

            SqlDataAdapter adp = new SqlDataAdapter(q,Session.sqlcon);
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }       
        void check_Statu() {
            for (int i = 0; i < bunifuCustomDataGrid1.RowCount ;i++ )
            {
                switch (bunifuCustomDataGrid1.Rows[i].Cells[1].Value.ToString().TrimEnd())
                {
                    case "تم اصلاحه": bunifuCustomDataGrid1.Rows[i].Cells[1].Style.BackColor = Color.Lime; break;
                    case "انتظار": bunifuCustomDataGrid1.Rows[i].Cells[1].Style.BackColor = Color.DeepSkyBlue; break;
                    case "جاري": bunifuCustomDataGrid1.Rows[i].Cells[1].Style.BackColor = Color.Yellow; break;
                    case "ملغي": bunifuCustomDataGrid1.Rows[i].Cells[1].Style.BackColor = Color.Red; break;
                }
            }
        }       
        void counterset() {
            SqlCommand cmd = new SqlCommand("select count(*) from [MYDB].[dbo].[TicketView] ", Session.sqlcon);
            SqlCommand cmd1 = new SqlCommand("select count(*) from [MYDB].[dbo].[TicketView]  where [حالة الطلب] = N'تم اصلاحه'", Session.sqlcon);
            SqlCommand cmd2 = new SqlCommand("select count(*) from [MYDB].[dbo].[TicketView]  where [حالة الطلب] = N'انتظار'", Session.sqlcon);
            SqlCommand cmd3 = new SqlCommand("select count(*) from [MYDB].[dbo].[TicketView]  where [حالة الطلب] = N'جاري'", Session.sqlcon);
            SqlCommand cmd4 = new SqlCommand("select count(*) from [MYDB].[dbo].[TicketView]  where [حالة الطلب] = N'ملغي'", Session.sqlcon);
            Session.sqlcon.Open();
            button1.Text = cmd1.ExecuteScalar().ToString();
            button2.Text = cmd2.ExecuteScalar().ToString();
            button3.Text = cmd3.ExecuteScalar().ToString();
            button4.Text = cmd4.ExecuteScalar().ToString();
            button5.Text = cmd.ExecuteScalar().ToString();
            i = (int)cmd.ExecuteScalar();
            Session.sqlcon.Close();
        }

        SqlDataAdapter adp;
        DataTable dt = new DataTable();

        private void Form3_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            ch = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ch = 5;
            _show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ch = 1;
            _show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ch = 2;
            _show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ch = 4;
            _show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ch = 3;
            _show();
        }

        private void DB_Click(object sender, DataGridViewCellEventArgs e)
        {
            Ticket t= new Ticket(1,(int)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);
            t.FormClosed += new FormClosedEventHandler(frmclose);
            t.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Ticket t= new Ticket(0);
            t.FormClosed += new FormClosedEventHandler(frmclose);
            t.Show();
        }

        void frmclose(object sender, FormClosedEventArgs e)//عند اغلاق الفورم الفرعي (الابن )من 
        {
            read("");
            check_Statu();
            counterset();
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            /*for (int i = 1; i < bunifuCustomDataGrid1.Columns.Count + 1; i++)
            {
                //worksheet.Cells[1, i] = bunifuCustomDataGrid1.Columns[i - 1].HeaderText;
            }*/
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < bunifuCustomDataGrid1.Columns.Count; j++)
                {
                    try { worksheet.Cells[i + 2, j + 1] = bunifuCustomDataGrid1.Rows[i].Cells[j].Value; }catch(Exception){}
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();  
        }

        private void dowork(object sender, DoWorkEventArgs e)
        {
            string q = "select top(100) * from [MYDB].[dbo].[TicketView]  order by id desc";//+" and id<"+i

            adp = new SqlDataAdapter(q, Session.sqlcon);

            try
            {
                adp.Fill(dt);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void shown(object sender, EventArgs e)
        {
           
        }

        private void tick(object sender, EventArgs e)
        {
        }

        private void next_Click(object sender, EventArgs e)
        {
            i -= 50;
            _show();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            i += 50;
            _show();
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string q = @"select * from [MYDB].[dbo].[TicketView]"+
                    "where [القسم] LIKE N'" + textBox1.Text + "%' or [نوع الماكينة/ المرفق] LIKE N'" + textBox1.Text +
                    "%' or [نوع العطل] LIKE N'" + textBox1.Text + "%' or [نوع العامل] LIKE N'" + textBox1.Text +
                    "%' order by id desc";

            SqlDataAdapter adp = new SqlDataAdapter(q,Session.sqlcon);
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            } 
            check_Statu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.MdiParent.MdiChildren[1].Show();
            this.MdiParent.MdiChildren[1].Activate();
        }
        

        private void DGVkeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                Ticket t = new Ticket(1, (int)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);
                t.FormClosed += new FormClosedEventHandler(frmclose);
                t.Show();
            }
        }

        private void complete(object sender, RunWorkerCompletedEventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = dt;
            counterset();
            check_Statu();
        }

        private void Active(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
