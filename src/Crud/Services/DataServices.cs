using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Models;

namespace Crud.Services
{
    public class DataServices : IDataServices
    {
        private static List<Product> _products;
        static DataServices()
        {
            _products = new List<Product>
            {
                new Product { ProductId = 1, Name = "PC", Details = "Intel Core 2", Type= TypeEnum.OLD },
                new Product { ProductId = 2, Name = "PC", Details = "Intel Core 2", Type= TypeEnum.NEW },
                new Product { ProductId = 3, Name = "MAC", Details = "Macbook", Type= TypeEnum.OLD },
                new Product { ProductId = 4, Name = "PC", Details = "Intel Core 2", Type= TypeEnum.OLD },
                new Product { ProductId = 5, Name = "MAC", Details = "Macbook Pro", Type= TypeEnum.NEW },
                new Product { ProductId = 6, Name = "PC", Details = "Intel Core 2", Type= TypeEnum.OLD },
                new Product { ProductId = 7, Name = "PC", Details = "Intel Core 2", Type= TypeEnum.OLD },
                new Product { ProductId = 8, Name = "MAC", Details = "Ipad", Type= TypeEnum.OLD },
                new Product { ProductId = 9, Name = "PC", Details = "Intel Core 2", Type= TypeEnum.NEW },
                new Product { ProductId = 10, Name = "MAC", Details = "Apple TV", Type= TypeEnum.OLD },
                new Product { ProductId = 11, Name = "PC", Details = "Intel Core 2", Type= TypeEnum.OLD },
                new Product { ProductId = 12, Name = "PC", Details = "Intel Core 2", Type= TypeEnum.NEW },
                new Product { ProductId = 13, Name = "PC", Details = "Intel Core 2", Type= TypeEnum.NEW },
                new Product { ProductId = 14, Name = "PC", Details = "Intel Core 2", Type= TypeEnum.OLD },

            };
        }

        public void Add(Product p)
        {
            int id = _products.Max(pr => p.ProductId);

            p.ProductId = id + 1;
          
            _products.Add(p);
        }

      

        public void Delete(int id)
        {
            _products.Remove(GetById(id));
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
            
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }

        public void Update()
        {
            
        }
    }
}
