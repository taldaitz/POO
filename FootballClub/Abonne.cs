using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    class Abonne : Personne, ISpectateur
    {
        private string numeroAbonnement;

        public Abonne(string nom, string prenom, DateTime dateNaissance) : base(nom, prenom, dateNaissance)
        {
        }

        public void assister()
        {
            throw new NotImplementedException();
        }

        public override string sePresenter()
        {
            throw new NotImplementedException();
        }

        public void supporter(Equipe equipe)
        {
            throw new NotImplementedException();
        }
    }
}
