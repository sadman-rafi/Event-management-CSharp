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
    public partial class VOL_login : Form
    {
        SqlConnection conn4;
        public VOL_login()
        {
            InitializeComponent();
        }

        private void btnBackVolLogIn_Click(object sender, EventArgs e)
        {
            Form1 f7 = new Form1();
            f7.Show();
            this.Hide();
        }

        private void btnLoginVolLogin_Click(object sender, EventArgs e)
        {
            conn4 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            string query4 = "select *FROM Volunteer_info WHERE Username=@Vol_Name and Password=@VolPASS";
            SqlCommand cmd4 = new SqlCommand(query4, conn4);


            conn4.Open();
            cmd4.Parameters.Add(new SqlParameter("Vol_Name", txtUsernameVolLogin.Text));
            cmd4.Parameters.Add(new SqlParameter("VolPASS", txtPasswordVolLogin.Text));
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();

            da4.Fill(dt4);
            if (dt4.Rows.Count > 0)
            {
                // name = dt2.Rows[0]["Name"].ToString();
                // id = Convert.ToInt32(dt2.Rows[0]["ID"].ToString());
                Vol_Home vh1 = new Vol_Home();
                vh1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Log in failed,doesn't match id or Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn4.Close();

            
        }
    }
}
