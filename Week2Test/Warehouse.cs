using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Test
{
    public class Warehouse
    {
        #region PROPERTIES
        public Guid ID { get; set; }
        public string Indirizzo { get; set; }
        public double ImportoTotaleMerci { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        public List<Good> MerciInGiacenza { get; set; }
        #endregion

        #region CONSTRUCTORS
        public Warehouse() { }
        public Warehouse(Guid id, string address, double total, DateTime operation, List<Good> list) : base()
        {
            try
            {
                ID = id;
                Indirizzo = address;
                ImportoTotaleMerci = total;
                DataUltimaOperazione = operation;
                MerciInGiacenza = list;
            }
            catch (InvalidWarehouseException e)
            {
                throw;
            }

        }
        #endregion

        #region OVERLOAD OPERATORS
        public static Warehouse operator +(Warehouse a, Good b)
        {
            a.MerciInGiacenza.Add(b);
            return a;
        }
        public static Warehouse operator -(Warehouse a, Good b)
        {
            a.MerciInGiacenza.Remove(b);
            return a;
        }
        #endregion

        #region METHODS
        public void StockList()
        {
            int i; //contatore per la lista di merci

            Console.WriteLine($"Dati del magazzino:\n");
            Console.WriteLine($"ID: \t{ID}:\n");
            Console.WriteLine($"Indirizzo: \t{Indirizzo}:\n");
            Console.WriteLine($"Importo totale merci: \t{ImportoTotaleMerci}:\n");
            Console.WriteLine($"Data ultima operazione: \t{DataUltimaOperazione}:\n");
            Console.WriteLine("Merci in giacenza: \n");
            
            for(i=0; i < MerciInGiacenza.Count(); i++)
            {
                Console.WriteLine($"{MerciInGiacenza[i]}");
            }
        }
        #endregion

    }
}
