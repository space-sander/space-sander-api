using space.sander.web.Domain.Catalog;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace space.sander.web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context, ILogger logger)
        {
            if (!context.Items.Any())
            {
                var items = new Item[]
                {
                    new Item("T-Shirt", "Ohio State Block O", "Nike", "/images/d1.jpg", 39.99m),
                    new Item("Shorts", "Casual Shorts", "Nike", "/images/d1.jpg", 49.99m)
                };
                context.Items.AddRange(items);
                context.SaveChanges();
            }

        }
    }
}
