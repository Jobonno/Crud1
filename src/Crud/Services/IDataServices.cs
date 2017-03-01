using Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Services
{
    public interface IDataServices
    {
        IEnumerable<Product> GetAll();

        Product GetById(int id);

        void Add(Product p);

        void Update();

        void Delete(int id);
    }
}
