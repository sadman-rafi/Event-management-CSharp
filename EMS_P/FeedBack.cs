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
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }

        private void btnBackFeedback_Click(object sender, EventArgs e)
        {
            Customer_Home cush = new Customer_Home();
            cush.Show();
            this.Hide();
        }
    }
}
