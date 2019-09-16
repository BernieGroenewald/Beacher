namespace Beacher
{
    partial class UCGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGrid));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tssbOpenClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdClearGrid = new System.Windows.Forms.Button();
            this.rbGridNumber = new System.Windows.Forms.RadioButton();
            this.rbGridmm = new System.Windows.Forms.RadioButton();
            this.cmdDrawGrid = new System.Windows.Forms.Button();
            this.tGridYLines = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tGridXlines = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tGridYmm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tGridXmm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.toolStripLabel1.Text = "Grid";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "navigate_close.png");
            this.imageList2.Images.SetKeyName(1, "navigate_open.png");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdClearGrid);
            this.groupBox3.Controls.Add(this.rbGridNumber);
            this.groupBox3.Controls.Add(this.rbGridmm);
            this.groupBox3.Controls.Add(this.cmdDrawGrid);
            this.groupBox3.Controls.Add(this.tGridYLines);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tGridXlines);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tGridYmm);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tGridXmm);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(3, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 142);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grid";
            // 
            // cmdClearGrid
            // 
            this.cmdClearGrid.Image = ((System.Drawing.Image)(resources.GetObject("cmdClearGrid.Image")));
            this.cmdClearGrid.Location = new System.Drawing.Point(252, 95);
            this.cmdClearGrid.Name = "cmdClearGrid";
            this.cmdClearGrid.Size = new System.Drawing.Size(37, 37);
            this.cmdClearGrid.TabIndex = 23;
            this.cmdClearGrid.UseVisualStyleBackColor = true;
            this.cmdClearGrid.Click += new System.EventHandler(this.cmdClearGrid_Click);
            // 
            // rbGridNumber
            // 
            this.rbGridNumber.AutoSize = true;
            this.rbGridNumber.Location = new System.Drawing.Point(205, 42);
            this.rbGridNumber.Name = "rbGridNumber";
            this.rbGridNumber.Size = new System.Drawing.Size(84, 17);
            this.rbGridNumber.TabIndex = 22;
            this.rbGridNumber.Text = "Grid Number";
            this.rbGridNumber.UseVisualStyleBackColor = true;
            this.rbGridNumber.CheckedChanged += new System.EventHandler(this.rbGridNumber_CheckedChanged);
            // 
            // rbGridmm
            // 
            this.rbGridmm.AutoSize = true;
            this.rbGridmm.Checked = true;
            this.rbGridmm.Location = new System.Drawing.Point(205, 19);
            this.rbGridmm.Name = "rbGridmm";
            this.rbGridmm.Size = new System.Drawing.Size(63, 17);
            this.rbGridmm.TabIndex = 21;
            this.rbGridmm.TabStop = true;
            this.rbGridmm.Text = "Grid mm";
            this.rbGridmm.UseVisualStyleBackColor = true;
            this.rbGridmm.CheckedChanged += new System.EventHandler(this.rbGridmm_CheckedChanged);
            // 
            // cmdDrawGrid
            // 
            this.cmdDrawGrid.Image = ((System.Drawing.Image)(resources.GetObject("cmdDrawGrid.Image")));
            this.cmdDrawGrid.Location = new System.Drawing.Point(209, 95);
            this.cmdDrawGrid.Name = "cmdDrawGrid";
            this.cmdDrawGrid.Size = new System.Drawing.Size(37, 37);
            this.cmdDrawGrid.TabIndex = 20;
            this.cmdDrawGrid.UseVisualStyleBackColor = true;
            this.cmdDrawGrid.Click += new System.EventHandler(this.cmdDrawGrid_Click);
            // 
            // tGridYLines
            // 
            this.tGridYLines.Location = new System.Drawing.Point(126, 112);
            this.tGridYLines.Name = "tGridYLines";
            this.tGridYLines.Size = new System.Drawing.Size(39, 20);
            this.tGridYLines.TabIndex = 20;
            this.tGridYLines.Text = "10";
            this.tGridYLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Number of y lines";
            // 
            // tGridXlines
            // 
            this.tGridXlines.Location = new System.Drawing.Point(126, 86);
            this.tGridXlines.Name = "tGridXlines";
            this.tGridXlines.Size = new System.Drawing.Size(39, 20);
            this.tGridXlines.TabIndex = 18;
            this.tGridXlines.Text = "10";
            this.tGridXlines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Number of x lines";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "-or-";
            // 
            // tGridYmm
            // 
            this.tGridYmm.Location = new System.Drawing.Point(126, 47);
            this.tGridYmm.Name = "tGridYmm";
            this.tGridYmm.Size = new System.Drawing.Size(39, 20);
            this.tGridYmm.TabIndex = 15;
            this.tGridYmm.Text = "100";
            this.tGridYmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Y every x mm";
            // 
            // tGridXmm
            // 
            this.tGridXmm.Location = new System.Drawing.Point(126, 21);
            this.tGridXmm.Name = "tGridXmm";
            this.tGridXmm.Size = new System.Drawing.Size(39, 20);
            this.tGridXmm.TabIndex = 13;
            this.tGridXmm.Text = "100";
            this.tGridXmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "X every x mm";
            // 
            // UCGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCGrid";
            this.Size = new System.Drawing.Size(305, 174);
            this.Load += new System.EventHandler(this.UCGrid_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tssbOpenClose;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdClearGrid;
        private System.Windows.Forms.RadioButton rbGridNumber;
        private System.Windows.Forms.RadioButton rbGridmm;
        private System.Windows.Forms.Button cmdDrawGrid;
        private System.Windows.Forms.TextBox tGridYLines;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tGridXlines;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tGridYmm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tGridXmm;
        private System.Windows.Forms.Label label8;
    }
}
