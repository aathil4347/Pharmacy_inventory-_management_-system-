using DGVPrinterHelper;
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
    public partial class sellmedicine : Form
    {
        String query;
        DataSet ds;
        myfunction fn = new myfunction();
        public sellmedicine()
        {
            InitializeComponent();
        }

        int valueAmount;
        String valueId;
        protected Int64 noOfunit;

        private void SellMedicine_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select medicinename from addmedicine where expiredate >= getdate() and quanity >'0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void sellmedicine_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellMedicine_Load(this, null);

        }
        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            query = "SELECT medicinename FROM addmedicine  WHERE medicinename LIKE '" + txtserch.Text + "%' AND expiredate >= GETDATE() AND quanity > 0";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (valueId != null && dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Remove the selected row from DataGridView
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    dataGridView1.Rows.RemoveAt(selectedIndex);

                    // Update quantity in the database
                    query = "SELECT quanity FROM addmedicine WHERE medicineid = '" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;

                    query = "UPDATE addmedicine SET quanity = '" + newQuantity + "' WHERE medicineid = '" + valueId + "'";
                    fn.setData(query, "Medicine Removed from Cart.");
                    ClearTextBoxes();

                    // Update total amount
                    totalAmount = totalAmount - valueAmount;
                    totallable.Text = "Rs. " + totalAmount.ToString();

                    // Reload DataGridView if you want to show updated data
                    SellMedicine_Load(this, null);

                    // OPTIONAL: Clear DataGridView if no rows remain
                    if (dataGridView1.Rows.Count == 0)
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date :- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + totallable.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridView1);

            totalAmount = 0;
            totallable.Text = "Rs. 00";
            dataGridView1.DataSource = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totallable_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textmedicinid.Text != "")
            {
                query = "select quanity from addmedicine where medicineid = '" + textmedicinid.Text + "'";
                ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count > 0)  // Check if data exists
                {
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString()); //50
                    newQuantity = quantity - Int64.Parse(textnoofunit.Text); //50-5

                    if (newQuantity >= 0)
                    {
                        n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = textmedicinid.Text;
                        dataGridView1.Rows[n].Cells[1].Value = textmedicname.Text;
                        dataGridView1.Rows[n].Cells[2].Value = dateexpiredate.Text;
                        dataGridView1.Rows[n].Cells[3].Value = textperunit.Text;
                        dataGridView1.Rows[n].Cells[4].Value = textnoofunit.Text;
                        dataGridView1.Rows[n].Cells[5].Value = texttotalprice.Text;

                        totalAmount = totalAmount + int.Parse(texttotalprice.Text);
                        totallable.Text = "Rs. " + totalAmount.ToString();

                        query = "update addmedicine set quanity = '" + newQuantity + "' where medicineid ='" + textmedicinid.Text + "'";
                        fn.setData(query, "Medicine Added.");
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Medicine is out of stock.\nOnly " + quantity + " left", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No medicine found with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select medicine first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearTextBoxes()
        {
            textmedicinid.Clear();
            textmedicname.Clear();
            dateexpiredate.Value = DateTime.Now; // Reset DateTimePicker
            textperunit.Clear();
            textnoofunit.Clear();

        }
    }
}
