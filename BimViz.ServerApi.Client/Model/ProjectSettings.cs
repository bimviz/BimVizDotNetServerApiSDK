using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BimViz.ServerApi.Client.Model
{
    public enum SceneBackgroundStyle
    {
        White = 1,
        Black = 2,
        BlueWhite = 3,
        BlueSky = 4
    }

    public class SceneGroundStyle
    {
        public const string None = "none";
        public const string GreenLand = "greenland";
    }

    public enum SceneLoadMode
    {
        Complete = 1,
        Dynamic = 2
    }

    public enum SceneThemeStyle
    {
        ModelSelf = 1,
        Sketch = 2
    }

    public enum SceneDomain
    {
        Architectural = 1,
        Rabar = 2
    }

    public enum ColorFilter
    {
        Open = 1,
        Close = 2
    }

    public class TransparentMode
    {
        public const string Theme = "theme";
        public const string Auto = "auto";
        public const string Custom = "custom";
    }

    public class ColorMode
    {
        public const string Theme = "theme";
        public const string Custom = "custom";
    }

    public enum GrayScene
    {
        Yes = 1,
        No = 0
    }

    public enum PickCameraMove
    {
        Yes = 1,
        No = 0
    }
    public enum ShowAxis
    {
        Yes = 1,
        No = 0
    }

    public enum ShowViewBox
    {
        Yes = 1,
        No = 0
    }

    public class ViewBoxPath
    {
        public const string Chinese = "/images/viewbox/cn";
        public const string English = "/images/viewbox/en";
        public const string XYZ = "/images/viewbox/xyz";
    }

    public enum ShowQuickBar
    {
        Yes = 1,
        No = 0
    }

    public enum GroundShadow
    {
        Yes = 1,
        No = 0
    }

    public class RenderMode
    {
        public const string Sketch = "Sketch";
        public const string AO2 = "AO2";
        public const string AO4 = "AO4";
    }

    public enum TextureMode
    {
        Color = 1,
        Texture = 0
    }

    public class ProjectSettings
    {
        public int BackgroundStyle { get; set; }
        
        public int SceneComplex { get; set; }
        
        public int ThemeStyle { get; set; }
        
        public string GroundStyle { get; set; }
        
        public int SceneDomain { get; set; }

        public int ColorFilter { get; set; }
        public string TransparentMode { get; set; }
        public string ColorMode { get; set; }
        public int GrayScene { get; set; }
        public int PickCameraMove { get; set; }

        public int ShowAxis { get; set; }
        public int ShowViewBox { get; set; }
        public string ViewBoxPath { get; set; }
        public int ShowQuickBar { get; set; }
        public int MaxMemory { get; set; }
        public int MobileMaxMemory { get; set; }
        public int RenderByteSize { get; set; }
        public int GroundShadow { get; set; }
        public string RenderMode { get; set; }
        public int TextureMode { get; set; }
        public string LoadFiles { get; set; }

        public ProjectSettings()
        {
            BackgroundStyle = 1;
            SceneComplex = 1;
            ThemeStyle = 1;
            GroundStyle = SceneGroundStyle.None;
            SceneDomain = 1;
            ColorFilter = 1;
            TransparentMode = "auto";
            ColorMode = "theme";
            GrayScene = 1;
            PickCameraMove = 1;
            ShowAxis = 0;
            ShowViewBox = 1;
            ViewBoxPath = "/images/viewbox/xyz";
            ShowQuickBar = 1;
            MaxMemory = 0;
            MobileMaxMemory = 0;
            RenderByteSize = 0;
            GroundShadow = 0;
            RenderMode = "Sketch";
            TextureMode = 1;
            LoadFiles = "";
        }
    }
}
