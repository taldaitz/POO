using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    class Equipe
    {
        public string nom;
        private string ville;
        private List<Joueur> joueurs;
        private Gardien gardien;
        private IEntraineur entraineur;

        public Equipe(string nom, string ville, IEntraineur entraineur)
        {
            this.nom = nom;
            this.ville = ville;
            this.entraineur = entraineur;

            this.joueurs = new List<Joueur>();
        }

        public void ajouterJoueur(Joueur joueur)
        {
            this.joueurs.Add(joueur);
            joueur.equipe = this;
        }

        public void ajouterJoueur(Gardien gardien)
        {
            this.gardien = gardien;
            this.ajouterJoueur((Joueur) gardien);
        }

        public bool EstPrete
        {
            get
            {
                return this.gardien != null && this.joueurs.Count >= 4;
            }
        }

        public void presenterEquipe()
        {
            Console.WriteLine("Nom de l'équipe : {0}", this.nom);
            Console.WriteLine("Ville de l'équipe : {0}", this.ville);
            Console.WriteLine("Joueurs : ");

            foreach(Joueur joueur in joueurs)
            {
                Console.WriteLine(joueur.sePresenter());
            }

        }


        public void genererEquipe()
        {
            for(int i = 0; i < 11; i++)
            {
                joueurs.Add(JoueurFactory.CreateJoueur());
            }
        }
    }
}
