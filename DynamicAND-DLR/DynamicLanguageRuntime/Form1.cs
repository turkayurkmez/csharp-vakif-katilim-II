namespace DynamicLanguageRuntime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.FormBag.Name = textBox1.Text;
            form2.FormBag.Price = int.Parse(textBox2.Text);
            form2.FormBag.Image = "varsayın";

            form2.Show();

        }
    }
}