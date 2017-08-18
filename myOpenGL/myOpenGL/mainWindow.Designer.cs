namespace myOpenGL
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            this.sbInterval = new System.Windows.Forms.HScrollBar();
            this.lblInterval = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.chkAnimate = new System.Windows.Forms.CheckBox();
            this.sbVerticalViewAngle = new System.Windows.Forms.HScrollBar();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lblVerticalViewAngle = new System.Windows.Forms.Label();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAnimate
            // 
            this.timerAnimate.Interval = 10;
            this.timerAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // sbInterval
            // 
            this.sbInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbInterval.Enabled = false;
            this.sbInterval.LargeChange = 1;
            this.sbInterval.Location = new System.Drawing.Point(10, 33);
            this.sbInterval.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.sbInterval.Maximum = 200;
            this.sbInterval.Minimum = 1;
            this.sbInterval.Name = "sbInterval";
            this.sbInterval.Size = new System.Drawing.Size(186, 20);
            this.sbInterval.TabIndex = 4;
            this.sbInterval.Value = 10;
            this.sbInterval.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbInterval_Scroll);
            // 
            // lblInterval
            // 
            this.lblInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(36, 10);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(82, 13);
            this.lblInterval.TabIndex = 5;
            this.lblInterval.Text = "Refresh Interval";
            this.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(515, 411);
            this.panel.TabIndex = 6;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.Resize += new System.EventHandler(this.panel_Resize);
            // 
            // chkAnimate
            // 
            this.chkAnimate.AutoSize = true;
            this.chkAnimate.Location = new System.Drawing.Point(54, 63);
            this.chkAnimate.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.chkAnimate.Name = "chkAnimate";
            this.chkAnimate.Size = new System.Drawing.Size(64, 17);
            this.chkAnimate.TabIndex = 7;
            this.chkAnimate.Text = "Animate";
            this.chkAnimate.UseVisualStyleBackColor = true;
            this.chkAnimate.CheckedChanged += new System.EventHandler(this.chkAnimate_CheckedChanged);
            // 
            // sbVerticalViewAngle
            // 
            this.sbVerticalViewAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbVerticalViewAngle.Location = new System.Drawing.Point(10, 381);
            this.sbVerticalViewAngle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.sbVerticalViewAngle.Name = "sbVerticalViewAngle";
            this.sbVerticalViewAngle.Size = new System.Drawing.Size(186, 20);
            this.sbVerticalViewAngle.TabIndex = 8;
            this.sbVerticalViewAngle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbVerticalViewAngle_Scroll);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lblVerticalViewAngle);
            this.splitContainer.Panel2.Controls.Add(this.sbVerticalViewAngle);
            this.splitContainer.Panel2.Controls.Add(this.chkAnimate);
            this.splitContainer.Panel2.Controls.Add(this.lblInterval);
            this.splitContainer.Panel2.Controls.Add(this.sbInterval);
            this.splitContainer.Panel2MinSize = 50;
            this.splitContainer.Size = new System.Drawing.Size(725, 411);
            this.splitContainer.SplitterDistance = 515;
            this.splitContainer.TabIndex = 9;
            // 
            // lblVerticalViewAngle
            // 
            this.lblVerticalViewAngle.AutoSize = true;
            this.lblVerticalViewAngle.Location = new System.Drawing.Point(51, 358);
            this.lblVerticalViewAngle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lblVerticalViewAngle.Name = "lblVerticalViewAngle";
            this.lblVerticalViewAngle.Size = new System.Drawing.Size(98, 13);
            this.lblVerticalViewAngle.TabIndex = 9;
            this.lblVerticalViewAngle.Text = "Vertical View Angle";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 435);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Shlomi & Liran Graphics Project";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerAnimate;
        private System.Windows.Forms.HScrollBar sbInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.CheckBox chkAnimate;
        private System.Windows.Forms.HScrollBar sbVerticalViewAngle;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblVerticalViewAngle;
    }
}

