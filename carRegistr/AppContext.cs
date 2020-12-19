using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace carRegistr
{
    class AppContext: DbContext
    {
        public DbSet<Car> Cars { set; get; }
        public DbSet<Owner> Owners { set; get; }

        public AppContext() :base("DefaultConnection") {   }

    }
}
