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
    public partial class pharmasist : Form
    {
        public pharmasist()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Conyfiguration message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dash loginform = new dash();

                loginform.Show();
                this.Close();
                this.Hide();
            }





        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtMNumber.Clear();
            txtEmail.Clear();
            txtpassw.Clear();
            txtUname.Clear();
            datetime.Value = DateTime.Now;
        }

        private void datetime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connstr = @"LAPTOP-6UG685U0\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connstr))
            {
                try
                {
                    string name = txtName.Text;
                    string email = txtEmail.Text;
                    string phone = txtMNumber.Text;
                    string password = txtpassw.Text;
                    string username = txtUname.Text;
                    string userrole = txtName.Text;
                    DateTime dob = datetime.Value;

                    string qry = @"INSERT INTO register 
                      (userrole, name, dob, phonenumber, email, username, password) 
                      VALUES 
                      (@userrole, @name, @dob, @phone, @email, @username, @password)";

                    SqlCommand cmd = new SqlCommand(qry, con);

                    cmd.Parameters.AddWithValue("@userrole", userrole);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
