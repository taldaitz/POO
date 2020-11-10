using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Utilisateur
    {
        private string login;
        private string password;

        public string nom;

        //Singleton
        private static Utilisateur instance;

        private Utilisateur()
        {
            this.login = "admin";
            this.password = "adminToto";
        }

        public bool authenticate(string login, string password)
        {
            return this.login == login && this.password == password;
        }

        public static Utilisateur getInstance()
        {
            if (instance == null)
                instance = new Utilisateur();
            return instance;
        }
    }
}
