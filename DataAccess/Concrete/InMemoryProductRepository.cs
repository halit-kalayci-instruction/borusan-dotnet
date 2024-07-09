using DataAccess.Absract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryProductRepository : IProductRepository
    {
        // InMemory
        private List<Product> products;
        // Veritabanı tablosu

        public InMemoryProductRepository()
        {
            Category category = new() { Id = 1, Name = "Kategori 1" };
            products = new List<Product> { 
                new() { 
                    Id=1, 
                    Description="Ürün 1", 
                    Name="Ürün 1", 
                    UnitPrice=50, 
                    UnitsInStock=0,
                    Category=category,
                }
            };
        }

        // Kullanıcının verdiği değer.
        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Delete(int id)
        {
            // Linq
            Product? product = products.FirstOrDefault(i=>i.Id == id); 

            if(product != null)
                products.Remove(product);
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(i => i.Id == id);
        }

        public void Update(Product product)
        {
            Product? productToUpdate = products.FirstOrDefault(i => i.Id == product.Id);

            if(productToUpdate != null)
            {
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.Category =  product.Category;
                productToUpdate.Description = product.Description;
            }
        }
    }
}
