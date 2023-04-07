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
    public partial class Sign_Up : Form
    {
        SqlConnection conn6;
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblSignUpBack_Click(object sender, EventArgs e)
        {
            Form1 f15 = new Form1();
            f15.Show();
            this.Hide();
        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {
            string name, username, password, gender = " ", email;
            DateTime dob;
            name = txtName.Text;
            username = txtUsername.Text;
            password = txtPassword.Text;
            email = txtEmail.Text;
            if(rbMale.Checked)
            {
                gender="Male";
            }
            else if(rbFemale.Checked)
            {
                gender="Female";
            }
            else if(rbOthers.Checked)
            {
                gender="others";
            }
             dob=Convert.ToDateTime(dtpSignUp.Text);
            // cmd6.Parameters.AddWithValue("@CGender", gender);
            conn6 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            conn6.Open();
            string query6 = "INSERT INTO  Customer_Info(Name,Username,Password,Gender,Email,DOB) VALUES('"+name+"','"+username+"','"+password+"','"+gender+"','"+email+"','"+dob+"')";
                SqlCommand cmd6 = new SqlCommand(query6, conn6);
     
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
     
                
                int row = cmd6.ExecuteNonQuery();

 

                if (row > 0)
                {
                    MessageBox.Show("your sign up successful and going to Login page", "info", MessageBoxButtons.OK);
                    //reset();
                    Customer_Login clog=new Customer_Login();
                    this.Hide();
                    clog.Show();

 

                }
                else
                {
                    MessageBox.Show("Wrong info or same id", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn6.Close();
            }
            
        }
    }

