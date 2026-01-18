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

namespace login_page1
{
    public partial class loginpage : Form
    {
  

        public loginpage()
        {
            InitializeComponent();
        }

        private void btn1login_Click(object sender, EventArgs e)
        {
            string connstr = @"LAPTOP-6UG685U0\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connstr);


            try
            {

                con.Open();
                String qry = "select username,password from register where" +
                    "(username='" + txtuser.Text + "' AND password='" + txtpass.Text + "')";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    con.Close();
                    dash home = new dash();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("username or password error");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("some error + " + ex);
                con.Close();
            }
        }

        private void btn2clear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
