using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ZAD5
{
    public class CollisionDetector
    {
        /// <summary>
        /// Calculates if rectangles describing two sprites
        /// are overlapping on screen.
        /// </summary>
        /// <param name="s1">First sprite</param>
        /// <param name="s2">Second sprite</param>
        /// <returns>Returns true if overlapping</returns>
        public static bool Overlaps(Sprite s1, Sprite s2)
        {
            Rectangle RectA = new Rectangle((int)s1.Position.X, (int)s1.Position.Y, s1.Size.Width, s1.Size.Height);
            Rectangle RectB = new Rectangle((int)s2.Position.X, (int)s2.Position.Y, s2.Size.Width, s2.Size.Height);
            if (Rectangle.Intersect(RectA, RectB) != Rectangle.Empty) return true;
            return false;
        }
    }
}
