using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tawa
{
    public partial class edit_in : Form
    {
        public edit_in()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new menuinvent();
            frm.Show();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form frm = new menuinvent();
            frm.Show();
            this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Form frm = new edit_in();
            frm.Show();
            this.Hide();
        }

        private void bills_Click(object sender, EventArgs e)
        {
            Form frm = new bills();
            frm.Show();
            this.Hide();
        }

        private void invent_Click(object sender, EventArgs e)
        {
            Form frm = new showinvent();
            frm.Show();
            this.Hide();
        }
    }
}
