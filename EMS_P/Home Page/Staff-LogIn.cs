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
    public partial class Staff_LogIn : Form
    {
        SqlConnection conn3;
        public Staff_LogIn()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f5 = new Form1();
            f5.Show();
            this.Hide();
        }

        private void btnLogInStafflogin_Click(object sender, EventArgs e)
        {
            conn3 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            string query3 = "select *FROM Staff_recorrect_info WHERE Username=@Staff_Name and Password=@StaffPASS";
            SqlCommand cmd3 = new SqlCommand(query3, conn3);


            conn3.Open();
            cmd3.Parameters.Add(new SqlParameter("Staff_Name", txtUsernameStafflogin.Text));
            cmd3.Parameters.Add(new SqlParameter("StaffPASS", txtPasswordStaffLogin.Text));
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();

            da3.Fill(dt3);
            if (dt3.Rows.Count > 0)
            {
                // name = dt2.Rows[0]["Name"].ToString();
                // id = Convert.ToInt32(dt2.Rows[0]["ID"].ToString());
                Staff_Home sh = new Staff_Home();
                sh.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Log in failed,doesn't match id or Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn3.Close();
        }
    }
}
