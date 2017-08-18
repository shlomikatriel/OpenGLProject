using System;
using System.Collections.Generic;
using System.Text;

namespace myOpenGL.BL
{
    static class GlobalProperties
    {
        // Vertical view angles
        public static readonly float MinVerticalViewAngle = 5.0f;
        public static readonly float MaxVerticalViewAngle = 90.0f;
        public static float CurrentVerticalViewAngle = 25.0f;

        // Horizontal view angles
        public static float CurrentHorizontalViewAngle = 0.0f;
        public static float HorizontalViewAngleIncrement = 1.0f;

        // Sizes
        public static readonly float seaSize = 70.0f;
    }
}
