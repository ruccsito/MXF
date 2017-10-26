using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MXF.Models
{
    public class ProjectData
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string bu { get; set; }
        public int size { get; set; }
        public DateTime lastModify { get; set; }
    }
}