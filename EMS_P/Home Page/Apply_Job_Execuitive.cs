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
    public partial class Apply_Job_Execuitive : Form
    {
        SqlConnection conn7;
        public Apply_Job_Execuitive()
        {
            InitializeComponent();
        }

        private void btnBackAppliJobEXI_Click(object sender, EventArgs e)
        {
            Form1 f10 = new Form1();
            f10.Show();
            this.Hide();
        }

        private void btnSubmitAppliJobEXI_Click(object sender, EventArgs e)
        {
            string name, username, email, dob1,department;
            
            name = txtNameAppliJobEXI.Text;
            username = txtUsernameAppliJobEXI.Text;
            email = txtEmailAppliJobEXI.Text;
            dob1 = textBoxDOBE.Text;
            department = txtDEPTAppliJobEXI.Text;
            //dob1 = Convert.ToString(dtpAppliJobEXI);
           
            // cmd6.Parameters.AddWithValue("@CGender", gender);
            conn7 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            conn7.Open();
            string query7 = "INSERT INTO  Apply_Execuitive(Name,Username,Email,DOB,Department) VALUES('" + name + "','" + username + "','" + email + "','" + dob1 + "','"+department+"')";
            SqlCommand cmd7 = new SqlCommand(query7, conn7);

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


            int rows = cmd7.ExecuteNonQuery();



            if (rows > 0)
            {
                MessageBox.Show("your apply successful and wait for the approve", "info", MessageBoxButtons.OK);
                //reset();
                



            }
            else
            {
                MessageBox.Show("Wrong", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn7.Close();
        }
    }
}
