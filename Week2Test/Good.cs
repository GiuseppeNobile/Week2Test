using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{
    public abstract class Good
    {
        #region PROPERTIES
        public string CodiceMerce { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public DateTime DataDiRicevimento { get; set; }
        public int QuantitaInGiacenza { get; set; }
        #endregion

        #region CONSTRUCTORS      
        public Good() { }
        public Good(string code, string desc, double price, DateTime datar, int quant) : base()
        {
            try
            {
                CodiceMerce = code;
                Descrizione = desc;
                Prezzo = price;
                DataDiRicevimento = datar;
                QuantitaInGiacenza = quant;
            }
            catch (InvalidGoodException e)
            {
                throw;
            }

        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"{CodiceMerce} \t {Descrizione} \t{Prezzo} \t{DataDiRicevimento} \t{QuantitaInGiacenza}";
        }
        #endregion
    }
}
