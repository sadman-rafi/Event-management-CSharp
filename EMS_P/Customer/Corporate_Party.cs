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
    public partial class Corporate_Party : Form
    {
        public Corporate_Party()
        {
            InitializeComponent();
        }

        private void btnBackCorporate_Click(object sender, EventArgs e)
        {
            Slots s3 = new Slots();
            s3.Show();
            this.Hide();
        }
    }
}
