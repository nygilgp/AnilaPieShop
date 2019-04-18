﻿using System;
using Microsoft.EntityFrameworkCore;

namespace AnilaPieShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pie> Pies { get; set; }

    }
}
