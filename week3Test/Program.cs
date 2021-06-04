using System;
using System.Collections.Generic;

namespace week3Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBenvenuto nello Store");

            // controllo credenziali 

            Utente uno = new Utente()
            {
                Username = "goosebump",
                Password = "hardtoguess",
                NomeCognome = "Carlo Carlino"
            };

            string nomeutente;
            string pass;

            do
            {
                Console.WriteLine("\n\n---------Accedi---------\n");
                Console.Write("Nome utente:");
                nomeutente = Console.ReadLine();
                Console.Write("\nPassword:");
                pass = Console.ReadLine();
               
            } while (pass != uno.Password || nomeutente != uno.Username);

            Console.WriteLine("\n\nAccesso eseguito!");

            

            char key;
            var prodotto = new List<Prodotto>();

            bool quit = false;
            do
            {
                Console.WriteLine("\nCosa vuoi fare?\n");
                Console.WriteLine("Premi 1 - Aggiungi Prodotto");
                Console.WriteLine("Premi 2 - Elimina Prodotto");
                Console.WriteLine("Premi 3 - Modifica Quantita Prodotto Acquistato");
                Console.WriteLine("Premi 4 - Visualizza il tuo carrello");
                Console.WriteLine("Premi q - Esci");

                key = Console.ReadKey().KeyChar;
                Console.ReadLine();
                switch (key)
                {
                    case '1':

                        Store.MostraProdotti();
                        
                        int scelta = Store.SceltaCodice();
                        Store.MostraProdottoSelezionato(scelta);

                        //prodotti scelti vengono aggiunti alla lista "ordine" di tipo prodotto presente nel carrello
                       
                        Console.WriteLine("\nProdotto aggiunto!");
                        
                        break;
                    case '2':
                        Console.WriteLine("\nProdotto Eliminato!");

                       
                        break;
                    case '3':
                        Console.WriteLine("\nModifica Eseguita!");
                        
                        break;
                    case '4':
                        Console.WriteLine("\nIl tuo carrello:");
                        
                        

                        break;
                    case 'q':
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("\nRiprovare");
                        break;
                }

            } while (!quit);

            
        }
    }
}
