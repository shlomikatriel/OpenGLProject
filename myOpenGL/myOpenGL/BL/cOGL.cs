using myOpenGL.BL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace OpenGL
{
    class cOGL
    {
        // Control members
        Control p;
        int Width;
        int Height;

        // Viewport members
        uint m_uint_HWND = 0;
        uint m_uint_DC = 0;
        uint m_uint_RC = 0;

        public cOGL(Control pb)
        {
            p = pb;
            Width = p.Width;
            Height = p.Height;
            InitializeGL();
        }



        public void Draw()
        {
            // MAIN FUNCTION
            if (m_uint_DC == 0 || m_uint_RC == 0)
            {
                MessageBox.Show("No screen dimension. Drawing canceled");
                return;
            }

            GL.glClear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            GL.glLoadIdentity();

            GL.glTranslatef(0.0f, 0.0f, -6.0f);
            GL.glRotatef(90.0f - GlobalProperties.CurrentVerticalViewAngle, -1.0f, 0.0f, 0.0f);
            GL.glRotatef(GlobalProperties.CurrentHorizontalViewAngle, 0.0f, 0.0f, 1.0f);

            DrawAxes();
            DrawSea();
            DrawIsland();
            DrawTower();


            GL.glFlush();

            WGL.wglSwapBuffers(m_uint_DC);

        }

        private void DrawSea()
        {
            GL.glEnable(GL.GL_TEXTURE_2D);
            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[0]);
            GL.glBegin(GL.GL_QUADS);

            float cor = GlobalProperties.seaSize / 2;
            GL.glTexCoord2f(0, 0);
            GL.glVertex3f(-cor, -cor, 0.0f);
            GL.glTexCoord2f(0, 5);
            GL.glVertex3f(cor, -cor, 0.0f);
            GL.glTexCoord2f(5, 5);
            GL.glVertex3f(cor, cor, 0.0f);
            GL.glTexCoord2f(5, 0);
            GL.glVertex3f(-cor, cor, 0.0f);

            GL.glEnd();
            GL.glDisable(GL.GL_TEXTURE_2D);
        }

        private void DrawIsland()
        {
            float moveSphere = 6.2f;
            GL.glTranslatef(0.0f, 0.0f, -moveSphere);

            GL.glEnable(GL.GL_TEXTURE_2D);
            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[1]);

            GLUquadric obj = GLU.gluNewQuadric();
            GLU.gluQuadricTexture(obj, 1);
            GLU.gluSphere(obj, 6.5, 16, 16);

            GLU.gluDeleteQuadric(obj);
            GL.glDisable(GL.GL_TEXTURE_2D);
            GL.glTranslatef(0.0f, 0.0f, moveSphere);
        }

        private void DrawTower()
        {
            const double baseRadius = 0.25, topRadius = 0.16, height = 1.8, diskHeight = 0.06;
            DrawPillar(baseRadius, topRadius, height);
            GL.glTranslatef(0.0f, 0.0f, (float)height);
            DrawDisk(diskHeight, topRadius + 0.12);
            GL.glTranslatef(0.0f, 0.0f, (float)diskHeight);
        }

        private void DrawPillar(double baseRadius, double topRadius, double height)
        {
            GL.glEnable(GL.GL_TEXTURE_2D);
            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[2]);

            GLUquadric obj = GLU.gluNewQuadric();
            GLU.gluQuadricTexture(obj, 2);
            GLU.gluCylinder(obj, baseRadius, topRadius, height, 32, 32);

            GLU.gluDeleteQuadric(obj);
            GL.glDisable(GL.GL_TEXTURE_2D);
        }

        private void DrawDisk(double diskHeight, double diskRadius)
        {
            GL.glEnable(GL.GL_TEXTURE_2D);
            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[3]);

            GLUquadric obj = GLU.gluNewQuadric();
            GLU.gluQuadricTexture(obj, 3);
            GLU.gluDisk(obj, 0, diskRadius, 60, 20);
            GLU.gluCylinder(obj, diskRadius, diskRadius, diskHeight, 32, 32);
            GL.glTranslatef(0.0f, 0.0f, (float)diskHeight);
            GLU.gluDisk(obj, 0, diskRadius, 60, 20);
            GL.glTranslatef(0.0f, 0.0f, -(float)diskHeight);

            GLU.gluDeleteQuadric(obj);
            GL.glDisable(GL.GL_TEXTURE_2D);
        }

        private void DrawAxes()
        {
            //axes
            GL.glBegin(GL.GL_LINES);
            //x  RED
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GL.glVertex3f(0.0f, 0.0f, 0.0f);
            GL.glVertex3f(3.0f, 0.0f, 0.0f);
            //y  GREEN 
            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GL.glVertex3f(0.0f, 0.0f, 0.0f);
            GL.glVertex3f(0.0f, 3.0f, 0.0f);
            //z  BLUE
            GL.glColor3f(0.0f, 0.0f, 1.0f);
            GL.glVertex3f(0.0f, 0.0f, 0.0f);
            GL.glVertex3f(0.0f, 0.0f, 3.0f);

            GL.glEnd();
        }

        protected virtual void InitializeGL()
        {
            m_uint_HWND = (uint)p.Handle.ToInt32();
            m_uint_DC = WGL.GetDC(m_uint_HWND);

            // Not doing the following WGL.wglSwapBuffers() on the DC will
            // result in a failure to subsequently create the RC.
            WGL.wglSwapBuffers(m_uint_DC);

            WGL.PIXELFORMATDESCRIPTOR pfd = new WGL.PIXELFORMATDESCRIPTOR();
            WGL.ZeroPixelDescriptor(ref pfd);
            pfd.nVersion = 1;
            pfd.dwFlags = (WGL.PFD_DRAW_TO_WINDOW | WGL.PFD_SUPPORT_OPENGL | WGL.PFD_DOUBLEBUFFER);
            pfd.iPixelType = (byte)(WGL.PFD_TYPE_RGBA);
            pfd.cColorBits = 32;
            pfd.cDepthBits = 32;
            pfd.iLayerType = (byte)(WGL.PFD_MAIN_PLANE);

            int pixelFormatIndex = 0;
            pixelFormatIndex = WGL.ChoosePixelFormat(m_uint_DC, ref pfd);
            if (pixelFormatIndex == 0)
            {
                MessageBox.Show("Unable to retrieve pixel format");
                return;
            }

            if (WGL.SetPixelFormat(m_uint_DC, pixelFormatIndex, ref pfd) == 0)
            {
                MessageBox.Show("Unable to set pixel format");
                return;
            }

            //Create rendering context
            m_uint_RC = WGL.wglCreateContext(m_uint_DC);
            if (m_uint_RC == 0)
            {
                MessageBox.Show("Unable to get rendering context");
                return;
            }
            if (WGL.wglMakeCurrent(m_uint_DC, m_uint_RC) == 0)
            {
                MessageBox.Show("Unable to make rendering context current");
                return;
            }


            initRenderingGL();
        }

        public void OnResize()
        {
            Width = p.Width;
            Height = p.Height;

            //!!!!!!!
            GL.glViewport(0, 0, Width, Height);
            //!!!!!!!

            initRenderingGL();
            Draw();
        }

        protected virtual void initRenderingGL()
        {
            if (m_uint_DC == 0 || m_uint_RC == 0)
                return;
            if (this.Width == 0 || this.Height == 0)
                return;
            GL.glEnable(GL.GL_DEPTH_TEST);
            GL.glDepthFunc(GL.GL_LEQUAL);

            GL.glViewport(0, 0, this.Width, this.Height);
            GL.glClearColor(0, 0, 0, 0);
            GL.glMatrixMode(GL.GL_PROJECTION);
            GL.glLoadIdentity();
            GLU.gluPerspective(45.0, ((double)Width) / Height, 1.0, 1000.0);
            GL.glMatrixMode(GL.GL_MODELVIEW);
            GL.glLoadIdentity();

            GenerateTextures();
        }

        public uint[] Textures;

        void GenerateTextures()
        {
            Bitmap[] images = { 
                                  myOpenGL.Properties.Resources.sea,
                                  myOpenGL.Properties.Resources.land,
                                  myOpenGL.Properties.Resources.wall,
                                  myOpenGL.Properties.Resources.whitewall
                              };
            Textures = new uint[images.Length];
            GL.glGenTextures(images.Length, Textures);
            for (int i = 0; i < images.Length; i++)
            {
                Bitmap image = images[i];
                image.RotateFlip(RotateFlipType.RotateNoneFlipY); //Y axis in Windows is directed downwards, while in OpenGL-upwards
                System.Drawing.Imaging.BitmapData bitmapdata;
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

                bitmapdata = image.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                GL.glBindTexture(GL.GL_TEXTURE_2D, Textures[i]);
                //2D for XYZ
                //The level-of-detail number. Level 0 is the base image level
                //The number of color components in the texture. 
                //Must be 1, 2, 3, or 4, or one of the following 
                //    symbolic constants: 
                //                GL_ALPHA, GL_ALPHA4, 
                //                GL_ALPHA8, GL_ALPHA12, GL_ALPHA16, GL_LUMINANCE, GL_LUMINANCE4, 
                //                GL_LUMINANCE8, GL_LUMINANCE12, GL_LUMINANCE16, GL_LUMINANCE_ALPHA, 
                //                GL_LUMINANCE4_ALPHA4, GL_LUMINANCE6_ALPHA2, GL_LUMINANCE8_ALPHA8, 
                //                GL_LUMINANCE12_ALPHA4, GL_LUMINANCE12_ALPHA12, GL_LUMINANCE16_ALPHA16, 
                //                GL_INTENSITY, GL_INTENSITY4, GL_INTENSITY8, GL_INTENSITY12, 
                //                GL_INTENSITY16, GL_R3_G3_B2, GL_RGB, GL_RGB4, GL_RGB5, GL_RGB8, 
                //                GL_RGB10, GL_RGB12, GL_RGB16, GL_RGBA, GL_RGBA2, GL_RGBA4, GL_RGB5_A1, 
                //                GL_RGBA8, GL_RGB10_A2, GL_RGBA12, or GL_RGBA16.

                GL.glTexImage2D(GL.GL_TEXTURE_2D, 0, (int)GL.GL_RGB8, image.Width, image.Height,
                    //The width of the border. Must be either 0 or 1.
                    //The format of the pixel data
                    //The data type of the pixel data
                    //A pointer to the image data in memory
                                                              0, GL.GL_BGR_EXT, GL.GL_UNSIGNED_byte, bitmapdata.Scan0);
                GL.glTexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MIN_FILTER, (int)GL.GL_LINEAR);
                GL.glTexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MAG_FILTER, (int)GL.GL_LINEAR);

                image.UnlockBits(bitmapdata);
                image.Dispose();
            }
        }

        ~cOGL()
        {
            WGL.wglDeleteContext(m_uint_RC);
        }
    }

}
