using Business.Abstract;
using DataAccess.Absract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product product)
        {
            // UnitPrice 0'dan küçük olamaz
            // Stok 0'dan küçok olamaz

            // Eğer bu kurallar sağlanıyor ise veritabanına ekle
            // sağlanmıyor ise Exception fırlat.

            // FluentValidation
            if (product.UnitPrice < 0)
                throw new Exception("Fiyat 0'dan küçük olamaz");

            if (product.UnitsInStock < 0)
                throw new Exception("Stok değeri 0'dan küçük olamaz.");

            _productRepository.Add(product);
        }
    }
}
