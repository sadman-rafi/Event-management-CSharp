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
    public partial class VolunteerAddempCeo : Form
    {
        public VolunteerAddempCeo()
        {
            InitializeComponent();
        }

        private void btnBackAddempV_Click(object sender, EventArgs e)
        {
            Add_Employee_ceo_ aec3 = new Add_Employee_ceo_();
            aec3.Show();
            this.Hide();
        }
    }
}
