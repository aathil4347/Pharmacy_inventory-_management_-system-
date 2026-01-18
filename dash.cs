using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_page1
{
    public partial class dash : Form
    {
        public dash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pharmasist p = new pharmasist();
            p.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMedicine p = new AddMedicine();
            p.Show(); this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_medicine p = new view_medicine();
            p.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sellmedicine p = new sellmedicine();
            p.Show(); this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginpage p = new loginpage();
            p.Show(); this.Hide();
        }
    }
}
