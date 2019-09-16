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
    public partial class UCGrid : UserControl
    {
        public event GridCleared GridClear;
        public delegate void GridCleared();

        public event GridDrawn DrawGrid;
        public delegate void GridDrawn(string GridType, int MeasureX, int MeasureY);

        public event ToolboxChanged ToolboxChange;
        public delegate void ToolboxChanged();

        string GridType = "mm";

        public UCGrid()
        {
            InitializeComponent();
        }

        private void UCGrid_Load(object sender, EventArgs e)
        {
            this.Height = toolStrip1.Height;
            tssbOpenClose.Image = imageList2.Images[0];
        }

        private void SetGridType()
        {
            if (rbGridmm.Checked)
            {
                tGridXmm.Enabled = true;
                tGridYmm.Enabled = true;
                tGridXlines.Enabled = false;
                tGridYLines.Enabled = false;

                GridType = "mm";
            }
            else
            {
                tGridXmm.Enabled = false;
                tGridYmm.Enabled = false;
                tGridXlines.Enabled = true;
                tGridYLines.Enabled = true;

                GridType = "Number";
            }
        }

        private void rbGridmm_CheckedChanged(object sender, EventArgs e)
        {
            SetGridType();
        }

        private void rbGridNumber_CheckedChanged(object sender, EventArgs e)
        {
            SetGridType();
        }

        private void cmdClearGrid_Click(object sender, EventArgs e)
        {
            GridClear?.Invoke();
        }

        private void cmdDrawGrid_Click(object sender, EventArgs e)
        {
            int MeasureX = 0;
            int MeasureY = 0;
            
            if (rbGridmm.Checked)
            {
                int.TryParse(tGridXmm.Text, out MeasureX);
                int.TryParse(tGridYmm.Text, out MeasureY);
            }
            else
            {
                int.TryParse(tGridXlines.Text, out MeasureX);
                int.TryParse(tGridYLines.Text, out MeasureY);
            }

            DrawGrid?.Invoke(GridType, MeasureX, MeasureY);
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
    }
}
