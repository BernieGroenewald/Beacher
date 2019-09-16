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
    public partial class UCWiper : UserControl
    {
        public event WiperLeftRight WipeLeftRight;
        public delegate void WiperLeftRight(double Offset);

        public event WiperUpDown WipeUpDown;
        public delegate void WiperUpDown(double Offset);

        public event WiperDiagonal WipeDiagonal;
        public delegate void WiperDiagonal(double Offset);

        public event WiperInsideOut WipeInsideOut;
        public delegate void WiperInsideOut(double Offset);

        public event WiperOutsideIn WipeOutsideIn;
        public delegate void WiperOutsideIn(double Offset);

        public event WiperClearScreen WipeCls;
        public delegate void WiperClearScreen(string ClsType);

        public event ToolboxChanged ToolboxChange;
        public delegate void ToolboxChanged();

        public UCWiper()
        {
            InitializeComponent();
        }

        private void UCWiper_Load(object sender, EventArgs e)
        {
            this.Height = toolStrip1.Height;
            tssbOpenClose.Image = imageList2.Images[0];
        }

        private void cmdLeftRight_Click(object sender, EventArgs e)
        {
            double Offset = 0;

            double.TryParse(tOffset.Text, out Offset);

            WipeLeftRight?.Invoke(Offset);
        }

        private void cmdUpDown_Click(object sender, EventArgs e)
        {
            double Offset = 0;

            double.TryParse(tOffset.Text, out Offset);

            WipeUpDown?.Invoke(Offset);
        }

        private void cmdWiperDiagonal_Click(object sender, EventArgs e)
        {
            double Offset = 0;

            double.TryParse(tOffset.Text, out Offset);

            WipeDiagonal?.Invoke(Offset);
        }

        private void cmdInsideOut_Click(object sender, EventArgs e)
        {
            double Offset = 0;

            double.TryParse(tOffset.Text, out Offset);

            WipeInsideOut?.Invoke(Offset);
        }

        private void cmdOutsideIn_Click(object sender, EventArgs e)
        {
            double Offset = 0;

            double.TryParse(tOffset.Text, out Offset);

            WipeOutsideIn?.Invoke(Offset);
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
                this.Height = 221;

                tssbOpenClose.Image = imageList2.Images[1];
            }

            ToolboxChange?.Invoke();
        }

        private void rbWiperClearNone_CheckedChanged(object sender, EventArgs e)
        {
            SetClsType();
        }

        private void rbWiperClearBefore_CheckedChanged(object sender, EventArgs e)
        {
            SetClsType();
        }
        

        private void SetClsType()
        {
            string ClearType = string.Empty;

            if (rbWiperClearNone.Checked)
            {
                ClearType = "None";
            }
            else if (rbWiperClearBefore.Checked)
            {
                ClearType = "Before";
            }
        
            WipeCls?.Invoke(ClearType);
        }
    }
}
