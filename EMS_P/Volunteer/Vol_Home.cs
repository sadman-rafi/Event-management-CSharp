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
    public partial class Vol_Home : Form
    {
        public Vol_Home()
        {
            InitializeComponent();
        }

        private void btnlogoutVol_Home_Click(object sender, EventArgs e)
        {
            VOL_login vl2 = new VOL_login();
            vl2.Show();
            this.Hide();
        }
    }
}
