using System;
using space.sander.web.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace space.sander.web.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {}

        public DbSet<Item> Items { get; set; }
    }
}
