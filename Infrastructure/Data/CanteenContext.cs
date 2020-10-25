using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class CanteenContext : DbContext
    {
        public CanteenContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<UserEntity> Users { get; private set; }
    }
}
