using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interface;
using Core.Models;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        private static ProductRepository _productRepository = null;
        private List<Product> products = new List<Product>();
        private int _nextId = 1;
        private ProductRepository()
        {
            Add(new Product { Name = "Tomato soup", Category = "Groceries", Price = 1.39M });
            Add(new Product { Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            Add(new Product { Name = "Hammer", Category = "Hardware", Price = 16.99M });
        }

        public static ProductRepository Init()
        {
            return _productRepository ?? (_productRepository = new ProductRepository());
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            item.Id = _nextId;
            products.Add(item);
            _nextId++;
            return item;
        }

        public int Delete(int id)
        {
            return products.RemoveAll(p => p.Id == id);
        }

        public int Update(Product item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
                return 0;
            products.RemoveAt(index);
            products.Add(item);
            return 1;
        }
    }
}
