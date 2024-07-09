using Business.DTO;
using Business.DTO.Request;
using Business.DTO.Response;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        AddProductResponse Add(AddProductRequest addProductRequest);
        List<ProductForListingDto> GetAll();
    }
}
