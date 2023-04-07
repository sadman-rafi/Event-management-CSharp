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
    
    public partial class Execuitive_Login : Form
    {
        SqlConnection conn2;
        public Execuitive_Login()
        {
            InitializeComponent();
        }

        private void btnBackEXILOGIN_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }

        private void btnLogInExicu_Click(object sender, EventArgs e)
        {
            conn2 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            string query2 = "select *FROM Execuitive_info WHERE Username=@Execuitive_Name and Password=@ExiPASS";
            SqlCommand cmd2 = new SqlCommand(query2, conn2);


            conn2.Open();
            cmd2.Parameters.Add(new SqlParameter("Execuitive_Name", txtUsernameExiLogin.Text));
            cmd2.Parameters.Add(new SqlParameter("ExiPASS", txtPassExiLogin.Text));
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {
               // name = dt2.Rows[0]["Name"].ToString();
               // id = Convert.ToInt32(dt2.Rows[0]["ID"].ToString());
                Execuitive exe = new Execuitive();
                this.Hide();
                exe.Show();

            }
            else
            {
                MessageBox.Show("Log in failed,doesn't match id or Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn2.Close();
            /*Execuitive ex = new Execuitive();
            ex.Show();
            this.Hide(); */
        }
    }
}
