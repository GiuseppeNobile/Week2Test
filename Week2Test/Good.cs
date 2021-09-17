﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{
    public class Good
    {
        #region PROPERTIES
        public Guid CodiceMerce { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public DateTime DataDiRicevimento { get; set; }
        public int QuantitaInGiacenza { get; set; }
        #endregion

        #region CONSTRUCTORS      
        public Good() { }
        public Good(Guid code, string desc, double price, DateTime datar, int quant) : base()
        {
            CodiceMerce = code;
            Descrizione = desc;
            Prezzo = price;
            DataDiRicevimento = datar;
            QuantitaInGiacenza = quant;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            Console.WriteLine($"Codice merce \tDescrizione \tPrezzo \tData di ricevimento \tQuantità in giacenza \n");
            return $"{CodiceMerce} \t {Descrizione} \t{Prezzo} \t{DataDiRicevimento} \t{QuantitaInGiacenza}";
        }
        #endregion
    }
}
