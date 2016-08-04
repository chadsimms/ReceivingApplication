using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CS493_Simms_ReceivingApplication
{
    public partial class Login : Form
    {
        private int result = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userTextBox.Text))
            {
                MessageBox.Show("Plese enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userTextBox.Focus();
            }

            string query = "Select * From Login where Username= @USERNAME and Password= @PASSWORD";

            SqlConnection con = new SqlConnection(Services.DataAccess.GetConnectionString("LOGIN"));
            SqlCommand cmd = new SqlCommand(query, con);
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                //identify the type of each parameterized arg
                cmd.Parameters.AddWithValue("@USERNAME", userTextBox.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", passTextBox.Text);

                //con.Open();

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    DSDMenu ss = new DSDMenu();
                    ss.Show();

                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Please Check Your Username and Password");
                    userTextBox.Clear();
                    userTextBox.Focus();
                    passTextBox.Clear();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
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

        private void userTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                passTextBox.Focus();
        }
    }
}
