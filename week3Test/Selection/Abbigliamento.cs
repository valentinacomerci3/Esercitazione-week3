using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3Test
{
    class Abbigliamento : Prodotto
    {
        public string Taglia { get; set; }
        public string Brand { get; set; }


        public override string ToString()
        {
            return base.ToString() + $"Taglia :{Taglia}\nBrand :{Brand}\n";
        }
    }
}
