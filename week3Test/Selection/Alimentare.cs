using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3Test
{
    class Alimentare : Prodotto
    {
        public DateTime Scadenza { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Data di Scadenza :{Scadenza}\n";
        }
    }
}
