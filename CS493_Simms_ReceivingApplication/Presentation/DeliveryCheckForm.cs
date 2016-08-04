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
    public partial class DeliveryCheckForm : Form
    {

        private List<ItemTrans> transactions = new List<ItemTrans>();
        private int invoiceNumber = 0;
        private int pieces = 0;
        private float cost = 0;
        private string vendor;

        public DeliveryCheckForm(int invoice, string vendor, List<ItemTrans> order)
        {
            InitializeComponent();

            //carryover the lists from previous windows with constructor
            this.vendor = vendor;
            this.invoiceNumber = invoice;
            this.transactions = order;
        }

        private void DeliveryCheckForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();

            //fill in the table with the information on load

            DataTable table = ConvertToDatatable(transactions);
            dataTableView.DataSource = table;
            calculatePiecesAndCost();
            costTextBox.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void calculatePiecesAndCost()
        {
            //find the index in the tempOrder list
            foreach (ItemTrans obj in transactions)
            {
                pieces += obj.amount;
                cost += (obj.amount * obj.cost);
            }

            pieceLbl.Text = pieces.ToString();
            costLbl.Text = cost.ToString("0.00");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            float inputCost = 0;
            if (cost < 0)
            {
                inputCost = (float.Parse(costTextBox.Text) * -1);
            }
            else
            {
                inputCost = float.Parse(costTextBox.Text);
            }

            //insert the accepted transaction into the transaction table
            //IF not transferred, error message
            if (!Services.DataTransfer.InsertIntoTransTable(invoiceNumber, vendor, true, cost, inputCost))
            {
                MessageBox.Show("Communication Error with: TRANSACTIONS DB, please try again", "ERROR");
            }
            else
            {
                //insert the accepted items from the transaction into the items table
                //IF not transferred, error message
                if (!Services.DataTransfer.AddOrderToDB(transactions, Services.DataTransfer.GetLastTransactionNumber()))
                {
                    MessageBox.Show("Communication Error with: ITEM DB, please try again", "ERROR");
                }
                else
                {
                    //Update the on hand quantities accordingly
                    //IF not updated, error message
                    if (!Services.DataTransfer.AddQuantitiesOnHand(transactions))
                    {
                        MessageBox.Show("Error updating On Hand Quantities in PRODUCTS DB", "ERROR");
                    }
                }
            }

            DSDMenu ss = new DSDMenu();
            ss.Show();
            this.Close();
        }

        private static DataTable ConvertToDatatable<T>(List<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
