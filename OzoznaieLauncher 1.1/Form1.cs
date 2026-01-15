using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzoznaieLauncher_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Path_local;
            Path_local = PathLink.Text;
            Process.Start(Path_local);
        }

        private void PathLink_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
