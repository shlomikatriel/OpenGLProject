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
            this.chkSoundON = new System.Windows.Forms.CheckBox();
            this.gbLightControl = new System.Windows.Forms.GroupBox();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.sbLightIntensity = new System.Windows.Forms.HScrollBar();
            this.lblLightColor = new System.Windows.Forms.Label();
            this.lblLightIntensity = new System.Windows.Forms.Label();
            this.chkLightOn = new System.Windows.Forms.CheckBox();
            this.lblVerticalViewAngle = new System.Windows.Forms.Label();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.gbLightControl.SuspendLayout();
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
            this.sbInterval.Size = new System.Drawing.Size(179, 20);
            this.sbInterval.TabIndex = 4;
            this.sbInterval.Value = 10;
            this.sbInterval.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbInterval_Scroll);
            // 
            // lblInterval
            // 
            this.lblInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(10, 10);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(85, 13);
            this.lblInterval.TabIndex = 5;
            this.lblInterval.Text = "Refresh Interval:";
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
            this.panel.Size = new System.Drawing.Size(816, 691);
            this.panel.TabIndex = 6;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.Resize += new System.EventHandler(this.panel_Resize);
            // 
            // chkAnimate
            // 
            this.chkAnimate.AutoSize = true;
            this.chkAnimate.Location = new System.Drawing.Point(13, 63);
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
            this.sbVerticalViewAngle.Location = new System.Drawing.Point(13, 337);
            this.sbVerticalViewAngle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.sbVerticalViewAngle.Name = "sbVerticalViewAngle";
            this.sbVerticalViewAngle.Size = new System.Drawing.Size(192, 20);
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
            this.splitContainer.Panel2.Controls.Add(this.chkSoundON);
            this.splitContainer.Panel2.Controls.Add(this.gbLightControl);
            this.splitContainer.Panel2.Controls.Add(this.lblVerticalViewAngle);
            this.splitContainer.Panel2.Controls.Add(this.sbVerticalViewAngle);
            this.splitContainer.Panel2.Controls.Add(this.chkAnimate);
            this.splitContainer.Panel2.Controls.Add(this.lblInterval);
            this.splitContainer.Panel2.Controls.Add(this.sbInterval);
            this.splitContainer.Panel2MinSize = 50;
            this.splitContainer.Size = new System.Drawing.Size(1032, 691);
            this.splitContainer.SplitterDistance = 816;
            this.splitContainer.TabIndex = 9;
            // 
            // chkSoundON
            // 
            this.chkSoundON.AutoSize = true;
            this.chkSoundON.Location = new System.Drawing.Point(90, 63);
            this.chkSoundON.Name = "chkSoundON";
            this.chkSoundON.Size = new System.Drawing.Size(57, 17);
            this.chkSoundON.TabIndex = 11;
            this.chkSoundON.Text = "Sound";
            this.chkSoundON.UseVisualStyleBackColor = true;
            this.chkSoundON.CheckedChanged += new System.EventHandler(this.chkSoundON_CheckedChanged);
            // 
            // gbLightControl
            // 
            this.gbLightControl.Controls.Add(this.rbBlue);
            this.gbLightControl.Controls.Add(this.rbRed);
            this.gbLightControl.Controls.Add(this.rbGreen);
            this.gbLightControl.Controls.Add(this.rbYellow);
            this.gbLightControl.Controls.Add(this.sbLightIntensity);
            this.gbLightControl.Controls.Add(this.lblLightColor);
            this.gbLightControl.Controls.Add(this.lblLightIntensity);
            this.gbLightControl.Controls.Add(this.chkLightOn);
            this.gbLightControl.Location = new System.Drawing.Point(10, 90);
            this.gbLightControl.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.gbLightControl.Name = "gbLightControl";
            this.gbLightControl.Size = new System.Drawing.Size(192, 213);
            this.gbLightControl.TabIndex = 10;
            this.gbLightControl.TabStop = false;
            this.gbLightControl.Text = "Light Beam Control";
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(9, 176);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(46, 17);
            this.rbBlue.TabIndex = 3;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(9, 153);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(45, 17);
            this.rbRed.TabIndex = 3;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(9, 130);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(54, 17);
            this.rbGreen.TabIndex = 3;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.Checked = true;
            this.rbYellow.Location = new System.Drawing.Point(9, 107);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(56, 17);
            this.rbYellow.TabIndex = 3;
            this.rbYellow.TabStop = true;
            this.rbYellow.Text = "Yellow";
            this.rbYellow.UseVisualStyleBackColor = true;
            this.rbYellow.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // sbLightIntensity
            // 
            this.sbLightIntensity.Location = new System.Drawing.Point(3, 61);
            this.sbLightIntensity.Maximum = 255;
            this.sbLightIntensity.Minimum = 20;
            this.sbLightIntensity.Name = "sbLightIntensity";
            this.sbLightIntensity.Size = new System.Drawing.Size(176, 20);
            this.sbLightIntensity.TabIndex = 2;
            this.sbLightIntensity.Value = 20;
            this.sbLightIntensity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbLightIntensity_Scroll);
            // 
            // lblLightColor
            // 
            this.lblLightColor.AutoSize = true;
            this.lblLightColor.Location = new System.Drawing.Point(6, 91);
            this.lblLightColor.Name = "lblLightColor";
            this.lblLightColor.Size = new System.Drawing.Size(60, 13);
            this.lblLightColor.TabIndex = 1;
            this.lblLightColor.Text = "Light Color:";
            // 
            // lblLightIntensity
            // 
            this.lblLightIntensity.AutoSize = true;
            this.lblLightIntensity.Location = new System.Drawing.Point(6, 39);
            this.lblLightIntensity.Name = "lblLightIntensity";
            this.lblLightIntensity.Size = new System.Drawing.Size(75, 13);
            this.lblLightIntensity.TabIndex = 1;
            this.lblLightIntensity.Text = "Light Intensity:";
            // 
            // chkLightOn
            // 
            this.chkLightOn.AutoSize = true;
            this.chkLightOn.Checked = true;
            this.chkLightOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLightOn.Location = new System.Drawing.Point(6, 19);
            this.chkLightOn.Name = "chkLightOn";
            this.chkLightOn.Size = new System.Drawing.Size(49, 17);
            this.chkLightOn.TabIndex = 0;
            this.chkLightOn.Text = "Light";
            this.chkLightOn.UseVisualStyleBackColor = true;
            this.chkLightOn.CheckedChanged += new System.EventHandler(this.chkLightOn_CheckedChanged);
            // 
            // lblVerticalViewAngle
            // 
            this.lblVerticalViewAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVerticalViewAngle.AutoSize = true;
            this.lblVerticalViewAngle.Location = new System.Drawing.Point(13, 314);
            this.lblVerticalViewAngle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lblVerticalViewAngle.Name = "lblVerticalViewAngle";
            this.lblVerticalViewAngle.Size = new System.Drawing.Size(101, 13);
            this.lblVerticalViewAngle.TabIndex = 9;
            this.lblVerticalViewAngle.Text = "Vertical View Angle:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 715);
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
            this.gbLightControl.ResumeLayout(false);
            this.gbLightControl.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbLightControl;
        private System.Windows.Forms.CheckBox chkLightOn;
        private System.Windows.Forms.HScrollBar sbLightIntensity;
        private System.Windows.Forms.Label lblLightIntensity;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.Label lblLightColor;
        private System.Windows.Forms.CheckBox chkSoundON;
    }
}

