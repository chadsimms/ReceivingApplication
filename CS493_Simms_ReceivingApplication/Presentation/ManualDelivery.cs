using CS493_Simms_ReceivingApplication.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CS493_Simms_ReceivingApplication.Presentation
{
    public partial class ManualDelivery : Form
    {
        private string selectedVendor;
        private int selectedVendorID;
        private List<ItemTrans> tempOrder = new List<ItemTrans>();
        int caseCount = 0;

        public ManualDelivery(int vendorID)
        {
            this.selectedVendor = Services.DataTransfer.GetVendorNameFromNum(vendorID);
            this.selectedVendorID = vendorID;
            InitializeComponent();
        }

        public void SetList(List<ItemTrans> listDB)
        {
            this.tempOrder = listDB;
        }

        private void ManualDelivery_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();

            vendorLabel.Text = selectedVendor;
            ClearDataOnScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //change focus and enter button to amount being accepted
            deliveryTextBox.Select();
            this.AcceptButton = enterButton;

            if (invoiceTextBox.Text == "" || invoiceTextBox.TextLength == '0')
            {
                MessageBox.Show("Please Enter an Invoice Number first!", "Missing Invoice Number!");
            }
            else
            {
                //find the vendor item
                FindVendorItemInfo();

                if (CheckForSameItem())
                {
                    //find the index in the tempOrder list
                    foreach (ItemTrans obj in tempOrder)
                    {
                        //if the upc matches, then change the value 
                        if (obj.UPC == upcTextBox.Text)
                        {
                            //set the amount to the new delivered amount
                            deliveredLbl.Text = obj.amount.ToString();
                        }
                    }
                }
            }
        }


        private void enterButton_Click(object sender, EventArgs e)
        {
            QueueItemDelivery();
            
            //change focus and enter button to next item input
            upcTextBox.Clear();
            deliveryTextBox.Clear();
            upcTextBox.Select();
            this.AcceptButton = searchButton;
            ClearDataOnScreen();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if(tempOrder.Count != 0)
            {
                DeliveryCheckForm ss = new DeliveryCheckForm(int.Parse(invoiceTextBox.Text), selectedVendor, tempOrder);
                this.Hide();
                ss.Show(this);
            }   
            else
            {
                Owner.Show();
                this.Close();
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //find the index in the tempOrder list
            foreach (ItemTrans obj in tempOrder)
            {
                //if the upc matches, then change the value 
                if (obj.UPC == upcTextBox.Text)
                {
                    //set the amount to the new delivered amount
                    obj.amount = 0;
                    deliveredLbl.Text = obj.amount.ToString();
                }
            }
        }

        private void suspendButton_Click(object sender, EventArgs e)
        {
            float itemCost = 0;

            //find the index in the tempOrder list
            foreach (ItemTrans obj in tempOrder)
            {
                itemCost += (obj.amount * obj.cost);
            }

            if(!Services.DataTransfer.InsertIntoTransTable(int.Parse(invoiceTextBox.Text), vendorLabel.Text, false, itemCost, 0f))
            {
                MessageBox.Show("There was an Error inserting data into table: TRANSACTIONS", "Communication Error!");
            }
            else
            {
                if (!Services.DataTransfer.AddOrderToDB(tempOrder, Services.DataTransfer.GetLastTransactionNumber()))
                {
                    MessageBox.Show("There was an Error inserting data into table: ITEMS", "Communication Error!");
                }
                else
                {
                    tempOrder.Clear();
                    Owner.Show();
                    this.Close();  
                }
            }
        }

        private void upcTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = searchButton;
        }

        private void deliveryTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = enterButton;
        }

        //----------------------------------------------------------------------------
        // Function:    FindVendorItemInfo
        // Description: Used to connect to a database and find the vendor item by UPC
        //              as well as fill in the appropriate textboxes on screen with
        //              corresponding information.
        //----------------------------------------------------------------------------
        private void FindVendorItemInfo()
        {
            string query1 =
                "SELECT * " +
                "FROM Products " +
                "WHERE UPC12 " +
                "LIKE '%'+@Target+'%' " +
                "AND Vendor= " +
                selectedVendorID;

            SqlConnection connection = new SqlConnection(Services.DataAccess.GetConnectionString("ITEMS"));
            using (SqlCommand cmd = new SqlCommand(query1, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {

                cmd.Parameters.AddWithValue("@Target", upcTextBox.Text);
                
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                //fill in the labels for each UPC with product info
                if (dataSet == null || dataSet.Tables == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows == null ||
                    dataSet.Tables[0].Rows.Count == 0 || dataSet.Tables[0].Rows[0].IsNull("Id"))
                {
                    statusLbl.Text = "NOT AUTHORIZED";
                }
                else
                {
                    statusLbl.Text = "OK";
                    upcTextBox.Text = dataSet.Tables[0].Rows[0]["UPC12"].ToString();
                    productLbl.Text = dataSet.Tables[0].Rows[0]["Name"].ToString();
                    sizeLbl.Text = dataSet.Tables[0].Rows[0]["Size"].ToString();
                    costLbl.Text = dataSet.Tables[0].Rows[0]["Cost"].ToString();
                    ohLbl.Text = dataSet.Tables[0].Rows[0]["OnHand"].ToString();
                    weekLbl.Text = dataSet.Tables[0].Rows[0]["SoldWeek"].ToString();
                    monthLbl.Text = dataSet.Tables[0].Rows[0]["SoldMonth"].ToString();
                    yearLbl.Text = dataSet.Tables[0].Rows[0]["SoldYear"].ToString();
                    caseCount = int.Parse(dataSet.Tables[0].Rows[0]["PerCase"].ToString());
                }
            }
        }

        //----------------------------------------------------------------------------
        // Function:    QueueItemDelivery
        // Description: Builds a List of UPCs and amounts that are stored temporarily
        //              until order entry is complete and accepted, then passed off to
        //              database for longer storage.
        //----------------------------------------------------------------------------
        private void QueueItemDelivery()
        {
            if (CheckForSameItem() && tempOrder != null)
            {
                //find the index in the tempOrder list
                foreach (ItemTrans obj in tempOrder)
                {
                    //if the upc matches, then change the value 
                    if (obj.UPC == upcTextBox.Text)
                    {
                        //set the amount to the new delivered amount
                        obj.amount = int.Parse(deliveryTextBox.Text);
                    }
                }
            }

            ////add a new item to the list
            else if (!string.IsNullOrWhiteSpace(deliveryTextBox.Text))
	        {
                tempOrder.Add(new ItemTrans()
                {
                    UPC = upcTextBox.Text,
                    amount = int.Parse(deliveryTextBox.Text),
                    product = productLbl.Text,
                    size = sizeLbl.Text,
                    cost = float.Parse(costLbl.Text),
                    perCase = caseCount
                });
            }
            //else display error message
            else
            {
                MessageBox.Show("Check the data being entered and Try Again", "ERROR");
            }
        }

        //----------------------------------------------------------------------------
        // Function:    CheckForSameItem
        // Description: Will return a boolean value based on if an item UPC in a textbox
        //              corresponds to an item already queued for delivery
        // Return Val:  boolean - True if the Same Item Exists within the list
        //----------------------------------------------------------------------------
        private bool CheckForSameItem()
        {
            //initialize the bool to false
            bool test = false;

            //check each object in tempOrder for UPC
            foreach (ItemTrans obj in tempOrder)
            {
                //if the upc matches, then test is true
                if(obj.UPC == upcTextBox.Text)
                {
                    test = true;
                }
            }

            //return test value
            return test;
        }

        //----------------------------------------------------------------------------
        // Function:    ClearDataOnScreen
        // Description: Clears the relevant labels on the screen 
        //----------------------------------------------------------------------------
        private void ClearDataOnScreen()
        {
            statusLbl.Text = "...";
            productLbl.Text = "...";
            sizeLbl.Text = "...";
            costLbl.Text = "0.00";
            ohLbl.Text = "0";
            weekLbl.Text = "0";
            monthLbl.Text = "0";
            yearLbl.Text = "0";
            deliveredLbl.Text = "0";
        }

        private void invoiceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void upcTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void deliveryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
