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
    public partial class Apply_Job_Volunteer : Form
    {
        SqlConnection conn8;
        public Apply_Job_Volunteer()
        {
            InitializeComponent();
        }

        private void btnBackAppliJobV_Click(object sender, EventArgs e)
        {
            Form1 f12 = new Form1();
            f12.Show();
            this.Hide();
        }

        private void btnSubmitAppliJobV_Click(object sender, EventArgs e)
        {
            string name, username, email, dob1, department;

            name = txtNameAppliJobV.Text;
            username = txtUsernameAppliJobV.Text;
            email = txtEmailAppliJobV.Text; ;
            dob1 = textBoxV.Text;
            department = txtDEPTAppliJobV.Text;
            //dob1 = Convert.ToString(dtpAppliJobEXI);

            // cmd6.Parameters.AddWithValue("@CGender", gender);
            conn8 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            conn8.Open();
            string query8 = "INSERT INTO  Apply_Volunteer(Name,Username,Email,DOB,Department) VALUES('" + name + "','" + username + "','" + email + "','" + dob1 + "','" + department + "')";
            SqlCommand cmd8 = new SqlCommand(query8, conn8);

            


            int rows = cmd8.ExecuteNonQuery();



            if (rows > 0)
            {
                MessageBox.Show("your apply successful and wait for the approve", "info", MessageBoxButtons.OK);
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
