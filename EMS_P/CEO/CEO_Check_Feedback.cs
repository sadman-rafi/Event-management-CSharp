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
    public partial class CEO_Check_Feedback : Form
    {
        public CEO_Check_Feedback()
        {
            InitializeComponent();
        }

        private void btnBackCeoCheckFeedback_Click(object sender, EventArgs e)
        {
            CEO_Home ch3 = new CEO_Home();
            ch3.Show();
            this.Hide();
        }
    }
}
