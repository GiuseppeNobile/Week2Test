using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{
    public class InvalidWarehouseException : Exception
    {
        public InvalidWarehouseException()
        {
            Console.WriteLine("Oggetto Warehouse non valido, ricontrollare gli attributi");
        }
    }
}
