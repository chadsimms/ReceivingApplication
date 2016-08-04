//*********************************************************************
// Filename: 	    Checkin.cs
//
// Description:     This Checkin Windows Form Class
//
// Author/Designer:	Chad Simms
//**********************************************************************

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
    public partial class VendorCheckinMenu : Form
    {
        public VendorCheckinMenu()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void vendorName_Click(object sender, EventArgs e)
        {
            this.Hide();

            checkinName ss = new checkinName();
            ss.Show(this);
        }

        private void vendorUPC_Click(object sender, EventArgs e)
        {
            this.Hide();

            checkinUPC ss = new checkinUPC();
            ss.Show(this);
        }

        private void Checkin_Load(object sender, EventArgs e)
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
