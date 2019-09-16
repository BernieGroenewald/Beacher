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
    public partial class UCSpriral : UserControl
    {
        public event ToolboxChanged ToolboxChange;
        public delegate void ToolboxChanged();

        public event SpiralDrawn DrawSpiral;
        public delegate void SpiralDrawn(GeneralStuff.SpiralType SpiralType, double SpiralOffset, double SpiralDegrees, double MaxSize, string StopAt, string Direction, string InOrOut);

        double SpiralOffset = 0;
        double SpiralPointDegrees = 0;
        double SpiralMax = 0;
        string StopAt = string.Empty;
        string Direction = "Counter Clockwise";
        string InOrOut = "InToOut";
        GeneralStuff.SpiralType SpiralType = GeneralStuff.SpiralType.Linear;

        public UCSpriral()
        {
            InitializeComponent();
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
                this.Height = 461;

                tssbOpenClose.Image = imageList2.Images[1];
            }

            ToolboxChange?.Invoke();
        }

        private void UCSpriral_Load(object sender, EventArgs e)
        {
            this.Height = toolStrip1.Height;
            tssbOpenClose.Image = imageList2.Images[0];
        }

        private void cmdSpiral_Click(object sender, EventArgs e)
        {
            double.TryParse(tSpiralDegrees.Text, out SpiralPointDegrees);
            double.TryParse(tSpiralOffset.Text, out SpiralOffset);
            double.TryParse(tSpiralSize.Text, out SpiralMax);

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

            if (rbSpiralCubic.Checked)
            {
                SpiralType = GeneralStuff.SpiralType.Cubic;
            }
            else if (rbSpiralExponential.Checked)
            {
                SpiralType = GeneralStuff.SpiralType.Exponential;
            }
            else if (rbSpiralLinear.Checked)
            {
                SpiralType = GeneralStuff.SpiralType.Linear;
            }
            else if (rbSpiralQuadratic.Checked)
            {
                SpiralType = GeneralStuff.SpiralType.Quadratic;
            }

            if (rbClockwise.Checked)
            {
                Direction = "Clockwise";
            }
            else
            {
                Direction = "Counter Clockwise";
            }

            if (rbInToOut.Checked)
            {
                InOrOut = "InToOut";
            }
            else
            {
                InOrOut = "OutToIn";
            }

            DrawSpiral?.Invoke(SpiralType, SpiralOffset, SpiralPointDegrees, SpiralMax, StopAt, Direction, InOrOut);
        }
    }
}
