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
using System.Media;

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
            sbLightIntensity.Value = GlobalProperties.LightBeamIntesity;

            timerAnimate.Interval = sbInterval.Value;
            lblInterval.Text = "Time Interval:" + sbInterval.Value;
            Log.Write("Time interval set to " + sbInterval.Value);




        }


        private void panel_Paint(object sender, PaintEventArgs e)
        {
            cGL.Draw();
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            cGL.OnResize();
        }

        private void timerAnimate_Tick(object sender, EventArgs e)
        {
            GlobalProperties.CurrentHorizontalViewAngle += GlobalProperties.HorizontalViewAngleIncrement;
            GlobalProperties.CurrentHorizontalViewAngle %= 360.0f;
            cGL.Draw();
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            float vAngle = GlobalProperties.LightBeamVerticalAngle;
            float hAngle = GlobalProperties.LightBeamHorizontalAngle;
            float increment = GlobalProperties.LightBeamAngleIncrement;
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                vAngle -= increment;
                if (vAngle >= 60.0f)
                    GlobalProperties.LightBeamVerticalAngle = vAngle;

            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                vAngle += increment;
                if (vAngle <= 110.0f)
                    GlobalProperties.LightBeamVerticalAngle = vAngle;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                hAngle += increment;
                hAngle %= 360.0f;
                GlobalProperties.LightBeamHorizontalAngle = hAngle;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                hAngle -= increment;
                hAngle %= 360.0f;
                GlobalProperties.LightBeamHorizontalAngle = hAngle;
            }
            cGL.Draw();
            return true;
            //return base.ProcessCmdKey(ref msg, keyData);
        }

        private void chkLightOn_CheckedChanged(object sender, EventArgs e)
        {
            bool on =  (sender as CheckBox).Checked;
            GlobalProperties.LightBeamOn = on;
            sbLightIntensity.Enabled = on;
            rbBlue.Enabled = on;
            rbGreen.Enabled = on;
            rbRed.Enabled = on;
            rbYellow.Enabled = on;

            cGL.Draw();
        }

        private void sbLightIntensity_Scroll(object sender, ScrollEventArgs e)
        {
            GlobalProperties.LightBeamIntesity = (sender as HScrollBar).Value;
            cGL.Draw();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "rbRed":
                    GlobalProperties.LightBeamColor = Color.Red;
                    break;
                case "rbGreen":
                    GlobalProperties.LightBeamColor = Color.LawnGreen;
                    break;
                case "rbYellow":
                    GlobalProperties.LightBeamColor = Color.LightGoldenrodYellow;
                    break;
                case "rbBlue":
                    GlobalProperties.LightBeamColor = Color.CadetBlue;
                    break;
            }
            cGL.Draw();
        }

        private void chkSoundON_CheckedChanged(object sender, EventArgs e)
        {
            bool on = (sender as CheckBox).Checked;
            System.Media.SoundPlayer audio = new SoundPlayer(myOpenGL.Properties.Resources.Ocean_Wave);

            if (on)
            {
                audio.Play();
            }
            else
                audio.Stop();
        }
    }


}