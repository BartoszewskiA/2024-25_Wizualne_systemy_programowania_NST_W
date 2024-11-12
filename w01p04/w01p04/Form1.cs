namespace w01p04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\nLoad";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\nShown";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\nActivate";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\nDeactivate";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           if( MessageBox.Show("Czy zamkn¹æ okno", "pytanie", MessageBoxButtons.YesNo)== DialogResult.No ) {
            e.Cancel = true;
            }
        }
    }
}