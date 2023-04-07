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
    public partial class ShowInfo_Staff : Form
    {
        public ShowInfo_Staff()
        {
            InitializeComponent();
        }

        private void btnBackShowStaff_Click(object sender, EventArgs e)
        {
            Staff_Home sh5 = new Staff_Home();
            sh5.Show();
            this.Hide();
        }
    }
}
