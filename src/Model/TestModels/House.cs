using System;
using System.Drawing;

namespace Draw
{
    /// <summary>
    /// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
    /// </summary>

    [Serializable]
    public class HouseShape : Shape
    {
        static int nameCounter = 0;

        #region Constructor

        public HouseShape(RectangleF rect) : base(rect)
        {
        }

        public HouseShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към правоъгълника.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.DrawRectangle(new Pen(BoarderColor, BoarderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            Point[] myPolygon = new Point[3];

            myPolygon[0] = new Point((int)Rectangle.X, (int)Rectangle.Y);
            myPolygon[1] = new Point((int)(Rectangle.X + Rectangle.Width / 2), (int)(Rectangle.Y - Rectangle.Height / 2));
            myPolygon[2] = new Point((int)(Rectangle.X + Rectangle.Width), (int)Rectangle.Y);

            grfx.DrawPolygon(new Pen(BoarderColor, BoarderWidth), myPolygon);
            grfx.FillPolygon(new SolidBrush(FillColor), myPolygon);

            //grfx.DrawLine(new Pen(BoarderColor, this.PenSize), Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Width / 2, Rectangle.Y - Rectangle.Height / 2);

            //grfx.DrawLine(new Pen(BoarderColor, this.PenSize), Rectangle.X + Rectangle.Width / 2, Rectangle.Y - Rectangle.Height / 2, Rectangle.X + Rectangle.Width, Rectangle.Y);
        }
    }
}
