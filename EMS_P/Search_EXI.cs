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
    public partial class Search_EXI : Form
    {
        public Search_EXI()
        {
            InitializeComponent();
        }

        private void btnBackSearchEXI_Click(object sender, EventArgs e)
        {
            Execuitive exe2 = new Execuitive();
            exe2.Show();
            this.Hide();
        }
    }
}
