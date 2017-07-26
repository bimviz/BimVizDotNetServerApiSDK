using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BimViz.ServerApi.Client.Model
{
    public class BVUserRole
    {
        public const string Admin = "admin";
        public const string User = "normal";
    }

    public class BVUser
    {
        public string username { get; set; }
        public string password { get; set; }
        public string helloname { get; set; }
        public string key { get; set; }
        public string role { get; set; }
    }
}
