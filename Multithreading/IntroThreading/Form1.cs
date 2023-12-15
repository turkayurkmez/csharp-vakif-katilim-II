namespace IntroThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tıklandı");
        }

        Thread thread = null;

        private void buttonSay_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(counter));
            thread.Start();

            MessageBox.Show("bitti");
        }

        void counter()
        {
            for (int i = 0; i <= 100000; i++)
            {
                labelCounter.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}