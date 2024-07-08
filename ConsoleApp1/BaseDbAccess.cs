using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class BaseDbAccess : IDataAccess
    {
        public void ConnectToDatabase()
        {
            // Scope
            Console.WriteLine("Ortak db bağlantı kodu çalıştı.");
        }

        public abstract void NotCommonFunction();
    }
}
