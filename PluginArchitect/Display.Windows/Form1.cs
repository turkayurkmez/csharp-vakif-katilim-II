using Display.Helper;

namespace Display.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, Plug> plugs = new Dictionary<string, Plug>();
        private void addPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //1. seçilen klasör içindeki tüm pluginleri al...
                var plugins = PluginHelper.GetPlugins(folderBrowserDialog.SelectedPath);

                foreach (var plugin in plugins)
                {
                    ToolStripMenuItem menuItem = new ToolStripMenuItem(plugin.Name);
                    loadadPluginsToolStripMenuItem.DropDownItems.Add(menuItem);
                    plugs.Add(plugin.Name, plugin);
                    menuItem.Click += MenuItem_Click;
                }

            }

        }

        private void MenuItem_Click(object? sender, EventArgs e)
        {
            string plugName = ((ToolStripMenuItem)(sender)).Text;
            var plug = plugs[plugName];
            var plgunInstance = PluginHelper.CreateInstance(plug);

            plgunInstance.Draw(panel1.CreateGraphics(), buttonColor.BackColor, (int)numericUpDownX.Value, (int)numericUpDownY.Value, (int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog.Color;
            }
        }
    }
}