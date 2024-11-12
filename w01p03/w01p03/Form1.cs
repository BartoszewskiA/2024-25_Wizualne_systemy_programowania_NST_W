namespace w01p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*            int a = int.Parse(textBox1.Text);
                        int b = int.Parse(textBox2.Text);
                        int c = int.Parse(textBox3.Text)*/
            ;
            int a = 0, b = 0, c = 0;

            if (!int.TryParse(textBox1.Text, out a))
            {
                a = 0;
                textBox1.Text = "0";
            }
            if (!int.TryParse(textBox2.Text, out b))
            {
                b = 0;
                textBox2.Text = "0";
            }
            if (!int.TryParse(textBox3.Text, out c))
            {
                c = 0;
                textBox3.Text = "0";
            }

            textBox4.Text = (a + b + c).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }
    }
}