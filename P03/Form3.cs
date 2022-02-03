using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string abeceda = " zyxwvutsqrponmlkjihgfedcba";
            int i = 0;
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button)
                {
                    (ctrl as Button).Text = abeceda[i].ToString();
                    i++;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char character = (sender as Button).Text[0];
            if (character == ' ') textBox1.Text += " ";
            else if (bold_toggle.Checked)
            {
                textBox1.Text += (char)(character - 32);
            }
            else textBox1.Text += (char)(character);
        }
    }
}
