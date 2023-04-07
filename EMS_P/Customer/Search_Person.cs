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
    public partial class Search_Person : Form
    {
        public Search_Person()
        {
            InitializeComponent();
        }

        private void btnshBack_Click(object sender, EventArgs e)
        {
            Customer_Home cust=new Customer_Home();
            cust.Show();
            this.Hide();

        }
    }
}
