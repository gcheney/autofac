﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutofacWebApp.Models;

namespace AutofacWebApp.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _db = new List<Product>();

        public void Add(Product product)
        {
            _db.Add(product);
        }

        public IEnumerable<Product> ListProducts(int startIndex, int limit)
        {
            return _db.GetRange(startIndex, limit);
        }
    }
}