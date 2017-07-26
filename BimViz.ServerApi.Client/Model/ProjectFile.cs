using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BimViz.ServerApi.Client.Model
{
    public class ProjectFile
    {
        public string Name { get; set; }
        public long Size { get; set; }

        public string Datetime { get; set; }
    }
}
