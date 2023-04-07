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
    public partial class Home_Announcement : Form
    {
        public Home_Announcement()
        {
            InitializeComponent();
        }

        private void btnBackHomeAnnouncement_Click(object sender, EventArgs e)
        {
            Form1 f18 = new Form1();
            f18.Show();
            this.Hide();
        }
    }
}
