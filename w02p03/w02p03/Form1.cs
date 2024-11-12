using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           //label1.Text = e.NewValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();
            label2.Text = checkBox1.Checked.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = checkBox1.Checked.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label3.Text = "Wybrano opcję 1";
            else if (radioButton2.Checked)
                label3.Text = "Wybrano opcje 2";
            else if (radioButton3.Checked)
                label3.Text = "wybrano opcje 3";
        }
    }
}
