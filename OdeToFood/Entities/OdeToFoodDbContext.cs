﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Entities
{
    public class OdeToFoodDbContext : IdentityDbContext<User>
    {
        public OdeToFoodDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }

    }
}
