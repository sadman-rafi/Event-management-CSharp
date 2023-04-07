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
    public partial class _CEO__Block_Users : Form
    {
        public _CEO__Block_Users()
        {
            InitializeComponent();
        }

        private void btnBackBlockID_Click(object sender, EventArgs e)
        {
            CEO_Home ch2 = new CEO_Home();
            ch2.Show();
            this.Hide();
        }
    }
}
