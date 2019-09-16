namespace Beacher
{
    partial class UCPolySpiral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPolySpiral));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tssbOpenClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDecFive = new System.Windows.Forms.Button();
            this.cmdDecOne = new System.Windows.Forms.Button();
            this.cmdDecTen = new System.Windows.Forms.Button();
            this.cmdIncTen = new System.Windows.Forms.Button();
            this.cmdIncOne = new System.Windows.Forms.Button();
            this.cmdIncFive = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbStopVertical = new System.Windows.Forms.RadioButton();
            this.rbStopHorisontal = new System.Windows.Forms.RadioButton();
            this.rbStopNone = new System.Windows.Forms.RadioButton();
            this.tIncrementSideLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tPolyRevolutions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDrawPolySpiral = new System.Windows.Forms.Button();
            this.tSideLength = new System.Windows.Forms.TextBox();
            this.tPolyAngleIncrement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(302, 25);
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
            this.toolStripLabel1.Text = "Poly Spiral";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "navigate_close.png");
            this.imageList2.Images.SetKeyName(1, "navigate_open.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdDecFive);
            this.groupBox1.Controls.Add(this.cmdDecOne);
            this.groupBox1.Controls.Add(this.cmdDecTen);
            this.groupBox1.Controls.Add(this.cmdIncTen);
            this.groupBox1.Controls.Add(this.cmdIncOne);
            this.groupBox1.Controls.Add(this.cmdIncFive);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tIncrementSideLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tPolyRevolutions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdDrawPolySpiral);
            this.groupBox1.Controls.Add(this.tSideLength);
            this.groupBox1.Controls.Add(this.tPolyAngleIncrement);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 243);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // cmdDecFive
            // 
            this.cmdDecFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDecFive.Location = new System.Drawing.Point(48, 41);
            this.cmdDecFive.Name = "cmdDecFive";
            this.cmdDecFive.Size = new System.Drawing.Size(34, 23);
            this.cmdDecFive.TabIndex = 82;
            this.cmdDecFive.Text = "-5";
            this.cmdDecFive.UseVisualStyleBackColor = true;
            this.cmdDecFive.Click += new System.EventHandler(this.cmdDecFive_Click);
            // 
            // cmdDecOne
            // 
            this.cmdDecOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDecOne.Location = new System.Drawing.Point(88, 41);
            this.cmdDecOne.Name = "cmdDecOne";
            this.cmdDecOne.Size = new System.Drawing.Size(34, 23);
            this.cmdDecOne.TabIndex = 83;
            this.cmdDecOne.Text = "-1";
            this.cmdDecOne.UseVisualStyleBackColor = true;
            this.cmdDecOne.Click += new System.EventHandler(this.cmdDecOne_Click);
            // 
            // cmdDecTen
            // 
            this.cmdDecTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDecTen.Location = new System.Drawing.Point(8, 41);
            this.cmdDecTen.Name = "cmdDecTen";
            this.cmdDecTen.Size = new System.Drawing.Size(34, 23);
            this.cmdDecTen.TabIndex = 81;
            this.cmdDecTen.Text = "-10";
            this.cmdDecTen.UseVisualStyleBackColor = true;
            this.cmdDecTen.Click += new System.EventHandler(this.cmdDecTen_Click);
            // 
            // cmdIncTen
            // 
            this.cmdIncTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdIncTen.Location = new System.Drawing.Point(243, 41);
            this.cmdIncTen.Name = "cmdIncTen";
            this.cmdIncTen.Size = new System.Drawing.Size(34, 23);
            this.cmdIncTen.TabIndex = 79;
            this.cmdIncTen.Text = "+10";
            this.cmdIncTen.UseVisualStyleBackColor = true;
            this.cmdIncTen.Click += new System.EventHandler(this.cmdIncTen_Click);
            // 
            // cmdIncOne
            // 
            this.cmdIncOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdIncOne.Location = new System.Drawing.Point(163, 41);
            this.cmdIncOne.Name = "cmdIncOne";
            this.cmdIncOne.Size = new System.Drawing.Size(34, 23);
            this.cmdIncOne.TabIndex = 78;
            this.cmdIncOne.Text = "+1";
            this.cmdIncOne.UseVisualStyleBackColor = true;
            this.cmdIncOne.Click += new System.EventHandler(this.cmdIncOne_Click);
            // 
            // cmdIncFive
            // 
            this.cmdIncFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdIncFive.Location = new System.Drawing.Point(203, 41);
            this.cmdIncFive.Name = "cmdIncFive";
            this.cmdIncFive.Size = new System.Drawing.Size(34, 23);
            this.cmdIncFive.TabIndex = 80;
            this.cmdIncFive.Text = "+5";
            this.cmdIncFive.UseVisualStyleBackColor = true;
            this.cmdIncFive.Click += new System.EventHandler(this.cmdIncFive_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbStopVertical);
            this.groupBox2.Controls.Add(this.rbStopHorisontal);
            this.groupBox2.Controls.Add(this.rbStopNone);
            this.groupBox2.Location = new System.Drawing.Point(8, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 92);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Border Stops";
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
            // tIncrementSideLength
            // 
            this.tIncrementSideLength.Location = new System.Drawing.Point(129, 121);
            this.tIncrementSideLength.Name = "tIncrementSideLength";
            this.tIncrementSideLength.Size = new System.Drawing.Size(29, 20);
            this.tIncrementSideLength.TabIndex = 13;
            this.tIncrementSideLength.Text = "10";
            this.tIncrementSideLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Increment Side Length";
            // 
            // tPolyRevolutions
            // 
            this.tPolyRevolutions.Location = new System.Drawing.Point(129, 95);
            this.tPolyRevolutions.Name = "tPolyRevolutions";
            this.tPolyRevolutions.Size = new System.Drawing.Size(29, 20);
            this.tPolyRevolutions.TabIndex = 11;
            this.tPolyRevolutions.Text = "10";
            this.tPolyRevolutions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Revolutions";
            // 
            // cmdDrawPolySpiral
            // 
            this.cmdDrawPolySpiral.Image = ((System.Drawing.Image)(resources.GetObject("cmdDrawPolySpiral.Image")));
            this.cmdDrawPolySpiral.Location = new System.Drawing.Point(240, 104);
            this.cmdDrawPolySpiral.Name = "cmdDrawPolySpiral";
            this.cmdDrawPolySpiral.Size = new System.Drawing.Size(37, 37);
            this.cmdDrawPolySpiral.TabIndex = 9;
            this.cmdDrawPolySpiral.UseVisualStyleBackColor = true;
            this.cmdDrawPolySpiral.Click += new System.EventHandler(this.cmdDrawPolySpiral_Click);
            // 
            // tSideLength
            // 
            this.tSideLength.Location = new System.Drawing.Point(129, 69);
            this.tSideLength.Name = "tSideLength";
            this.tSideLength.Size = new System.Drawing.Size(29, 20);
            this.tSideLength.TabIndex = 8;
            this.tSideLength.Text = "10";
            this.tSideLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tPolyAngleIncrement
            // 
            this.tPolyAngleIncrement.Location = new System.Drawing.Point(128, 43);
            this.tPolyAngleIncrement.Name = "tPolyAngleIncrement";
            this.tPolyAngleIncrement.Size = new System.Drawing.Size(29, 20);
            this.tPolyAngleIncrement.TabIndex = 7;
            this.tPolyAngleIncrement.Text = "0.5";
            this.tPolyAngleIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Side Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Angle Increment";
            // 
            // UCPolySpiral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCPolySpiral";
            this.Size = new System.Drawing.Size(302, 275);
            this.Load += new System.EventHandler(this.UCPolySpiral_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tssbOpenClose;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdDrawPolySpiral;
        private System.Windows.Forms.TextBox tSideLength;
        private System.Windows.Forms.TextBox tPolyAngleIncrement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tIncrementSideLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tPolyRevolutions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbStopVertical;
        private System.Windows.Forms.RadioButton rbStopHorisontal;
        private System.Windows.Forms.RadioButton rbStopNone;
        private System.Windows.Forms.Button cmdDecFive;
        private System.Windows.Forms.Button cmdDecOne;
        private System.Windows.Forms.Button cmdDecTen;
        private System.Windows.Forms.Button cmdIncTen;
        private System.Windows.Forms.Button cmdIncOne;
        private System.Windows.Forms.Button cmdIncFive;
    }
}
