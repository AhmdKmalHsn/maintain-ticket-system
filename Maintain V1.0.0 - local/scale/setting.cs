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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.usersTableAdapter.Update(this.databaseDataSet1.Users);
            Properties.Settings.Default.ServerConnectionString = textBox1.Text;
            Properties.Settings.Default.ServerName=serverName.Text ;
            Properties.Settings.Default.DBuser=DBUser.Text ;
            Properties.Settings.Default.DBpass= DBPass.Text ;
            Properties.Settings.Default.serverTable=DBName.Text ;
            Properties.Settings.Default.Save();   
            SqlDataAdapter da = new SqlDataAdapter();
            MessageBox.Show("تم الحفظ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MdiParent.MdiChildren[1].Show();
            this.MdiParent.MdiChildren[1].Activate();   
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy(this.databaseDataSet1.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void KeyUp(object sender, KeyEventArgs e)
        {
            textBox1.Text = "Data Source=" + serverName.Text + ";Initial Catalog=" + DBName.Text + ";User ID=" + DBUser.Text + ";Password=" + DBPass.Text +";";
        }

        void frmclose(object sender, FormClosedEventArgs e)
        {
            this.usersViewTableAdapter1.Fill(this.mYDBDataSet5.UsersView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Session.Master_Data >= 2)
            {
                Users b = new Users(0,"");
                b.FormClosed += new FormClosedEventHandler(frmclose);
                b.Show();
            }
            
        }

        private void Cell_DClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Session.Master_Data >= 3)
            {

                Users b = new Users(1, dataGridView1.CurrentRow.Cells[0].Value.ToString());
                b.FormClosed += new FormClosedEventHandler(frmclose);
                b.Show();
            }
        }

        private void Active(object sender, EventArgs e)
        {
            if (Session.User_Id == "")
            {
                dataGridView1.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
            }
            this.usersViewTableAdapter1.Fill(this.mYDBDataSet5.UsersView);
        }

        private void shown(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }
    }
}
