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

namespace CS493_Simms_ReceivingApplication
{
    public partial class VendorList : Form
    {
        public VendorList()
        {
            InitializeComponent();
        }

        private void VendorList_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();

            PopulateVendorList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void vendorListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PopulateVendorInfo();
        }

        private void PopulateVendorList()
        {
            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("Items"));
            connection.Open();
            string query = "SELECT * FROM Vendor";

            SqlCommand cmd = new SqlCommand(query, connection);

            DataTable vendorTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                adapter.Fill(vendorTable);
                vendorListBox.DisplayMember = "Name";
                vendorListBox.ValueMember = "Id";
                vendorListBox.DataSource = vendorTable;
            }
        }

        private void PopulateVendorInfo()
        {
            string query2 = "SELECT * FROM Vendor where Id = @Target";

            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("Items"));
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(query2, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))

            {
                cmd.Parameters.AddWithValue("@Target", vendorListBox.SelectedValue);

                DataSet vendorInfo = new DataSet();
                adapter.Fill(vendorInfo);

                vendorTextBox.Text = vendorInfo.Tables[0].Rows[0]["Name"].ToString();
                vendorIdTextBox.Text = vendorInfo.Tables[0].Rows[0]["Id"].ToString();
            }
        }
    }
}
