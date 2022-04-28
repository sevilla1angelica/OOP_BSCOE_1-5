namespace Sevilla_Ma.Angelica_P_1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ma. Angelica Pereyra Sevilla");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BS Computer Engineering");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Polytechnic University of the Philippines");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hi! You can call me Je!");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hi! You can call me Ange!");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! You can call me Angel!");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! You can call me Sevi!");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! You can call me anything appropriate you would like");
        }
    }
}