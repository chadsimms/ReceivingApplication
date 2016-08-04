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
    public partial class ReceivedListForm : Form
    {
        public ReceivedListForm()
        {
            InitializeComponent();
        }

        private void ReceivedListForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();

            PopulateTransList();
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

        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This would print the list if needed", "Work in Progress!");
        }

        //----------------------------------------------------------------------------
        // Function:    PopulateTransList
        // Description: Used to populate the transactions list with Complete orders
        //              Which is set in the query string @ "isComplete= 1"
        //----------------------------------------------------------------------------
        private void PopulateTransList()
        {
            string query = "SELECT invoiceNumber, vendorName, dateTime, totalCost, vendorCost FROM Transactions WHERE isComplete= 1";

            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("TRANSACTIONS"));

            connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable vendorTable = new DataTable();
                adapter.Fill(vendorTable);
                dataGridView.DataSource = vendorTable;
            }
        }
    }
}
