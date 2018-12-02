using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
        public bool StartPainting { get; set; }
        //Graphics g;
        public int? InitX { get; set; }
        public int? InitY { get; set; }
        public float PenWidth { get; set; }
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
        #endregion

        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;
            rect.BoarderColor = Color.Black;

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
					//ShapeList[i].FillColor = Color.Red;
						
					return ShapeList[i];
				}	
			}
			return null;
		}

        internal void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape rect = new EllipseShape(new Rectangle(x, y, 200, 100));
            rect.FillColor = Color.White;
            rect.BoarderColor = Color.Black;

            ShapeList.Add(rect);
        }

        internal void AddRandomDot(bool line = false)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);


            RectangleShape rect = new RectangleShape(new Rectangle(x, y, line ? 50 : 1, 1));
            rect.FillColor = Color.White;
            rect.BoarderColor = Color.Black;

            ShapeList.Add(rect);
        }

        internal void FreeDraw(Graphics grfx, int x, int y)
        {
            Pen p = new Pen(Color.Black, this.PenWidth);
            grfx.DrawLine(p, new Point(this.InitX ?? x, this.InitY ?? y), new Point(x, y));
            this.InitX = x;
            this.InitY = y;
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
            //if (selection != null)
            foreach (var item in Selection){
				item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
				
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
        public void SaveAs(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ShapeList);
            fs.Close();
                //filemode ima za otvarqne i dr...
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
