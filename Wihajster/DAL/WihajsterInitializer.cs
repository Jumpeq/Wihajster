using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wihajster.Models;

namespace Wihajster.DAL
{
    public class WihajsterInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WihajsterDbContext>
    {
        protected override void Seed(WihajsterDbContext context)
        {
            
        }
    }
}