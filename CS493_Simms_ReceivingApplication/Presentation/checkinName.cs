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

namespace CS493_Simms_ReceivingApplication.Presentation
{
    public partial class checkinName : Form
    {
        public checkinName()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkinName_Load(object sender, EventArgs e)
        {
            nameTextBox.Focus();
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (vendorListBox.SelectedValue != null)
            {
                VendorMenu ss = new VendorMenu(vendorListBox.SelectedValue.ToString());
                ss.Show(this);
                this.Hide();
            }
            else
            {
                nameTextBox.Focus();
                MessageBox.Show("You have not selected a Vendor, Please try again or Go Back!", "ERROR!");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT * FROM Vendor WHERE Name LIKE '%'+@Target+'%'";

            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("ITEMS"));
            using (SqlCommand cmd = new SqlCommand(query2, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@Target", nameTextBox.Text);

                DataTable vendorInfo = new DataTable();
                adapter.Fill(vendorInfo);

                vendorListBox.DisplayMember = "Name";
                vendorListBox.ValueMember = "Id";
                vendorListBox.DataSource = vendorInfo;
            }

            this.AcceptButton = selectButton;
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = searchButton;
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
