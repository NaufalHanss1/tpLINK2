namespace TPmod2KPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;


            string outputText = "Hello, " + inputText + "!";


            label1.Text = outputText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}