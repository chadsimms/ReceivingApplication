using CS493_Simms_ReceivingApplication.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS493_Simms_ReceivingApplication
{
    public partial class DSDMenu : Form
    {
        public DSDMenu()
        {
            InitializeComponent();
        }

        private void receivedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceivedListForm ss = new ReceivedListForm();
            ss.Show(this);
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            Login ss = new Login();
            ss.Show();
            this.Close();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendorList ss = new VendorList();
            ss.Show(this);
        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendorCheckinMenu ss = new VendorCheckinMenu();
            ss.Show(this);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
