using CS493_Simms_ReceivingApplication.Services;
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
    public partial class RetrievalForm : Form
    {
        /*indexes are as follows:
                Index 0 = transactionNumber
                Index 1 = vendorName
                Index 2 = isComplete
                Index 3 = dateTime
                Index 4 = invoiceNumber
                Index 5 = totalCost
                Index 6 = vendorCost
            */
        private List<string> suspended = new List<string>();
        private List<ItemTrans> listDB = new List<ItemTrans>();

        //get the selected row in the transaction list info
        int selectedTrans = 0;

        public RetrievalForm()
        {
            InitializeComponent();
        }

        private void RetrievalForm_Load(object sender, EventArgs e)
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

        private void selectButton_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentRow.Index;
            selectedTrans = int.Parse(dataGridView[0, row].Value.ToString());

            //update a list with the information from that transaction
            suspended = Services.DataTransfer.RetrieveDBTransactionInfo(selectedTrans);

            if(float.Parse(suspended.ElementAt(5)) < 0)
            {
                MessageBox.Show("Changed Not Allowed On Return Transactions", "ERROR");
            }
            else
            {
                //update a list with all the items with transaction # selectedTrans
                List<ItemTrans> listDB = new List<ItemTrans>(Services.DataTransfer.RetrieveItemsDB(selectedTrans));

                //delete previously stored transaction items with selectedTrans
                if (!Services.DataTransfer.DeleteItemsWithTransNum(selectedTrans))
                {
                    MessageBox.Show("Error Deleting Old Items with Transaction Number: " + selectedTrans, "ERROR!");
                }
                else
                {
                    //delete the old data with old transaction number
                    if (!Services.DataTransfer.DeleteTransaction(selectedTrans))
                    {
                        MessageBox.Show("Error Deleting Old Transaction Info in Transactions.Transactions DB", "ERROR!");
                    }
                }

                //subtract the amounts on hand from current amounts until updated again
                Services.DataTransfer.SubtractQuantitiesOnHand(listDB);

                //open the receiving window with list to correct
                ManualDelivery ss = new ManualDelivery(Services.DataTransfer.GetVendorNumFromName(suspended.ElementAt(1)));
                ss.SetList(listDB);
                ss.Show();
                this.Close();
            }

        }

        //----------------------------------------------------------------------------
        // Function:    PopulateTransList
        // Description: Used to populate the transactions list with incomplete orders
        //              Which is set in the query string @ "isComplete= 0"
        //----------------------------------------------------------------------------
        private void PopulateTransList()
        {
            string query = "SELECT transactionNumber, invoiceNumber, vendorName, dateTime, totalCost FROM Transactions WHERE isComplete= 1";

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
