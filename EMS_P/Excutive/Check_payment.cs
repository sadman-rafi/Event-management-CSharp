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
    public partial class Check_payment : Form
    {
        public Check_payment()
        {
            InitializeComponent();
        }

        private void btnBackCheck_payment_Click(object sender, EventArgs e)
        {
            Execuitive exe4 = new Execuitive();
            exe4.Show();
            this.Hide();
        }
    }
}
