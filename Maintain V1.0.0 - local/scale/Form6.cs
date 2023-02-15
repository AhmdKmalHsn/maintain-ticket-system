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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mYDBDataSet10.LOGS' table. You can move, or remove it, as needed.
            this.lOGSTableAdapter.Fill(this.mYDBDataSet10.LOGS);

        }
    }
}
