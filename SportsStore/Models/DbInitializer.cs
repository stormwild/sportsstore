using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public static class DbInitializer
    {
        public static void Initialize(SportStoreContext ctx)
        {
            ctx.Database.EnsureCreated();

            if (!ctx.Products.Any())
            {
                ctx.Products.AddRange(
                    new Product { Name = "Football", Price = 25 },
                    new Product { Name = "Surf board", Price = 179 },
                    new Product { Name = "Running shoes", Price = 95 }
                );

                ctx.SaveChanges();
            }
        }
    }
}
