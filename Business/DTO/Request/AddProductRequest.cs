using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO.Request
{
    public class AddProductRequest
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public int UnitsInStock { get; set; }
    }
}
