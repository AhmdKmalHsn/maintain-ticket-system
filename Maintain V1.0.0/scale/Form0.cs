using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace scale
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            Session.User_Id = "";
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Dock = DockStyle.Fill;
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Dock = DockStyle.Fill;
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Dock = DockStyle.Fill;
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Dock = DockStyle.Fill;
            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.Dock = DockStyle.Fill;
            setting f6 = new setting();
            f6.MdiParent = this;
            f6.Dock = DockStyle.Fill;
            /*f2.Visible = false;
            f3.Visible = false;
            f4.Visible = false;
            f5.Visible = false;
            f6.Visible = false;*/
            //this.MdiChildren[5].Show();
            //this.MdiChildren[5].Hide();
            this.MdiChildren[0].Show();
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
        
        private void dowork(object sender, DoWorkEventArgs e)
        {
            /*this.BeginInvoke(new Action(() => this.MdiChildren[1].Visible=false));
            this.BeginInvoke(new Action(() => this.MdiChildren[1].Show()));
            //backgroundWorker1.ReportProgress(20);            
            this.BeginInvoke(new Action(() => this.MdiChildren[2].Visible = false));
            this.BeginInvoke(new Action(() => this.MdiChildren[2].Show()));
            //backgroundWorker1.ReportProgress(40);
            this.BeginInvoke(new Action(() => this.MdiChildren[3].Visible = false));
            this.BeginInvoke(new Action(() => this.MdiChildren[3].Show()));
            //backgroundWorker1.ReportProgress(60);
            this.BeginInvoke(new Action(() => this.MdiChildren[4].Visible = false));
            this.BeginInvoke(new Action(() => this.MdiChildren[4].Show()));
            //backgroundWorker1.ReportProgress(80);
            this.BeginInvoke(new Action(() => this.MdiChildren[5].Visible = false));
            this.BeginInvoke(new Action(() => this.MdiChildren[5].Show()));*/
            /*for (int i=0; i < 100; i++)
            {
                backgroundWorker1.ReportProgress(i);
            }*/
        }

        private void compelete(object sender, RunWorkerCompletedEventArgs e)
        {
            //Thread.Sleep(500);
            //progressBar1.Hide();
            //pictureBox1.Hide();
            
            this.MdiChildren[0].Activate();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            /*for (int i = 0; i < 100; i++)
            {
                backgroundWorker1.ReportProgress(i);
            }*/
           // progressBar1.Value = e.ProgressPercentage;
        }
    }
}
