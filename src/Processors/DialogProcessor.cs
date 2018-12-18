using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Draw.src.Model;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}

        #endregion

        #region Properties
        /// <summary>
        /// Избран елемент.
        /// </summary>
        private List <Shape> selection = new List<Shape>() ;
        public List<Shape> Selection {
			get { return selection; }
			set { selection = value; }
		}
		
		/// <summary>
		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		/// </summary>
		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}

        public float BoarderWidth { get; set; }
        public ToolSet CurrentTool = ToolSet.Selection;
        #endregion

        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRectangle(bool isRandom = false, int x = 0, int y = 0)
		{
            if (isRandom)
            {
                Random rnd = new Random();
                x = rnd.Next(100, 1000);
                y = rnd.Next(100, 600);
            }
		    			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;
            rect.BoarderColor = Color.Black;
            rect.BoarderWidth = BoarderWidth;

			ShapeList.Add(rect);
		}
		
		/// <summary>
		/// Проверява дали дадена точка е в елемента.
		/// Обхожда в ред обратен на визуализацията с цел намиране на
		/// "най-горния" елемент т.е. този който виждаме под мишката.
		/// </summary>
		/// <param name="point">Указана точка</param>
		/// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
		public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){						
					return ShapeList[i];
				}	
			}
			return null;
		}

        internal void AddEllipse(bool isRandom = false, int x = 0, int y = 0)
        {
            if (isRandom)
            {
                Random rnd = new Random();
                x = rnd.Next(100, 1000);
                y = rnd.Next(100, 600);
            }
            
            EllipseShape rect = new EllipseShape(new Rectangle(x, y, 200, 100));
            rect.FillColor = Color.White;
            rect.BoarderColor = Color.Black;
            rect.BoarderWidth = BoarderWidth;

            ShapeList.Add(rect);
        }

        internal void AddCircle(bool isRandom = false, int x = 0, int y = 0)
        {
            if (isRandom)
            {
                Random rnd = new Random();
                x = rnd.Next(100, 1000);
                y = rnd.Next(100, 600);
            }

            Circle rect = new Circle(new Rectangle(x, y, 200, 200));
            rect.FillColor = Color.White;
            rect.BoarderColor = Color.Black;
            rect.BoarderWidth = BoarderWidth;

            ShapeList.Add(rect);

            
        }

        internal void AddSquare(bool isRandom = false, int x = 0, int y = 0)
        {
            if (isRandom)
            {
                Random rnd = new Random();
                x = rnd.Next(100, 1000);
                y = rnd.Next(100, 600);
            }

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 100));
            rect.FillColor = Color.White;
            rect.BoarderColor = Color.Black;
            rect.BoarderWidth = BoarderWidth;

            ShapeList.Add(rect);


        }

        /// <summary>
        /// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
        /// </summary>
        /// <param name="p">Вектор на транслация.</param>

        public void SetFillColor(Color color)
        {
            foreach (var item in Selection)
            {
                item.FillColor = color;
            }
        }

        public void TranslateTo(PointF p)
		{
            foreach (var item in Selection){
				item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
				
                if (item is GroupShape)
                {
                    foreach(var element in (item as GroupShape).SubItems)
                    {
                        element.Location = new PointF(element.Location.X + p.X - LastLocation.X, element.Location.Y + p.Y - LastLocation.Y);
                    }
                }
			}
            lastLocation = p;
        }

        internal void ChangeSelectedFillColor(Color color)
        {
            foreach (var item in Selection)
            {
                item.FillColor = color;
            }
        }

        public override void Draw(Graphics grfx)
        {
            base.Draw(grfx);
            foreach (var item in Selection)
            {
                grfx.DrawRectangle(Pens.Black, item.Location.X - 3, item.Location.Y - 3, item.Width + 6, item.Height + 6);
            }  
        }

        internal void Group()
        {
            if (Selection.Count < 2)
            {
                return;
            }

            float minX=float.PositiveInfinity;
            float minY=float.PositiveInfinity;
            float maxX = float.NegativeInfinity; ;
            float maxY = float.NegativeInfinity;
            foreach (var item in Selection)
            {
                if (minX > item.Location.X) minX = item.Location.X;
                if (minY > item.Location.Y) minY = item.Location.Y;
                if (maxX < item.Location.X + item.Width) maxX = item.Location.X + item.Width;
                if (maxY < item.Location.Y + item.Height) maxY = item.Location.Y + item.Height;

            }
                GroupShape group = new GroupShape(new RectangleF(minX,minY,maxX-minX,maxY-minY));

                group.SubItems = Selection;

                foreach (var item in Selection)
                {
                    ShapeList.Remove(item);

                }
                Selection = new List<Shape>();
                Selection.Add(group);

                ShapeList.Add(group);


        }

        internal void SelectAll()
        {
            Selection = new List<Shape>(ShapeList);
        }

        internal void Delete()
        {
            foreach (var item in Selection)
            {
                ShapeList.Remove(item);
                Selection = new List<Shape>();
            }
        }
    }
}
