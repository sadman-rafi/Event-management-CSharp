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
    public partial class Announcement_CEO : Form
    {
        public Announcement_CEO()
        {
            InitializeComponent();
        }

        private void btnBackAnnouncementCeo_Click(object sender, EventArgs e)
        {
            CEO_Home ch4 = new CEO_Home();
            ch4.Show();
            this.Hide();
        }
    }
}
