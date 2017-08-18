using System;
using System.Collections.Generic;
using System.Text;

namespace myOpenGL.BL
{
    public static class Log
    {
        public static void Write(string s)
        {
            Console.WriteLine(DateTime.Now + ":\n" + s);
        }
    }
}
