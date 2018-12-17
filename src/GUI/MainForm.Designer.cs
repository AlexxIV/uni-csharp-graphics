namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawCircleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawSquareSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBtn = new System.Windows.Forms.ToolStripButton();
            this.btnChangeColor = new System.Windows.Forms.ToolStripButton();
            this.boarderWidthSelect = new System.Windows.Forms.ToolStripDropDownButton();
            this.ptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeLabel = new System.Windows.Forms.ToolStripLabel();
            this.buttonIncreaseSize = new System.Windows.Forms.ToolStripButton();
            this.buttonDecreaseSize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.houseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envelopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.AllowMerge = false;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.devToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(750, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.circleToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.drawRectangleSpeedButton_DoubleClick);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.drawEllipseSpeedButton_DoubleClick);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 478);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(750, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.drawCircleSpeedButton,
            this.drawSquareSpeedButton,
            this.drawRectangleSpeedButton,
            this.drawEllipseSpeedButton,
            this.toolStripSeparator1,
            this.groupBtn,
            this.btnChangeColor,
            this.boarderWidthSelect,
            this.sizeLabel,
            this.buttonIncreaseSize,
            this.buttonDecreaseSize,
            this.toolStripButton1});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(750, 26);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 23);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            this.pickUpSpeedButton.Click += new System.EventHandler(this.pickUpSpeedButton_Click);
            // 
            // drawCircleSpeedButton
            // 
            this.drawCircleSpeedButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.drawCircleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleSpeedButton.DoubleClickEnabled = true;
            this.drawCircleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleSpeedButton.Image")));
            this.drawCircleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleSpeedButton.Name = "drawCircleSpeedButton";
            this.drawCircleSpeedButton.Size = new System.Drawing.Size(23, 23);
            this.drawCircleSpeedButton.Text = "DrawRectangleButton";
            this.drawCircleSpeedButton.Click += new System.EventHandler(this.drawCircleSpeedButton_Click);
            this.drawCircleSpeedButton.DoubleClick += new System.EventHandler(this.drawCircleSpeedButton_DoubleClick);
            // 
            // drawSquareSpeedButton
            // 
            this.drawSquareSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawSquareSpeedButton.DoubleClickEnabled = true;
            this.drawSquareSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawSquareSpeedButton.Image")));
            this.drawSquareSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawSquareSpeedButton.Name = "drawSquareSpeedButton";
            this.drawSquareSpeedButton.Size = new System.Drawing.Size(23, 23);
            this.drawSquareSpeedButton.Text = "DrawRectangleButton";
            this.drawSquareSpeedButton.Click += new System.EventHandler(this.drawSquareSpeedButton_Click);
            this.drawSquareSpeedButton.DoubleClick += new System.EventHandler(this.drawSquareSpeedButton_DoubleClick);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.DoubleClickEnabled = true;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(23, 23);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            this.drawRectangleSpeedButton.DoubleClick += new System.EventHandler(this.drawRectangleSpeedButton_DoubleClick);
            // 
            // drawEllipseSpeedButton
            // 
            this.drawEllipseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseSpeedButton.DoubleClickEnabled = true;
            this.drawEllipseSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseSpeedButton.Image")));
            this.drawEllipseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseSpeedButton.Name = "drawEllipseSpeedButton";
            this.drawEllipseSpeedButton.Size = new System.Drawing.Size(23, 23);
            this.drawEllipseSpeedButton.Text = "toolStripButton1";
            this.drawEllipseSpeedButton.Click += new System.EventHandler(this.drawEllipseSpeedButton_Click);
            this.drawEllipseSpeedButton.DoubleClick += new System.EventHandler(this.drawEllipseSpeedButton_DoubleClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // groupBtn
            // 
            this.groupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupBtn.Image = ((System.Drawing.Image)(resources.GetObject("groupBtn.Image")));
            this.groupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(23, 23);
            this.groupBtn.Text = "toolStripButton1";
            this.groupBtn.Click += new System.EventHandler(this.groupBtn_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeColor.Image")));
            this.btnChangeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(87, 23);
            this.btnChangeColor.Text = "SelectColor";
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // boarderWidthSelect
            // 
            this.boarderWidthSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boarderWidthSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ptToolStripMenuItem,
            this.ptToolStripMenuItem1,
            this.ptToolStripMenuItem2,
            this.ptToolStripMenuItem3,
            this.ptToolStripMenuItem4});
            this.boarderWidthSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boarderWidthSelect.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.boarderWidthSelect.Name = "boarderWidthSelect";
            this.boarderWidthSelect.Size = new System.Drawing.Size(66, 23);
            this.boarderWidthSelect.Text = "Size: 1 pt";
            this.boarderWidthSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.boarderWidthSelect.ToolTipText = "Size";
            this.boarderWidthSelect.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.boarderWidthSelect_DropDownItemClicked);
            // 
            // ptToolStripMenuItem
            // 
            this.ptToolStripMenuItem.Name = "ptToolStripMenuItem";
            this.ptToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ptToolStripMenuItem.Tag = "1";
            this.ptToolStripMenuItem.Text = "1 pt";
            // 
            // ptToolStripMenuItem1
            // 
            this.ptToolStripMenuItem1.Name = "ptToolStripMenuItem1";
            this.ptToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.ptToolStripMenuItem1.Tag = "2";
            this.ptToolStripMenuItem1.Text = "2 pt";
            // 
            // ptToolStripMenuItem2
            // 
            this.ptToolStripMenuItem2.Name = "ptToolStripMenuItem2";
            this.ptToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.ptToolStripMenuItem2.Tag = "4";
            this.ptToolStripMenuItem2.Text = "4 pt";
            // 
            // ptToolStripMenuItem3
            // 
            this.ptToolStripMenuItem3.Name = "ptToolStripMenuItem3";
            this.ptToolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.ptToolStripMenuItem3.Tag = "8";
            this.ptToolStripMenuItem3.Text = "8 pt";
            // 
            // ptToolStripMenuItem4
            // 
            this.ptToolStripMenuItem4.Name = "ptToolStripMenuItem4";
            this.ptToolStripMenuItem4.Size = new System.Drawing.Size(100, 22);
            this.ptToolStripMenuItem4.Tag = "16";
            this.ptToolStripMenuItem4.Text = "16 pt";
            // 
            // sizeLabel
            // 
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(37, 23);
            this.sizeLabel.Text = "Scale:";
            // 
            // buttonIncreaseSize
            // 
            this.buttonIncreaseSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonIncreaseSize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonIncreaseSize.Image = ((System.Drawing.Image)(resources.GetObject("buttonIncreaseSize.Image")));
            this.buttonIncreaseSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonIncreaseSize.Name = "buttonIncreaseSize";
            this.buttonIncreaseSize.Size = new System.Drawing.Size(23, 23);
            this.buttonIncreaseSize.Text = "+";
            this.buttonIncreaseSize.Click += new System.EventHandler(this.buttonIncreaseSize_Click);
            // 
            // buttonDecreaseSize
            // 
            this.buttonDecreaseSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonDecreaseSize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDecreaseSize.Image = ((System.Drawing.Image)(resources.GetObject("buttonDecreaseSize.Image")));
            this.buttonDecreaseSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDecreaseSize.Name = "buttonDecreaseSize";
            this.buttonDecreaseSize.Size = new System.Drawing.Size(23, 23);
            this.buttonDecreaseSize.Text = "-";
            this.buttonDecreaseSize.Click += new System.EventHandler(this.buttonDecreaseSize_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.toolStripButton1.Size = new System.Drawing.Size(72, 23);
            this.toolStripButton1.Text = "X";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(750, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 50);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(750, 428);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // devToolStripMenuItem
            // 
            this.devToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mercedesToolStripMenuItem,
            this.houseToolStripMenuItem,
            this.envelopeToolStripMenuItem});
            this.devToolStripMenuItem.Name = "devToolStripMenuItem";
            this.devToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.devToolStripMenuItem.Text = "Dev";
            // 
            // mercedesToolStripMenuItem
            // 
            this.mercedesToolStripMenuItem.Name = "mercedesToolStripMenuItem";
            this.mercedesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mercedesToolStripMenuItem.Text = "Mercedes";
            this.mercedesToolStripMenuItem.Click += new System.EventHandler(this.mercedesToolStripMenuItem_Click);
            // 
            // houseToolStripMenuItem
            // 
            this.houseToolStripMenuItem.Name = "houseToolStripMenuItem";
            this.houseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.houseToolStripMenuItem.Text = "House";
            this.houseToolStripMenuItem.Click += new System.EventHandler(this.houseToolStripMenuItem_Click);
            // 
            // envelopeToolStripMenuItem
            // 
            this.envelopeToolStripMenuItem.Name = "envelopeToolStripMenuItem";
            this.envelopeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.envelopeToolStripMenuItem.Text = "Envelope";
            this.envelopeToolStripMenuItem.Click += new System.EventHandler(this.envelopeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton drawEllipseSpeedButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnChangeColor;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton boarderWidthSelect;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton groupBtn;
        private System.Windows.Forms.ToolStripButton buttonIncreaseSize;
        private System.Windows.Forms.ToolStripButton buttonDecreaseSize;
        private System.Windows.Forms.ToolStripLabel sizeLabel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton drawCircleSpeedButton;
        private System.Windows.Forms.ToolStripButton drawSquareSpeedButton;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem houseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envelopeToolStripMenuItem;
    }
}
