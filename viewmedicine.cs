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
    public partial class view_medicine : Form
    {
        public view_medicine()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Conyfiguration message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dash loginform = new dash();

                loginform.Show();
                this.Close();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void txtmname_TextChanged(object sender, EventArgs e)
        {

            string connstr = @"LAPTOP-6UG685U0\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connstr);

            string searchText = textBox1.Text.Trim();
            string query = "SELECT medicineid, medicinename, expiredate, quanity FROM addmedicine WHERE (medicinename LIKE @search + '%' OR CAST(medicineid AS NVARCHAR) LIKE @search + '%') AND expiredate >= GETDATE() AND quanity > 0";

            con.Open();
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@search", searchText);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;  // Bind data to DataGridView
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
