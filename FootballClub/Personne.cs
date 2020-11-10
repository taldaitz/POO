using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    abstract class Personne
    {
        protected string nom;
        protected string prenom;
        protected DateTime dateNaissance;
        public string email;

        protected Personne(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        public abstract string sePresenter();
    }
}
