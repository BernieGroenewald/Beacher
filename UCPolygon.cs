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
    public partial class UCPolygon : UserControl
    {
        public event ToolboxChanged ToolboxChange;
        public delegate void ToolboxChanged();

        public event PolyDrawn DrawPoly;
        public delegate void PolyDrawn(int NumberOfSides, int SideLength);

        public UCPolygon()
        {
            InitializeComponent();
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
                this.Height = 104;

                tssbOpenClose.Image = imageList2.Images[1];
            }

            ToolboxChange?.Invoke();
        }

        private void cmdPolygon_Click(object sender, EventArgs e)
        {
            int NumberOfSides = 0;
            int SideLenght = 0;

            int.TryParse(tNumberOfSides.Text, out NumberOfSides);
            int.TryParse(tSideLength.Text, out SideLenght);

            DrawPoly?.Invoke(NumberOfSides, SideLenght);
        }

        private void UCPolygon_Load(object sender, EventArgs e)
        {
            this.Height = toolStrip1.Height;
            tssbOpenClose.Image = imageList2.Images[0];
        }
    }
}
