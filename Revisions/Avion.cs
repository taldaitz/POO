using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class Avion : IPilotable
    {
        public string modele;
        public int nbPlaces;
        private bool estDemarre;
        private int altitude;
        private int vitesse;

        public void demarrer()
        {
            this.estDemarre = true;
        }

        public void arreter()
        {
            sePoser();
            this.vitesse = 0;
            this.estDemarre = false;
        }

        public void decoller() {
            this.altitude = 100;
        }

        public void sePoser()
        {
            this.altitude = 0;
        }

        public void mettreLesGaz()
        {
            this.vitesse = 300;
        }

        public void avancer()
        {
            this.demarrer();
            this.decoller();
            this.mettreLesGaz();
        }
    }
}
