using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutofacWebApp.Models;

namespace AutofacWebApp.Services
{
    public interface IProductRepository
    {
        void Add(Product product);
        IEnumerable<Product> ListProducts(int startIndex, int retrievalCount);
    }
}