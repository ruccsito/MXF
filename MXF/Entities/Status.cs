using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MXF.Entities
{
    [Table("tbl_status")]
    public class Status
    {
        [Key]
        public int statusid { get; set; }
        public string status { get; set; }
    }
}