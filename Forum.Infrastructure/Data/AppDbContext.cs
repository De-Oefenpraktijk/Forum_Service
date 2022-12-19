﻿using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {
            // ...
        }

        public DbSet<FormPost> ForumPosts { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
    }
}
