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
    public partial class Responsibility : Form
    {
        public Responsibility()
        {
            InitializeComponent();
        }

        private void btnBackResponsibilityStaff_Click(object sender, EventArgs e)
        {
            Staff_Home sh4 = new Staff_Home();
            sh4.Show();
            this.Hide();
        }
    }
}
