using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenGL;
using System.Runtime.InteropServices;
using myOpenGL.BL;

namespace myOpenGL
{
    public partial class MainWindow : Form
    {
        cOGL cGL;
        public MainWindow()
        {

            InitializeComponent();
            cGL = new cOGL(panel);


            sbVerticalViewAngle.Minimum = (int)(GlobalProperties.MinVerticalViewAngle * 100);
            sbVerticalViewAngle.Maximum = (int)(GlobalProperties.MaxVerticalViewAngle * 100);
            sbVerticalViewAngle.Value = (int)(GlobalProperties.CurrentVerticalViewAngle * 100);
            lblVerticalViewAngle.Text = "Vertical View Angle: " + GlobalProperties.CurrentVerticalViewAngle + " °";
            Log.Write("Initialize vertical view angles:\nMin: " + GlobalProperties.MinVerticalViewAngle + "°, Max: " + GlobalProperties.MaxVerticalViewAngle + "°, Initial: " + GlobalProperties.CurrentVerticalViewAngle + "°");

            timerAnimate.Interval = sbInterval.Value;
            lblInterval.Text = "Time Interval:" + sbInterval.Value;
            Log.Write("Time interval set to " + sbInterval.Value);
        }

        private void timerAnimate_Tick(object sender, EventArgs e)
        {
            GlobalProperties.CurrentHorizontalViewAngle += GlobalProperties.HorizontalViewAngleIncrement;
            GlobalProperties.CurrentHorizontalViewAngle %= 360.0f;
            cGL.Draw();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            cGL.Draw();
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            cGL.OnResize();
        }

        private void sbInterval_Scroll(object sender, ScrollEventArgs e)
        {
            timerAnimate.Interval = sbInterval.Value;
            lblInterval.Text = "Time Interval:" + sbInterval.Value;
        }

        private void chkAnimate_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox))
            {
                return;
            }
            CheckBox control = sender as CheckBox;
            Log.Write("Animation checkbox status changed to: " + control.Checked);
            sbInterval.Enabled = timerAnimate.Enabled = control.Checked;
        }

        private void sbVerticalViewAngle_Scroll(object sender, ScrollEventArgs e)
        {
            if (!(sender is HScrollBar))
                return;
            HScrollBar control = sender as HScrollBar;
            float newValue = ((float)control.Value) / 100;
            GlobalProperties.CurrentVerticalViewAngle = newValue;
            lblVerticalViewAngle.Text = "Vertical View Angle: " + newValue + "°";
            cGL.Draw();
        }



    }


}