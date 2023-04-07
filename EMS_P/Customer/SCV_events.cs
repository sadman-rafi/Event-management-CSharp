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
    public partial class SCV_events : Form
    {
        public SCV_events()
        {
            InitializeComponent();
        }

        private void btnBackSCV_Click(object sender, EventArgs e)
        {
            Slots s4 = new Slots();
            s4.Show();
            this.Hide();
        }
    }
}
