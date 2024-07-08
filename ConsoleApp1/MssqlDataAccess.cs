using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MssqlDataAccess : BaseDbAccess
    {
        public override void NotCommonFunction()
        {
            Console.WriteLine("Mssql'e erişildi.");
        }
    }
}
