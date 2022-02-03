using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double value;
            bool enable_execute = true;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                {
                    value = Convert.ToDouble(ctrl.Text);
                    if (value != (int)value)
                    {
                        enable_execute = false;
                    }
                }
            }
            execute.Enabled = enable_execute;
        }

        private void execute_Click(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(comboBox1.SelectedItem);
            label1.Text = selected.ToString();
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                {
                    int value = Convert.ToInt32(ctrl.Text);
                    int power = value;
                    for (int i = 1; i < selected; i++)
                    {
                        value *= power;
                    }
                    ctrl.Text = value.ToString();
                }
            }
        }
    }
}
