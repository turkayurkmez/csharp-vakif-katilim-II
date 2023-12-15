namespace DynamicLanguageRuntime
{
    public partial class Form2 : Form, IIncludeFormBag
    {
        public Form2()
        {
            InitializeComponent();
            FormBag = new FormsBag();
        }

        public dynamic FormBag { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = FormBag.Name;
            label2.Text = FormBag.Price.ToString();
            label3.Text = FormBag.Image;
        }
    }
}
