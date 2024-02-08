namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                label1.Text = "Hello";
            }
            else
            {
                label1.Text = "";
            }
        }
    }
}