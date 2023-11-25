using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace tawa
{
    public partial class login : Form
    {
        string ConStr = @"Data Source=CLYDEN\SQLEXPRESS;Initial Catalog = DBMSProj; Integrated Security = True";
        SqlConnection con;
        SqlDataReader dr;
        public login()
        {
            InitializeComponent();
            con = new SqlConnection(ConStr);
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=CLYDEN\SQLEXPRESS;Initial Catalog=DBMSProj;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Regester_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
       [username]
      ,[password]
  FROM [dbo].[SignUp] WHERE username = '"+textBox2.Text+ "' AND password = '" + textBox3.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form frm = new restaurantmanagement();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid unsername or password!");
            }
            conn.Close();
        }

        private void signnup_Click(object sender, EventArgs e)
        {
            Form frm = new Signup();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text  = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
