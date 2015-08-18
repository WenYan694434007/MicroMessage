using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core.Interface;
using Core.Models;
using Repository;

namespace WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        static readonly IProductRepository repository=ProductRepository.Init();
        public IEnumerable<Product> GetAllProducts()
        {
            return repository.GetAll();
        }
        public Product GetProduct(int id)
        {
            Product item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return repository.GetAll().Where(
                p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        }
        public Product PostProduct(Product item)
        {
            if (ModelState.IsValid)
            {
                item = repository.Add(item);
            }
            return item;
        }
    }
}
