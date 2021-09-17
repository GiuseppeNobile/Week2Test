using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{
    public class InvalidGoodException : Exception
    {
        
        public InvalidGoodException() : base()
        {

        }
        public InvalidGoodException(string message) : base(message)
        {
            
        }
        public InvalidGoodException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
