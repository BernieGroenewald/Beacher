namespace Beacher
{
    partial class ucImage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucImage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tssbOpenClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gbManualMove = new System.Windows.Forms.GroupBox();
            this.cmdTrace = new System.Windows.Forms.Button();
            this.cmdImageMinus = new System.Windows.Forms.Button();
            this.cmdImagePlus = new System.Windows.Forms.Button();
            this.cmdBottomRight = new System.Windows.Forms.Button();
            this.cmdBottomCentre = new System.Windows.Forms.Button();
            this.cmdBottomLeft = new System.Windows.Forms.Button();
            this.cmdRightCentre = new System.Windows.Forms.Button();
            this.cmdCentre = new System.Windows.Forms.Button();
            this.cmdLeftCentre = new System.Windows.Forms.Button();
            this.cmdTopRight = new System.Windows.Forms.Button();
            this.cmdTopCentre = new System.Windows.Forms.Button();
            this.cmdTopLeft = new System.Windows.Forms.Button();
            this.cmdLoadImage = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.cInsideOut = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.gbManualMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbOpenClose,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(305, 25);
            this.toolStrip1.TabIndex = 72;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tssbOpenClose
            // 
            this.tssbOpenClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbOpenClose.Image = ((System.Drawing.Image)(resources.GetObject("tssbOpenClose.Image")));
            this.tssbOpenClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbOpenClose.Name = "tssbOpenClose";
            this.tssbOpenClose.Size = new System.Drawing.Size(23, 22);
            this.tssbOpenClose.Click += new System.EventHandler(this.tssbOpenClose_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(250, 22);
            this.toolStripLabel1.Text = "Background Image";
            // 
            // gbManualMove
            // 
            this.gbManualMove.Controls.Add(this.cInsideOut);
            this.gbManualMove.Controls.Add(this.cmdTrace);
            this.gbManualMove.Controls.Add(this.cmdImageMinus);
            this.gbManualMove.Controls.Add(this.cmdImagePlus);
            this.gbManualMove.Controls.Add(this.cmdBottomRight);
            this.gbManualMove.Controls.Add(this.cmdBottomCentre);
            this.gbManualMove.Controls.Add(this.cmdBottomLeft);
            this.gbManualMove.Controls.Add(this.cmdRightCentre);
            this.gbManualMove.Controls.Add(this.cmdCentre);
            this.gbManualMove.Controls.Add(this.cmdLeftCentre);
            this.gbManualMove.Controls.Add(this.cmdTopRight);
            this.gbManualMove.Controls.Add(this.cmdTopCentre);
            this.gbManualMove.Controls.Add(this.cmdTopLeft);
            this.gbManualMove.Controls.Add(this.cmdLoadImage);
            this.gbManualMove.Location = new System.Drawing.Point(3, 28);
            this.gbManualMove.Name = "gbManualMove";
            this.gbManualMove.Size = new System.Drawing.Size(296, 201);
            this.gbManualMove.TabIndex = 71;
            this.gbManualMove.TabStop = false;
            // 
            // cmdTrace
            // 
            this.cmdTrace.Image = ((System.Drawing.Image)(resources.GetObject("cmdTrace.Image")));
            this.cmdTrace.Location = new System.Drawing.Point(160, 145);
            this.cmdTrace.Name = "cmdTrace";
            this.cmdTrace.Size = new System.Drawing.Size(50, 50);
            this.cmdTrace.TabIndex = 12;
            this.cmdTrace.UseVisualStyleBackColor = true;
            this.cmdTrace.Click += new System.EventHandler(this.cmdTrace_Click);
            // 
            // cmdImageMinus
            // 
            this.cmdImageMinus.Image = ((System.Drawing.Image)(resources.GetObject("cmdImageMinus.Image")));
            this.cmdImageMinus.Location = new System.Drawing.Point(105, 23);
            this.cmdImageMinus.Name = "cmdImageMinus";
            this.cmdImageMinus.Size = new System.Drawing.Size(36, 36);
            this.cmdImageMinus.TabIndex = 11;
            this.cmdImageMinus.UseVisualStyleBackColor = true;
            this.cmdImageMinus.Click += new System.EventHandler(this.cmdImageMinus_Click);
            // 
            // cmdImagePlus
            // 
            this.cmdImagePlus.Image = ((System.Drawing.Image)(resources.GetObject("cmdImagePlus.Image")));
            this.cmdImagePlus.Location = new System.Drawing.Point(63, 23);
            this.cmdImagePlus.Name = "cmdImagePlus";
            this.cmdImagePlus.Size = new System.Drawing.Size(36, 36);
            this.cmdImagePlus.TabIndex = 10;
            this.cmdImagePlus.UseVisualStyleBackColor = true;
            this.cmdImagePlus.Click += new System.EventHandler(this.cmdImagePlus_Click);
            // 
            // cmdBottomRight
            // 
            this.cmdBottomRight.Image = ((System.Drawing.Image)(resources.GetObject("cmdBottomRight.Image")));
            this.cmdBottomRight.Location = new System.Drawing.Point(90, 157);
            this.cmdBottomRight.Name = "cmdBottomRight";
            this.cmdBottomRight.Size = new System.Drawing.Size(36, 36);
            this.cmdBottomRight.TabIndex = 9;
            this.cmdBottomRight.Tag = "BottomRight";
            this.cmdBottomRight.UseVisualStyleBackColor = true;
            this.cmdBottomRight.Click += new System.EventHandler(this.cmdBottomRight_Click);
            // 
            // cmdBottomCentre
            // 
            this.cmdBottomCentre.Image = ((System.Drawing.Image)(resources.GetObject("cmdBottomCentre.Image")));
            this.cmdBottomCentre.Location = new System.Drawing.Point(48, 156);
            this.cmdBottomCentre.Name = "cmdBottomCentre";
            this.cmdBottomCentre.Size = new System.Drawing.Size(36, 36);
            this.cmdBottomCentre.TabIndex = 8;
            this.cmdBottomCentre.Tag = "BottomCentre";
            this.cmdBottomCentre.UseVisualStyleBackColor = true;
            this.cmdBottomCentre.Click += new System.EventHandler(this.cmdBottomCentre_Click);
            // 
            // cmdBottomLeft
            // 
            this.cmdBottomLeft.Image = ((System.Drawing.Image)(resources.GetObject("cmdBottomLeft.Image")));
            this.cmdBottomLeft.Location = new System.Drawing.Point(6, 156);
            this.cmdBottomLeft.Name = "cmdBottomLeft";
            this.cmdBottomLeft.Size = new System.Drawing.Size(36, 36);
            this.cmdBottomLeft.TabIndex = 7;
            this.cmdBottomLeft.Tag = "BottomLeft";
            this.cmdBottomLeft.UseVisualStyleBackColor = true;
            this.cmdBottomLeft.Click += new System.EventHandler(this.cmdBottomLeft_Click);
            // 
            // cmdRightCentre
            // 
            this.cmdRightCentre.Image = ((System.Drawing.Image)(resources.GetObject("cmdRightCentre.Image")));
            this.cmdRightCentre.Location = new System.Drawing.Point(90, 115);
            this.cmdRightCentre.Name = "cmdRightCentre";
            this.cmdRightCentre.Size = new System.Drawing.Size(36, 36);
            this.cmdRightCentre.TabIndex = 6;
            this.cmdRightCentre.Tag = "RightCentre";
            this.cmdRightCentre.UseVisualStyleBackColor = true;
            this.cmdRightCentre.Click += new System.EventHandler(this.cmdRightCentre_Click);
            // 
            // cmdCentre
            // 
            this.cmdCentre.Image = ((System.Drawing.Image)(resources.GetObject("cmdCentre.Image")));
            this.cmdCentre.Location = new System.Drawing.Point(48, 114);
            this.cmdCentre.Name = "cmdCentre";
            this.cmdCentre.Size = new System.Drawing.Size(36, 36);
            this.cmdCentre.TabIndex = 5;
            this.cmdCentre.Tag = "Centre";
            this.cmdCentre.UseVisualStyleBackColor = true;
            this.cmdCentre.Click += new System.EventHandler(this.cmdCentre_Click);
            // 
            // cmdLeftCentre
            // 
            this.cmdLeftCentre.Image = ((System.Drawing.Image)(resources.GetObject("cmdLeftCentre.Image")));
            this.cmdLeftCentre.Location = new System.Drawing.Point(6, 114);
            this.cmdLeftCentre.Name = "cmdLeftCentre";
            this.cmdLeftCentre.Size = new System.Drawing.Size(36, 36);
            this.cmdLeftCentre.TabIndex = 4;
            this.cmdLeftCentre.Tag = "LeftCentre";
            this.cmdLeftCentre.UseVisualStyleBackColor = true;
            this.cmdLeftCentre.Click += new System.EventHandler(this.cmdLeftCentre_Click);
            // 
            // cmdTopRight
            // 
            this.cmdTopRight.Image = ((System.Drawing.Image)(resources.GetObject("cmdTopRight.Image")));
            this.cmdTopRight.Location = new System.Drawing.Point(91, 73);
            this.cmdTopRight.Name = "cmdTopRight";
            this.cmdTopRight.Size = new System.Drawing.Size(36, 36);
            this.cmdTopRight.TabIndex = 3;
            this.cmdTopRight.Tag = "TopRight";
            this.cmdTopRight.UseVisualStyleBackColor = true;
            this.cmdTopRight.Click += new System.EventHandler(this.cmdTopRight_Click);
            // 
            // cmdTopCentre
            // 
            this.cmdTopCentre.Image = ((System.Drawing.Image)(resources.GetObject("cmdTopCentre.Image")));
            this.cmdTopCentre.Location = new System.Drawing.Point(48, 72);
            this.cmdTopCentre.Name = "cmdTopCentre";
            this.cmdTopCentre.Size = new System.Drawing.Size(36, 36);
            this.cmdTopCentre.TabIndex = 2;
            this.cmdTopCentre.Tag = "TopCentre";
            this.cmdTopCentre.UseVisualStyleBackColor = true;
            this.cmdTopCentre.Click += new System.EventHandler(this.cmdTopCentre_Click);
            // 
            // cmdTopLeft
            // 
            this.cmdTopLeft.Image = ((System.Drawing.Image)(resources.GetObject("cmdTopLeft.Image")));
            this.cmdTopLeft.Location = new System.Drawing.Point(6, 72);
            this.cmdTopLeft.Name = "cmdTopLeft";
            this.cmdTopLeft.Size = new System.Drawing.Size(36, 36);
            this.cmdTopLeft.TabIndex = 1;
            this.cmdTopLeft.Tag = "TopLeft";
            this.cmdTopLeft.UseVisualStyleBackColor = true;
            this.cmdTopLeft.Click += new System.EventHandler(this.cmdTopLeft_Click);
            // 
            // cmdLoadImage
            // 
            this.cmdLoadImage.Image = ((System.Drawing.Image)(resources.GetObject("cmdLoadImage.Image")));
            this.cmdLoadImage.Location = new System.Drawing.Point(7, 16);
            this.cmdLoadImage.Name = "cmdLoadImage";
            this.cmdLoadImage.Size = new System.Drawing.Size(50, 50);
            this.cmdLoadImage.TabIndex = 0;
            this.cmdLoadImage.UseVisualStyleBackColor = true;
            this.cmdLoadImage.Click += new System.EventHandler(this.cmdLoadImage_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "navigate_close.png");
            this.imageList2.Images.SetKeyName(1, "navigate_open.png");
            // 
            // cInsideOut
            // 
            this.cInsideOut.AutoSize = true;
            this.cInsideOut.Location = new System.Drawing.Point(160, 126);
            this.cInsideOut.Name = "cInsideOut";
            this.cInsideOut.Size = new System.Drawing.Size(74, 17);
            this.cInsideOut.TabIndex = 13;
            this.cInsideOut.Text = "Inside Out";
            this.cInsideOut.UseVisualStyleBackColor = true;
            // 
            // ucImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbManualMove);
            this.Name = "ucImage";
            this.Size = new System.Drawing.Size(305, 233);
            this.Load += new System.EventHandler(this.ucImage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbManualMove.ResumeLayout(false);
            this.gbManualMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tssbOpenClose;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox gbManualMove;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button cmdImageMinus;
        private System.Windows.Forms.Button cmdImagePlus;
        private System.Windows.Forms.Button cmdBottomRight;
        private System.Windows.Forms.Button cmdBottomCentre;
        private System.Windows.Forms.Button cmdBottomLeft;
        private System.Windows.Forms.Button cmdRightCentre;
        private System.Windows.Forms.Button cmdCentre;
        private System.Windows.Forms.Button cmdLeftCentre;
        private System.Windows.Forms.Button cmdTopRight;
        private System.Windows.Forms.Button cmdTopCentre;
        private System.Windows.Forms.Button cmdTopLeft;
        private System.Windows.Forms.Button cmdLoadImage;
        private System.Windows.Forms.Button cmdTrace;
        private System.Windows.Forms.CheckBox cInsideOut;
    }
}
