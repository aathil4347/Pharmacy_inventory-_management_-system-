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
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Conyfiguration message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                 dash  da= new dash();

                da.Show();
                this.Close();
                this.Hide();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            manufacturedate.Value = DateTime.Now;
            expireddate.Value = DateTime.Now;
            medicineid.Clear();
            medicinename.Clear();   
            medicinenumber.Clear();
            priceperunit.Clear();   
            quanity.Clear();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connstr = @"LAPTOP-6UG685U0\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connstr);
            try
            {
                String medicineid1 = medicineid.Text;
                String name = medicinename.Text;

                String number = medicinenumber.Text;
                String manudate = manufacturedate.Value.ToString("yyy/MM/dd");
                String expired = expireddate.Value.ToString("yyy/MM/dd");
                String quani = quanity.Text;
                String price = priceperunit.Text;
         


            
                con.Open();

                String qry = "INSERT INTO addmedicine(medicineid, medicinename , medicinenumber, manufacturingdate, expiredate,quanity,priceperunit) VALUES ('" + medicineid1 + "','" + name + "','" + number + "','" + manudate + "','" + expired + "','" + quani + "','" + price + "')";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("added successfully");
                con.Close();



            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }
        }
    }
}
