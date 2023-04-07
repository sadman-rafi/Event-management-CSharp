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
    public partial class Slots : Form
    {
        public Slots()
        {
            InitializeComponent();
        }

        private void btnBackSlots_Click(object sender, EventArgs e)
        {
            Customer_Home com = new Customer_Home();
            com.Show();
            this.Hide();
        }

        private void btnHomeParty_Click(object sender, EventArgs e)
        {
            Add_newHome_Party hp = new Add_newHome_Party();
            hp.Show();
            this.Hide();
        }

        private void btnBirthday_Click(object sender, EventArgs e)
        {
            Birthday br = new Birthday();
            br.Show();
            this.Hide();
        }

        private void btnCorporate_Click(object sender, EventArgs e)
        {
            Corporate_Party cpa = new Corporate_Party();
            cpa.Show();
            this.Hide();
        }

        private void btnSchool_Click(object sender, EventArgs e)
        {
            SCV_events scv = new SCV_events();
            scv.Show();
            this.Hide();
        }

        private void btnWedding_Click(object sender, EventArgs e)
        {
            Wedding wedd = new Wedding();
            wedd.Show();
            this.Hide();

        }
    }
}
