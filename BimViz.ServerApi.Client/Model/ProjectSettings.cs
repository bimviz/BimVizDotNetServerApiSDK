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

    public class ProjectSettings
    {
        public int BackgroundStyle { get; set; }
        
        public int SceneComplex { get; set; }
        
        public int ThemeStyle { get; set; }
        
        public string GroundStyle { get; set; }
        
        public int SceneDomain { get; set; }

        public ProjectSettings()
        {
            BackgroundStyle = 1;
            SceneComplex = 1;
            ThemeStyle = 1;
            GroundStyle = SceneGroundStyle.None;
            SceneDomain = 1;
        }
    }
}
