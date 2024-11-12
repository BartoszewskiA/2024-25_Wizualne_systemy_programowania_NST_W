using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w2p01
{
    public partial class Form1 : Form
    {

        Color kolor;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
           // label1.Text += "\nKliknięcie";
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
         richTextBox1.Text += "\nKliknięcie: "+e.X.ToString()+" "+e.Y.ToString();

            if (e.Y < panel1.Height * 0.33)
                panel1.BackColor = Color.FromArgb(255, 200, 200, 200);
            else if (e.Y < panel1.Height * 0.66)
                panel1.BackColor = Color.FromArgb(255, 100, 100, 100);
            else
                panel1.BackColor = Color.FromArgb(255, 50, 50, 50);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
/*            kolor = panel1.BackColor;
            panel1.BackColor = Color.Red;*/
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //panel1.BackColor = kolor;
        }

        private void panel1_Move(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
         /*   kolor = panel1.BackColor;
            panel1.BackColor = Color.Green;*/
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
         /*   panel1.BackColor = kolor;*/
        }
    }
}
