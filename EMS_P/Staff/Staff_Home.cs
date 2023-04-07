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
    public partial class Staff_Home : Form
    {
        public Staff_Home()
        {
            InitializeComponent();
        }

        private void btnLogoutStaffhome_Click(object sender, EventArgs e)
        {
            Staff_LogIn sl2 = new Staff_LogIn();
            sl2.Show();
            this.Hide();
        }

        private void btnShowDealails_Click(object sender, EventArgs e)
        {
            ShowInfo_Staff sis = new ShowInfo_Staff();
            sis.Show();
            this.Hide();
        }

        private void btnResponsibility_Click(object sender, EventArgs e)
        {
            Responsibility r1 = new Responsibility();
            r1.Show();
            this.Hide();
        }

        private void btnSalaryInfoStaff_Click(object sender, EventArgs e)
        {
            Salary_staff ss = new Salary_staff();
            ss.Show();
            this.Hide();
        }
    }
}
