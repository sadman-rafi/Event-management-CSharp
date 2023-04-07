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
    public partial class Apply_Job_Staff : Form
    {
        SqlConnection conn8;
        public Apply_Job_Staff()
        {
            InitializeComponent();
        }

        private void btnBackAppliJobStaff_Click(object sender, EventArgs e)
        {
            Form1 f11 = new Form1();
            f11.Show();
            this.Hide();
        }

        private void btnSubmitAppliJobStaff_Click(object sender, EventArgs e)
        {
            string name, username, email, dob1, department;

            name =txtNameAppliJobStaff.Text;
            username = txtUsernameAppliJobStaff.Text;
            email = txtEmailAppliJobStaff.Text;
            dob1 = textBoxS.Text;
            department = txtDEPTAppliJobStaff.Text;
            //dob1 = Convert.ToString(dtpAppliJobEXI);

            // cmd6.Parameters.AddWithValue("@CGender", gender);
            conn8 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            conn8.Open();
            string query8 = "INSERT INTO  Apply_Staff(Name,Username,Email,DOB,Department) VALUES('" + name + "','" + username + "','" + email + "','" + dob1 + "','" + department + "')";
            SqlCommand cmd8 = new SqlCommand(query8, conn8);

            //cmd6.Parameters.AddWithValue("@CNAME", txtName.Text);
            //cmd6.Parameters.AddWithValue("@CUsername", txtUsername.Text);
            //cmd6.Parameters.AddWithValue("@CPassword", txtPassword);
            //if(rbMale.Checked)
            //{
            //    gender="Male";
            //}
            //else if(rbFemale.Checked)
            //{
            //    gender="Female";
            //}
            //else if(rbOthers.Checked)
            //{
            //    gender="others";
            //}
            // cmd6.Parameters.AddWithValue("@CGender", gender);
            //cmd6.Parameters.AddWithValue("@CEmail", txtEmail.Text);
            // dob=Convert.ToDateTime(dtpSignUp.Text);
            //  cmd6.Parameters.AddWithValue("@CDOB", dob);


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
