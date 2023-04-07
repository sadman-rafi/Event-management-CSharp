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
    public partial class Customer_Login : Form
    {
        SqlConnection conn;
        public Customer_Login()
        {
            InitializeComponent();
        }
        public static string name;
        public static int id;


        private void btnBackCustomerLogin_Click(object sender, EventArgs e)
        {
            Form1 fom = new Form1();
            fom.Show();
            this.Hide();
        }

        private void btnLoginCustomerLogin_Click(object sender, EventArgs e)
        {
            
                conn = new SqlConnection(@"Data Source=LAPTOP-DFTNPE37\SQLEXPRESS;Initial Catalog=Project_Event;Integrated Security=True");
                string query = "select *FROM Customer_Info WHERE Username=@Customer_Name and Password=@PASS";
                SqlCommand cmd = new SqlCommand(query, conn);


                conn.Open();
                cmd.Parameters.Add(new SqlParameter("Customer_Name", txtUsernameCustomerLogin.Text));
                cmd.Parameters.Add(new SqlParameter("PASS", txtPassCustomerlogin.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    name = dt.Rows[0]["Name"].ToString();
                    id = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                    Customer_Home chome = new Customer_Home();
                    this.Hide();
                    chome.Show();

                }
                else
                {
                    MessageBox.Show("Log in failed,doesn't match id or Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
           
        }
    }
}
