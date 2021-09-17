﻿using System;
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
        public PerishableGood(Guid code, string desc, double price, DateTime datar, int quant, 
                              DateTime scad, PlaceToStore cons) 
                            : base(code, desc, price, datar, quant)
        {
            DataScadenza = scad;
            Conservazione = cons;
        }
        #endregion

        #region METHODS

        #endregion
    }
}
