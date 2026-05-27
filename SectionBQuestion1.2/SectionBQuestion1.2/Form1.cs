namespace SectionBQuestion1._2
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           textBox2.Text = "Hello"+" "+ textBox1.Text+  "!";
        }
    }
}
