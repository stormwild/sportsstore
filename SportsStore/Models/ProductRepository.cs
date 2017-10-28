using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly SportStoreContext ctx;

        public ProductRepository(SportStoreContext context)
        {
            ctx = context;
        }

        public IEnumerable<Product> Products => ctx.Products;
    }
}
