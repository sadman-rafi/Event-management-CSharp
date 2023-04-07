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
    public partial class Add_Employee_ceo_ : Form
    {
        public Add_Employee_ceo_()
        {
            InitializeComponent();
        }

        private void btnBackAddEmployeeCeo_Click(object sender, EventArgs e)
        {
            CEO_Home ch5 = new CEO_Home();
            ch5.Show();
            this.Hide();
        }

        private void btnExecuitiveAddemp_Click(object sender, EventArgs e)
        {
            ExecuitiveAddEmpCEO eaec = new ExecuitiveAddEmpCEO();
            eaec.Show();
            this.Hide();
        }

        private void btnStaffAddemp_Click(object sender, EventArgs e)
        {
            StaffAddEmpCEO sac = new StaffAddEmpCEO();
            sac.Show();
            this.Hide();
        }

        private void btnVolunteer_Click(object sender, EventArgs e)
        {
            VolunteerAddempCeo vac = new VolunteerAddempCeo();
            vac.Show();
            this.Hide();
        }
    }
}
