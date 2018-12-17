using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Draw
{

    [Serializable]
    class GroupShape : Shape
    {
        #region Constructor

        public GroupShape(RectangleF rect) : base(rect)
        {
        }

        public GroupShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        #endregion
        public List<Shape> SubItems { get; set; }       
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
            {
                foreach (var item in SubItems)
                {
                    if (item.Contains(point)) return true;
                    
                }
                return false;
            }
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
               
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            foreach (var item in SubItems)
            {
                item.DrawSelf(grfx);
            }
            }

        public override Color FillColor
        {

            set
            {
                foreach (var item in SubItems)
                {

                    item.FillColor = value;


                }
            }
        }


        public override PointF Location
        {
            
            set {
                float dx = value.X - base.Location.X;
                float dy = value.Y - base.Location.Y;


                base.Location = value;
                foreach (var item in SubItems)
                {
                    //???
                }
            }
          
        }

        internal void Resize(float scaleFactor)
        {
            foreach (var element in SubItems)
            {
                if (element is GroupShape)
                {
                    (element as GroupShape).Resize(scaleFactor);
                }
                else
                {
                    element.Width = element.Width * scaleFactor;
                    element.Height = element.Height * scaleFactor;
                }
                InvalidategroupShape();
            }
        }

        private void InvalidategroupShape()
        {
            float minX = float.PositiveInfinity;
            float minY = float.PositiveInfinity;
            float maxX = float.NegativeInfinity; ;
            float maxY = float.NegativeInfinity;
            foreach (var item in SubItems)
            {
                if (minX > item.Location.X) minX = item.Location.X;
                if (minY > item.Location.Y) minY = item.Location.Y;
                if (maxX < item.Location.X + item.Width) maxX = item.Location.X + item.Width;
                if (maxY < item.Location.Y + item.Height) maxY = item.Location.Y + item.Height;
            }
            this.Rectangle = new RectangleF(minX, minY, maxX - minX, maxY - minY);
        }
    }
}

