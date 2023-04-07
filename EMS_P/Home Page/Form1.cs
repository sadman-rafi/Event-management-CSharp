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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pnlAllLogin.Height==0)
            {
                pnlAllLogin.Height=199;
            }
            else
            {
                pnlAllLogin.Height = 0;
            }
        }

        private void btnCustomerAllLogin_Click(object sender, EventArgs e)
        {
            Customer_Login cl = new Customer_Login();
            cl.Show();
            this.Hide();
        }

        private void btnExiAllLogin_Click(object sender, EventArgs e)
        {
            Execuitive_Login el = new Execuitive_Login();
            el.Show();
            this.Hide();
        }

        private void btnStaffAllLogin_Click(object sender, EventArgs e)
        {
            Staff_LogIn sl = new Staff_LogIn();
            sl.Show();
            this.Hide();
        }

        private void btnVOLAllLogin_Click(object sender, EventArgs e)
        {
            VOL_login vl = new VOL_login();
            vl.Show();
            this.Hide();
        }

        private void btnCEOAllLogin_Click(object sender, EventArgs e)
        {
            CEO_LOGIN cl = new CEO_LOGIN();
            cl.Show();
            this.Hide();
        }

        private void btnExecuitiveApplyJob_Click(object sender, EventArgs e)
        {
            Apply_Job_Execuitive ae = new Apply_Job_Execuitive();
            ae.Show();
            this.Hide();
        }

        private void btnStaffApplyJob_Click(object sender, EventArgs e)
        {
            Apply_Job_Staff ajs = new Apply_Job_Staff();
            ajs.Show();
            this.Hide();

        }

        private void btnVolunteerApplyJob_Click(object sender, EventArgs e)
        {
            Apply_Job_Volunteer ajv=new Apply_Job_Volunteer();
            ajv.Show();
            this.Hide();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (pnlApplyJob.Height == 0)
            {
                pnlApplyJob.Height = 134;
            }
            else
            {
                pnlApplyJob.Height = 0;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Sign_Up su = new Sign_Up();
            su.Show();
            this.Hide();

        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Contact_Us cu = new Contact_Us();
            cu.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutUS au =new AboutUS();
            au.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Home_Announcement ha = new Home_Announcement();
            ha.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
