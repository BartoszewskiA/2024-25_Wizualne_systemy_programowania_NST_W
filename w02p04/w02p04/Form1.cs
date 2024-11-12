namespace w02p04
{
    public partial class Form1 : Form
    {
        int licznik = 0;
        int czas = 2000;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            licznik++;
            label1.Text = licznik.ToString();
            if (timer1.Interval > 100)
                timer1.Interval -= 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // timer1.Interval = 1001 - e.NewValue * 50;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Interval = 800;
            timer1.Start();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }
    }
}