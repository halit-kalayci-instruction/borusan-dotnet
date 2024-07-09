﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Absract
{
    public interface IProductRepository
    {
        // CRUD Operasyonları
        // Create - Read - Update - Delete
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);   
        void Delete(int id);
    }
}
