using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BimViz.ServerApi.Client.Model
{
    public class ProjectInfo
    {
        public BVProject Project { get; set; }
        public string ThrumbnailUrl { get; set; } //创建项目时，不需要赋值
        public List<ProjectFile> FileInfos { get; set; }//创建项目时，不需要赋值
        public ProjectSettings SceneSettings { get; set; }//创建项目时，改值可以为空
    }
}
