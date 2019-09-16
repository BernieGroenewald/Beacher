using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beacher
{
    public partial class EditPoints : Form
    {
        GeneralStuff gs = new GeneralStuff();

        public double MachineX = 0;
        public double MachineY = 0;
        public List<VertexPoint> AllPoints = new List<VertexPoint>();

        Color ColGrid = Color.Aqua;
        double ZoomFactor = 1;
        double LastX = 0;
        double LastY = 0;
        string Mode = "None";
        Bitmap bmp;

        public EditPoints()
        {
            InitializeComponent();
            pEdit.MouseWheel += pEdit_MouseWheel;
        }

        private void EditPoints_Load(object sender, EventArgs e)
        {
            double MaxX = 0;
            double MaxY = 0;

            pEdit.Parent = pMain;

            if (AllPoints != null)
            {
                foreach (VertexPoint vp in AllPoints)
                {
                    if (vp.x > MaxX)
                    {
                        MaxX = vp.x;
                    }

                    if (vp.y > MaxY)
                    {
                        MaxY = vp.y;
                    }
                }

                MachineX = MaxX + (MaxX * 0.1);
                MachineY = MaxY + (MaxY * 0.1);
            }

            SetEditLayout();
        }

        private void pEdit_MouseWheel(object sender, MouseEventArgs e)
        {
            int ScrollValue = e.Delta / 120;

            if (ScrollValue > 0)
            {
                ZoomFactor += 1;
            }
            else
            {
                ZoomFactor -= 1;
            }

            if (ZoomFactor <= 0)
            {
                ZoomFactor = 1;
            }

            pEdit.Width = (int)(MachineX * ZoomFactor);
            pEdit.Height = (int)(MachineY * ZoomFactor);
            AddGridLines((int)MachineX, (int)MachineY);

            RedrawAll();

            pEdit.Invalidate();
        }

        private void SetEditLayout()
        {
            double ZoomX = 0;
            double ZoomY = 0;

            if ((int)(MachineX * ZoomFactor) < pMain.Width)
            {
                ZoomX = pMain.Width / (MachineX * ZoomFactor);
            }

            if ((int)(MachineY * ZoomFactor) < pMain.Height)
            {
                ZoomY = pMain.Height / (MachineY * ZoomFactor);
            }

            if (ZoomFactor < ZoomX)
            {
                ZoomFactor = ZoomX;
            }
            
            pEdit.Width = (int)(MachineX * ZoomFactor);
            pEdit.Height = (int)(MachineY * ZoomFactor);
            AddGridLines((int)MachineX, (int)MachineY);

            RedrawAll();

            pEdit.Invalidate();
        }

        private void AddGridLines(int XLines, int YLines)
        {
            decimal result = Math.Ceiling((decimal)pEdit.Width / (decimal)XLines);

            int XSpace = (int)result;

            result = Math.Ceiling((decimal)pEdit.Height / (decimal)YLines);
            int YSpace = (int)result;

            SetNewBitmap();

            for (int x = XSpace; x < pEdit.Width; x += XSpace)
            {
                using (Graphics g = Graphics.FromImage(pEdit.Image))
                {
                    DrawLine(x, 0, x, pEdit.Height, 1, ColGrid, g);
                }
            }

            for (int x = YSpace; x < pEdit.Height; x += YSpace)
            {
                using (Graphics g = Graphics.FromImage(pEdit.Image))
                {
                    DrawLine(0, x, pEdit.Height, x, 1, ColGrid, g);
                }
            }
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

                    bmp = new Bitmap(pEdit.Width, pEdit.Height);
                    pEdit.Image = bmp;
                }

                catch { }

                this.Invoke((MethodInvoker)delegate
                {
                    pEdit.Image = bmp;
                });

                GC.Collect(); //Without this, memory goes nuts
            });
        }

        private void DrawBox(int x1, int y1, int x2, int y2, float PenWidth, Color colour, Graphics page)
        {
            Rectangle rect = new Rectangle(x1, y1, 3, 3);
            
            SolidBrush myBrush = new SolidBrush(colour);
            page.FillRectangle(myBrush, rect);
            myBrush.Dispose();
        }

        private void DrawLine(int x1, int y1, int x2, int y2, float PenWidth, Color colour, Graphics page)
        {
            Pen p = new Pen(colour, PenWidth);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            page.DrawLine(p, p1, p2);
        }

        private void RedrawAll()
        {
            LastX = 0;
            LastY = 0;

            pEdit.Controls.Clear();

            Color pen = Color.Black;

            foreach (VertexPoint vp in AllPoints)
            {
                Label l = new Label();
                l.Parent = pEdit;
                l.Left = (int)(vp.x * ZoomFactor);
                l.Top = (int)(vp.y * ZoomFactor);
                l.Width = 4;
                l.Height = 4;
                l.BackColor = Color.DarkBlue;
                l.Tag = vp.x.ToString() + ":" + vp.y.ToString();
                l.BringToFront();
                l.MouseDown += Point_MouseDown;
                l.MouseEnter += Point_MouseEnter;

                //using (Graphics g = Graphics.FromImage(pEdit.Image))
                //{
                //    DrawBox((int)((LastX) * ZoomFactor), (int)((LastY) * ZoomFactor), (int)((vp.x) * ZoomFactor), (int)((vp.y) * ZoomFactor), 1, pen, g);

                //    LastX = vp.x;
                //    LastY = vp.y;
                //}
            }

            //pEdit.Invalidate();   
        }

        private void Point_MouseEnter(object sender, EventArgs e)
        {
            if (Mode != "Erase")
            {
                return;
            }

            Label l = (Label)sender;
            double x = 0;
            double y = 0;

            string[] xy = l.Tag.ToString().Split(':');

            double.TryParse(xy[0], out x);
            double.TryParse(xy[1], out y);

            if (RemovePoint(x, y))
            {
                pEdit.Controls.Remove(l);
            }
        }

        private void Point_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Label l = (Label)sender;
                double x = 0;
                double y = 0;

                string[] xy = l.Tag.ToString().Split(':');

                double.TryParse(xy[0], out x);
                double.TryParse(xy[1], out y);

                RemovePoint(x, y);

                pEdit.Controls.Remove(l);
            }

            
        }

        private bool RemovePoint(double x, double y)
        {
            bool FoundElement = false;

            for (int i = AllPoints.Count - 1; i >= 0; i--)
            {
                VertexPoint vp = AllPoints[i];

                if ((vp.x == x) && (vp.y == y))
                {
                    AllPoints.RemoveAt(i);
                    FoundElement = true;
                }
            }
            
            return FoundElement;
        }

        private void pEdit_MouseHover(object sender, EventArgs e)
        {
            pEdit.Focus();
        }

        private void pEdit_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;

            if (mouseEventArgs != null)
            {
                LastX = mouseEventArgs.X / ZoomFactor;
                LastY = mouseEventArgs.Y / ZoomFactor;

                //AddConnector(LastX, LastY);
            }

            tssl1.Text = "X " + LastX.ToString() + " : Y " + LastY.ToString();
        }

        private void tsbErase_Click(object sender, EventArgs e)
        {
            if (Mode == "Erase")
            {
                Mode = "None";
                pEdit.Cursor = Cursors.Default;
            }
            else
            {
                Mode = "Erase";
                pEdit.Cursor = Cursors.No;
            }
        }
    }
}
