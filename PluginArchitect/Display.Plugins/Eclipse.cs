using Display.Helper;
using System.Drawing;

namespace Display.Plugins
{
    public class Eclipse : IPlugin
    {
        public string Name => "Elips";

        public void Draw(Graphics graphics, Color color, int x, int y, int width, int height)
        {
            SolidBrush solidBrush = new SolidBrush(color);
            graphics.FillEllipse(solidBrush, x, y, width, height);

        }
    }
}