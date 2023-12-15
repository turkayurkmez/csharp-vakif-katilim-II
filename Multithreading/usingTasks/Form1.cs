namespace usingTasks
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
            MessageBox.Show("Tıklandı");
        }

        private async void buttonSay_Click(object sender, EventArgs e)
        {
            await counter();
            MessageBox.Show("bitti");
        }

        private async Task counter()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5000; i++)
                {
                    labelCounter.Text = i.ToString();
                }
            });
        }
    }
}