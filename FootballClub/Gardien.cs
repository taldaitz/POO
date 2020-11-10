using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    class Gardien : Joueur
    {
        public int tailleDesGants;

        public Gardien(string nom, string prenom, DateTime dateNaissance) : base(nom, prenom, dateNaissance, "en forme")
        {
            this.poste = "gardien";
        }

        public override string sePresenter()
        {
            return String.Format("Je suis gardien, mon nom est {0} {1} et ma taille de gant est {2}", 
                this.Prenom, this.Nom, this.tailleDesGants);
        }
    }
}
