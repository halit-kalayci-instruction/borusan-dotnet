using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        // sayısal => 1,2,3,4,5,6,7,8,9
        // uuid, guid => ASKDE-KDQWEC9123-ASDL23
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public int UnitsInStock { get; set; }
    }
}
