namespace Beacher
{
    partial class UCSpriral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSpriral));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tssbOpenClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbStopHorisontal = new System.Windows.Forms.RadioButton();
            this.rbStopVertical = new System.Windows.Forms.RadioButton();
            this.rbStopNone = new System.Windows.Forms.RadioButton();
            this.rbSpiralExponential = new System.Windows.Forms.RadioButton();
            this.rbSpiralCubic = new System.Windows.Forms.RadioButton();
            this.rbSpiralQuadratic = new System.Windows.Forms.RadioButton();
            this.rbSpiralLinear = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tSpiralSize = new System.Windows.Forms.TextBox();
            this.tSpiralOffset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tSpiralDegrees = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdSpiral = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbCounterClockwise = new System.Windows.Forms.RadioButton();
            this.rbClockwise = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbOutToIn = new System.Windows.Forms.RadioButton();
            this.rbInToOut = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(304, 25);
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
            this.toolStripLabel1.Text = "Spiral";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "navigate_close.png");
            this.imageList2.Images.SetKeyName(1, "navigate_open.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tSpiralSize);
            this.groupBox2.Controls.Add(this.tSpiralOffset);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tSpiralDegrees);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmdSpiral);
            this.groupBox2.Location = new System.Drawing.Point(3, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 429);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spiral";
            // 
            // rbStopHorisontal
            // 
            this.rbStopHorisontal.AutoSize = true;
            this.rbStopHorisontal.Location = new System.Drawing.Point(6, 42);
            this.rbStopHorisontal.Name = "rbStopHorisontal";
            this.rbStopHorisontal.Size = new System.Drawing.Size(143, 17);
            this.rbStopHorisontal.TabIndex = 17;
            this.rbStopHorisontal.Text = "Stop at Horisontal Border";
            this.rbStopHorisontal.UseVisualStyleBackColor = true;
            // 
            // rbStopVertical
            // 
            this.rbStopVertical.AutoSize = true;
            this.rbStopVertical.Location = new System.Drawing.Point(6, 65);
            this.rbStopVertical.Name = "rbStopVertical";
            this.rbStopVertical.Size = new System.Drawing.Size(131, 17);
            this.rbStopVertical.TabIndex = 18;
            this.rbStopVertical.Text = "Stop at Vertical Border";
            this.rbStopVertical.UseVisualStyleBackColor = true;
            // 
            // rbStopNone
            // 
            this.rbStopNone.AutoSize = true;
            this.rbStopNone.Checked = true;
            this.rbStopNone.Location = new System.Drawing.Point(6, 19);
            this.rbStopNone.Name = "rbStopNone";
            this.rbStopNone.Size = new System.Drawing.Size(103, 17);
            this.rbStopNone.TabIndex = 19;
            this.rbStopNone.TabStop = true;
            this.rbStopNone.Text = "No Border Stops";
            this.rbStopNone.UseVisualStyleBackColor = true;
            // 
            // rbSpiralExponential
            // 
            this.rbSpiralExponential.AutoSize = true;
            this.rbSpiralExponential.Location = new System.Drawing.Point(150, 42);
            this.rbSpiralExponential.Name = "rbSpiralExponential";
            this.rbSpiralExponential.Size = new System.Drawing.Size(80, 17);
            this.rbSpiralExponential.TabIndex = 23;
            this.rbSpiralExponential.Text = "Exponential";
            this.rbSpiralExponential.UseVisualStyleBackColor = true;
            // 
            // rbSpiralCubic
            // 
            this.rbSpiralCubic.AutoSize = true;
            this.rbSpiralCubic.Location = new System.Drawing.Point(150, 19);
            this.rbSpiralCubic.Name = "rbSpiralCubic";
            this.rbSpiralCubic.Size = new System.Drawing.Size(52, 17);
            this.rbSpiralCubic.TabIndex = 22;
            this.rbSpiralCubic.Text = "Cubic";
            this.rbSpiralCubic.UseVisualStyleBackColor = true;
            // 
            // rbSpiralQuadratic
            // 
            this.rbSpiralQuadratic.AutoSize = true;
            this.rbSpiralQuadratic.Location = new System.Drawing.Point(6, 42);
            this.rbSpiralQuadratic.Name = "rbSpiralQuadratic";
            this.rbSpiralQuadratic.Size = new System.Drawing.Size(71, 17);
            this.rbSpiralQuadratic.TabIndex = 21;
            this.rbSpiralQuadratic.Text = "Quadratic";
            this.rbSpiralQuadratic.UseVisualStyleBackColor = true;
            // 
            // rbSpiralLinear
            // 
            this.rbSpiralLinear.AutoSize = true;
            this.rbSpiralLinear.Checked = true;
            this.rbSpiralLinear.Location = new System.Drawing.Point(6, 19);
            this.rbSpiralLinear.Name = "rbSpiralLinear";
            this.rbSpiralLinear.Size = new System.Drawing.Size(54, 17);
            this.rbSpiralLinear.TabIndex = 20;
            this.rbSpiralLinear.TabStop = true;
            this.rbSpiralLinear.Text = "Linear";
            this.rbSpiralLinear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Max Size";
            // 
            // tSpiralSize
            // 
            this.tSpiralSize.Location = new System.Drawing.Point(76, 401);
            this.tSpiralSize.Name = "tSpiralSize";
            this.tSpiralSize.Size = new System.Drawing.Size(39, 20);
            this.tSpiralSize.TabIndex = 14;
            this.tSpiralSize.Text = "100";
            this.tSpiralSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tSpiralOffset
            // 
            this.tSpiralOffset.Location = new System.Drawing.Point(76, 375);
            this.tSpiralOffset.Name = "tSpiralOffset";
            this.tSpiralOffset.Size = new System.Drawing.Size(39, 20);
            this.tSpiralOffset.TabIndex = 13;
            this.tSpiralOffset.Text = "5";
            this.tSpiralOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Offset";
            // 
            // tSpiralDegrees
            // 
            this.tSpiralDegrees.Location = new System.Drawing.Point(76, 349);
            this.tSpiralDegrees.Name = "tSpiralDegrees";
            this.tSpiralDegrees.Size = new System.Drawing.Size(39, 20);
            this.tSpiralDegrees.TabIndex = 11;
            this.tSpiralDegrees.Text = "1";
            this.tSpiralDegrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Degrees";
            // 
            // cmdSpiral
            // 
            this.cmdSpiral.Image = ((System.Drawing.Image)(resources.GetObject("cmdSpiral.Image")));
            this.cmdSpiral.Location = new System.Drawing.Point(252, 384);
            this.cmdSpiral.Name = "cmdSpiral";
            this.cmdSpiral.Size = new System.Drawing.Size(37, 37);
            this.cmdSpiral.TabIndex = 9;
            this.cmdSpiral.UseVisualStyleBackColor = true;
            this.cmdSpiral.Click += new System.EventHandler(this.cmdSpiral_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStopVertical);
            this.groupBox1.Controls.Add(this.rbStopHorisontal);
            this.groupBox1.Controls.Add(this.rbStopNone);
            this.groupBox1.Location = new System.Drawing.Point(6, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 92);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border Stops";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSpiralLinear);
            this.groupBox3.Controls.Add(this.rbSpiralQuadratic);
            this.groupBox3.Controls.Add(this.rbSpiralExponential);
            this.groupBox3.Controls.Add(this.rbSpiralCubic);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 75);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spiral Type";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbCounterClockwise);
            this.groupBox4.Controls.Add(this.rbClockwise);
            this.groupBox4.Location = new System.Drawing.Point(7, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 69);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Direction";
            // 
            // rbCounterClockwise
            // 
            this.rbCounterClockwise.AutoSize = true;
            this.rbCounterClockwise.Location = new System.Drawing.Point(6, 42);
            this.rbCounterClockwise.Name = "rbCounterClockwise";
            this.rbCounterClockwise.Size = new System.Drawing.Size(110, 17);
            this.rbCounterClockwise.TabIndex = 20;
            this.rbCounterClockwise.Text = "CounterClockwise";
            this.rbCounterClockwise.UseVisualStyleBackColor = true;
            // 
            // rbClockwise
            // 
            this.rbClockwise.AutoSize = true;
            this.rbClockwise.Checked = true;
            this.rbClockwise.Location = new System.Drawing.Point(6, 19);
            this.rbClockwise.Name = "rbClockwise";
            this.rbClockwise.Size = new System.Drawing.Size(73, 17);
            this.rbClockwise.TabIndex = 21;
            this.rbClockwise.TabStop = true;
            this.rbClockwise.Text = "Clockwise";
            this.rbClockwise.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbOutToIn);
            this.groupBox5.Controls.Add(this.rbInToOut);
            this.groupBox5.Location = new System.Drawing.Point(6, 274);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 69);
            this.groupBox5.TabIndex = 79;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "In or Out";
            // 
            // rbOutToIn
            // 
            this.rbOutToIn.AutoSize = true;
            this.rbOutToIn.Location = new System.Drawing.Point(6, 42);
            this.rbOutToIn.Name = "rbOutToIn";
            this.rbOutToIn.Size = new System.Drawing.Size(66, 17);
            this.rbOutToIn.TabIndex = 20;
            this.rbOutToIn.Text = "Out to In";
            this.rbOutToIn.UseVisualStyleBackColor = true;
            // 
            // rbInToOut
            // 
            this.rbInToOut.AutoSize = true;
            this.rbInToOut.Checked = true;
            this.rbInToOut.Location = new System.Drawing.Point(6, 19);
            this.rbInToOut.Name = "rbInToOut";
            this.rbInToOut.Size = new System.Drawing.Size(66, 17);
            this.rbInToOut.TabIndex = 21;
            this.rbInToOut.TabStop = true;
            this.rbInToOut.Text = "In to Out";
            this.rbInToOut.UseVisualStyleBackColor = true;
            // 
            // UCSpriral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCSpriral";
            this.Size = new System.Drawing.Size(304, 461);
            this.Load += new System.EventHandler(this.UCSpriral_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tssbOpenClose;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSpiralExponential;
        private System.Windows.Forms.RadioButton rbSpiralCubic;
        private System.Windows.Forms.RadioButton rbSpiralQuadratic;
        private System.Windows.Forms.RadioButton rbSpiralLinear;
        private System.Windows.Forms.RadioButton rbStopNone;
        private System.Windows.Forms.RadioButton rbStopVertical;
        private System.Windows.Forms.RadioButton rbStopHorisontal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tSpiralSize;
        private System.Windows.Forms.TextBox tSpiralOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tSpiralDegrees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdSpiral;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbOutToIn;
        private System.Windows.Forms.RadioButton rbInToOut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbCounterClockwise;
        private System.Windows.Forms.RadioButton rbClockwise;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
