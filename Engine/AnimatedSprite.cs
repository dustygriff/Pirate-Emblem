using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Engine
{
    /// <summary>
	/// Animated sprites used for characters and misc.
	/// </summary>
    public class AnimatedSprite
    {
        public Image Image_;

        public AnimatedSprite(String filepath)
        {
            Image_ = Image.FromFile(filepath);
        }

        public void Draw(int x, int y, int w, int l, BufferedGraphics buff, int count)
        {
            RectangleF r = new RectangleF((count % 2) * 32, 0, w, l);
            GraphicsUnit units = GraphicsUnit.Pixel;

            buff.Graphics.DrawImage(Image_, 20, 20, r, units);
        }
    }
}
