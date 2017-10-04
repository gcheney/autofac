using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using AutofacWebApp.Models;
using AutofacWebApp.Services;

namespace AutofacWebApp.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductRepository _productRepositroy;

        public ProductController(IProductRepository productRepositroy)
        {
            _productRepositroy = productRepositroy;
        }

        [HttpGet]
        public IEnumerable<Product> ListProducts(int startIndex = 0, int limit = 250)
        {
            return _productRepositroy.ListProducts(startIndex, limit);
        }

        [HttpPost]
        public void Add(Product product)
        {
            _productRepositroy.Add(product);
        }
    }
}