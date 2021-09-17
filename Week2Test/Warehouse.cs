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
        public Guid ID { get; }
        public string Indirizzo { get; set; }
        public double ImportoTotaleMerci { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        public List<Good> MerciInGiacenza { get; set; }
        #endregion

        #region CONSTRUCTORS
        public Warehouse() { }
        public Warehouse(Guid id, string address, double total, DateTime operation, List<Good> list) : base()
        {
            ID = id;
            Indirizzo = address;
            ImportoTotaleMerci = total;
            DataUltimaOperazione = operation;
            MerciInGiacenza = list;
        }
        #endregion

        #region OVERLOAD OPERATORS

        #endregion

        #region METHODS

        #endregion

    }
}
