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
    public partial class _CEO__Customer_info : Form
    {
        public _CEO__Customer_info()
        {
            InitializeComponent();
        }

        private void btnBackCEOCustomerInfo_Click(object sender, EventArgs e)
        {
            CEO_Home ch1 = new CEO_Home();
            ch1.Show();
            this.Hide();
        }
    }
}
