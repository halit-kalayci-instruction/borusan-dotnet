using Business.Abstract;
using Business.DTO;
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

        public void Add(ProductForAddDto productForAddDto)
        {
            // UnitPrice 0'dan küçük olamaz
            // Stok 0'dan küçük olamaz

            // Eğer bu kurallar sağlanıyor ise veritabanına ekle
            // sağlanmıyor ise Exception fırlat.

            // FluentValidation
            if (productForAddDto.UnitPrice < 0)
                throw new Exception("Fiyat 0'dan küçük olamaz");

            if (productForAddDto.UnitsInStock < 0)
                throw new Exception("Stok değeri 0'dan küçük olamaz.");

            // Manual Mapping

            // DTO => Entity ✔️✔️
            // Entity => DTO

            Product product = new Product()
            {
                Description = productForAddDto.Description,
                Name = productForAddDto.Name,
                UnitPrice = productForAddDto.UnitPrice,
                UnitsInStock = productForAddDto.UnitsInStock,
                Id = new Random().Next(1, 9999),
            };

            _productRepository.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
