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

namespace scale
{
    public partial class Form5 : Form
    {
        bool c = false;
        int ch = 0;
        public Form5()
        {
            InitializeComponent();
        }
        void load_data()
        {
            string q1 = "select * from [أعطال]";
            string q2 = "select * from [الأقسام]";
            string q3 = "select * from [المكن]";
            string q4 = "select * from [عمال]";

            string q = "";
            switch (this.ch)
            {
                case 1: q = q1; break;
                case 2: q = q2; break;
                case 3: q = q3; break;
                case 4: q = q4; break;
                default: break;
            }

            if (Session.Master_Data == 0) { MessageBox.Show("ليس من حفك الوصول للبيانات"); }
            else
            {
                SqlDataAdapter adp;
                adp = new SqlDataAdapter(q, Properties.Settings.Default.ServerConnectionString);
                DataTable dt = new DataTable();
                try
                {
                    adp.Fill(dt);
                    bunifuCustomDataGrid1.DataSource = dt;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            /*if (Session.Master_Data == 0) { }
            if (Session.Master_Data == 0) { }
            if (Session.Master_Data == 0) { }
            if (Session.Master_Data == 0) { }*/
        }
   
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            ch = 1;
            load_data();
             
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ch = 2;
           load_data();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ch = 3;
            load_data();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            ch = 4;
            load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed=!splitContainer1.Panel1Collapsed;
        }
        void frmclose(object sender,FormClosedEventArgs  e){
            load_data();
            }
        private void CELL_DCLICK(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(""+bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);
            if(Session.Master_Data==3){
                /*BreakDown b = new BreakDown(1, (int)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value, bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString(), bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString());
                b.FormClosed += new FormClosedEventHandler(frmclose);
                */
                try
                {
                    switch (ch)
                    {
                        case 1:
                            {
                                BreakDown b = new BreakDown(1, (int)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value, bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString(), bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString());
                                b.FormClosed += new FormClosedEventHandler(frmclose);
                                b.Show();
                            } break;
                        case 2:
                            {
                                Department d = new Department(1, (int)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value, bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString(), bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString());
                                d.FormClosed += new FormClosedEventHandler(frmclose);
                                d.Show();
                            } break;
                        case 3:
                            {
                                Machine m = new Machine(1, (int)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value, bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString(), bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString());
                                m.FormClosed += new FormClosedEventHandler(frmclose);
                                m.Show();
                            } break;
                        case 4:
                            {
                                Worker w = new Worker(1, (int)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value, bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString(), bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString());
                                w.FormClosed += new FormClosedEventHandler(frmclose);
                                w.Show();
                            } break;
                    }

                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("ليس لك حق التعديل !");
            }

        }

        private void bunifuِِِِADD_Click(object sender, EventArgs e)
        {
            if(Session.Master_Data>=2){
                switch(ch){
                    case 1: 
                        {
                        BreakDown b = new BreakDown(0, 0, "", "");
                        b.FormClosed += new FormClosedEventHandler(frmclose);
                        b.Show();
                        } break;
                    case 2:
                        {
                            Department d = new Department(0, 0, "", "");
                            d.FormClosed += new FormClosedEventHandler(frmclose);
                            d.Show();
                        } break;
                    case 3:
                        {
                            Machine m = new Machine(0, 0, "", "");
                            m.FormClosed += new FormClosedEventHandler(frmclose);
                            m.Show();
                        } break;
                    case 4:
                        {
                            Worker w = new Worker(0, 0, "", "");
                            w.FormClosed += new FormClosedEventHandler(frmclose);
                            w.Show();
                        } break;
                }
            }
            else {
                MessageBox.Show("ليس لك حق الاضافة !");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ahmed.LOGS("تسجيل خروج", "insert", "", "", "", "");
            Session.dest();
            c = true;
            this.Close();
            new Form1().Show();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MdiParent.MdiChildren[1].Show();
            this.MdiParent.MdiChildren[1].Activate();
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            //if (!c) Application.Exit();
        }
        

    }
}
