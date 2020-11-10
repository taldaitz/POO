using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    class Coach : Personne, IEntraineur, ISpectateur
    {
        public Equipe equipe;
        public int anciennete;

        public Coach(string nom, string prenom, DateTime dateNaissance, int anciennete) : base(nom, prenom, dateNaissance)
        {
            this.anciennete = anciennete;
        }

        public void entrainer(Equipe equipe)
        {
            Console.WriteLine("{0} {1} entraine {2}", this.prenom, this.nom, equipe);
        }

        public override string sePresenter()
        {
            return String.Format("Je suis entraineur depuis {2} années, mon nom est {0} {1}.", this.prenom, this.nom, this.anciennete);
        }

        public void assister()
        {
            throw new NotImplementedException();
        }

        public void supporter(Equipe equipe)
        {
            throw new NotImplementedException();
        }
    }
}
