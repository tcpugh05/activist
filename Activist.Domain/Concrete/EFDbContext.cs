﻿using Activist.Domain.Concrete;
using System.Data.Entity;

namespace Activist.Domain.Concrete{
    public class EFDbContext : DbContext {
        public DbSet<Issue> Issues { get; set; }
    }
}