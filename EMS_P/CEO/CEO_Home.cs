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
    public partial class CEO_Home : Form
    {
        public CEO_Home()
        {
            InitializeComponent();
        }

        private void btnLogoutCEOhome_Click(object sender, EventArgs e)
        {
            CEO_LOGIN clg = new CEO_LOGIN();
            clg.Show();
            this.Hide();
        }

        private void btnCustomerInfoCEOHome_Click(object sender, EventArgs e)
        {
            _CEO__Customer_info cci = new _CEO__Customer_info();
            cci.Show();
            this.Hide();
        }

        private void btnBlockCEOhome_Click(object sender, EventArgs e)
        {
            _CEO__Block_Users cbu = new _CEO__Block_Users();
            cbu.Show();
            this.Hide();
        }

        private void btnCustomerfeedbackCEOhome_Click(object sender, EventArgs e)
        {
            CEO_Check_Feedback ccf = new CEO_Check_Feedback();
            ccf.Show();
            this.Hide();
        }

        private void btnAnnouncementCEOhome_Click(object sender, EventArgs e)
        {
            Announcement_CEO aco = new Announcement_CEO();
            aco.Show();
            this.Hide();
        }

        private void btnAddEmployeeCEOhome_Click(object sender, EventArgs e)
        {
            Add_Employee_ceo_ aec = new Add_Employee_ceo_();
            aec.Show();
            this.Hide();
        }
    }
}
