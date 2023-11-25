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
    public partial class showinvent : Form
    {
        public showinvent()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form frm = new menuinvent();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
