using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{    
    class PerishableGood: Good
    {
        public enum PlaceToStore { FREEZER, FRIDGE, SHELF }

        #region PROPERTIES
        public DateTime DataScadenza { get; set; }
        public PlaceToStore Conservazione { get; set; }
        #endregion

        #region CONSTRUCTORS
        public PerishableGood(string code, string desc, double price, DateTime datar, int quant, 
                              DateTime scad, PlaceToStore cons) 
                            : base(code, desc, price, datar, quant)
        {
            try
            {
                DataScadenza = scad;
                Conservazione = cons;
            }
            catch
            {
                throw new InvalidGoodException();
            }
            
        }
        #endregion

        #region METHODS
        public override string ToString()
        {            
            return $"{CodiceMerce} \t {Descrizione} \t{Prezzo} \t{DataDiRicevimento} \t{QuantitaInGiacenza} " +
                   $"\t{DataScadenza} \t{Conservazione}";
        }
        #endregion
    }
}
