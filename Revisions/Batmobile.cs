using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class Batmobile : Voiture, IPilotable
    {
        private bool reacteur;

        public Batmobile(string plaque) : base (plaque, "Wayne Entreprise", "Noire") {}

        public void allumerReacteur() {
            this.reacteur = true;
        }
        public void eteindreReacteur() {
            this.reacteur = false;
        }

        public override void accelerer()
        {
            int multiplicateur = reacteur ? 5 : 1;
            for(int i = 0; i < multiplicateur; i++)
            {
                base.accelerer();
            }
                
        }
    }
}
