using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MXF.Entities
{
    [Table("tbl_project")]
    public class Project
    {
        [Key]
        public int projectid { get; set; }
        public string projectname { get; set; }
        public int statusid { get; set; }
        public int belongto_businessunitid { get; set; }
        public int storagesize { get; set; }
        public DateTime lastmodifydate { get; set; }
    }
}