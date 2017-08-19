using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace myOpenGL.BL
{
    public static class Log
    {
        public static void Write(string s)
        {
            StackTrace st = new StackTrace(true);
            string method = "<NO METHOD>", type = "<NO CLASS>";
            if (st.FrameCount > 1)
            {
                method = st.GetFrame(1).GetMethod().Name;
                type = st.GetFrame(1).GetMethod().ReflectedType.Name;
            }
            Console.WriteLine(DateTime.Now + " - " + type + " - " + method + ":\n" + s);
        }
    }
}
