using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    class MercedesLogo : Shape
    {
        static int nameCounter = 0;

        #region Constructor

        public MercedesLogo(RectangleF rect) : base(rect)
        {
        }

        public MercedesLogo(Circle ellipse)
            : base(ellipse)
        {
        }

        #endregion

        /// <summary>
        ///  Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            int sides = 3;
            int angle = 90;
            int radius = 100;
            float step = 360.0f / sides;
            PointF[] nPoints;
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Width);

            grfx.DrawEllipse(new Pen(BoarderColor, BoarderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Width);

            //Point center = new Point((int)this.Width / 2, (int)this.Height / 2);
            Point center = new Point((int)(Rectangle.X + Rectangle.Width / 2), (int)(Rectangle.Y + Rectangle.Width / 2));

            nPoints = CalculateVertices(sides, radius, angle, center);
            for (int i = 0; i < sides; i++)
            {
                grfx.DrawLine(Pens.Black, center.X, center.Y, nPoints[i].X, nPoints[i].Y);
            }
        }

        private PointF[] CalculateVertices(int sides, int radius, float startingAngle, Point center)
        {
            if (sides < 3)
            {
                sides = 3;
            }
            //throw new ArgumentException("Polygon must have 3 sides or more.");

            List<PointF> points = new List<PointF>();
            float step = 360.0f / sides;

            float angle = startingAngle; //starting angle
            for (double i = startingAngle; i < startingAngle + 360.0; i += step) //go in a circle
            {
                points.Add(DegreesToXY(angle, radius, center));
                angle += step;
            }

            return points.ToArray();
        }

        // this is your code unchanged
        private PointF DegreesToXY(float degrees, float radius, Point origin)
        {
            PointF xy = new PointF();
            double radians = degrees * Math.PI / 180.0;

            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);

            return xy;
        }

    }
}
