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
    public partial class Wedding_Slots : Form
    {
        public Wedding_Slots()
        {
            InitializeComponent();
        }

        private void btnBackWeddingslots_Click(object sender, EventArgs e)
        {
            Wedding we = new Wedding();
            we.Show();
            this.Hide();
        }
    }
}
