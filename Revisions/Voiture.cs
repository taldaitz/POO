using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class Voiture : IPilotable
    {
        private string plaque;
        private string marque;
        private string couleur;
        private int vitesse;
        private bool estDemarre;

        public Voiture(string plaque, string marque, string couleur)
        {
            this.plaque = plaque;
            this.marque = marque;
            this.couleur = couleur;
        }

        public void demarrer() {
            this.estDemarre = true;
        }
        public virtual void accelerer() {
            if (this.estDemarre)
                this.vitesse += 5;
        }
        public void arreter() {
            this.estDemarre = false;
            this.vitesse = 0;
        }

        public override string ToString()
        {
            return String.Format("Etat : {0} - vitesse = {1}", this.estDemarre ? "demarrée" : "à l'arret", this.vitesse );
        }

        public void avancer()
        {
            this.demarrer();
            this.accelerer();
        }
    }
}
