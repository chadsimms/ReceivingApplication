using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CS493_Simms_ReceivingApplication.Presentation;

namespace CS493_Simms_ReceivingApplication
{
    public partial class checkinUPC : Form
    {
        public checkinUPC()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void checkinUPC_Load(object sender, EventArgs e)
        {
            upcTextBox.Focus();
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT * FROM Vendor WHERE Id in (SELECT Vendor FROM Products WHERE UPC12 LIKE '%'+@Target+'%')";

            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("ITEMS"));
            using (SqlCommand cmd = new SqlCommand(query2, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@Target", upcTextBox.Text);

                DataTable vendorInfo = new DataTable();
                adapter.Fill(vendorInfo);

                vendorListBox.DisplayMember = "Name";
                vendorListBox.ValueMember = "Id";
                vendorListBox.DataSource = vendorInfo;
            }

            this.AcceptButton = selectButton;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            
            if(vendorListBox.SelectedValue != null)
            {
                VendorMenu ss = new VendorMenu(vendorListBox.SelectedValue.ToString());
                ss.Show(this);
                this.Hide();
            }
            else
            {
                upcTextBox.Focus();
                MessageBox.Show("You have not selected a Vendor, Please try again or Go Back!", "ERROR!");
            }
            
        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void vendorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void upcTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = searchButton;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void upcTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
