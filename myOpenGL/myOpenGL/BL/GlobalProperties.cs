using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace myOpenGL.BL
{
    static class GlobalProperties
    {
        // Vertical view angles
        public static readonly float MinVerticalViewAngle = 13.0f;
        public static readonly float MaxVerticalViewAngle = 60.0f;
        public static float CurrentVerticalViewAngle = 25.0f;

        // Horizontal view angles
        public static float CurrentHorizontalViewAngle = 0.0f;
        public static float HorizontalViewAngleIncrement = 1.0f;

        // Sizes
        public static readonly float seaSize = 70.0f;
        public static readonly float seaDuplicates = 5.0f;

        public static readonly float islandHeight = 0.5f;
        public static readonly float islandRadius = 6.0f;

        public static readonly float windowRadius = 0.25f;
        public static readonly float windowHeight = 0.25f;

        // Light beam
        public static int LightBeamIntesity = 100;
        public static bool LightBeamOn = true;
        public static float LightBeamVerticalAngle = 90.0f;
        public static float LightBeamHorizontalAngle = 45.0f;
        public static Color LightBeamColor = Color.LightGoldenrodYellow;
        public static readonly float LightBeamLength = 4.0f;
        public static float LightBeamAngleIncrement = 2.0f;
    }
}
