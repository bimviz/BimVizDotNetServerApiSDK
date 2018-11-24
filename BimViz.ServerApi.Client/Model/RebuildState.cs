using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BimViz.ServerApi.Client.Model
{
    public class RebuildCmd
    {
        public const string RebuildAll = "RebuildAll";
        public const string RebuildScene = "RebuildScene";
    }

    public class RebuildState
    {
        public bool IsSuccess { get; set; }
        public bool IsFinished { get; set; }
        public int State { get; set; }
        public List<string> Messages { get; set; }
    }
}
