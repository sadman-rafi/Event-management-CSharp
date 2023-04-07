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
    public partial class Bookings : Form
    {
        SqlConnection conn8;
        public Bookings()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBackBooking_Click(object sender, EventArgs e)
        {
            Customer_Home cho = new Customer_Home();
            cho.Show();
            this.Hide();

        }

        private void rbWeddingBook_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bookings_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id, username, ev, dat, shift;

            id = txtIDBook.Text;
            username = txtNameBook.Text;
            ev = textBoxEvent.Text;
            dat = textBoxDate.Text;
            shift = textBoxShift.Text;

            //dob1 = Convert.ToString(dtpAppliJobEXI);

            // cmd6.Parameters.AddWithValue("@CGender", gender);
            conn8 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            conn8.Open();
            string query8 = "INSERT INTO  Booking_HomeParty_slot(ID,Username,Event,Date,Shift) VALUES('" + id + "','" + username + "','" + ev + "','" + dat + "','" + shift + "')";
            SqlCommand cmd8 = new SqlCommand(query8, conn8);




            int rows = cmd8.ExecuteNonQuery();



            if (rows > 0)
            {
                MessageBox.Show("your apply of booking successful and wait for the approve", "info", MessageBoxButtons.OK);
                //reset();




            }
            else
            {
                MessageBox.Show("Wrong", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn8.Close();
        }

        private void btnWED_Click(object sender, EventArgs e)
        {
            string id, username, ev, dat, shift;

            id=txtIDBook.Text;
            username = txtNameBook.Text;
            ev = textBoxEvent.Text;
            dat = textBoxDate.Text;
            shift = textBoxShift.Text;
            
            //dob1 = Convert.ToString(dtpAppliJobEXI);

            // cmd6.Parameters.AddWithValue("@CGender", gender);
            conn8 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            conn8.Open();
            string query8 = "INSERT INTO  Booking_wedding_slots(ID,Username,Event,Date,Shift) VALUES('" + id + "','" + username + "','" + ev + "','" + dat + "','" + shift + "')";
            SqlCommand cmd8 = new SqlCommand(query8, conn8);

            


            int rows = cmd8.ExecuteNonQuery();



            if (rows > 0)
            {
                MessageBox.Show("your apply of booking successful and wait for the approve", "info", MessageBoxButtons.OK);
                //reset();




            }
            else
            {
                MessageBox.Show("Wrong", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn8.Close();
        }

        private void buttonBirth_Click(object sender, EventArgs e)
        {
            string id, username, ev, dat, shift;

            id = txtIDBook.Text;
            username = txtNameBook.Text;
            ev = textBoxEvent.Text;
            dat = textBoxDate.Text;
            shift = textBoxShift.Text;

            //dob1 = Convert.ToString(dtpAppliJobEXI);

            // cmd6.Parameters.AddWithValue("@CGender", gender);
            conn8 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            conn8.Open();
            string query8 = "INSERT INTO  Booking_Birthday_Slot(ID,Username,Event,Date,Shift) VALUES('" + id + "','" + username + "','" + ev + "','" + dat + "','" + shift + "')";
            SqlCommand cmd8 = new SqlCommand(query8, conn8);




            int rows = cmd8.ExecuteNonQuery();



            if (rows > 0)
            {
                MessageBox.Show("your apply of booking successful and wait for the approve", "info", MessageBoxButtons.OK);
                //reset();




            }
            else
            {
                MessageBox.Show("Wrong", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn8.Close();
        }

        private void btnCorpo_Click(object sender, EventArgs e)
        {
            string id, username, ev, dat, shift;

            id = txtIDBook.Text;
            username = txtNameBook.Text;
            ev = textBoxEvent.Text;
            dat = textBoxDate.Text;
            shift = textBoxShift.Text;

            //dob1 = Convert.ToString(dtpAppliJobEXI);

            // cmd6.Parameters.AddWithValue("@CGender", gender);
            conn8 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            conn8.Open();
            string query8 = "INSERT INTO  Booking_Corporate_Slot(ID,Username,Event,Date,Shift) VALUES('" + id + "','" + username + "','" + ev + "','" + dat + "','" + shift + "')";
            SqlCommand cmd8 = new SqlCommand(query8, conn8);




            int rows = cmd8.ExecuteNonQuery();



            if (rows > 0)
            {
                MessageBox.Show("your apply of booking successful and wait for the approve", "info", MessageBoxButtons.OK);
                //reset();




            }
            else
            {
                MessageBox.Show("Wrong", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn8.Close();
        }

        private void btnSCVE_Click(object sender, EventArgs e)
        {
            string id, username, ev, dat, shift;

            id = txtIDBook.Text;
            username = txtNameBook.Text;
            ev = textBoxEvent.Text;
            dat = textBoxDate.Text;
            shift = textBoxShift.Text;

            //dob1 = Convert.ToString(dtpAppliJobEXI);

            // cmd6.Parameters.AddWithValue("@CGender", gender);
            conn8 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            conn8.Open();
            string query8 = "INSERT INTO  Booking_SCVEvent_Slot(ID,Username,Event,Date,Shift) VALUES('" + id + "','" + username + "','" + ev + "','" + dat + "','" + shift + "')";
            SqlCommand cmd8 = new SqlCommand(query8, conn8);




            int rows = cmd8.ExecuteNonQuery();



            if (rows > 0)
            {
                MessageBox.Show("your apply of booking successful and wait for the approve", "info", MessageBoxButtons.OK);
                //reset();




            }
            else
            {
                MessageBox.Show("Wrong", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn8.Close();
        }
    }
}
