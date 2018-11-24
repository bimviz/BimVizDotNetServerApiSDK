using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BimViz.ServerApi.Client.Model
{
    public enum ProjectState 
    {
        Processing = 0,
        Finished = 1
    }

    public class BVProject
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Guid { get; set; }

        public int State { get; set; }
        public BVProject()
        {
            State = -1;
        }
    }
}
