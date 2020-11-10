using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    class Arbitre : Personne, IParticipant
    {
        public int anneeDiplome;

        public Arbitre(string nom, string prenom, DateTime dateNaissance, int anneeDiplome) : base(nom, prenom, dateNaissance)
        {
            this.anneeDiplome = anneeDiplome;
        }

        public string afficherParticipation()
        {
            return String.Format("- {0} {1} : {2}", this.nom, this.prenom, this.GetType());
        }

        public void courrir()
        {
            Console.WriteLine("{0} {1} cours", this.prenom, this.nom);
        }

        public override string sePresenter()
        {
            return String.Format("Je suis un arbitre. J'ai eu mon en diplome en {0}. Je m'appelle {1} {2}.", 
                this.anneeDiplome, this.prenom, this.nom);
        }
    }
}
