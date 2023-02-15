using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scale
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Session.Report > 0)
            {
                this.MdiParent.MdiChildren[3].Show();
                this.MdiParent.MdiChildren[3].Activate();
            }
            else { MessageBox.Show("ليس لديكم صلاحية الوصول!"); }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Session.User_Id == "") {
                this.MdiParent.MdiChildren[0].Show();
                this.MdiParent.MdiChildren[0].Activate();
            } 
            toolTip1.SetToolTip(this.button1, "طلب اصلاح");
            toolTip1.SetToolTip(this.button2, "التقارير");
            toolTip1.SetToolTip(this.button3, "البيانات الاساسية");
            toolTip1.SetToolTip(this.button4, "الاعدادات");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Session.Setting > 0)
            {
                this.MdiParent.MdiChildren[5].Show();
                this.MdiParent.MdiChildren[5].Activate();
            }
            else { MessageBox.Show("ليس لديكم صلاحية الوصول!"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ahmed.LOGS("تسجيل خروج","insert","","","","");
            Session.dest();         
            this.MdiParent.MdiChildren[0].Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Session.Master_Data > 0)
            {
                this.MdiParent.MdiChildren[4].Show();
                this.MdiParent.MdiChildren[4].Activate();
            }
            else { MessageBox.Show("ليس لديكم صلاحية الوصول!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Session.Ticket > 0)
            {

                this.MdiParent.MdiChildren[2].Show();
                this.MdiParent.MdiChildren[2].Activate();
            }
            else { MessageBox.Show("ليس لديكم صلاحية الوصول!"); }
        }
    }
}
