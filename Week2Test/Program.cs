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
            #region Test creazione warehouse
            Warehouse warehouse1 = new Warehouse()
            {
                Indirizzo = "via Dante 51",
                ImportoTotaleMerci = 560.34,
                DataUltimaOperazione = DateTime.Today,
                MerciInGiacenza = new List<Good>()

            };

            Console.WriteLine($"{warehouse1.ID}");
            #endregion


        }
    }
}
