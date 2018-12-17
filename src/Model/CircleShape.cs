using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    class Circle:Shape
    {
        #region Constructor
        public Circle(RectangleF rect) : base(rect)
        {
        }
        
        public Circle(Circle ellipse)
            : base (ellipse)
        {
        }
        #endregion

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Width);
            grfx.DrawEllipse(new Pen(BoarderColor, BoarderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Width);
        }
    }
}
