using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3Test
{
    public abstract class Prodotto
    {
     
        public int Codice { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double Sconto { get; set; }

        public override string ToString()
        {
            return $"Codice:{Codice}\n Descrizione: {Descrizione}\n Prezzo: {Prezzo}\n Sconto: {Sconto} ";
        }
    }

}
