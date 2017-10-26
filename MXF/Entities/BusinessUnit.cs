using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MXF.Entities
{
    [Table("tbl_businessunit")]
    public class BusinessUnit
    {
        [Key]
        public int businessunitid { get; set; }
        public string businessunitname { get; set; }
    }
}