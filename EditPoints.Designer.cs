namespace Beacher
{
    partial class EditPoints
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPoints));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbErase = new System.Windows.Forms.ToolStripButton();
            this.pMain = new System.Windows.Forms.Panel();
            this.pEdit = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEdit)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbErase,
            this.tsbStop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1371, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbErase
            // 
            this.tsbErase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbErase.Image = ((System.Drawing.Image)(resources.GetObject("tsbErase.Image")));
            this.tsbErase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbErase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbErase.Name = "tsbErase";
            this.tsbErase.Size = new System.Drawing.Size(36, 36);
            this.tsbErase.Text = "Eraser";
            this.tsbErase.Click += new System.EventHandler(this.tsbErase_Click);
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMain.AutoScroll = true;
            this.pMain.Controls.Add(this.pEdit);
            this.pMain.Location = new System.Drawing.Point(0, 42);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1359, 698);
            this.pMain.TabIndex = 1;
            // 
            // pEdit
            // 
            this.pEdit.Location = new System.Drawing.Point(3, 3);
            this.pEdit.Name = "pEdit";
            this.pEdit.Size = new System.Drawing.Size(74, 55);
            this.pEdit.TabIndex = 0;
            this.pEdit.TabStop = false;
            this.pEdit.Click += new System.EventHandler(this.pEdit_Click);
            this.pEdit.MouseHover += new System.EventHandler(this.pEdit_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 766);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1371, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl1
            // 
            this.tssl1.Name = "tssl1";
            this.tssl1.Size = new System.Drawing.Size(1356, 17);
            this.tssl1.Spring = true;
            this.tssl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbStop.Image")));
            this.tsbStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(36, 36);
            this.tsbStop.Text = "Stop";
            // 
            // EditPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 788);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPoints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Points";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditPoints_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pEdit)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbErase;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.PictureBox pEdit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
        private System.Windows.Forms.ToolStripButton tsbStop;
    }
}