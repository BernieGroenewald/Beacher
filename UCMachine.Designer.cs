namespace Beacher
{
    partial class UCMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMachine));
            this.cmdSaveSettings = new System.Windows.Forms.Button();
            this.tMachineX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tssbOpenClose = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tMachineY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tMachineStartCode = new System.Windows.Forms.TextBox();
            this.tMachineEndCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBitmapSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tDefaultSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSaveSettings
            // 
            this.cmdSaveSettings.Image = ((System.Drawing.Image)(resources.GetObject("cmdSaveSettings.Image")));
            this.cmdSaveSettings.Location = new System.Drawing.Point(251, 28);
            this.cmdSaveSettings.Name = "cmdSaveSettings";
            this.cmdSaveSettings.Size = new System.Drawing.Size(37, 37);
            this.cmdSaveSettings.TabIndex = 9;
            this.cmdSaveSettings.UseVisualStyleBackColor = true;
            this.cmdSaveSettings.Click += new System.EventHandler(this.cmdSaveSettings_Click);
            // 
            // tMachineX
            // 
            this.tMachineX.Location = new System.Drawing.Point(163, 19);
            this.tMachineX.Name = "tMachineX";
            this.tMachineX.Size = new System.Drawing.Size(44, 20);
            this.tMachineX.TabIndex = 8;
            this.tMachineX.Text = "1000";
            this.tMachineX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Machine X Size (mm)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBitmapSpeed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tDefaultSpeed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tMachineEndCode);
            this.groupBox1.Controls.Add(this.tMachineStartCode);
            this.groupBox1.Controls.Add(this.tMachineY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdSaveSettings);
            this.groupBox1.Controls.Add(this.tMachineX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(4, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 476);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "navigate_close.png");
            this.imageList2.Images.SetKeyName(1, "navigate_open.png");
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(250, 22);
            this.toolStripLabel1.Text = "Machine Settings";
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbOpenClose,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(303, 25);
            this.toolStrip1.TabIndex = 74;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tMachineY
            // 
            this.tMachineY.Location = new System.Drawing.Point(161, 45);
            this.tMachineY.Name = "tMachineY";
            this.tMachineY.Size = new System.Drawing.Size(44, 20);
            this.tMachineY.TabIndex = 11;
            this.tMachineY.Text = "1000";
            this.tMachineY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Machine Y Size (mm)";
            // 
            // tMachineStartCode
            // 
            this.tMachineStartCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMachineStartCode.Location = new System.Drawing.Point(6, 93);
            this.tMachineStartCode.Multiline = true;
            this.tMachineStartCode.Name = "tMachineStartCode";
            this.tMachineStartCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tMachineStartCode.Size = new System.Drawing.Size(283, 143);
            this.tMachineStartCode.TabIndex = 12;
            this.tMachineStartCode.Text = "G21 ;metric values\r\nG90 ;absolute positioning\r\nG28 X Y; Home Axis\r\nM117 Drawing.." +
    ".;Put drawing message on LCD screen\r\n";
            this.tMachineStartCode.WordWrap = false;
            // 
            // tMachineEndCode
            // 
            this.tMachineEndCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMachineEndCode.Location = new System.Drawing.Point(5, 265);
            this.tMachineEndCode.Multiline = true;
            this.tMachineEndCode.Name = "tMachineEndCode";
            this.tMachineEndCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tMachineEndCode.Size = new System.Drawing.Size(283, 143);
            this.tMachineEndCode.TabIndex = 13;
            this.tMachineEndCode.Text = "G90 ; Absolute positioning\r\nG28 X Y ; Home X and Y\r\nG28 X Y ; Home it again, Sam." +
    "\r\nM84 ; Steppers off";
            this.tMachineEndCode.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Machine Start G-Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Machine End G-Code";
            // 
            // tBitmapSpeed
            // 
            this.tBitmapSpeed.Location = new System.Drawing.Point(163, 449);
            this.tBitmapSpeed.Name = "tBitmapSpeed";
            this.tBitmapSpeed.Size = new System.Drawing.Size(44, 20);
            this.tBitmapSpeed.TabIndex = 19;
            this.tBitmapSpeed.Text = "1000";
            this.tBitmapSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Bitmap Draw Speed (mm/min)";
            // 
            // tDefaultSpeed
            // 
            this.tDefaultSpeed.Location = new System.Drawing.Point(163, 423);
            this.tDefaultSpeed.Name = "tDefaultSpeed";
            this.tDefaultSpeed.Size = new System.Drawing.Size(44, 20);
            this.tDefaultSpeed.TabIndex = 17;
            this.tDefaultSpeed.Text = "600";
            this.tDefaultSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Default Draw Speed (mm/min)";
            // 
            // UCMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCMachine";
            this.Size = new System.Drawing.Size(303, 508);
            this.Load += new System.EventHandler(this.UCMachine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSaveSettings;
        private System.Windows.Forms.TextBox tMachineX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tMachineEndCode;
        private System.Windows.Forms.TextBox tMachineStartCode;
        private System.Windows.Forms.TextBox tMachineY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tssbOpenClose;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox tBitmapSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tDefaultSpeed;
        private System.Windows.Forms.Label label6;
    }
}
