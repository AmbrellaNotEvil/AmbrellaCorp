using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzoznaieLauncher_1._1
{
    public partial class UpdateWindow : Form
    {
        public UpdateWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthForms authForms = new AuthForms();
            authForms.Show();
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AuthForms authForms = new AuthForms();
            authForms.Show();
        }
    }
}
