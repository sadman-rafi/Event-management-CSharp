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
    public partial class CEO_LOGIN : Form
    {
        SqlConnection conn5;
        
        public CEO_LOGIN()
        {
            InitializeComponent();
        }

        private void btnLogInCEOLogin_Click(object sender, EventArgs e)
        {
            conn5 = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
            string query5 = "select *FROM CEO_info WHERE Username=@CEO_Name and Password=@CEOPASS";
            SqlCommand cmd5 = new SqlCommand(query5, conn5);


            conn5.Open();
            cmd5.Parameters.Add(new SqlParameter("CEO_Name", textBox1.Text));
            cmd5.Parameters.Add(new SqlParameter("CEOPASS", textBox2.Text));
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            DataTable dt5 = new DataTable();

            da5.Fill(dt5);
            if (dt5.Rows.Count > 0)
            {
                // name = dt2.Rows[0]["Name"].ToString();
                // id = Convert.ToInt32(dt2.Rows[0]["ID"].ToString());
                CEO_Home ch = new CEO_Home();
                ch.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Log in failed,doesn't match id or Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn5.Close();
            //CEO_Home ch = new CEO_Home();
            //ch.Show();
            //this.Hide();
        }

        private void btnBackCEOlogin_Click(object sender, EventArgs e)
        {
            Form1 f3 =new Form1();
            f3.Show();
            this.Hide();
        }
    }
}
