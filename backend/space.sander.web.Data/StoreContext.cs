using System.Collections.Generic;
using space.sander.web.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace space.sander.web.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {}

        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
