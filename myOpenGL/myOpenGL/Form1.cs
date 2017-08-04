using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenGL;
using System.Runtime.InteropServices; 

namespace myOpenGL
{
    public partial class Form1 : Form
    {
        cOGL cGL;

        public Form1()
        {

            InitializeComponent();
            cGL = new cOGL(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cGL.Draw();
        }

        private void timerRepaint_Tick(object sender, EventArgs e)
        {
             cGL.Draw();
            timerRepaint.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Width +=10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerRUN.Enabled = !timerRUN.Enabled;
            if (timerRUN.Enabled)
                button3.Text = "stop";
            else
                button3.Text = "run";
            label1.Text = "delay = " + hScrollBar1.Value;
        }

        private void timerRUN_Tick(object sender, EventArgs e)
        {
            cGL.Draw(); 
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timerRUN.Interval = hScrollBar1.Value;
            label1.Text = "delay = " + hScrollBar1.Value;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            cGL.Draw();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            cGL.OnResize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}