using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            int soucet = 0;
            int pocet = 0;
            double prumer;
            if (sudy_toggle.Checked)
            {
                foreach (Control ctrl in input.Controls)
                {
                    int value = Convert.ToInt32(ctrl.Text);
                    if (value % 2 == 0)
                    {
                        soucet += value;
                        pocet++;
                    }
                }
            }
            else if (lichy_toggle.Checked)
            {
                foreach (Control ctrl in input.Controls)
                {
                    int value = Convert.ToInt32(ctrl.Text);
                    if (value % 2 != 0)
                    {
                        soucet += value;
                        pocet++;
                    }
                }
            }
            else
            {
                foreach (Control ctrl in input.Controls)
                {
                    int value = Convert.ToInt32(ctrl.Text);
                    if (value < 0)
                    {
                        soucet += value;
                        pocet++;
                    }
                }
            }
            if (pocet > 0)
            {
                prumer = soucet / (double)pocet;
                output.Text = (": " + prumer);
            }
        }
    }
}
