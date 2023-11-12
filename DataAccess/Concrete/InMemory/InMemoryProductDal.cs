using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            // veritabanının simule edilmesi
            _products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Kalem", UnitPrice = 15, UnitsInStock = 10 },
                new Product { ProductId = 2, CategoryId = 1, ProductName = "Silgi", UnitPrice = 5, UnitsInStock = 100 },
                new Product { ProductId = 3, CategoryId = 1, ProductName = "Defter", UnitPrice = 20, UnitsInStock = 55 },
                new Product { ProductId = 4, CategoryId = 3, ProductName = "Kitap", UnitPrice = 15, UnitsInStock = 44 },
                new Product { ProductId = 5, CategoryId = 3, ProductName = "Dergi", UnitPrice = 15, UnitsInStock = 75 },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=> p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
