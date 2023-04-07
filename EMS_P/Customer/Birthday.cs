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
    public partial class Birthday : Form
    {
        public Birthday()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Birthday_Load(object sender, EventArgs e)
        {

        }

        private void btnBackBirthday_Click(object sender, EventArgs e)
        {
            Slots s2 = new Slots();
            s2.Show();
            this.Hide();
        }
    }
}
