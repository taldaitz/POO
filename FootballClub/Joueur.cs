using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    class Joueur : Personne, IEntraineur, IParticipant
    {
        public string poste;
        public int numero;
        private bool titulaire;
        private string statut;
        public Equipe equipe;


        public Joueur(string nom, string prenom, DateTime dateNaissance, string statut) : base(nom, prenom, dateNaissance)
        {
            this.titulaire = false;
        }

        public override string sePresenter()
        {
            return String.Format("Je m'appelle {0} {1} et je joue au poste de {2} au numéro {3}", 
                this.prenom, this.nom, this.poste, this.numero);
        }

        public void titulariser()
        {

        }

        public override string ToString()
        {
            return this.sePresenter();
        }

        public void entrainer(Equipe equipe)
        {
            Console.WriteLine("{0} {1} entraine {2}", this.prenom, this.nom, equipe);
        }

        public void courrir()
        {
            Console.WriteLine("{0} {1} cours", this.prenom, this.nom);
        }

        public string afficherParticipation()
        {
            return String.Format("- {0} {1} : {2}", this.nom, this.prenom, this.GetType());
        }

        protected string Nom { get => nom;}
        protected string Prenom { get => prenom;}
    }
}
