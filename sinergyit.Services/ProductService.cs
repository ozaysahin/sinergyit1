using sinergyit.Entities;
using sinergyit.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinergyit.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public List<Product> GetAll()
        {
            return _repo.GetAll();
        }

        public void Add(Product product)
        {
            _repo.Add(product);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }

}
