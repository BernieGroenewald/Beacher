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
    public partial class UCPolySpiral : UserControl
    {
        public event ToolboxChanged ToolboxChange;
        public delegate void ToolboxChanged();

        public event PolySpiralDrawn DrawPolySpiral;
        public delegate void PolySpiralDrawn(double IncrementAngle, double SideLength, int Revolutions, string StopAt, double IncrementSide);

        public UCPolySpiral()
        {
            InitializeComponent();
        }

        private void cmdDrawPolySpiral_Click(object sender, EventArgs e)
        {
            string StopAt = string.Empty;
            int Revolutions = 0;
            double IncrementAngle = 0;
            double IncrementSide = 0;
            double SideLength = 0;

            double.TryParse(tPolyAngleIncrement.Text, out IncrementAngle);
            double.TryParse(tSideLength.Text, out SideLength);
            int.TryParse(tPolyRevolutions.Text, out Revolutions);
            double.TryParse(tIncrementSideLength.Text, out IncrementSide);

            if (rbStopHorisontal.Checked)
            {
                StopAt = "Horisontal";
            }
            else if (rbStopVertical.Checked)
            {
                StopAt = "Vertical";
            }
            else
            {
                StopAt = "None";
            }

            DrawPolySpiral?.Invoke(IncrementAngle, SideLength, Revolutions, StopAt, IncrementSide);
        }

        private void tssbOpenClose_Click(object sender, EventArgs e)
        {
            if (this.Height > toolStrip1.Height + 10)
            {
                this.Height = toolStrip1.Height;
                tssbOpenClose.Image = imageList2.Images[0];
            }
            else
            {
                this.Height = 275;

                tssbOpenClose.Image = imageList2.Images[1];
            }

            ToolboxChange?.Invoke();
        }

        private void UCPolySpiral_Load(object sender, EventArgs e)
        {
            this.Height = toolStrip1.Height;
            tssbOpenClose.Image = imageList2.Images[0];
        }

        private void cmdIncOne_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tPolyAngleIncrement.Text, out TmpForward);

            TmpForward++;

            tPolyAngleIncrement.Text = TmpForward.ToString();
        }

        private void cmdIncFive_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tPolyAngleIncrement.Text, out TmpForward);

            TmpForward = TmpForward + 5;

            tPolyAngleIncrement.Text = TmpForward.ToString();
        }

        private void cmdIncTen_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tPolyAngleIncrement.Text, out TmpForward);

            TmpForward = TmpForward + 10;

            tPolyAngleIncrement.Text = TmpForward.ToString();
        }

        private void cmdDecOne_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tPolyAngleIncrement.Text, out TmpForward);

            TmpForward--;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tPolyAngleIncrement.Text = TmpForward.ToString();
        }

        private void cmdDecFive_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tPolyAngleIncrement.Text, out TmpForward);

            TmpForward = TmpForward - 5;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tPolyAngleIncrement.Text = TmpForward.ToString();
        }

        private void cmdDecTen_Click(object sender, EventArgs e)
        {
            double TmpForward = 0;

            double.TryParse(tPolyAngleIncrement.Text, out TmpForward);

            TmpForward = TmpForward - 10;

            if (TmpForward <= 0)
            {
                TmpForward = 1;
            }

            tPolyAngleIncrement.Text = TmpForward.ToString();
        }
    }
}
