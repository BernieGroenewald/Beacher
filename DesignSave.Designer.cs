namespace Beacher
{
    partial class DesignSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignSave));
            this.cbDesignName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDesignName
            // 
            this.cbDesignName.FormattingEnabled = true;
            this.cbDesignName.Location = new System.Drawing.Point(84, 12);
            this.cbDesignName.Name = "cbDesignName";
            this.cbDesignName.Size = new System.Drawing.Size(263, 21);
            this.cbDesignName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Design Name";
            // 
            // cmdSave
            // 
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.Location = new System.Drawing.Point(305, 39);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(42, 42);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Image = ((System.Drawing.Image)(resources.GetObject("cmdOpen.Image")));
            this.cmdOpen.Location = new System.Drawing.Point(305, 39);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(42, 42);
            this.cmdOpen.TabIndex = 3;
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // DesignSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 90);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDesignName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DesignSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Design";
            this.Load += new System.EventHandler(this.DesignSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDesignName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdOpen;
    }
}