using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3Test
{
    public class Store
    {
        private static IDictionary<int, Prodotto> prodottiDisponibili = CaricaDistributore();

        private static IDictionary<int, Prodotto> CaricaDistributore()
        {
            IDictionary<int, Prodotto> merendine = new Dictionary<int, Prodotto>()
            {
                [0] = new Alimentare() { Codice = 0, Descrizione = "Biscotti Mulino Bianco", Prezzo = 4.0, Sconto = 30, Scadenza= new DateTime(12/12/2024)},
                [1] = new Abbigliamento() { Codice = 1, Descrizione = "Runner Shorts", Brand = "Nike", Prezzo = 25.0, Sconto = 10 },
                [2] = new Elettronica() { Codice = 2, Descrizione = "Power Bank", Prezzo = 15.0, Sconto = 20 },
                [3] = new Elettronica() { Codice = 3, Descrizione = "Cuffie Bluetooth", Prezzo = 75.0, Sconto = 30 }
            };
            return merendine;
        }

        public static void MostraProdotti()
        {
            Console.WriteLine("Lista di prodotti disponibili");
            foreach (var item in prodottiDisponibili)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Descrizione} - Prezzo:{item.Value.Prezzo} euro - Sconto:{item.Value.Sconto}%");
            }
        }


        public static int SceltaCodice()
        {
            int codice;
            do
            {
                Console.WriteLine("Inserisci il codice prodotto");

            } while (!(Int32.TryParse(Console.ReadLine(), out codice)) || !prodottiDisponibili.ContainsKey(codice));
            return codice;
        }

        public static void MostraProdottoSelezionato(int codice)
        {
            Console.Write($"Hai scelto il codice {codice} \t");
            var prodottoSelezionato = prodottiDisponibili[codice];
            Console.WriteLine($"{prodottoSelezionato.Descrizione} - {prodottoSelezionato.Prezzo}");
        }


    }
}