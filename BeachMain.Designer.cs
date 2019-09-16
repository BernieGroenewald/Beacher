namespace Beacher
{
    partial class BeachMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeachMain));
            this.pMachine = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenDesign = new System.Windows.Forms.ToolStripButton();
            this.tsbCombine = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGCode = new System.Windows.Forms.ToolStripButton();
            this.tsbLoadGCode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTopLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbTopMiddle = new System.Windows.Forms.ToolStripButton();
            this.tsbTopRight = new System.Windows.Forms.ToolStripButton();
            this.tsbMiddleLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbMiddleMiddle = new System.Windows.Forms.ToolStripButton();
            this.tsbMiddleRight = new System.Windows.Forms.ToolStripButton();
            this.tsbBottomLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbBottomMiddle = new System.Windows.Forms.ToolStripButton();
            this.tsbBottomRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUndoLast = new System.Windows.Forms.ToolStripButton();
            this.tsbRedoLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClearDrawing = new System.Windows.Forms.ToolStripButton();
            this.tsbClearScreenOnly = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsbZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsbZoomNormal = new System.Windows.Forms.ToolStripButton();
            this.gbPlay = new System.Windows.Forms.GroupBox();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.tStartY = new System.Windows.Forms.TextBox();
            this.cmdPlayBack = new System.Windows.Forms.Button();
            this.tStartX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdPlayForward = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayBar = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslObjectType = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslX = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslY = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pTools = new System.Windows.Forms.Panel();
            this.ucMachine1 = new Beacher.UCMachine();
            this.ucImage1 = new Beacher.ucImage();
            this.ucPolySpiral1 = new Beacher.UCPolySpiral();
            this.ucPolygon1 = new Beacher.UCPolygon();
            this.ucSpriral1 = new Beacher.UCSpriral();
            this.ucGrid1 = new Beacher.UCGrid();
            this.ucWiper1 = new Beacher.UCWiper();
            this.ucTurtle1 = new Beacher.UCTurtle();
            this.tspbProgress = new System.Windows.Forms.ProgressBar();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEditPoints = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pMachine)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gbPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.pMain.SuspendLayout();
            this.pTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMachine
            // 
            this.pMachine.BackColor = System.Drawing.SystemColors.Window;
            this.pMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMachine.Location = new System.Drawing.Point(3, 3);
            this.pMachine.Name = "pMachine";
            this.pMachine.Size = new System.Drawing.Size(67, 70);
            this.pMachine.TabIndex = 0;
            this.pMachine.TabStop = false;
            this.pMachine.Click += new System.EventHandler(this.pMachine_Click);
            this.pMachine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pMachine_MouseMove);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbSaveAs,
            this.tsbOpenDesign,
            this.tsbCombine,
            this.toolStripSeparator5,
            this.tsbGCode,
            this.tsbLoadGCode,
            this.toolStripSeparator3,
            this.tsbTopLeft,
            this.tsbTopMiddle,
            this.tsbTopRight,
            this.tsbMiddleLeft,
            this.tsbMiddleMiddle,
            this.tsbMiddleRight,
            this.tsbBottomLeft,
            this.tsbBottomMiddle,
            this.tsbBottomRight,
            this.toolStripSeparator1,
            this.tsbUndoLast,
            this.tsbRedoLast,
            this.toolStripSeparator2,
            this.tsbClearDrawing,
            this.tsbClearScreenOnly,
            this.toolStripSeparator4,
            this.tsbZoomIn,
            this.tsbZoomOut,
            this.tsbZoomNormal,
            this.toolStripSeparator6,
            this.tsbEditPoints});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1377, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(36, 36);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbSaveAs
            // 
            this.tsbSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAs.Image")));
            this.tsbSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAs.Name = "tsbSaveAs";
            this.tsbSaveAs.Size = new System.Drawing.Size(36, 36);
            this.tsbSaveAs.Text = "Save As";
            this.tsbSaveAs.Click += new System.EventHandler(this.tsbSaveAs_Click);
            // 
            // tsbOpenDesign
            // 
            this.tsbOpenDesign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenDesign.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenDesign.Image")));
            this.tsbOpenDesign.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOpenDesign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenDesign.Name = "tsbOpenDesign";
            this.tsbOpenDesign.Size = new System.Drawing.Size(36, 36);
            this.tsbOpenDesign.Text = "Open Design";
            this.tsbOpenDesign.Click += new System.EventHandler(this.tsbOpenDesign_Click);
            // 
            // tsbCombine
            // 
            this.tsbCombine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCombine.Image = ((System.Drawing.Image)(resources.GetObject("tsbCombine.Image")));
            this.tsbCombine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCombine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCombine.Name = "tsbCombine";
            this.tsbCombine.Size = new System.Drawing.Size(36, 36);
            this.tsbCombine.Text = "Combine with existing";
            this.tsbCombine.Click += new System.EventHandler(this.tsbCombine_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbGCode
            // 
            this.tsbGCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGCode.Image = ((System.Drawing.Image)(resources.GetObject("tsbGCode.Image")));
            this.tsbGCode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGCode.Name = "tsbGCode";
            this.tsbGCode.Size = new System.Drawing.Size(36, 36);
            this.tsbGCode.Text = "Create G-Code";
            this.tsbGCode.Click += new System.EventHandler(this.tsbGCode_Click);
            // 
            // tsbLoadGCode
            // 
            this.tsbLoadGCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoadGCode.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadGCode.Image")));
            this.tsbLoadGCode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLoadGCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadGCode.Name = "tsbLoadGCode";
            this.tsbLoadGCode.Size = new System.Drawing.Size(36, 36);
            this.tsbLoadGCode.Text = "Load G-Code";
            this.tsbLoadGCode.Click += new System.EventHandler(this.tsbLoadGCode_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbTopLeft
            // 
            this.tsbTopLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTopLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbTopLeft.Image")));
            this.tsbTopLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTopLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTopLeft.Name = "tsbTopLeft";
            this.tsbTopLeft.Size = new System.Drawing.Size(36, 36);
            this.tsbTopLeft.Text = "Move XY Top-Left";
            this.tsbTopLeft.Click += new System.EventHandler(this.tsbTopLeft_Click);
            // 
            // tsbTopMiddle
            // 
            this.tsbTopMiddle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTopMiddle.Image = ((System.Drawing.Image)(resources.GetObject("tsbTopMiddle.Image")));
            this.tsbTopMiddle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTopMiddle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTopMiddle.Name = "tsbTopMiddle";
            this.tsbTopMiddle.Size = new System.Drawing.Size(36, 36);
            this.tsbTopMiddle.Text = "Move XY Top-Centre";
            this.tsbTopMiddle.Click += new System.EventHandler(this.tsbTopMiddle_Click);
            // 
            // tsbTopRight
            // 
            this.tsbTopRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTopRight.Image = ((System.Drawing.Image)(resources.GetObject("tsbTopRight.Image")));
            this.tsbTopRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTopRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTopRight.Name = "tsbTopRight";
            this.tsbTopRight.Size = new System.Drawing.Size(36, 36);
            this.tsbTopRight.Text = "Move XY Top-Right";
            this.tsbTopRight.Click += new System.EventHandler(this.tsbTopRight_Click);
            // 
            // tsbMiddleLeft
            // 
            this.tsbMiddleLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMiddleLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbMiddleLeft.Image")));
            this.tsbMiddleLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMiddleLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMiddleLeft.Name = "tsbMiddleLeft";
            this.tsbMiddleLeft.Size = new System.Drawing.Size(36, 36);
            this.tsbMiddleLeft.Text = "Move XY Centre-Left";
            this.tsbMiddleLeft.Click += new System.EventHandler(this.tsbMiddleLeft_Click);
            // 
            // tsbMiddleMiddle
            // 
            this.tsbMiddleMiddle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMiddleMiddle.Image = ((System.Drawing.Image)(resources.GetObject("tsbMiddleMiddle.Image")));
            this.tsbMiddleMiddle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMiddleMiddle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMiddleMiddle.Name = "tsbMiddleMiddle";
            this.tsbMiddleMiddle.Size = new System.Drawing.Size(36, 36);
            this.tsbMiddleMiddle.Text = "Move XY Centre";
            this.tsbMiddleMiddle.Click += new System.EventHandler(this.tsbMiddleMiddle_Click);
            // 
            // tsbMiddleRight
            // 
            this.tsbMiddleRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMiddleRight.Image = ((System.Drawing.Image)(resources.GetObject("tsbMiddleRight.Image")));
            this.tsbMiddleRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMiddleRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMiddleRight.Name = "tsbMiddleRight";
            this.tsbMiddleRight.Size = new System.Drawing.Size(36, 36);
            this.tsbMiddleRight.Text = "Move XY Centre-Right";
            this.tsbMiddleRight.Click += new System.EventHandler(this.tsbMiddleRight_Click);
            // 
            // tsbBottomLeft
            // 
            this.tsbBottomLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBottomLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbBottomLeft.Image")));
            this.tsbBottomLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBottomLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBottomLeft.Name = "tsbBottomLeft";
            this.tsbBottomLeft.Size = new System.Drawing.Size(36, 36);
            this.tsbBottomLeft.Text = "Move XY Bottom-Left";
            this.tsbBottomLeft.Click += new System.EventHandler(this.tsbBottomLeft_Click);
            // 
            // tsbBottomMiddle
            // 
            this.tsbBottomMiddle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBottomMiddle.Image = ((System.Drawing.Image)(resources.GetObject("tsbBottomMiddle.Image")));
            this.tsbBottomMiddle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBottomMiddle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBottomMiddle.Name = "tsbBottomMiddle";
            this.tsbBottomMiddle.Size = new System.Drawing.Size(36, 36);
            this.tsbBottomMiddle.Text = "Move XY Bottom-Centre";
            this.tsbBottomMiddle.Click += new System.EventHandler(this.tsbBottomMiddle_Click);
            // 
            // tsbBottomRight
            // 
            this.tsbBottomRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBottomRight.Image = ((System.Drawing.Image)(resources.GetObject("tsbBottomRight.Image")));
            this.tsbBottomRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBottomRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBottomRight.Name = "tsbBottomRight";
            this.tsbBottomRight.Size = new System.Drawing.Size(36, 36);
            this.tsbBottomRight.Text = "Move XY Bottom-Right";
            this.tsbBottomRight.Click += new System.EventHandler(this.tsbBottomRight_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbUndoLast
            // 
            this.tsbUndoLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUndoLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbUndoLast.Image")));
            this.tsbUndoLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUndoLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndoLast.Name = "tsbUndoLast";
            this.tsbUndoLast.Size = new System.Drawing.Size(36, 36);
            this.tsbUndoLast.Text = "Undo";
            this.tsbUndoLast.Click += new System.EventHandler(this.tsbUndoLast_Click);
            // 
            // tsbRedoLast
            // 
            this.tsbRedoLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRedoLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbRedoLast.Image")));
            this.tsbRedoLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRedoLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRedoLast.Name = "tsbRedoLast";
            this.tsbRedoLast.Size = new System.Drawing.Size(36, 36);
            this.tsbRedoLast.Text = "Redo";
            this.tsbRedoLast.Click += new System.EventHandler(this.tsbRedoLast_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbClearDrawing
            // 
            this.tsbClearDrawing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClearDrawing.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearDrawing.Image")));
            this.tsbClearDrawing.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClearDrawing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearDrawing.Name = "tsbClearDrawing";
            this.tsbClearDrawing.Size = new System.Drawing.Size(36, 36);
            this.tsbClearDrawing.Text = "Clear Drawing";
            this.tsbClearDrawing.Click += new System.EventHandler(this.tsbClearDrawing_Click);
            // 
            // tsbClearScreenOnly
            // 
            this.tsbClearScreenOnly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClearScreenOnly.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearScreenOnly.Image")));
            this.tsbClearScreenOnly.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClearScreenOnly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearScreenOnly.Name = "tsbClearScreenOnly";
            this.tsbClearScreenOnly.Size = new System.Drawing.Size(36, 36);
            this.tsbClearScreenOnly.Text = "Clear Screen (Keep data)";
            this.tsbClearScreenOnly.Click += new System.EventHandler(this.tsbClearScreenOnly_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbZoomIn
            // 
            this.tsbZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoomIn.Image")));
            this.tsbZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoomIn.Name = "tsbZoomIn";
            this.tsbZoomIn.Size = new System.Drawing.Size(36, 36);
            this.tsbZoomIn.Text = "Zoom In";
            this.tsbZoomIn.Click += new System.EventHandler(this.tsbZoomIn_Click);
            // 
            // tsbZoomOut
            // 
            this.tsbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoomOut.Image")));
            this.tsbZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoomOut.Name = "tsbZoomOut";
            this.tsbZoomOut.Size = new System.Drawing.Size(36, 36);
            this.tsbZoomOut.Text = "Zoom Out";
            this.tsbZoomOut.Click += new System.EventHandler(this.tsbZoomOut_Click);
            // 
            // tsbZoomNormal
            // 
            this.tsbZoomNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZoomNormal.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoomNormal.Image")));
            this.tsbZoomNormal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbZoomNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoomNormal.Name = "tsbZoomNormal";
            this.tsbZoomNormal.Size = new System.Drawing.Size(36, 36);
            this.tsbZoomNormal.Text = "Zoom 1:1";
            this.tsbZoomNormal.Click += new System.EventHandler(this.tsbZoomNormal_Click);
            // 
            // gbPlay
            // 
            this.gbPlay.Controls.Add(this.cmdStop);
            this.gbPlay.Controls.Add(this.cmdPlay);
            this.gbPlay.Controls.Add(this.tStartY);
            this.gbPlay.Controls.Add(this.cmdPlayBack);
            this.gbPlay.Controls.Add(this.tStartX);
            this.gbPlay.Controls.Add(this.label2);
            this.gbPlay.Controls.Add(this.cmdPlayForward);
            this.gbPlay.Controls.Add(this.label1);
            this.gbPlay.Controls.Add(this.PlayBar);
            this.gbPlay.Location = new System.Drawing.Point(12, 42);
            this.gbPlay.Name = "gbPlay";
            this.gbPlay.Size = new System.Drawing.Size(331, 119);
            this.gbPlay.TabIndex = 13;
            this.gbPlay.TabStop = false;
            this.gbPlay.Text = "Play";
            // 
            // cmdStop
            // 
            this.cmdStop.Image = ((System.Drawing.Image)(resources.GetObject("cmdStop.Image")));
            this.cmdStop.Location = new System.Drawing.Point(231, 82);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(38, 33);
            this.cmdStop.TabIndex = 8;
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Image = ((System.Drawing.Image)(resources.GetObject("cmdPlay.Image")));
            this.cmdPlay.Location = new System.Drawing.Point(275, 82);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(38, 33);
            this.cmdPlay.TabIndex = 7;
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // tStartY
            // 
            this.tStartY.Location = new System.Drawing.Point(60, 89);
            this.tStartY.Name = "tStartY";
            this.tStartY.Size = new System.Drawing.Size(78, 20);
            this.tStartY.TabIndex = 6;
            this.tStartY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdPlayBack
            // 
            this.cmdPlayBack.Image = ((System.Drawing.Image)(resources.GetObject("cmdPlayBack.Image")));
            this.cmdPlayBack.Location = new System.Drawing.Point(231, 46);
            this.cmdPlayBack.Name = "cmdPlayBack";
            this.cmdPlayBack.Size = new System.Drawing.Size(38, 33);
            this.cmdPlayBack.TabIndex = 2;
            this.cmdPlayBack.UseVisualStyleBackColor = true;
            this.cmdPlayBack.Click += new System.EventHandler(this.cmdPlayBack_Click);
            // 
            // tStartX
            // 
            this.tStartX.Location = new System.Drawing.Point(60, 63);
            this.tStartX.Name = "tStartX";
            this.tStartX.Size = new System.Drawing.Size(78, 20);
            this.tStartX.TabIndex = 2;
            this.tStartX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Y";
            // 
            // cmdPlayForward
            // 
            this.cmdPlayForward.Image = ((System.Drawing.Image)(resources.GetObject("cmdPlayForward.Image")));
            this.cmdPlayForward.Location = new System.Drawing.Point(275, 46);
            this.cmdPlayForward.Name = "cmdPlayForward";
            this.cmdPlayForward.Size = new System.Drawing.Size(38, 33);
            this.cmdPlayForward.TabIndex = 1;
            this.cmdPlayForward.UseVisualStyleBackColor = true;
            this.cmdPlayForward.Click += new System.EventHandler(this.cmdPlayForward_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start X";
            // 
            // PlayBar
            // 
            this.PlayBar.Location = new System.Drawing.Point(7, 12);
            this.PlayBar.Name = "PlayBar";
            this.PlayBar.Size = new System.Drawing.Size(318, 45);
            this.PlayBar.TabIndex = 0;
            this.PlayBar.Scroll += new System.EventHandler(this.PlayBar_Scroll);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslObjectType,
            this.tsslX,
            this.tsslY});
            this.statusStrip1.Location = new System.Drawing.Point(0, 806);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1377, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslObjectType
            // 
            this.tsslObjectType.Name = "tsslObjectType";
            this.tsslObjectType.Size = new System.Drawing.Size(454, 17);
            this.tsslObjectType.Spring = true;
            // 
            // tsslX
            // 
            this.tsslX.Name = "tsslX";
            this.tsslX.Size = new System.Drawing.Size(454, 17);
            this.tsslX.Spring = true;
            // 
            // tsslY
            // 
            this.tsslY.Name = "tsslY";
            this.tsslY.Size = new System.Drawing.Size(454, 17);
            this.tsslY.Spring = true;
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMain.AutoScroll = true;
            this.pMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pMain.Controls.Add(this.pMachine);
            this.pMain.Location = new System.Drawing.Point(349, 42);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(770, 760);
            this.pMain.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrow_down_blue.png");
            // 
            // pTools
            // 
            this.pTools.AutoScroll = true;
            this.pTools.Controls.Add(this.ucMachine1);
            this.pTools.Controls.Add(this.ucImage1);
            this.pTools.Controls.Add(this.ucPolySpiral1);
            this.pTools.Controls.Add(this.ucPolygon1);
            this.pTools.Controls.Add(this.ucSpriral1);
            this.pTools.Controls.Add(this.ucGrid1);
            this.pTools.Controls.Add(this.ucWiper1);
            this.pTools.Controls.Add(this.ucTurtle1);
            this.pTools.Location = new System.Drawing.Point(13, 167);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(330, 635);
            this.pTools.TabIndex = 6;
            // 
            // ucMachine1
            // 
            this.ucMachine1.Location = new System.Drawing.Point(6, 221);
            this.ucMachine1.Name = "ucMachine1";
            this.ucMachine1.Size = new System.Drawing.Size(303, 25);
            this.ucMachine1.TabIndex = 12;
            // 
            // ucImage1
            // 
            this.ucImage1.Location = new System.Drawing.Point(6, 189);
            this.ucImage1.Name = "ucImage1";
            this.ucImage1.Size = new System.Drawing.Size(306, 25);
            this.ucImage1.TabIndex = 11;
            // 
            // ucPolySpiral1
            // 
            this.ucPolySpiral1.Location = new System.Drawing.Point(6, 158);
            this.ucPolySpiral1.Name = "ucPolySpiral1";
            this.ucPolySpiral1.Size = new System.Drawing.Size(306, 25);
            this.ucPolySpiral1.TabIndex = 10;
            // 
            // ucPolygon1
            // 
            this.ucPolygon1.Location = new System.Drawing.Point(6, 127);
            this.ucPolygon1.Name = "ucPolygon1";
            this.ucPolygon1.Size = new System.Drawing.Size(306, 25);
            this.ucPolygon1.TabIndex = 9;
            // 
            // ucSpriral1
            // 
            this.ucSpriral1.Location = new System.Drawing.Point(6, 96);
            this.ucSpriral1.Name = "ucSpriral1";
            this.ucSpriral1.Size = new System.Drawing.Size(306, 25);
            this.ucSpriral1.TabIndex = 8;
            // 
            // ucGrid1
            // 
            this.ucGrid1.Location = new System.Drawing.Point(6, 34);
            this.ucGrid1.Name = "ucGrid1";
            this.ucGrid1.Size = new System.Drawing.Size(306, 25);
            this.ucGrid1.TabIndex = 7;
            // 
            // ucWiper1
            // 
            this.ucWiper1.Location = new System.Drawing.Point(6, 65);
            this.ucWiper1.Name = "ucWiper1";
            this.ucWiper1.Size = new System.Drawing.Size(306, 25);
            this.ucWiper1.TabIndex = 6;
            // 
            // ucTurtle1
            // 
            this.ucTurtle1.Location = new System.Drawing.Point(6, 3);
            this.ucTurtle1.Name = "ucTurtle1";
            this.ucTurtle1.Size = new System.Drawing.Size(306, 25);
            this.ucTurtle1.TabIndex = 5;
            // 
            // tspbProgress
            // 
            this.tspbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tspbProgress.Location = new System.Drawing.Point(1115, 10);
            this.tspbProgress.Name = "tspbProgress";
            this.tspbProgress.Size = new System.Drawing.Size(250, 24);
            this.tspbProgress.TabIndex = 14;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbEditPoints
            // 
            this.tsbEditPoints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditPoints.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditPoints.Image")));
            this.tsbEditPoints.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditPoints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditPoints.Name = "tsbEditPoints";
            this.tsbEditPoints.Size = new System.Drawing.Size(36, 36);
            this.tsbEditPoints.Text = "Edit Points";
            this.tsbEditPoints.Click += new System.EventHandler(this.tsbEditPoints_Click);
            // 
            // BeachMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 828);
            this.Controls.Add(this.tspbProgress);
            this.Controls.Add(this.gbPlay);
            this.Controls.Add(this.pTools);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BeachMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beacher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BeachMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMachine)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbPlay.ResumeLayout(false);
            this.gbPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pMachine;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslObjectType;
        private System.Windows.Forms.ToolStripStatusLabel tsslX;
        private System.Windows.Forms.ToolStripStatusLabel tsslY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tStartX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tStartY;
        private System.Windows.Forms.ToolStripButton tsbTopLeft;
        private System.Windows.Forms.ToolStripButton tsbTopMiddle;
        private System.Windows.Forms.ToolStripButton tsbTopRight;
        private System.Windows.Forms.ToolStripButton tsbMiddleLeft;
        private System.Windows.Forms.ToolStripButton tsbMiddleMiddle;
        private System.Windows.Forms.ToolStripButton tsbMiddleRight;
        private System.Windows.Forms.ToolStripButton tsbBottomLeft;
        private System.Windows.Forms.ToolStripButton tsbBottomMiddle;
        private System.Windows.Forms.ToolStripButton tsbBottomRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbUndoLast;
        private System.Windows.Forms.ToolStripButton tsbRedoLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbClearDrawing;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbPlay;
        private System.Windows.Forms.TrackBar PlayBar;
        private System.Windows.Forms.Button cmdPlayBack;
        private System.Windows.Forms.Button cmdPlayForward;
        private System.Windows.Forms.ImageList imageList1;
        private UCTurtle ucTurtle1;
        private System.Windows.Forms.Panel pTools;
        private UCWiper ucWiper1;
        private UCGrid ucGrid1;
        private UCSpriral ucSpriral1;
        private UCPolygon ucPolygon1;
        private UCPolySpiral ucPolySpiral1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbOpenDesign;
        private System.Windows.Forms.ToolStripButton tsbSaveAs;
        private System.Windows.Forms.ProgressBar tspbProgress;
        private System.Windows.Forms.ToolStripButton tsbGCode;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.ToolStripButton tsbClearScreenOnly;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private ucImage ucImage1;
        private System.Windows.Forms.ToolStripButton tsbCombine;
        private UCMachine ucMachine1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbLoadGCode;
        private System.Windows.Forms.ToolStripButton tsbZoomIn;
        private System.Windows.Forms.ToolStripButton tsbZoomOut;
        private System.Windows.Forms.ToolStripButton tsbZoomNormal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbEditPoints;
    }
}

