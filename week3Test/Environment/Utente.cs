using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3Test
{
    public class Utente //utente is defined with UN, PASS, NOMECOGN
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NomeCognome { get; set; }
        public Carrello Carrello { get; set; }

        //COSTRUTTORI 

        public Utente() { }
        public Utente(string username, string password, string nomecognome)
        {
            Username = username;
            Password = password;
            NomeCognome = nomecognome;
        }

        
    }
}
