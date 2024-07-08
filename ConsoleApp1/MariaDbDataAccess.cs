using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MariaDbDataAccess : BaseDbAccess
    {
        // Abstract class ile çalışırken abstract methodlar implemente edilmek zorundadır!
        // virtual methodlar ise override edilebilir.
        public override void NotCommonFunction()
        {
            Console.WriteLine("Maria Db Özel Fonksiyonu");
        }
    }
}
