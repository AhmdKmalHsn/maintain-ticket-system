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
using System.Windows.Forms.DataVisualization.Charting;

namespace scale
{
    public partial class Form4 : Form
    {
        bool c = false;
        public static string _id="";
        Bitmap MemoryImage;
        SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.MYDBConnectionString);

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mYDBDataSet2.الأقسام' table. You can move, or remove it, as needed.
            this.الأقسامTableAdapter.Fill(this.mYDBDataSet2.الأقسام);
            // TODO: This line of code loads data into the 'mYDBDataSet3.TicketView' table. You can move, or remove it, as needed.
            //this.ticketViewTableAdapter.Fill(this.mYDBDataSet3.TicketView);
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.White;
            Print(splitContainer3.Panel2);
            DGVPrinter p = new DGVPrinter();
            p.Title = "تقرير الصيانة";
            p.PageNumbers = true;
            p.PageNumberInHeader = false;
            p.ColumnWidth = DGVPrinter.ColumnWidthSetting.CellWidth;
            p.HeaderCellAlignment = StringAlignment.Near;
            //p.TableAlignment = Center;
            p.PageSettings.Margins = new System.Drawing.Printing.Margins(20, 5, 5, 5);
            p.PageSettings.Landscape = true;
            //p.PrintPreviewDataGridView(dataGridView1);
            p.PrintDataGridView(dataGridView1);
        }

        
        
        public void GetPrintArea(DataGridView pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        public void Print(Panel pnl)
        {
            GetPrintArea(pnl);
            printDocument1.DefaultPageSettings.Landscape = true;
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, 0, 0,1188 ,840);
        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            c = true;
            (new Form5()).Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MdiParent.MdiChildren[1].Show();
            this.MdiParent.MdiChildren[1].Activate();
        }
       
        private void closed(object sender, FormClosedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();
            p.Title = "تقرير العملاء";
            p.PageNumbers = true;
            p.PageNumberInHeader = false;
            p.ColumnWidth = DGVPrinter.ColumnWidthSetting.CellWidth;          
            p.HeaderCellAlignment = StringAlignment.Near;
            //p.TableAlignment = Center;
            p.PageSettings.Margins = new System.Drawing.Printing.Margins(20,5,5,5);
            p.PageSettings.Landscape = true;
            p.PrintPreviewDataGridView(dataGridView1);
            //p.PrintDataGridView(dataGridView1);
        }
        
        

        private void DeptBTN_Click(object sender, EventArgs e)
        {
            string q = @"SELECT [القسم] ,count(*) 'العدد' FROM [TicketView] "
                     + " where [تاريخ العطل] >= CONVERT(date, '" + dateTimePicker1.Value.ToShortDateString()+ "',103) and [تاريخ العطل] <= CONVERT(date, '" + dateTimePicker2.Value.ToShortDateString()+ "',103)"
                      +" group by [القسم]";
            SqlDataAdapter adp;
            //dateTimePicker1.Value.ToShortDateString()
            adp = new SqlDataAdapter(q, sqlcon);
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            chart1.DataSource = dt;
            //Mapping a field with x-value of chart
            this.chart1.Series[0].XValueMember = "القسم";

            //Mapping a field with y-value of Chart
            this.chart1.Series[0].YValueMembers = "العدد";
            this.chart1.Series[0].IsValueShownAsLabel = true;
            //Bind the DataTable with Chart
            this.chart1.DataBind();
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
        }

        private void WorkerBTN_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
            string q = @"SELECT [نوع العامل] as 'اسم العامل',count(*) 'العدد' FROM [TicketView] "
                    + " where [تاريخ العطل] >= CONVERT(date,'" + dateTimePicker1.Value.ToShortDateString()+ "',103) and [تاريخ العطل] <= CONVERT(date, '" + dateTimePicker2.Value.ToShortDateString()+ "',103)"
                     + " group by [نوع العامل] ";
            SqlDataAdapter adp;
            adp = new SqlDataAdapter(q, sqlcon);
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            chart1.DataSource = dt;
            //Mapping a field with x-value of chart
            this.chart1.Series[0].XValueMember = "اسم العامل";

            //Mapping a field with y-value of Chart
            this.chart1.Series[0].YValueMembers = "العدد";
            //this.chart1.Series[0].IsValueShownAsLabel = false;
            //Bind the DataTable with Chart
            this.chart1.DataBind();
        }

        private void MachMostBTN_Click(object sender, EventArgs e)
        {
            string q = @"SELECT [نوع الماكينة/ المرفق] as 'الماكينة' ,count(*) 'العدد' FROM [TicketView] "
                   + " where [تاريخ العطل] >= CONVERT(date, '" + dateTimePicker1.Value.ToShortDateString()+ "',103) and [تاريخ العطل] <= CONVERT(date, '" + dateTimePicker2.Value.ToShortDateString()+ "',103)"
                    + " group by [نوع الماكينة/ المرفق] order by العدد desc";
            SqlDataAdapter adp;
            adp = new SqlDataAdapter(q, sqlcon);
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            chart1.DataSource = dt;
            //Mapping a field with x-value of chart
            this.chart1.Series[0].XValueMember = "الماكينة";

            //Mapping a field with y-value of Chart
            this.chart1.Series[0].YValueMembers = "العدد";
            //this.chart1.Series[0].IsValueShownAsLabel = false;
           
            //Bind the DataTable with Chart
            this.chart1.DataBind();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ////تحتاج الي حساب فترة التوقف
            string q = @"SELECT  A.[ملاحظات],
                                 A.[نوع قطع الغيار],
                                 A.[عدد قطع الغيار],
                                 A.[العمل المطلوب],
                                 A.[نوع الماكينة/ المرفق],
                                 q.sumt "
                + @"from [TicketView] A join (SELECT 
      [نوع الماكينة/ المرفق] 'mach',
      sum(ABS(datediff(minute,[وقت التوقف],[وقت التشغيل]))) 'sumt'
      FROM [TicketView] "+
      " where [تاريخ العطل] >= CONVERT(date, '" + dateTimePicker1.Value.ToShortDateString() + "',103) and [تاريخ العطل] <= CONVERT(date, '" + dateTimePicker2.Value.ToShortDateString() + "',103) " + " AND [القسم]=N'" + comboBox2.Text + "'"
      +@" group by [نوع الماكينة/ المرفق]
      )q on A.[نوع الماكينة/ المرفق]=q.mach" +
      " where [تاريخ العطل] >= CONVERT(date, '" + dateTimePicker1.Value.ToShortDateString() + "',103) and [تاريخ العطل] <= CONVERT(date, '" + dateTimePicker2.Value.ToShortDateString() + "',103) " + " AND [القسم]=N'" + comboBox2.Text + "'" +
      " order by q.sumt desc";
                   
            SqlDataAdapter adp;
            adp = new SqlDataAdapter(q, sqlcon);
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string q = @"SELECT [نوع الماكينة/ المرفق] as 'الماكينة' ,sum(ABS(datediff(minute,[وقت التوقف],[وقت التشغيل]))) as 'فترة التوقف' FROM [TicketView] "
                   + " where [تاريخ العطل] >= CONVERT(date, '" + dateTimePicker1.Value.ToShortDateString()+ "',103) and [تاريخ العطل] <= CONVERT(date, '" + dateTimePicker2.Value.ToShortDateString()+ "',103)"
                   + " AND [القسم]=N'" + comboBox2.Text + "'"
                   +  " group by [نوع الماكينة/ المرفق] order by [فترة التوقف] desc";
            SqlDataAdapter adp;
            adp = new SqlDataAdapter(q, sqlcon);
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            chart1.DataSource = dt;
            //Mapping a field with x-value of chart
            this.chart1.Series[0].XValueMember = "الماكينة";
            
            //Mapping a field with y-value of Chart
            this.chart1.Series[0].YValueMembers = "فترة التوقف";
            this.chart1.Series[0].IsValueShownAsLabel = true;

            //Bind the DataTable with Chart
            this.chart1.DataBind();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0: chart1.Series[0].ChartType = SeriesChartType.Column; break;
                case 1: chart1.Series[0].ChartType = SeriesChartType.Pie; break;
                case 2: chart1.Series[0].ChartType = SeriesChartType.Line; break;
                case 3: chart1.Series[0].ChartType = SeriesChartType.Area; break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string q = @"SELECT [القسم] as 'الماكينة' ,sum(ABS(datediff(minute,[وقت التوقف],[وقت التشغيل]))) as 'فترة التوقف' FROM [TicketView] "
                   + " where [تاريخ العطل] >= CONVERT(date, '" + dateTimePicker1.Value.ToShortDateString()+ "',103) and [تاريخ العطل] <= CONVERT(date, '" + dateTimePicker2.Value.ToShortDateString()+ "',103)"
                   + " group by [القسم] ";
            SqlDataAdapter adp;
            adp = new SqlDataAdapter(q, sqlcon);
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            chart1.DataSource = dt;
            //Mapping a field with x-value of chart
            this.chart1.Series[0].XValueMember = "الماكينة";

            //Mapping a field with y-value of Chart
            this.chart1.Series[0].YValueMembers = "فترة التوقف";
            this.chart1.Series[0].IsValueShownAsLabel = true;

            //Bind the DataTable with Chart
            this.chart1.DataBind();

        }
    }
}
