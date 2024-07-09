using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    // Ürün eklemek isteyen kullanıcı ürünün tüm bilgileri yerine
    // aşağıdaki kalıpta bilgiler gönderecek.
    public class ProductForAddDto
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public int UnitsInStock { get; set; }
    }
}
