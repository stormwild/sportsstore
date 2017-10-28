﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class SportStoreContext : DbContext
    {
        public SportStoreContext(DbContextOptions<SportStoreContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
