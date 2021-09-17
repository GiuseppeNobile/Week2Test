using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{
    public class InvalidGoodException : Exception
    {
        public InvalidGoodException() 
        {
            Console.WriteLine("Oggetto Good non valido, ricontrollare gli attributi");
        }
    }
}
