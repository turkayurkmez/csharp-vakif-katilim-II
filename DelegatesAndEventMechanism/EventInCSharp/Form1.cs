namespace EventInCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        CategoryService categoryService = new CategoryService();
        private void Form1_Load(object sender, EventArgs e)
        {
            categoryService.NewCategoryCreated += CategoryService_NewCategoryCreated;


            Category category = new Category { Name = "Elektronik" };
            categoryService.Create(category);
        }

        private void CategoryService_NewCategoryCreated(object sender, CreatedCategoryEventArgs e)
        {
            MessageBox.Show($"{e.Category.Name} isimli kategori, {e.User} tarafından {e.CreatedDate} tarihinde eklendi!");
        }

        private void Common_click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
        }

        private void Common_Down(object sender, MouseEventArgs e)
        {
            label1.Text = e.Button.ToString();
        }
    }
}