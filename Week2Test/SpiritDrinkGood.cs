using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{
    class SpiritDrinkGood : Good
    {
        public enum AlcoholType { WHISKY, VODKA, GRAPPA, GIN, OTHER}
        #region PROPERTIES
        public int GradazioneAlcolica { get; set; }
        public AlcoholType Tipo { get; set; }
        #endregion

        #region CONSTRUCTORS
        public SpiritDrinkGood(string code, string desc, double price, DateTime datar, int quant, 
                               int grad, AlcoholType t)
                            : base(code, desc, price, datar, quant)
        {
            GradazioneAlcolica = grad;
            Tipo = t;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"{CodiceMerce} \t {Descrizione} \t{Prezzo} \t{DataDiRicevimento} \t{QuantitaInGiacenza} " +
                   $"\t{GradazioneAlcolica} {Tipo}";
        }
        #endregion
    }
}
