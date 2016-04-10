using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Engine
{
    public class Sprite
    {
        public Image Image_;    

        public Sprite(String filepath)
        {
            Image_ = Image.FromFile(filepath);
        }

        public void Draw(int x, int y, int w, int l, Graphics g)
        {
            Rectangle r = new Rectangle(x, y, w, l);

            g.DrawImage(Image_, r);
        }
    }
}
