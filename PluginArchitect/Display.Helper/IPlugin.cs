using System.Drawing;

namespace Display.Helper
{
    public interface IPlugin
    {
        string Name { get; }
        void Draw(Graphics graphics, Color color, int x, int y, int width, int height);
    }
}
