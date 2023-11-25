﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace tawa
{
    public partial class deldata : Form
    {
        string ConStr = @"Data Source=CLYDEN\SQLEXPRESS;Initial Catalog = DBMSProj; Integrated Security = True";
        SqlConnection con;
        public deldata()
        {
            InitializeComponent();
            con = new SqlConnection(ConStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("empty feild exists");
            }
            else
            {
                string query = @"DELETE FROM [dbo].[InventoryTable] WHERE item = '" + textBox8.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully!");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConStr))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM InventoryTable", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new inventorymanagement();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
