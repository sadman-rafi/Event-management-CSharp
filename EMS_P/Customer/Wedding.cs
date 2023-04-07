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
    public partial class Wedding : Form
    {
        public Wedding()
        {
            InitializeComponent();
        }

        private void btnBackWedding_Click(object sender, EventArgs e)
        {
            Slots w = new Slots();
            w.Show();
            this.Hide();
        }

        private void btnSlotsWedding_Click(object sender, EventArgs e)
        {
            Wedding_Slots ws = new Wedding_Slots();
            ws.Show();
            this.Hide();
        }

        private void btnOffers_Click(object sender, EventArgs e)
        {
            Offer wo = new Offer();
            wo.Show();
            this.Hide();
        }
    }
}
