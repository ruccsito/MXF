using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MXF.Entities
{
    public partial class MySqlContext: DbContext
    {
        static MySqlContext()
        {
            Database.SetInitializer<MySqlContext>(null);
        }

        public MySqlContext() : base("Name=MySQL")
        {
        }

        public DbSet<Project> Project { get; set; }
        public DbSet<BusinessUnit> BusinessUnit { get; set; }
        public DbSet<Status> Status { get; set; }


    }
}