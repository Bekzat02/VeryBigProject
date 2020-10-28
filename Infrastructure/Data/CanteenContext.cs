using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using ProjectForAITUCanteen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class CanteenContext : DbContext
    {
        public CanteenContext(DbContextOptions<CanteenContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
