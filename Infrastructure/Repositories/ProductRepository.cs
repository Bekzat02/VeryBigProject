﻿using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using ProjectForAITUCanteen.Domain.Models;
using ProjectForAITUCanteen.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForAITUCanteen.Infrastructure.Repositories
{
    public class ProductRepository : EntityRepository<Product>, IProductRepository
    {
        private readonly DbSet<Product> _products;

        public ProductRepository(CanteenContext dbContext) : base(dbContext)
        {
            _products = dbContext.Products; // or dbContext.Set<Product>()
        }
        public async Task<Product> GetProductWithMinimumPrice()
        {
            var min = await _products.MinAsync(p => p.Price);
            return await _products.FirstOrDefaultAsync(p => p.Price == min);
        }
    }
}
