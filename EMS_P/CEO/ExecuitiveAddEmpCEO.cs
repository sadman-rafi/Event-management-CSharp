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
    public partial class ExecuitiveAddEmpCEO : Form
    {
        public ExecuitiveAddEmpCEO()
        {
            InitializeComponent();
        }

        private void btnBackAddempEXI_Click(object sender, EventArgs e)
        {
            Add_Employee_ceo_ aec1 = new Add_Employee_ceo_();
            aec1.Show();
            this.Hide();
        }
    }
}
