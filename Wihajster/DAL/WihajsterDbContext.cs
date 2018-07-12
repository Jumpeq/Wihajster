using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Wihajster.Models;

namespace Wihajster.DAL
{
    public class WihajsterDbContext :DbContext
    {
        public WihajsterDbContext()
            : base("WihajsterDbContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Picture> Pictures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}