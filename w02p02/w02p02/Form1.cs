using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p02
{
    public partial class Form1 : Form
    {

        int licznik = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                licznik++;
            else if (e.KeyCode == Keys.Down)
                licznik--;
            else if (e.KeyCode == Keys.Escape)
                licznik = 0;
            label1.Text = licznik.ToString();
        }
    }
}
