using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p05
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            int soucet = 0;
            int pocet = 0;
            double prumer;
            int value;
            string selected = listBox1.GetItemText(listBox1.SelectedItem);
            foreach (Control ctrl in output.Controls)
            {
                if (ctrl is TextBox)
                {
                    value = Convert.ToInt32(((TextBox)ctrl).Text);
                    soucet += value;
                    pocet++;
                }
                if (ctrl is Label)
                {
                    (ctrl as Label).Text = selected;
                }
            }
            if (pocet > 0)
            {
                prumer = soucet / (double)pocet;
                MessageBox.Show("Aritmetický průměr " + prumer);
            }
        }
    }
}
