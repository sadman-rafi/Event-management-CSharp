using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_P
{
    public partial class AboutUS : Form
    {
        public AboutUS()
        {
            InitializeComponent();
        }

        private void btnAbountus_Click(object sender, EventArgs e)
        {
            Form1 f17 = new Form1();
            f17.Show();
            this.Hide();
        }
    }
}
