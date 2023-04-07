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
    public partial class NEW_ADD : Form
    {
        public NEW_ADD()
        {
            InitializeComponent();
        }

        private void btnBackNewadd_Click(object sender, EventArgs e)
        {
            Execuitive e2 = new Execuitive();
            this.Hide();
            e2.Show();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Add_Nwe an1 = new Add_Nwe();
            this.Hide();
            an1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_new_Birthday anb1 = new Add_new_Birthday();
            anb1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_HomeParty_New ahpn1 = new Add_HomeParty_New();
            ahpn1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_new_Corporate anc1 = new Add_new_Corporate();
            anc1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_new_SCVE anscv1 = new Add_new_SCVE();
            anscv1.Show();
            this.Hide();
        } */
    }
}
