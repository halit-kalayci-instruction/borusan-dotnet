using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Kalıtım, Inheritance
    public class PgDataAccess : BaseDbAccess
    {
        public override void NotCommonFunction()
        {
            Console.WriteLine("PG'e erişildi.");
        }
    }
}
