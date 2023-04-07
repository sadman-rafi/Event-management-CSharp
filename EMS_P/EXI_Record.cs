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
    public partial class EXI_Record : Form
    {
        public EXI_Record()
        {
            InitializeComponent();
        }

        private void btnBackEXI_record_Click(object sender, EventArgs e)
        {
            Execuitive exe = new Execuitive();
            exe.Show();
            this.Hide();
        }
    }
}
