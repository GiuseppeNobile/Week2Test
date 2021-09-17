using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CREAZIONE WAREHOUSE
            Warehouse warehouse1 = new Warehouse()
            {
                ID = Guid.NewGuid(),
                Indirizzo = "via Dante 51",
                ImportoTotaleMerci = 560.34,
                DataUltimaOperazione = DateTime.Today,
                MerciInGiacenza = new List<Good>()
            };            
            #endregion

            #region CREAZIONE GOODS
            Good electronic1 = new ElectronicGood
                               ("E001", "Smatrphone", 340.99, DateTime.Today, 123, "Samsung");
            Good electronic2 = new ElectronicGood
                               ("E002", "Tablet", 120.50, DateTime.Today, 90, "LG");

            Good perishable1 = new PerishableGood
                               ("P001", "Carote", 4.50, DateTime.Today, 56, DateTime.Today, PerishableGood.PlaceToStore.FRIDGE);
            Good perishable2 = new PerishableGood
                               ("P002", "Carne in scatola", 4.50, DateTime.Today, 45, DateTime.Today, PerishableGood.PlaceToStore.SHELF);

            Good spirit1 = new SpiritDrinkGood
                           ("S001", "Vodka alla fragola", 12.55, DateTime.Today, 34, 7, SpiritDrinkGood.AlcoholType.VODKA);
            Good spirit2 = new SpiritDrinkGood
                           ("S002", "Whisky doppio malto", 22.40, DateTime.Today, 67, 9, SpiritDrinkGood.AlcoholType.WHISKY);

            #endregion

            #region AGGIUNTA E RIMOZIONE DI OGGETTI
            warehouse1 += electronic1;
            warehouse1 += electronic2;
            warehouse1 += perishable1;
            warehouse1 += perishable2;
            warehouse1 += spirit1;
            warehouse1 += spirit2;

            warehouse1.StockList();

            warehouse1 -= perishable1;
            warehouse1 -= electronic2;

            warehouse1.StockList();

            #endregion
            
        }
    }
}
