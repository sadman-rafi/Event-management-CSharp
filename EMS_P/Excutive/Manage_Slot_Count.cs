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
    public partial class Manage_Slot_Count : Form
    {
        public Manage_Slot_Count()
        {
            InitializeComponent();
        }

        private void btnBackManageSlot_Click(object sender, EventArgs e)
        {
            Execuitive exe3 = new Execuitive();
            exe3.Show();
            this.Hide();
        }
    }
}
