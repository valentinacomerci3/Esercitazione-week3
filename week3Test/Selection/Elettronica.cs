using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3Test
{
    class Elettronica : Prodotto
    {
        public string Produttore { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Prodotto da :{Produttore}\n";
        }
    }
}
