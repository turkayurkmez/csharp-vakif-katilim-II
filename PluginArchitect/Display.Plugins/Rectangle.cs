using Display.Helper;
using System.Drawing;

namespace Display.Plugins
{
    public class Rectangle : IPlugin
    {
        public string Name => "Dörtgen";

        public void Draw(Graphics graphics, Color color, int x, int y, int width, int height)
        {
            SolidBrush solidBrush = new SolidBrush(color);
            graphics.FillRectangle(solidBrush, x, y, width, height);

        }
    }
}
