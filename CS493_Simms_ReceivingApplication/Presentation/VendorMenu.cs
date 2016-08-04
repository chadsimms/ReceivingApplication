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
    public partial class VendorMenu : Form
    {
        private string selectedVendor;

        public VendorMenu()
        {
            InitializeComponent();
        }

        public VendorMenu(string vendor)
        {
            InitializeComponent();
            this.selectedVendor = vendor;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void VendorMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();

            string query2 = "SELECT * FROM Vendor WHERE id= @Target";

            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("ITEMS"));
            using (SqlCommand cmd = new SqlCommand(query2, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@Target", selectedVendor);

                DataSet vendorInfo = new DataSet();
                adapter.Fill(vendorInfo);

                vendorLbl.Text = vendorInfo.Tables[0].Rows[0]["Name"].ToString();
                idLbl.Text = vendorInfo.Tables[0].Rows[0]["Id"].ToString();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This would re-print an invoice!", "Work In Progress");
        }

        private void deliveryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            ManualDelivery ss = new ManualDelivery(int.Parse(idLbl.Text));
            ss.Show(this);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            ManualReturn ss = new ManualReturn(int.Parse(idLbl.Text));
            ss.Show(this);
        }

        private void ediButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This would bring up a list of EDI Invoices for Selected Vendor!", "Work In Progress");
        }

        private void retriveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            SuspendedRetrievalForm ss = new SuspendedRetrievalForm();
            ss.Show(this);
        }

        private void correctBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            RetrievalForm ss = new RetrievalForm();
            ss.Show(this);
        }
    }
}
