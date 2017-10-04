using System;
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

        public IEnumerable<Product> ListProducts(int retrievalCount = 250, int startIndex = 0)
        {
            return _db.GetRange(startIndex, retrievalCount);
        }
    }
}