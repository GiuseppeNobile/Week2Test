using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{
    public class ElectronicGood : Good
    {
        #region PROPERTIES
        public string Produttore { get; set; }
        #endregion

        #region CONSTRUCTORS
        public ElectronicGood(Guid code, string desc, double price, DateTime datar , int quant, string prod) 
                            : base(code, desc, price, datar, quant)
        {

            Produttore = prod;
        }
        #endregion

        #region METHODS

        #endregion
    }
}
