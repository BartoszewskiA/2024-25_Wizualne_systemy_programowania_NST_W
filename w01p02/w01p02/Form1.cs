namespace w01p02
{
    public partial class Form1 : Form
    {

        int licznik = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            licznik++;
            label1.Text = licznik.ToString();
        }
    }
}