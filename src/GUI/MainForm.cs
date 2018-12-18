using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Draw.src.Model;


namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();

        public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateButtonsState();
            WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Изход от програмата. Затваря главната форма, а с това и програмата.
        /// </summary>
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}

        /// <summary>
        /// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        /// </summary>
        void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}
		
		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
            dialogProcessor.CurrentTool = ToolSet.DrawRectangle;
            UpdateButtonsState();
        }

		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            if (dialogProcessor.CurrentTool == ToolSet.Selection)
            {
                Shape selectedShape = dialogProcessor.ContainsPoint(e.Location);

                if (selectedShape == null)
                {
                    return;
                }

                if (dialogProcessor.Selection.Contains(selectedShape))
                {
                    dialogProcessor.Selection.Remove(selectedShape);
                }
                else
                {
                    dialogProcessor.Selection.Add(selectedShape);
                }
                statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                dialogProcessor.IsDragging = true;
                dialogProcessor.LastLocation = e.Location;
                viewPort.Invalidate();
                //ReloadShapesList();
            }
            else if(dialogProcessor.CurrentTool == ToolSet.DrawEllipse)
            {
                dialogProcessor.AddEllipse(false, e.X, e.Y);
                viewPort.Invalidate();
                //ReloadShapesList();
            }
            else if(dialogProcessor.CurrentTool == ToolSet.DrawRectangle)
            {
                dialogProcessor.AddRectangle(false, e.X, e.Y);
                viewPort.Invalidate();
            }
            else if(dialogProcessor.CurrentTool == ToolSet.DrawCircle)
            {
                dialogProcessor.AddCircle(false, e.X, e.Y);
                viewPort.Invalidate();
                //ReloadShapesList();
            }
            else if(dialogProcessor.CurrentTool == ToolSet.DrawSquare)
            {
                dialogProcessor.AddSquare(false, e.X, e.Y);
                viewPort.Invalidate();
            }
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
           if (dialogProcessor.IsDragging)
            {
                if (dialogProcessor.Selection != null)
                {
                    statusBar.Items[0].Text = "Последно действие: Влачене";
                }
                dialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
            }
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

        private void drawEllipseSpeedButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.CurrentTool = ToolSet.DrawEllipse;
            UpdateButtonsState();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                dialogProcessor.ChangeSelectedFillColor(colorDialog1.Color);
                viewPort.Invalidate();
            }
        }

        private void pickUpSpeedButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.CurrentTool = ToolSet.Selection;
            UpdateButtonsState();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dialogProcessor.Group();
            viewPort.Invalidate();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.Delete();
            viewPort.Invalidate();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectAll();
            viewPort.Invalidate();

        }

        //private void ReloadShapesList()
        //{
        //    comboShapes.Items.Clear();

        //    foreach (Shape sh in dialogProcessor.ShapeList)
        //    {
        //        comboShapes.Items.Add(sh.Name);
        //    }
        //}

        private void UpdateButtonsState()
        {
            pickUpSpeedButton.Checked =
                       drawEllipseSpeedButton.Checked =
                       drawRectangleSpeedButton.Checked =
                       drawCircleSpeedButton.Checked =
                       drawSquareSpeedButton.Checked = false;

            switch (dialogProcessor.CurrentTool)
            {
                case ToolSet.Selection:
                    pickUpSpeedButton.Checked = true;
                    viewPort.Cursor = Cursors.Arrow;
                    break;
                case ToolSet.DrawEllipse:
                    drawEllipseSpeedButton.Checked = true;
                    viewPort.Cursor = Cursors.Hand;
                    break;
                case ToolSet.DrawRectangle:
                    drawRectangleSpeedButton.Checked = true;
                    viewPort.Cursor = Cursors.Hand;
                    break;
                case ToolSet.DrawCircle:
                    drawCircleSpeedButton.Checked = true;
                    viewPort.Cursor = Cursors.Hand;
                    break;
                case ToolSet.DrawSquare:
                    drawSquareSpeedButton.Checked = true;
                    viewPort.Cursor = Cursors.Hand;
                    break;
            }
        }

        private void boarderWidthSelect_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine(e.ClickedItem.Tag);
            float width = Convert.ToInt32(e.ClickedItem.Tag);
            dialogProcessor.BoarderWidth = width;

            boarderWidthSelect.Text = $"Size: {width} pt";

            foreach (var element in dialogProcessor.Selection)
            {
                element.BoarderWidth = width;
            }
            viewPort.Invalidate();
        }

        private void groupBtn_Click(object sender, EventArgs e)
        {
            dialogProcessor.Group();
            viewPort.Invalidate();
        }

        private void buttonIncreaseSize_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection)
            {
                Scaling(item, 1.2f);
            }
            viewPort.Invalidate();
        }

        private void buttonDecreaseSize_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection)
            {
                Scaling(item, 0.8f);
            }
            viewPort.Invalidate();
        }

        private static void Scaling(Shape item, float factor)
        {
            item.Width = item.Width * factor;
            item.Height = item.Height * factor;

            if (item is GroupShape)
            {
                (item as GroupShape).Resize(factor);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            dialogProcessor.Delete();
            viewPort.Invalidate();
        }

        private void drawRectangleSpeedButton_DoubleClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRectangle(true);
            viewPort.Invalidate();
        }

        private void drawEllipseSpeedButton_DoubleClick(object sender, EventArgs e)
        {
            dialogProcessor.AddEllipse(true);
            viewPort.Invalidate();
        }

        private void drawSquareSpeedButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.CurrentTool = ToolSet.DrawSquare;
            UpdateButtonsState();
        }

        private void drawCircleSpeedButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.CurrentTool = ToolSet.DrawCircle;
            UpdateButtonsState();
        }

        private void drawSquareSpeedButton_DoubleClick(object sender, EventArgs e)
        {
            dialogProcessor.AddSquare(true);
            viewPort.Invalidate();
        }

        private void drawCircleSpeedButton_DoubleClick(object sender, EventArgs e)
        {
            dialogProcessor.AddCircle(true);
            viewPort.Invalidate();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddCircle(true);
            viewPort.Invalidate();
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddSquare(true);
            viewPort.Invalidate();
        }
    }
}
