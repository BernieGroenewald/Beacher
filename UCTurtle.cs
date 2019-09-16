using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beacher
{
    public partial class UCTurtle : UserControl
    {
        public event TurtleForward MoveTurtleForward;
        public delegate void TurtleForward(double Distance, double Angle);

        public event TurtleStar CreateTurtleStar;
        public delegate void TurtleStar(double StarLength, double StartAngle, double OffsetX, double OffsetY, double OffsetAngle);

        public event TurtleToolboxChanged TurtleToolboxChange;
        public delegate void TurtleToolboxChanged();

        public double TurtleAngle = 0;

        public UCTurtle()
        {
            InitializeComponent();
        }

        private void cmdTurtleForward_Click(object sender, EventArgs e)
        {
            double TurtleDistance = 0;
            double Angle = 0;

            double.TryParse(tTurtleForward.Text, out TurtleDistance);
            double.TryParse(tTurtleCurrentAngle.Text, out Angle);

            MoveTurtleForward?.Invoke(TurtleDistance, Angle);
        }

        private void RotatePointer()
        {
            double.TryParse(tTurtleCurrentAngle.Text, out TurtleAngle);

            Bitmap rotatedImage = new Bitmap(imageList1.Images[0]);
            pTurtleDirection.Invalidate();

            pTurtleDirection.Image = RotateImage(rotatedImage, (float)TurtleAngle);
        }

        private void SetTurtleDisplayAngle()
        {
            if (TurtleAngle > 360)
            {
                TurtleAngle = 360;
            }

            tTurtleCurrentAngle.Text = TurtleAngle.ToString();
        }

        private Bitmap RotateImage(Bitmap bmp, float angleDegrees)
        {
            float DrawDegrees = 0;

            DrawDegrees = angleDegrees + 180;

            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point as the center into the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);

                // Rotate
                g.RotateTransform(DrawDegrees);

                // Restore the rotation point into the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);

                // Draw the image on the new bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            bmp.Dispose();

            return rotatedImage;
        }

        private void cmdTurtleRotateInc_Click(object sender, EventArgs e)
        {
            TurtleAngle++;

            if (TurtleAngle > 360)
            {
                TurtleAngle = TurtleAngle % 360;
            }

            SetTurtleDisplayAngle();
        }

        private void cmdTurtleRotateIncTen_Click(object sender, EventArgs e)
        {
            TurtleAngle += 10;

            if (TurtleAngle > 360)
            {
                TurtleAngle = TurtleAngle % 360;
            }

            SetTurtleDisplayAngle();
        }

        private void cmdTurtleRotateDecTen_Click(object sender, EventArgs e)
        {
            TurtleAngle -= 10;

            if (TurtleAngle < 0)
            {
                TurtleAngle = 360;
            }

            SetTurtleDisplayAngle();
        }

        private void cmdTurtleRotateDDec_Click(object sender, EventArgs e)
        {
            TurtleAngle--;

            if (TurtleAngle < 0)
            {
                TurtleAngle = 360;
            }

            SetTurtleDisplayAngle();
        }

        private void tTurtleCurrentAngle_TextChanged(object sender, EventArgs e)
        {
            RotatePointer();
        }

        private void cmdTop_Click(object sender, EventArgs e)
        {
            tTurtleCurrentAngle.Text = "0";
        }

        private void cmdTopRight_Click(object sender, EventArgs e)
        {
            tTurtleCurrentAngle.Text = "45";
        }

        private void cmdRight_Click(object sender, EventArgs e)
        {
            tTurtleCurrentAngle.Text = "90";
        }

        private void cmdBottomRight_Click(object sender, EventArgs e)
        {
            tTurtleCurrentAngle.Text = "135";
        }

        private void cmdBottom_Click(object sender, EventArgs e)
        {
            tTurtleCurrentAngle.Text = "180";
        }

        private void cmdBottomLeft_Click(object sender, EventArgs e)
        {
            tTurtleCurrentAngle.Text = "225";
        }

        private void cmdLeft_Click(object sender, EventArgs e)
        {
            tTurtleCurrentAngle.Text = "270";
        }

        private void cmdTopLeft_Click(object sender, EventArgs e)
        {
            tTurtleCurrentAngle.Text = "315";
        }

        private void cmdTurtleRotateDecFive_Click(object sender, EventArgs e)
        {
            TurtleAngle -= 5;

            if (TurtleAngle < 0)
            {
                TurtleAngle = 360;
            }

            SetTurtleDisplayAngle();
        }

        private void cmdTurtleRotateIncFive_Click(object sender, EventArgs e)
        {
            TurtleAngle += 5;

            if (TurtleAngle > 360)
            {
                TurtleAngle = TurtleAngle % 360;
            }

            SetTurtleDisplayAngle();
        }

        private void cmdTurtleForwardIncOne_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tTurtleForward.Text, out TmpForward);

            TmpForward++;

            tTurtleForward.Text = TmpForward.ToString();
        }

        private void cmdTurtleForwardIncFive_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tTurtleForward.Text, out TmpForward);

            TmpForward += 5;

            tTurtleForward.Text = TmpForward.ToString();
        }

        private void cmdTurtleForwardIncTen_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tTurtleForward.Text, out TmpForward);

            TmpForward += 10;

            tTurtleForward.Text = TmpForward.ToString();
        }

        private void cmdTurtleStar_Click(object sender, EventArgs e)
        {
            double StarLength = 0;
            double StartAngle = 0;
            double IncrementStarlength = 0;
            double IncrementStartAngle = 0;
            double OffsetX = 0;
            double OffsetY = 0;
            double OffsetAngle = 0;
            double Tmp = 0;
            double IncrementDirection = 0;

            double.TryParse(tStarLength.Text, out StarLength);
            double.TryParse(tStarStartAngle.Text, out StartAngle);
            double.TryParse(tStarIncrementLength.Text, out IncrementStarlength);
            double.TryParse(tStarIncrementAngle.Text, out IncrementStartAngle);
            double.TryParse(tStarOffsetX.Text, out OffsetX);
            double.TryParse(tStarOffsetY.Text, out OffsetY);
            double.TryParse(tTurtleCurrentAngle.Text, out OffsetAngle);

            CreateTurtleStar?.Invoke(StarLength, StartAngle, OffsetX, OffsetY, OffsetAngle);

            StarLength += IncrementStarlength;
            StartAngle += IncrementStartAngle;

            tStarLength.Text = StarLength.ToString();
            tStarStartAngle.Text = StartAngle.ToString();

            if (rbIncXPlus.Checked)
            {
                double.TryParse(tStarOffsetX.Text, out Tmp);
                Tmp++;
                tStarOffsetX.Text = Tmp.ToString();
            }

            if (rbIncXMinus.Checked)
            {
                double.TryParse(tStarOffsetX.Text, out Tmp);
                Tmp--;

                if (Tmp < 0)
                {
                    Tmp = 0;
                }

                tStarOffsetX.Text = Tmp.ToString();
            }

            if (rbIncYPlus.Checked)
            {
                double.TryParse(tStarOffsetY.Text, out Tmp);
                Tmp++;
                tStarOffsetY.Text = Tmp.ToString();
            }

            if (rbIncYMinus.Checked)
            {
                double.TryParse(tStarOffsetY.Text, out Tmp);
                Tmp--;

                if (Tmp < 0)
                {
                    Tmp = 0;
                }

                tStarOffsetY.Text = Tmp.ToString();
            }

            if (tDirectionInc.Text != "0")
            {
                double.TryParse(tDirectionInc.Text, out IncrementDirection);
                double.TryParse(tTurtleCurrentAngle.Text, out Tmp);

                Tmp += IncrementDirection;

                if (Tmp < 0)
                {
                    Tmp = 0;
                }

                tTurtleCurrentAngle.Text = Tmp.ToString();
            }
        }

        private void cmdStarIncOne_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarLength.Text, out TmpForward);

            TmpForward++;

            tStarLength.Text = TmpForward.ToString();
        }

        private void cmdStarIncFive_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarLength.Text, out TmpForward);

            TmpForward += 5;

            tStarLength.Text = TmpForward.ToString();
        }

        private void cmdStarIncTen_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarLength.Text, out TmpForward);

            TmpForward += 10;

            tStarLength.Text = TmpForward.ToString();
        }

        private void cmdTurtleForwardDecOne_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tTurtleForward.Text, out TmpForward);

            TmpForward--;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tTurtleForward.Text = TmpForward.ToString();
        }

        private void cmdTurtleForwardDecFive_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tTurtleForward.Text, out TmpForward);

            TmpForward -= 5;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tTurtleForward.Text = TmpForward.ToString();
        }

        private void cmdTurtleForwardDecTen_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tTurtleForward.Text, out TmpForward);

            TmpForward -= 10;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tTurtleForward.Text = TmpForward.ToString();
        }

        private void cmdStarDecTen_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarLength.Text, out TmpForward);

            TmpForward -= 10;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tStarLength.Text = TmpForward.ToString();
        }

        private void cmdStarDecFive_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarLength.Text, out TmpForward);

            TmpForward -= 5;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tStarLength.Text = TmpForward.ToString();
        }

        private void cmdStarDecOne_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarLength.Text, out TmpForward);

            TmpForward--;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tStarLength.Text = TmpForward.ToString();
        }

        private void cmdStarAngleDecOne_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarStartAngle.Text, out TmpForward);

            TmpForward--;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tStarStartAngle.Text = TmpForward.ToString();
        }

        private void cmdStarAngleDecFive_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarStartAngle.Text, out TmpForward);

            TmpForward -= 5;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tStarStartAngle.Text = TmpForward.ToString();
        }

        private void cmdStarAngleDecTen_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarStartAngle.Text, out TmpForward);

            TmpForward -= 10;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tStarStartAngle.Text = TmpForward.ToString();
        }

        private void cmdStarAngleIncOne_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarStartAngle.Text, out TmpForward);

            TmpForward++;

            tStarStartAngle.Text = TmpForward.ToString();
        }

        private void cmdStarAngleIncFive_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarStartAngle.Text, out TmpForward);

            TmpForward += 5;

            tStarStartAngle.Text = TmpForward.ToString();
        }

        private void cmdStarAngleIncTen_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tStarStartAngle.Text, out TmpForward);

            TmpForward += 10;

            if (TmpForward >= 360)
            {
                TmpForward = TmpForward % 360;
            }

            tStarStartAngle.Text = TmpForward.ToString();
        }

        private void cmdStarReset_Click(object sender, EventArgs e)
        {
            tStarLength.Text = "100";
            tStarStartAngle.Text = "18";
            tStarIncrementAngle.Text = "0";
            tStarIncrementLength.Text = "0";
            tStarOffsetX.Text = "0";
            tStarOffsetY.Text = "0";
        }

        private void UCTurtle_Load(object sender, EventArgs e)
        {
            tTurtleCurrentAngle.Text = TurtleAngle.ToString();
            RotatePointer();
            this.Height = toolStrip1.Height;
            tssbOpenClose.Image = imageList2.Images[0];
        }
        
        private void tssbOpenClose_Click(object sender, EventArgs e)
        {
            if (this.Height > toolStrip1.Height + 100)
            {
                this.Height = toolStrip1.Height;
                tssbOpenClose.Image = imageList2.Images[0];
            }
            else
            {
                this.Height = 665;

                tssbOpenClose.Image = imageList2.Images[1];
            }

            TurtleToolboxChange?.Invoke();
        }
    }
}
