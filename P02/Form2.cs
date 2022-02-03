using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soucet = 0;
            int pocet = 0;
            double prumer;
            int i = 1;
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    int cislo = Convert.ToInt32(((TextBox)ctrl).Text);
                    if (cislo % 2 != 0)
                    {
                        soucet += cislo;
                        pocet++;
                    }
                }
                if (ctrl is CheckBox)
                {
                    if ((ctrl as CheckBox).Checked == false) (ctrl as CheckBox).Checked = true;
                    else (ctrl as CheckBox).Checked = false;
                } 
                if (ctrl is ListBox)
                {
                    (ctrl as ListBox).Items.Add(textBox1.Text);
                }
                if (ctrl is Button)
                {
                    (ctrl as Button).Text = ("T" + i);
                    i++;
                }
            }
            if (pocet > 0)
            {

                prumer = soucet / (double)pocet;
                label1.Text = ("" + prumer);
            }
        }
    }
}
