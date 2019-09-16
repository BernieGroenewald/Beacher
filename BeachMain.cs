using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beacher
{
    public partial class BeachMain : Form
    {
        GeneralStuff gs = new GeneralStuff();

        double MachineX = 1000;
        double MachineY = 1000;
        double LastX = 0;
        double LastY = 0;
        bool BusyDrawing = false;
        int PartOfPattern = 0;
        bool GridDrawn = false;
        double TurtleAngle = 0;
        int GridMeasureX = 10;
        int GridMeasureY = 10;
        string GridTypeSelected = "mm";
        string CurrentDesignName = string.Empty;
        string WiperClearType = "None";
        int ImageCurrentWidth = 0;
        int ImageCurrentHeight = 0;
        string ImageXPos = "Left";
        string ImageYPos = "Top";

        string MachineStartCode = string.Empty;
        string MachineEndCode = string.Empty;
        string MachineDefaultSpeed = string.Empty;
        string MachineBitmapSpeed = string.Empty;
        string MachineXSize = string.Empty;
        string MachineYSize = string.Empty;

        double ZoomFactor = 1;

        string ImageCurrentFileName = string.Empty;
        Graphics gPic = null;

        List<VertexPoint> AllPoints = new List<VertexPoint>();
        List<VertexPoint> RedoPoints = new List<VertexPoint>();

        DataStuffLight ds;
        
        Color ColConnector = Color.Red;
        Color ColSpiral = Color.Blue;
        Color ColWiper = Color.Green;
        Color ColPolygon = Color.Blue;
        Color ColPolySpiral = Color.Blue;
        Color ColTurtleForward = Color.Black;
        Color ColTurtleOffset = Color.Red;
        Color ColGrid = Color.Aqua;

        Timer PlayTimer = new Timer();

        Bitmap bmp;

        public BeachMain()
        {
            InitializeComponent();
        }

        private void SetMachineDisplay()
        {
            try
            {
                Rectangle screen = Screen.PrimaryScreen.WorkingArea;

                pMain.Top = toolStrip1.Top + toolStrip1.Height + 10;
                pMain.Height = screen.Height - pMain.Top - statusStrip1.Height - 30;

                pMachine.Parent = pMain;
                pMachine.Width = Convert.ToInt32(MachineX * ZoomFactor);
                pMachine.Height = Convert.ToInt32(MachineY * ZoomFactor);

                if (pMachine.Width < screen.Width - pMain.Left - 30)
                {
                    pMain.Width = pMachine.Width + 20;
                }

                pTools.Height = screen.Height - pMain.Top - gbPlay.Height - statusStrip1.Height - 30;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Sorry. too many pixels...", "Zoom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ZoomFactor -= 0.25;

                RedrawAll(0);
                return;
            }
        }

        private void AddConnector(double NewX, double NewY)
        {
            VertexPoint vp = new VertexPoint();

            if (!DiscardElementsTrackBarChanged())
            {
                return;
            }

            PartOfPattern++;

            vp.PartOfPattern = PartOfPattern;
            vp.PatternType = "Connector";
            vp.x = NewX;
            vp.y = NewY;

            AllPoints.Add(vp);
            
            SetNewBitmap();

            using (Graphics g = Graphics.FromImage(pMachine.Image))
            {
                DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColConnector, g);
            }

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();

            pMachine.Invalidate();

            RedrawAll(0);
        }
              
        private void SetNewBitmap()
        {
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    if (bmp != null)
                    {
                        bmp.Dispose(); //Without this, memory goes nuts
                    }

                    bmp = new Bitmap(pMachine.Width, pMachine.Height);
                    pMachine.Image = bmp;

                    if (!string.IsNullOrEmpty(ImageCurrentFileName))
                    {
                        GetThumbnails();
                    }
                }

                catch { }

                this.Invoke((MethodInvoker)delegate
                {
                    pMachine.Image = bmp;
                });

                GC.Collect(); //Without this, memory goes nuts
            });
        }  

        private void RedrawAll(int UpToValue)
        {
            int Counter = 0;
            bool WiperClearDone = false;

            LastX = 0;
            LastY = 0;

            Color pen = Color.Black;

            BusyDrawing = true;

            SetNewBitmap();

            if (GridDrawn)
            {
                ReDrawGrid(false);
            }

            foreach (VertexPoint vp in AllPoints)
            {
                switch (vp.PatternType)
                {
                    case "Connector":
                        pen = ColConnector;
                        WiperClearDone = false;
                        break;

                    case "Spiral":
                        pen = ColSpiral;
                        WiperClearDone = false;
                        break;

                    case "Wiper":

                        if (!WiperClearDone)
                        {
                            if (WiperClearType == "Before")
                            {
                                SetNewBitmap();
                            }

                            WiperClearDone = true;
                        }

                        pen = ColWiper;
                        break;

                    case "Polygon":
                        pen = ColPolygon;
                        WiperClearDone = false;
                        break;

                    case "PolySpiral":
                        pen = ColPolySpiral;
                        WiperClearDone = false;
                        break;

                    case "Turtle Forward":
                        pen = ColTurtleForward;
                        WiperClearDone = false;
                        break;

                    case "Bitmap Trace":
                        pen = ColTurtleForward;
                        WiperClearDone = false;
                        break;

                    case "Turtle Offset":
                        pen = ColTurtleOffset;
                        WiperClearDone = false;
                        break;

                    default:
                        WiperClearDone = false;
                        break;
                }

                using (Graphics g = Graphics.FromImage(pMachine.Image))
                {
                    DrawLine((int)((LastX) * ZoomFactor) , (int)((LastY) * ZoomFactor), (int)((vp.x) * ZoomFactor), (int)((vp.y) * ZoomFactor), 1, pen, g);

                    LastX = vp.x;
                    LastY = vp.y;
                }

                Counter++;

                if (UpToValue > 0)
                {
                    if (UpToValue <= Counter)
                    {
                        break;
                    }
                }
            }

            pMachine.Invalidate();
            
            BusyDrawing = false;

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();

            SetTrackBar(UpToValue);
        }

        private void SetTrackBar(int SetValue)
        {
            PlayBar.Maximum = AllPoints.Count;

            if (SetValue > 0)
            {
                if (SetValue <= PlayBar.Maximum)
                {
                    PlayBar.Value = SetValue;
                }
            }
            else
            {
                PlayBar.Value = PlayBar.Maximum;
            }
        }

        private void AddGridLines(int XLines, int YLines)
        {
            int XSpace = pMachine.Width / XLines;
            int YSpace = pMachine.Height / YLines;

            SetNewBitmap();

            for (int x = XSpace; x < pMachine.Width; x+=XSpace)
            {
                using (Graphics g = Graphics.FromImage(pMachine.Image))
                {
                    DrawLine(x, 0, x, pMachine.Height, 1, ColGrid, g);
                }
            }

            for (int x = YSpace; x < pMachine.Height; x += YSpace)
            {
                using (Graphics g = Graphics.FromImage(pMachine.Image))
                {
                    DrawLine(0, x, pMachine.Height, x, 1, ColGrid, g);
                }
            }

            pMachine.Invalidate();

            GridDrawn = true;
        }

        private void AddGridmm(int XLineSpace, int YLineSpace)
        {
            int XSpace = XLineSpace;
            int YSpace = YLineSpace;

            for (int x = XSpace; x < pMachine.Width; x += XSpace)
            {
                using (Graphics g = Graphics.FromImage(pMachine.Image))
                {
                    DrawLine(x, 0, x, pMachine.Height, 1, ColGrid, g);
                }
            }

            for (int x = YSpace; x < pMachine.Height; x += YSpace)
            {
                using (Graphics g = Graphics.FromImage(pMachine.Image))
                {
                    DrawLine(0, x, pMachine.Height, x, 1, ColGrid, g);
                }
            }

            pMachine.Invalidate();

            GridDrawn = true;
        }

        private void DrawString(string StringIn, Font font, RectangleF rect, Color colour, Graphics page, StringFormat format)
        {
            SolidBrush myBrush = new SolidBrush(colour);
            page.DrawString(StringIn, font, myBrush, rect, format);
            myBrush.Dispose();
        }

        private void DrawBox(Rectangle rect, Color colour, Graphics page)
        {
            SolidBrush myBrush = new SolidBrush(colour);
            page.FillRectangle(myBrush, rect);
            myBrush.Dispose();
        }

        private void DrawFrame(Rectangle rect, float PenWidth, Color colour, Graphics page)
        {
            Pen p = new Pen(colour, PenWidth);
            page.DrawRectangle(p, rect);
        }

        private void DrawLine(int x1, int y1, int x2, int y2, float PenWidth, Color colour, Graphics page)
        {
            Pen p = new Pen(colour, PenWidth);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            page.DrawLine(p, p1, p2);
        }

        private void BeachMain_Load(object sender, EventArgs e)
        {
            GlobalStatic.ConnectionString = "Data Source=" + Application.StartupPath + @"\Beacher.sqlite;Version=3;";

            ds = new DataStuffLight();

            using (DataStuffLight dsl = new DataStuffLight())
            {
                dsl.LoadDataStore(Application.StartupPath + @"\Beacher.sqlite");
            }

            LoadMachineData();
            
            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();

            LoadTurtleToolbox();
            LoadWiperToolbox();
            LoadGridToolbox();
            LoadSpiralToolbox();
            LoadPolygonToolbox();
            LoadPolySpiralToolbox();
            LoadImageToolbox();
            LoadSettingsToolbox();

            ToolboxChange();

            CurrentDesignName = "";
            this.Text = "Beacher";
            tspbProgress.Visible = false;

            PlayTimer.Interval = 10;
            PlayTimer.Tick += PlayTimer_Tick;
            cmdStop.Enabled = false;
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            if (PlayBar.Value + 1 < PlayBar.Maximum)
            {
                PlayBar.Value++;
                RedrawAll(PlayBar.Value);
                cmdStop.Enabled = true;
                cmdPlay.Enabled = false;
            }
            else
            {
                cmdStop.Enabled = false;
                cmdPlay.Enabled = true;
                PlayTimer.Stop();
            }
        }

        private void LoadGridToolbox()
        {
            ucGrid1.GridClear += GridClear;
            ucGrid1.DrawGrid += DrawGrid;
            ucGrid1.ToolboxChange += ToolboxChange;
        }

        private void DrawGrid(string GridType, int MeasureX, int MeasureY)
        {
            GridMeasureX = MeasureX;
            GridMeasureY = MeasureY;
            GridTypeSelected = GridType;

            ReDrawGrid(true);
        }

        private void GridClear()
        {
            if (GridDrawn)
            {
                RedrawAll(0);
                GridDrawn = false;
            }
        }

        private void LoadTurtleToolbox()
        {
            ucTurtle1.TurtleAngle = TurtleAngle;
            ucTurtle1.MoveTurtleForward += MoveTurtleForward;
            ucTurtle1.CreateTurtleStar += CreateTurtleStar;
            ucTurtle1.TurtleToolboxChange += ToolboxChange;
        }

        private void LoadSpiralToolbox()
        {
            ucSpriral1.ToolboxChange += ToolboxChange;
            ucSpriral1.DrawSpiral += DrawSpiral;
        }

        private void LoadPolygonToolbox()
        {
            ucPolygon1.ToolboxChange += ToolboxChange;
            ucPolygon1.DrawPoly += DrawPoly;
        }

        private void LoadImageToolbox()
        {
            ucImage1.ToolboxChange += ToolboxChange;
            ucImage1.ImageFileChanged += ImageFileChanged;
            ucImage1.ImagePositionChanged += ImagePositionChanged;
            ucImage1.ImageSizeChanged += ImageSizeChanged;
            ucImage1.ImageTraceClicked += ImageTraceClicked;
        }
        
        private void ImageTraceClicked(bool InsideOut)
        {
            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);

            Bitmap myBitmap = new Bitmap(ImageCurrentFileName);

            Image myThumbnail = myBitmap.GetThumbnailImage(ImageCurrentWidth, ImageCurrentHeight, myCallback, IntPtr.Zero);

            BorderFinder bf = new BorderFinder();

            List<Point[]> returnregions = new List<Point[]>();

            returnregions = bf.Find((Bitmap)myThumbnail, true);

            if (gPic == null)
            {
                gPic = pMachine.CreateGraphics();
            }

            gPic.Clear(Color.White);

            GraphicsPath gp = new GraphicsPath();

            PartOfPattern++;

            int ImageX = 0;
            int ImageY = 0;

            switch (ImageXPos)
            {
                case "Left":
                    ImageX = 0;
                    break;

                case "Right":
                    ImageX = pMachine.Width - ImageCurrentWidth;
                    break;

                case "Centre":
                    ImageX = (pMachine.Width / 2) - (ImageCurrentWidth / 2);
                    break;

                default:
                    break;
            }

            switch (ImageYPos)
            {
                case "Top":
                    ImageY = 0;
                    break;

                case "Bottom":
                    ImageY = pMachine.Height - ImageCurrentHeight;
                    break;

                case "Centre":
                    ImageY = (pMachine.Height / 2) - (ImageCurrentHeight / 2);
                    break;

                default:
                    break;
            }

            if (InsideOut)
            {
                for (int i = returnregions.Count - 1; i >= 0; i--)
                {
                    gp.AddLines(returnregions[i]);

                    for (int x = 0; x < returnregions[i].Count(); x++)
                    {
                        VertexPoint vp = new VertexPoint();
                        Point p = new Point();
                        p = returnregions[i][x];
                        vp.x = p.X + ImageX;
                        vp.y = p.Y + ImageY;
                        vp.PartOfPattern = PartOfPattern;
                        vp.PatternType = "Bitmap Trace";

                        AllPoints.Add(vp);
                    }
                }
            }
            else
            {
                for (int i = 0; i < returnregions.Count; i++)
                {
                    gp.AddLines(returnregions[i]);

                    for (int x = 0; x < returnregions[i].Count(); x++)
                    {
                        VertexPoint vp = new VertexPoint();
                        Point p = new Point();
                        p = returnregions[i][x];
                        vp.x = p.X + ImageX;
                        vp.y = p.Y + ImageY;
                        vp.PartOfPattern = PartOfPattern;
                        vp.PatternType = "Bitmap Trace";

                        AllPoints.Add(vp);
                    }
                }
            }

            RedrawAll(0);
        }

        private void ImageSizeChanged(string PlusOrMinus)
        {
            if (PlusOrMinus == "+")
            {
                if ((ImageCurrentHeight + (ImageCurrentHeight * 5 / 100) <= pMachine.Height) && (ImageCurrentWidth + (ImageCurrentWidth * 5 / 100) <= pMachine.Width))
                {
                    if ((ImageCurrentHeight * 5 / 100) <= 1)
                    {
                        ImageCurrentHeight = ImageCurrentHeight + 1;
                        ImageCurrentWidth = ImageCurrentWidth + 1;
                    }
                    else
                    {
                        ImageCurrentHeight = ImageCurrentHeight + (ImageCurrentHeight * 5 / 100);
                        ImageCurrentWidth = ImageCurrentWidth + (ImageCurrentWidth * 5 / 100);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                if ((ImageCurrentHeight - (ImageCurrentHeight * 5 / 100) > 0) && (ImageCurrentWidth - (ImageCurrentWidth * 5 / 100) > 0))
                {
                    ImageCurrentHeight = ImageCurrentHeight - (ImageCurrentHeight * 5 / 100);
                    ImageCurrentWidth = ImageCurrentWidth - (ImageCurrentWidth * 5 / 100);
                }
                else
                {
                    return;
                }
            }

            GetThumbnails();
        }

        private void ImagePositionChanged(string NewPosition)
        {
            switch (NewPosition)
            {
                case "TopLeft":
                    ImageXPos = "Left";
                    ImageYPos = "Top";
                    break;

                case "TopCentre":
                    ImageXPos = "Centre";
                    ImageYPos = "Top";
                    break;

                case "TopRight":
                    ImageXPos = "Right";
                    ImageYPos = "Top";
                    break;

                case "LeftCentre":
                    ImageXPos = "Left";
                    ImageYPos = "Centre";
                    break;

                case "RightCentre":
                    ImageXPos = "Right";
                    ImageYPos = "Centre";
                    break;

                case "Centre":
                    ImageXPos = "Centre";
                    ImageYPos = "Centre";
                    break;

                case "BottomLeft":
                    ImageXPos = "Left";
                    ImageYPos = "Bottom";
                    break;

                case "BottomCentre":
                    ImageXPos = "Centre";
                    ImageYPos = "Bottom";
                    break;

                case "BottomRight":
                    ImageXPos = "Right";
                    ImageYPos = "Bottom";
                    break;

                default:
                    break;
            }

            GetThumbnails();
        }

        private void ImageFileChanged(string FileName)
        {
            try
            {
                ImageCurrentFileName = FileName;

                Bitmap Tmp = new Bitmap(ImageCurrentFileName);

                ImageCurrentHeight = Tmp.Height;
                ImageCurrentWidth = Tmp.Width;
                GetThumbnails();
            }

            catch
            {
            }
        }

        
        private void LoadPolySpiralToolbox()
        {
            ucPolySpiral1.ToolboxChange += ToolboxChange;
            ucPolySpiral1.DrawPolySpiral += DrawPolySpiral;
        }

        private void DrawPolySpiral(double IncrementAngle, double SideLength, int Revolutions, string StopAt, double IncrementSide)
        {
            if (!DiscardElementsTrackBarChanged())
            {
                return;
            }

            BusyDrawing = true;

            PartOfPattern++;

            double.TryParse(tStartX.Text, out LastX);
            double.TryParse(tStartY.Text, out LastY);
            
            List<VertexPoint> points = new List<VertexPoint>();
            
            points = gs.GetPolySpiralPoints(LastX, LastY, IncrementAngle, SideLength, Revolutions, PartOfPattern, StopAt, IncrementSide);

            SetNewBitmap();

            using (Graphics g = Graphics.FromImage(pMachine.Image))
            {
                foreach (VertexPoint vp in points)
                {
                    DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColPolySpiral, g);
                    LastX = vp.x;
                    LastY = vp.y;

                    AllPoints.Add(vp);
                }

                tStartX.Text = LastX.ToString();
                tStartY.Text = LastY.ToString();
            }

            pMachine.Invalidate();

            BusyDrawing = false;

            RedrawAll(0);
        }

        private void DrawPoly(int NumberOfSides, int SideLength)
        {
            if ((tStartX.Text == "") || (tStartY.Text == "") || BusyDrawing)
            {
                return;
            }

            if (!DiscardElementsTrackBarChanged())
            {
                return;
            }

            BusyDrawing = true;

            double.TryParse(tStartX.Text, out LastX);
            double.TryParse(tStartY.Text, out LastY);

            PartOfPattern++;

            List<VertexPoint> points = new List<VertexPoint>();

            points = gs.PolygonPoints(LastX, LastY, NumberOfSides, SideLength, PartOfPattern);

            SetNewBitmap();

            using (Graphics g = Graphics.FromImage(pMachine.Image))
            {
                foreach (VertexPoint vp in points)
                {
                    DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColPolygon, g);
                    LastX = vp.x;
                    LastY = vp.y;
                }

                tStartX.Text = LastX.ToString();
                tStartY.Text = LastY.ToString();
            }

            pMachine.Invalidate();

            BusyDrawing = false;
        }

        private void DrawSpiral(GeneralStuff.SpiralType SpiralType, double SpiralOffset, double SpiralDegrees, double MaxSize, string StopAt, string Direction, string InOrOut)
        {
            if (!DiscardElementsTrackBarChanged())
            {
                return;
            }

            BusyDrawing = true;

            PartOfPattern++;

            double.TryParse(tStartX.Text, out LastX);
            double.TryParse(tStartY.Text, out LastY);

            List<VertexPoint> points = new List<VertexPoint>();

            points = gs.GetSpiralPoints(LastX, LastY, SpiralOffset, SpiralDegrees, MaxSize, PartOfPattern, StopAt, Direction, InOrOut, SpiralType);

            SetNewBitmap();

            using (Graphics g = Graphics.FromImage(pMachine.Image))
            {
                foreach (VertexPoint vp in points)
                {
                    DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColSpiral, g);
                    LastX = vp.x;
                    LastY = vp.y;

                    AllPoints.Add(vp);
                }

                tStartX.Text = LastX.ToString();
                tStartY.Text = LastY.ToString();
            }

            pMachine.Invalidate();

            BusyDrawing = false;

            RedrawAll(0);
        }

        private void ToolboxChange()
        {
            ucWiper1.Top = ucTurtle1.Top + ucTurtle1.Height + 10;
            ucGrid1.Top = ucWiper1.Top + ucWiper1.Height + 10;
            ucSpriral1.Top = ucGrid1.Top + ucGrid1.Height + 10;
            ucPolygon1.Top = ucSpriral1.Top + ucSpriral1.Height;
            ucPolySpiral1.Top = ucPolygon1.Top + ucPolygon1.Height + 10;
            ucImage1.Top = ucPolySpiral1.Top + ucPolySpiral1.Height + 10;
            ucMachine1.Top = ucImage1.Top + ucImage1.Height + 10;
        }

        private void LoadWiperToolbox()
        {
            ucWiper1.Top = ucTurtle1.Top + ucTurtle1.Height + 10;

            ucWiper1.WipeLeftRight += WipeLeftRight;
            ucWiper1.WipeUpDown += WipeUpDown;
            ucWiper1.WipeDiagonal += WipeDiagonal;
            ucWiper1.WipeInsideOut += WipeInsideOut;
            ucWiper1.WipeOutsideIn += WipeOutsideIn;
            ucWiper1.ToolboxChange += ToolboxChange;
            ucWiper1.WipeCls += WipeCls;
        }

        private void LoadSettingsToolbox()
        {
            ucMachine1.Top = ucImage1.Top + ucImage1.Height + 10;

            ucMachine1.SaveClick += Machine_SaveClick;
            ucMachine1.ToolboxChange += ToolboxChange;
        }

        private void LoadMachineData()
        {
            using (DataStuffLight dsl = new DataStuffLight())
            {
                DataTable dt = dsl.GetMachineSettings();

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            switch (row["SettingName"].ToString())
                            {
                                case "MachineSizeX":

                                    MachineXSize = row["SettingValue"].ToString();
                                    break;

                                case "MachineSizeY":

                                    MachineYSize = row["SettingValue"].ToString();
                                    break;

                                case "MachineStartCode":

                                    MachineStartCode = row["SettingValue"].ToString();
                                    break;

                                case "MachineEndCode":

                                    MachineEndCode = row["SettingValue"].ToString();
                                    break;

                                case "MachineDefaultSpeed":

                                    MachineDefaultSpeed = row["SettingValue"].ToString();
                                    break;

                                case "MachineBitmapSpeed":

                                    MachineBitmapSpeed = row["SettingValue"].ToString();
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }

                double.TryParse(MachineXSize, out MachineX);
                double.TryParse(MachineYSize, out MachineY);
                
                if (MachineX <= 100)
                {
                    MachineX = 100;
                }

                if (MachineY <= 100)
                {
                    MachineY = 100;
                }

                gs.MachineMaxX = MachineX;
                gs.MachineMaxY = MachineY;

                SetMachineDisplay();
            }
        }

        private void Machine_SaveClick(string MachineX, string MachineY, string StartCode, string EndCode, string DefaultSpeed, string BitmapSpeed)
        {
            LoadMachineData();
        }

        private void WipeCls(string ClsType)
        {
            WiperClearType = ClsType;
        }

        private void WipeOutsideIn(double Offset)
        {
            PartOfPattern++;

            List<VertexPoint> points = new List<VertexPoint>();

            points = gs.GetWiperOutsideIn(LastX, LastY, Offset, PartOfPattern);

            SetNewBitmap();

            using (Graphics g = Graphics.FromImage(pMachine.Image))
            {
                foreach (VertexPoint vp in points)
                {
                    DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColWiper, g);
                    LastX = vp.x;
                    LastY = vp.y;

                    AllPoints.Add(vp);
                }

                tStartX.Text = LastX.ToString();
                tStartY.Text = LastY.ToString();
            }

            pMachine.Invalidate();

            RedrawAll(0);
        }

        private void WipeInsideOut(double Offset)
        {
            PartOfPattern++;

            List<VertexPoint> points = new List<VertexPoint>();

            points = gs.GetWiperInsideOut(LastX, LastY, Offset, PartOfPattern);

            SetNewBitmap();

            using (Graphics g = Graphics.FromImage(pMachine.Image))
            {
                foreach (VertexPoint vp in points)
                {
                    DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColWiper, g);
                    LastX = vp.x;
                    LastY = vp.y;

                    AllPoints.Add(vp);
                }

                tStartX.Text = LastX.ToString();
                tStartY.Text = LastY.ToString();
            }

            pMachine.Invalidate();

            RedrawAll(0);
        }

        private void WipeDiagonal(double Offset)
        {
            PartOfPattern++;

            List<VertexPoint> points = new List<VertexPoint>();

            points = gs.GetWiperDiagonal(LastX, LastY, Offset, PartOfPattern);

            SetNewBitmap();

            //if (pMachine.Image == null)
            //{
            //    Bitmap bmp = new Bitmap(pMachine.Width, pMachine.Height);

            //    pMachine.Image = bmp;
            //}

            using (Graphics g = Graphics.FromImage(pMachine.Image))
            {
                foreach (VertexPoint vp in points)
                {
                    DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColWiper, g);
                    LastX = vp.x;
                    LastY = vp.y;

                    AllPoints.Add(vp);
                }

                tStartX.Text = LastX.ToString();
                tStartY.Text = LastY.ToString();
            }

            pMachine.Invalidate();

            RedrawAll(0);
        }

        private void WipeLeftRight(double Offset)
        {
            PartOfPattern++;

            List<VertexPoint> points = new List<VertexPoint>();

            points = gs.GetWiperLeftRight(LastX, LastY, Offset, PartOfPattern);

            SetNewBitmap();

            using (Graphics g = Graphics.FromImage(pMachine.Image))
            {
                foreach (VertexPoint vp in points)
                {
                    DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColWiper, g);
                    LastX = vp.x;
                    LastY = vp.y;

                    AllPoints.Add(vp);
                }

                tStartX.Text = LastX.ToString();
                tStartY.Text = LastY.ToString();
            }

            pMachine.Invalidate();

            RedrawAll(0);
        }

        private void WipeUpDown(double Offset)
        {
            PartOfPattern++;

            List<VertexPoint> points = new List<VertexPoint>();

            points = gs.GetWiperUpDown(LastX, LastY, Offset, PartOfPattern);

            SetNewBitmap();

            using (Graphics g = Graphics.FromImage(pMachine.Image))
            {
                foreach (VertexPoint vp in points)
                {
                    DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColWiper, g);
                    LastX = vp.x;
                    LastY = vp.y;

                    AllPoints.Add(vp);
                }

                tStartX.Text = LastX.ToString();
                tStartY.Text = LastY.ToString();
            }

            pMachine.Invalidate();

            RedrawAll(0);
        }

        private void CreateTurtleStar(double StarLength, double StartAngle, double OffsetX, double OffsetY, double OffsetAngle)
        {
            PartOfPattern++;

            if ((OffsetX != 0) || (OffsetY != 0))
            {
                double.TryParse(tStartX.Text, out LastX);
                double.TryParse(tStartY.Text, out LastY);

                List<VertexPoint> points = new List<VertexPoint>();

                points = gs.GetTurtleOffset(LastX, LastY, OffsetAngle, OffsetX, OffsetY, PartOfPattern);

                SetNewBitmap();

                using (Graphics g = Graphics.FromImage(pMachine.Image))
                {
                    foreach (VertexPoint vp in points)
                    {
                        DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColTurtleForward, g);
                        LastX = vp.x;
                        LastY = vp.y;

                        AllPoints.Add(vp);
                    }

                    tStartX.Text = LastX.ToString();
                    tStartY.Text = LastY.ToString();
                }

                pMachine.Invalidate();
            }

            TurtleAngle = StartAngle;

            for (int i = 0; i < 5; i++)
            {
                TurtleForward(StarLength, TurtleAngle, true);
                TurtleAngle += 144;
            }

            RedrawAll(0);
        }

        private void MoveTurtleForward(double Distance, double Angle)
        {
            TurtleForward(Distance, Angle, false);
        }

        private void DrawPolygon(object sender, EventArgs e)
        {
            
        }

        private void pMachine_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;

            if (mouseEventArgs != null)
            {
                LastX = mouseEventArgs.X / ZoomFactor;
                LastY = mouseEventArgs.Y / ZoomFactor;

                AddConnector(LastX, LastY);
            }

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();
        }
        
        private void cmdPolygon_Click(object sender, EventArgs e)
        {
            DrawPolygon(null, null);
        }
        
        private void tsbMiddleMiddle_Click(object sender, EventArgs e)
        {
            BusyDrawing = true;

            AddConnector(MachineX / 2, MachineY / 2);

            LastX = MachineX / 2;
            LastY = MachineY / 2;

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();
            
            BusyDrawing = false;
        }

        private void tsbClearDrawing_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to discard the current design?", "Clear Design", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pMachine.Image = null;

                BusyDrawing = true;

                LastX = MachineX / 2;
                LastY = MachineY / 2;

                tStartX.Text = LastX.ToString();
                tStartY.Text = LastY.ToString();

                AllPoints = null;
                AllPoints = new List<VertexPoint>();

                BusyDrawing = false;

                CurrentDesignName = "";
                this.Text = "Beacher";
                PartOfPattern = 0;
                TurtleAngle = 0;

                AllPoints = null;
                RedoPoints = null;

                AllPoints = new List<VertexPoint>();
                RedoPoints = new List<VertexPoint>();

                ImageCurrentFileName = string.Empty;
                gPic = null;
            }

            RedrawAll(0);
        }

        private void UndoLast()
        {
            int LastUndo = 0;

            //PartOfPattern++;

            List<VertexPoint> NewAllPoints = new List<VertexPoint>();

            foreach (VertexPoint vp in AllPoints)
            {
                if (vp.PartOfPattern > LastUndo)
                {
                    LastUndo = vp.PartOfPattern;   
                }
            }

            foreach (VertexPoint vp in AllPoints)
            {
                if (vp.PartOfPattern == LastUndo)
                {
                    RedoPoints.Add(vp);
                }
                else
                {
                    NewAllPoints.Add(vp);
                }
            }

            AllPoints = null;
            AllPoints = new List<VertexPoint>();
            AllPoints = NewAllPoints;

            RedrawAll(0);

            if (GridDrawn)
            {
                ReDrawGrid(false);
            }

            RedrawAll(0);
        }

        private void RedoLast()
        {
            int FirstRedo = 999999;

            //PartOfPattern++;

            List<VertexPoint> NewRedoPoints = new List<VertexPoint>();

            foreach (VertexPoint vp in RedoPoints)
            {
                if (vp.PartOfPattern < FirstRedo)
                {
                    FirstRedo = vp.PartOfPattern;
                }
            }

            foreach (VertexPoint vp in RedoPoints)
            {
                if (vp.PartOfPattern == FirstRedo)
                {
                    AllPoints.Add(vp);
                }
                else
                {
                    NewRedoPoints.Add(vp);
                }
            }
            
            RedoPoints = null;
            RedoPoints = new List<VertexPoint>();
            RedoPoints = NewRedoPoints;

            RedrawAll(0);

            if (GridDrawn)
            {
                ReDrawGrid(false);
            }

            RedrawAll(0);
        }

        private void tsbTopLeft_Click(object sender, EventArgs e)
        {
            BusyDrawing = true;

            AddConnector(0, 0);

            LastX = 0;
            LastY = 0;

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();
            
            BusyDrawing = false;
        }

        private void tsbTopMiddle_Click(object sender, EventArgs e)
        {
            BusyDrawing = true;

            AddConnector(MachineX / 2, 0);

            LastX = MachineX / 2;
            LastY = 0;

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();
            
            BusyDrawing = false;

            RedrawAll(0);
        }

        private void tsbTopRight_Click(object sender, EventArgs e)
        {
            BusyDrawing = true;

            AddConnector(MachineX, 0);

            LastX = MachineX;
            LastY = 0;

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();
            
            BusyDrawing = false;

            RedrawAll(0);
        }

        private void tsbMiddleLeft_Click(object sender, EventArgs e)
        {
            BusyDrawing = true;

            AddConnector(0, MachineY / 2);

            LastX = 0;
            LastY = MachineY / 2;

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();
            
            BusyDrawing = false;

            RedrawAll(0);
        }

        private void tsbMiddleRight_Click(object sender, EventArgs e)
        {
            BusyDrawing = true;

            AddConnector(MachineX, MachineY / 2);

            LastX = MachineX;
            LastY = MachineY / 2;

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();

            BusyDrawing = false;

            RedrawAll(0);
        }

        private void tsbBottomLeft_Click(object sender, EventArgs e)
        {
            BusyDrawing = true;

            AddConnector(0, MachineY);

            LastX = 0;
            LastY = MachineY;

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();
            
            BusyDrawing = false;

            RedrawAll(0);
        }

        private void tsbBottomMiddle_Click(object sender, EventArgs e)
        {
            BusyDrawing = true;

            AddConnector(MachineX / 2, MachineY);

            LastX = MachineX / 2;
            LastY = MachineY;

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();
            
            BusyDrawing = false;

            RedrawAll(0);
        }

        private void tsbBottomRight_Click(object sender, EventArgs e)
        {
            BusyDrawing = true;

            AddConnector(MachineX, MachineY);

            LastX = MachineX;
            LastY = MachineY;

            tStartX.Text = LastX.ToString();
            tStartY.Text = LastY.ToString();

            BusyDrawing = false;

            RedrawAll(0);
        }

        private void pMachine_MouseMove(object sender, MouseEventArgs e)
        {
            tsslX.Text = "X: " + (e.X / ZoomFactor).ToString() + " Y: " + (e.Y / ZoomFactor).ToString();
        }

        private void ReDrawGrid(bool RedrawItems)
        {
            if (RedrawItems)
            {
                RedrawAll(0);
            }

            if (GridTypeSelected == "mm")
            {
                AddGridmm(GridMeasureX, GridMeasureY);
            }
            else
            {
                AddGridLines(GridMeasureX, GridMeasureY);
            }
        }
        
        
        private void tsbUndoLast_Click(object sender, EventArgs e)
        {
            UndoLast();
        }

        private void tsbRedoLast_Click(object sender, EventArgs e)
        {
            RedoLast();
        }

        private void PlayBar_Scroll(object sender, EventArgs e)
        {
            RedrawAll(PlayBar.Value);
        }

        private bool DiscardElementsTrackBarChanged()
        {
            if (AllPoints.Count <= 0)
            {
                return true;
            }

            if (PlayBar.Value != PlayBar.Maximum)
            {
                DialogResult result = MessageBox.Show("You are about to discard some of your drawing elements. Do you wish to continue?", "Change Design", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    RedoPoints = null;
                    RedoPoints = new List<VertexPoint>();

                    List<VertexPoint> NewAllPoints = new List<VertexPoint>();

                    for (int i = 0; i <= PlayBar.Value; i++)
                    {
                        NewAllPoints.Add(AllPoints[i]);
                    }

                    AllPoints = null;
                    AllPoints = new List<VertexPoint>();
                    AllPoints = NewAllPoints;

                    RedrawAll(0);

                    return true;
                }
            }
            else
            {
                return true;
            }

            return false;
        }

        private void cmdPlayForward_Click(object sender, EventArgs e)
        {
            SetTrackBar(PlayBar.Value + 1);
            RedrawAll(PlayBar.Value);
        }

        private void cmdPlayBack_Click(object sender, EventArgs e)
        {
            SetTrackBar(PlayBar.Value - 1);
            RedrawAll(PlayBar.Value);
        }

        private void cmdDrawPolySpiral_Click(object sender, EventArgs e)
        {
            double SpiralOffset = 0;
            double SpiralPointDegrees = 0;
            double SpiralMax = 0;
            string StopAt = string.Empty;
            string Direction = "Counter Clockwise";
            string InOrOut = "Out";
            int Revolutions = 0;

            double inc = 0;
            //inc = (inc + 0.05) % 360;

            
        }
        
        private void TurtleForward(double Length, double AddAngle, bool SamePattern)
        {
            double CurrentAngle = 0;

            CurrentAngle = Math.Abs(TurtleAngle) % 360;

            BusyDrawing = true;

            if (!SamePattern)
            {
                PartOfPattern++;
            }

            double.TryParse(tStartX.Text, out LastX);
            double.TryParse(tStartY.Text, out LastY);
            
            List<VertexPoint> points = new List<VertexPoint>();

            points = gs.GetTurtleMove(LastX, LastY, AddAngle, Length, PartOfPattern);

            SetNewBitmap();

            using (Graphics g = Graphics.FromImage(pMachine.Image))
            {
                foreach (VertexPoint vp in points)
                {
                    DrawLine((int)(LastX), (int)(LastY), (int)(vp.x), (int)(vp.y), 1, ColTurtleForward, g);
                    LastX = vp.x;
                    LastY = vp.y;

                    AllPoints.Add(vp);
                }

                tStartX.Text = LastX.ToString();
                tStartY.Text = LastY.ToString();
            }

            pMachine.Invalidate();

            BusyDrawing = false;

            RedrawAll(0);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (CurrentDesignName.Trim() != "")
            {
                SaveClick(CurrentDesignName);
                return;
            }

            DesignSave ds = new DesignSave();
            ds.Action = "Save";
            ds.SaveClick += SaveClick;
            ds.ShowDialog();
        }

        private void SaveClick(string DesignName)
        {
            int Sequence = 1;

            tspbProgress.Visible = true;
            tspbProgress.Value = 0;

            Cursor.Current = Cursors.WaitCursor;

            tsslObjectType.Text = "Saving design, please wait...";

            using (DataStuffLight dsl = new DataStuffLight())
            {
                dsl.DeleteDesign(DesignName);

                foreach (VertexPoint vp in AllPoints)
                {
                    dsl.SaveDesign(DesignName, vp.PartOfPattern, vp.PatternType, vp.x, vp.y, Sequence);

                    tspbProgress.Value = (int)(((double)Sequence / (double)AllPoints.Count) * 100);

                    Application.DoEvents();

                    Sequence++;
                }
            }

            CurrentDesignName = DesignName;

            this.Text = "Beacher - " + CurrentDesignName;

            tspbProgress.Visible = false;

            Cursor.Current = Cursors.Default;

            tsslObjectType.Text = "Design saved";
        }

        private void tsbOpenDesign_Click(object sender, EventArgs e)
        {
            DesignSave ds = new DesignSave();
            ds.Action = "Open";
            ds.OpenClick += OpenClick;
            ds.ShowDialog();
        }

        private void OpenClick(string DesignName)
        {
            int CurPattern = 0;
            double x = 0;
            double y = 0;

            AllPoints = null;
            RedoPoints = null;

            AllPoints = new List<VertexPoint>();
            RedoPoints = new List<VertexPoint>();

            using (DataStuffLight dsl = new DataStuffLight())
            {
                DataTable dt = dsl.GetDesign(DesignName);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            VertexPoint vp = new VertexPoint();

                            int.TryParse(row["PartOfPattern"].ToString(), out CurPattern);
                            double.TryParse(row["XPos"].ToString(), out x);
                            double.TryParse(row["YPos"].ToString(), out y);
                            
                            vp.PartOfPattern = CurPattern;
                            vp.PatternType = row["PatternType"].ToString();
                            vp.x = x;
                            vp.y = y;

                            AllPoints.Add(vp);
                            RedoPoints.Add(vp);
                        }

                        RedrawAll(dt.Rows.Count);
                        PartOfPattern = CurPattern;
                        LastX = x;
                        LastY = y;
                    }
                }
            }

            CurrentDesignName = DesignName;

            this.Text = "Beacher - " + CurrentDesignName;
        }

        private void tsbSaveAs_Click(object sender, EventArgs e)
        {
            DesignSave ds = new DesignSave();
            ds.Action = "Save";
            ds.SaveClick += SaveClick;
            ds.ShowDialog();
        }

        private void tsbGCode_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            
            savefile.FileName = "unknown.gcode";
            
            savefile.Filter = "G-Code files (*.gcode)|*.gcode|All files (*.*)|*.*";

            LoadMachineData();

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    if (MachineStartCode.Trim() != "")
                    {
                        sw.WriteLine(MachineStartCode);
                    }

                    foreach (VertexPoint vp in AllPoints)
                    {
                        if (vp.PatternType != "Bitmap Trace")
                        {
                            sw.WriteLine("G01 X" + string.Format("{0:0.000}", vp.x) + " Y" + string.Format("{0:0.000}", vp.y) + " F" + MachineDefaultSpeed);
                        }
                        else
                        {
                            sw.WriteLine("G01 X" + string.Format("{0:0.000}", vp.x) + " Y" + string.Format("{0:0.000}", vp.y) + " F" + MachineBitmapSpeed);
                        }

                    }

                    if (MachineEndCode.Trim() != "")
                    {
                        sw.WriteLine(MachineEndCode);
                    }
                }
            }
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            if (PlayBar.Value + 1 >= PlayBar.Maximum)
            {
                PlayBar.Value = 1;
            }

            RedrawAll(PlayBar.Value);

            PlayTimer.Start();
            cmdStop.Enabled = true;
            cmdPlay.Enabled = false;
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            PlayTimer.Stop();
            cmdPlay.Enabled = true;
            cmdStop.Enabled = false;
        }

        private void tsbClearScreenOnly_Click(object sender, EventArgs e)
        {
            pMachine.Image = null;
        }
        
        public void GetThumbnails()
        {
            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);

            Bitmap myBitmap = new Bitmap(ImageCurrentFileName);
            
            Image myThumbnail = myBitmap.GetThumbnailImage(ImageCurrentWidth, ImageCurrentHeight, myCallback, IntPtr.Zero);
            
            if (gPic == null)
            {
                gPic = pMachine.CreateGraphics();
            }

            gPic.Clear(Color.White);

            int ImageX = 0;
            int ImageY = 0;

            switch (ImageXPos)
            {
                case "Left":
                    ImageX = 0;
                    break;

                case "Right":
                    ImageX = pMachine.Width - ImageCurrentWidth;
                    break;

                case "Centre":
                    ImageX = (pMachine.Width / 2) - (ImageCurrentWidth / 2);
                    break;

                default:
                    break;
            }

            switch (ImageYPos)
            {
                case "Top":
                    ImageY = 0;
                    break;

                case "Bottom":
                    ImageY = pMachine.Height - ImageCurrentHeight;
                    break;

                case "Centre":
                    ImageY = (pMachine.Height / 2) - (ImageCurrentHeight / 2);
                    break;

                default:
                    break;
            }

            gPic.DrawImage(myThumbnail, new Point(ImageX, ImageY));
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private void tsbCombine_Click(object sender, EventArgs e)
        {
            DesignSave ds = new DesignSave();
            ds.Action = "Open";
            ds.OpenClick += OpenAddClick;
            ds.ShowDialog();
        }

        private void OpenAddClick(string DesignName)
        {
            double x = 0;
            double y = 0;

            PartOfPattern++;

            using (DataStuffLight dsl = new DataStuffLight())
            {
                DataTable dt = dsl.GetDesign(DesignName);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            VertexPoint vp = new VertexPoint();

                            int.TryParse(row["PartOfPattern"].ToString(), out PartOfPattern);
                            double.TryParse(row["XPos"].ToString(), out x);
                            double.TryParse(row["YPos"].ToString(), out y);

                            vp.PartOfPattern = PartOfPattern;
                            vp.PatternType = row["PatternType"].ToString();
                            vp.x = x + LastX;
                            vp.y = y + LastY;

                            AllPoints.Add(vp);
                            RedoPoints.Add(vp);
                        }

                        RedrawAll(0);
                        LastX = x;
                        LastY = y;
                    }
                }
            }
        }

        private void tsbLoadGCode_Click(object sender, EventArgs e)
        {
            string line = string.Empty;
            double x = 0;
            double y = 0;
            double z = 0;
            double InitZ = 0;
            bool PointsFound = false;
            bool InitZFound = false;

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PartOfPattern++;

                    StreamReader sr = new StreamReader(ofd.FileName);

                    line = sr.ReadLine();

                    while (line != null)
                    {
                        string[] tmp = line.Split(' ');

                        if (tmp.Length >= 3)
                        {
                            if ((tmp[0] == "G0") || (tmp[0] == "G00"))
                            {
                                if (line.Contains("Z"))
                                {
                                    for (int i = 1; i < tmp.Length; i++)
                                    {
                                        if (tmp[i].Contains("Z"))
                                        {
                                            double.TryParse(tmp[i].Substring(1), out z);

                                            if (!InitZFound)
                                            {
                                                InitZ = z;
                                                InitZFound = true;
                                                break;
                                            }
                                        }
                                    }

                                    if (InitZFound)
                                    {
                                        if (InitZ != z)
                                        {
                                            sr.Close();

                                            if (PointsFound)
                                            {
                                                RedrawAll(0);
                                                LastX = x;
                                                LastY = y;
                                            }

                                            //Done with the first layer
                                            return;
                                        }
                                    }
                                }
                            }

                            if ((tmp[0] == "G1") || (tmp[0] == "G01"))
                            {
                                if ((tmp[1].ToUpper().Contains("X")) && (tmp[2].ToUpper().Contains("Y")))
                                {
                                    

                                    double.TryParse(tmp[1].Substring(1), out x);
                                    double.TryParse(tmp[2].Substring(1), out y);

                                    VertexPoint vp = new VertexPoint();

                                    vp.x = x;
                                    vp.y = y;
                                    vp.PartOfPattern = PartOfPattern;
                                    vp.PatternType = "Turtle Forward";

                                    AllPoints.Add(vp);
                                    RedoPoints.Add(vp);

                                    PointsFound = true;
                                }
                            }
                        }

                        line = sr.ReadLine();
                    }

                    sr.Close();

                    if (PointsFound)
                    {
                        RedrawAll(0);
                        LastX = x;
                        LastY = y;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
            }
        }

        private void tsbZoomIn_Click(object sender, EventArgs e)
        {
            ZoomFactor += 0.25;
            SetMachineDisplay();
            RedrawAll(0);
        }

        private void tsbZoomOut_Click(object sender, EventArgs e)
        {
            if (ZoomFactor - 0.25 > 0)
            {
                ZoomFactor -= 0.25;
                SetMachineDisplay();
                RedrawAll(0);
            }
        }

        private void tsbZoomNormal_Click(object sender, EventArgs e)
        {
            ZoomFactor = 1;
            SetMachineDisplay();
            RedrawAll(0);
        }

        private void tsbEditPoints_Click(object sender, EventArgs e)
        {
            EditPoints ep = new EditPoints();
            ep.MachineX = MachineX;
            ep.MachineY = MachineY;
            ep.AllPoints = AllPoints;
            ep.ShowDialog();
            AllPoints = null;
            AllPoints = ep.AllPoints;
            RedrawAll(0);
        }

        //private void cmdTurtleStar_Click(object sender, EventArgs e)
        //{
        //    double.TryParse(tTurtleForward.Text, out TurtleDistance);

        //    for (int i = 0; i < 5; i++)
        //    {
        //        //TurtleForward(TurtleDistance);
        //        TurtleAngle += 144;
        //    }
        //}

        //private void cmdTurtleSpiral_Click(object sender, EventArgs e)
        //{
        //    int Rotations = 0;
        //    int Corners = 0;
        //    double LineIncrement = 0;
        //    double Angle = 0;

        //    int.TryParse(tTurtleSpiralRotation.Text, out Rotations);
        //    int.TryParse(tTurtleSpiralCorners.Text, out Corners);
        //    double.TryParse(tTurtleSpiralLineIncrement.Text, out LineIncrement);

        //    Angle = 360 / Corners;

        //    double.TryParse(tTurtleForward.Text, out TurtleDistance);

        //    for (int i = 0; i < Rotations; i++)
        //    {
        //        //TurtleForward(i * LineIncrement);
        //        TurtleAngle += Angle;
        //    }
        //}


    }
}
