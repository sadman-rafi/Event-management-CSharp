using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_P
{
    public partial class Customer_Details : Form
    {
        public Customer_Details()
        {
            InitializeComponent();
        }

        private void btnBackCoustomerD_Click(object sender, EventArgs e)
        {
            Customer_Home cuh = new Customer_Home();
            cuh.Show();
            this.Hide();
        }
    }
}
