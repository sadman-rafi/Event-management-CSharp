using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_P
{
    public partial class Customer_Home : Form
    {
        public Customer_Home()
        {
            InitializeComponent();
        }


        private void btnDC_Click(object sender, EventArgs e)
        {
            Customer_Details cd = new Customer_Details();
            cd.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FeedBack fb = new FeedBack();
            fb.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Customer_Login cl1=new Customer_Login();
            cl1.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_Person sp = new Search_Person();
            sp.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment pa = new Payment();
            pa.Show();
            this.Hide();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Bookings bo = new Bookings();
            bo.Show();
            this.Hide();
        }

        private void btnCslots_Click(object sender, EventArgs e)
        {
            Slots sl = new Slots();
            sl.Show();
            this.Hide();
        }

        private void Customer_Home_Load(object sender, EventArgs e)
        {
            lblNameCH.Text = "Name:" + Customer_Login.name;
            lblIDCH.Text = "ID:" + Customer_Login.id;
        }
    }
}
