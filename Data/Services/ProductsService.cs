﻿using ECommerce1.Data.Services.Interfaces;
using ECommerce1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce1.Data.Services
{
    public class ProductsService : IProductsService
    {
        private readonly AppDBContext _context;
        public ProductsService(AppDBContext context)
        {
            _context = context;
        }

        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Task<bool> DeleteProduct(long Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var result = await _context.Products.ToListAsync();

            return result;
        }

        public Product GetProductById(long Id)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(long Id, Product product)
        {
            throw new NotImplementedException();
        }

        public Product InitializeProduct() {
            var _result = new Product()
            {
                ProductCategories =  _context.ProductCategories.ToList(),
                Statuses =  _context.Statuses.ToList(),
                Genders =  _context.Genders.ToList()
            };

         return _result;

        }

    }
}
