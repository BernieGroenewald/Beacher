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
    public partial class ucImage : UserControl
    {
        public event ImageFileChange ImageFileChanged;
        public delegate void ImageFileChange(string FileName);

        public event ImageSizeChange ImageSizeChanged;
        public delegate void ImageSizeChange(string PlusOrMinus);

        public event ImagePositionChange ImagePositionChanged;
        public delegate void ImagePositionChange(string NewPosition);

        public event ImageTraceClick ImageTraceClicked;
        public delegate void ImageTraceClick(bool InsideOut);

        public event ToolboxChanged ToolboxChange;
        public delegate void ToolboxChanged();

        public ucImage()
        {
            InitializeComponent();
        }

        private void ucImage_Load(object sender, EventArgs e)
        {
            this.Height = toolStrip1.Height;
            tssbOpenClose.Image = imageList2.Images[0];
        }

        private void cmdLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            string ImagePath = string.Empty;

            fd.Multiselect = false;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in fd.FileNames)
                {
                    ImagePath = file;
                }
            }

            ImageFileChanged?.Invoke(ImagePath);
        }

        private void cmdImagePlus_Click(object sender, EventArgs e)
        {
            ImageSizeChanged?.Invoke("+");
        }

        private void cmdImageMinus_Click(object sender, EventArgs e)
        {
            ImageSizeChanged?.Invoke("-");
        }

        private void cmdTopLeft_Click(object sender, EventArgs e)
        {
            Button ThisButton = (Button)sender;
            string ButtonTag = ThisButton.Tag.ToString();

            ImagePositionChanged?.Invoke(ButtonTag);
        }

        private void cmdTopCentre_Click(object sender, EventArgs e)
        {
            Button ThisButton = (Button)sender;
            string ButtonTag = ThisButton.Tag.ToString();

            ImagePositionChanged?.Invoke(ButtonTag);
        }

        private void cmdTopRight_Click(object sender, EventArgs e)
        {
            Button ThisButton = (Button)sender;
            string ButtonTag = ThisButton.Tag.ToString();

            ImagePositionChanged?.Invoke(ButtonTag);
        }

        private void cmdLeftCentre_Click(object sender, EventArgs e)
        {
            Button ThisButton = (Button)sender;
            string ButtonTag = ThisButton.Tag.ToString();

            ImagePositionChanged?.Invoke(ButtonTag);
        }

        private void cmdCentre_Click(object sender, EventArgs e)
        {
            Button ThisButton = (Button)sender;
            string ButtonTag = ThisButton.Tag.ToString();

            ImagePositionChanged?.Invoke(ButtonTag);
        }

        private void cmdRightCentre_Click(object sender, EventArgs e)
        {
            Button ThisButton = (Button)sender;
            string ButtonTag = ThisButton.Tag.ToString();

            ImagePositionChanged?.Invoke(ButtonTag);
        }

        private void cmdBottomLeft_Click(object sender, EventArgs e)
        {
            Button ThisButton = (Button)sender;
            string ButtonTag = ThisButton.Tag.ToString();

            ImagePositionChanged?.Invoke(ButtonTag);
        }

        private void cmdBottomCentre_Click(object sender, EventArgs e)
        {
            Button ThisButton = (Button)sender;
            string ButtonTag = ThisButton.Tag.ToString();

            ImagePositionChanged?.Invoke(ButtonTag);
        }

        private void cmdBottomRight_Click(object sender, EventArgs e)
        {
            Button ThisButton = (Button)sender;
            string ButtonTag = ThisButton.Tag.ToString();

            ImagePositionChanged?.Invoke(ButtonTag);
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
                this.Height = 233;

                tssbOpenClose.Image = imageList2.Images[1];
            }

            ToolboxChange?.Invoke();
        }

        private void cmdTrace_Click(object sender, EventArgs e)
        {
            ImageTraceClicked?.Invoke(cInsideOut.Checked);
        }
    }
}
