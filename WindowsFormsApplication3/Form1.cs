using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);   // чего я блять сломала
            int from = int.Parse(textBox1.Text);
            int to = int.Parse(textBox2.Text);
            rnd.Next(from, to);
            if (textBox1.Text == textBox2.Text || int.Parse(textBox1.Text) > 9999999 || int.Parse(textBox2.Text) > 9999999 || textBox1.Text == null || textBox2.Text == null || int.Parse(textBox2.Text) < int.Parse(textBox1.Text))
            {
                MessageBox.Show("incorrect value");
            }
            else
            {
                MessageBox.Show(rnd.Next(from, to).ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
