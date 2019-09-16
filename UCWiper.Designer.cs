namespace Beacher
{
    partial class UCWiper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWiper));
            this.cmdUpDown = new System.Windows.Forms.Button();
            this.cmdOutsideIn = new System.Windows.Forms.Button();
            this.cmdInsideOut = new System.Windows.Forms.Button();
            this.cmdWiperDiagonal = new System.Windows.Forms.Button();
            this.cmdLeftRight = new System.Windows.Forms.Button();
            this.tOffset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tssbOpenClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gbManualMove = new System.Windows.Forms.GroupBox();
            this.rbWiperClearBefore = new System.Windows.Forms.RadioButton();
            this.rbWiperClearNone = new System.Windows.Forms.RadioButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.gbManualMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdUpDown
            // 
            this.cmdUpDown.Image = ((System.Drawing.Image)(resources.GetObject("cmdUpDown.Image")));
            this.cmdUpDown.Location = new System.Drawing.Point(77, 19);
            this.cmdUpDown.Name = "cmdUpDown";
            this.cmdUpDown.Size = new System.Drawing.Size(65, 65);
            this.cmdUpDown.TabIndex = 68;
            this.cmdUpDown.UseVisualStyleBackColor = true;
            this.cmdUpDown.Click += new System.EventHandler(this.cmdUpDown_Click);
            // 
            // cmdOutsideIn
            // 
            this.cmdOutsideIn.Image = ((System.Drawing.Image)(resources.GetObject("cmdOutsideIn.Image")));
            this.cmdOutsideIn.Location = new System.Drawing.Point(77, 90);
            this.cmdOutsideIn.Name = "cmdOutsideIn";
            this.cmdOutsideIn.Size = new System.Drawing.Size(65, 65);
            this.cmdOutsideIn.TabIndex = 67;
            this.cmdOutsideIn.UseVisualStyleBackColor = true;
            this.cmdOutsideIn.Click += new System.EventHandler(this.cmdOutsideIn_Click);
            // 
            // cmdInsideOut
            // 
            this.cmdInsideOut.Image = ((System.Drawing.Image)(resources.GetObject("cmdInsideOut.Image")));
            this.cmdInsideOut.Location = new System.Drawing.Point(6, 90);
            this.cmdInsideOut.Name = "cmdInsideOut";
            this.cmdInsideOut.Size = new System.Drawing.Size(65, 65);
            this.cmdInsideOut.TabIndex = 66;
            this.cmdInsideOut.UseVisualStyleBackColor = true;
            this.cmdInsideOut.Click += new System.EventHandler(this.cmdInsideOut_Click);
            // 
            // cmdWiperDiagonal
            // 
            this.cmdWiperDiagonal.Image = ((System.Drawing.Image)(resources.GetObject("cmdWiperDiagonal.Image")));
            this.cmdWiperDiagonal.Location = new System.Drawing.Point(148, 19);
            this.cmdWiperDiagonal.Name = "cmdWiperDiagonal";
            this.cmdWiperDiagonal.Size = new System.Drawing.Size(65, 65);
            this.cmdWiperDiagonal.TabIndex = 65;
            this.cmdWiperDiagonal.UseVisualStyleBackColor = true;
            this.cmdWiperDiagonal.Click += new System.EventHandler(this.cmdWiperDiagonal_Click);
            // 
            // cmdLeftRight
            // 
            this.cmdLeftRight.Image = ((System.Drawing.Image)(resources.GetObject("cmdLeftRight.Image")));
            this.cmdLeftRight.Location = new System.Drawing.Point(6, 19);
            this.cmdLeftRight.Name = "cmdLeftRight";
            this.cmdLeftRight.Size = new System.Drawing.Size(65, 65);
            this.cmdLeftRight.TabIndex = 64;
            this.cmdLeftRight.UseVisualStyleBackColor = true;
            this.cmdLeftRight.Click += new System.EventHandler(this.cmdLeftRight_Click);
            // 
            // tOffset
            // 
            this.tOffset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tOffset.Location = new System.Drawing.Point(77, 161);
            this.tOffset.Name = "tOffset";
            this.tOffset.Size = new System.Drawing.Size(39, 20);
            this.tOffset.TabIndex = 62;
            this.tOffset.Text = "10";
            this.tOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Line Offset";
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
            this.toolStrip1.TabIndex = 70;
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
            this.toolStripLabel1.Text = "Wiper";
            // 
            // gbManualMove
            // 
            this.gbManualMove.Controls.Add(this.rbWiperClearBefore);
            this.gbManualMove.Controls.Add(this.rbWiperClearNone);
            this.gbManualMove.Controls.Add(this.cmdLeftRight);
            this.gbManualMove.Controls.Add(this.cmdUpDown);
            this.gbManualMove.Controls.Add(this.tOffset);
            this.gbManualMove.Controls.Add(this.label5);
            this.gbManualMove.Controls.Add(this.cmdOutsideIn);
            this.gbManualMove.Controls.Add(this.cmdWiperDiagonal);
            this.gbManualMove.Controls.Add(this.cmdInsideOut);
            this.gbManualMove.Location = new System.Drawing.Point(3, 28);
            this.gbManualMove.Name = "gbManualMove";
            this.gbManualMove.Size = new System.Drawing.Size(296, 189);
            this.gbManualMove.TabIndex = 69;
            this.gbManualMove.TabStop = false;
            this.gbManualMove.Text = "Wipe Table";
            // 
            // rbWiperClearBefore
            // 
            this.rbWiperClearBefore.AutoSize = true;
            this.rbWiperClearBefore.Location = new System.Drawing.Point(149, 115);
            this.rbWiperClearBefore.Name = "rbWiperClearBefore";
            this.rbWiperClearBefore.Size = new System.Drawing.Size(142, 17);
            this.rbWiperClearBefore.TabIndex = 70;
            this.rbWiperClearBefore.Text = "Clear screen before wipe";
            this.rbWiperClearBefore.UseVisualStyleBackColor = true;
            this.rbWiperClearBefore.CheckedChanged += new System.EventHandler(this.rbWiperClearBefore_CheckedChanged);
            // 
            // rbWiperClearNone
            // 
            this.rbWiperClearNone.AutoSize = true;
            this.rbWiperClearNone.Checked = true;
            this.rbWiperClearNone.Location = new System.Drawing.Point(149, 91);
            this.rbWiperClearNone.Name = "rbWiperClearNone";
            this.rbWiperClearNone.Size = new System.Drawing.Size(118, 17);
            this.rbWiperClearNone.TabIndex = 69;
            this.rbWiperClearNone.TabStop = true;
            this.rbWiperClearNone.Text = "Do not clear screen";
            this.rbWiperClearNone.UseVisualStyleBackColor = true;
            this.rbWiperClearNone.CheckedChanged += new System.EventHandler(this.rbWiperClearNone_CheckedChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "navigate_close.png");
            this.imageList2.Images.SetKeyName(1, "navigate_open.png");
            // 
            // UCWiper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbManualMove);
            this.Name = "UCWiper";
            this.Size = new System.Drawing.Size(305, 221);
            this.Load += new System.EventHandler(this.UCWiper_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbManualMove.ResumeLayout(false);
            this.gbManualMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUpDown;
        private System.Windows.Forms.Button cmdOutsideIn;
        private System.Windows.Forms.Button cmdInsideOut;
        private System.Windows.Forms.Button cmdWiperDiagonal;
        private System.Windows.Forms.Button cmdLeftRight;
        private System.Windows.Forms.TextBox tOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tssbOpenClose;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox gbManualMove;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.RadioButton rbWiperClearBefore;
        private System.Windows.Forms.RadioButton rbWiperClearNone;
    }
}
