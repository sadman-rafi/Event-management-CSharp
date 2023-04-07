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
    public partial class Execuitive : Form
    {
        public Execuitive()
        {
            InitializeComponent();
        }

        private void btnLogoutExicuitive_Click(object sender, EventArgs e)
        {
            Execuitive_Login exl = new Execuitive_Login();
            exl.Show();
            this.Hide();
        }

        private void btnRecordExi_Click(object sender, EventArgs e)
        {
            EXI_Record exr = new EXI_Record();
            exr.Show();
            this.Hide();
        }

        private void btnSearchExi_Click(object sender, EventArgs e)
        {
            Search_EXI seaxi = new Search_EXI();
            seaxi.Show();
            this.Hide();
        }

        private void btnManageSlotsExi_Click(object sender, EventArgs e)
        {
            Manage_Slot_Count msc = new Manage_Slot_Count();
            msc.Show();
            this.Hide();
        }

        private void btnCheckPaymentExi_Click(object sender, EventArgs e)
        {
            Check_payment chp = new Check_payment();
            chp.Show();
            this.Hide();

        }

        private void btnSetWorkExi_Click(object sender, EventArgs e)
        {
            Set_Work sw = new Set_Work();
            sw.Show();
            this.Hide();
        }

        private void btnAddNewExi_Click(object sender, EventArgs e)
        {
            NEW_ADD nwa = new NEW_ADD();
            nwa.Show();
            this.Hide();
        }
    }
}
