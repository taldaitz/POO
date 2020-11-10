using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Produit
    {
        private string nom;
        private string description;
        private double prixUnitaire;

        
        public Produit(string nom, double prixUnitaire)
        {
            this.nom = nom;
            this.prixUnitaire = prixUnitaire;
            this.description = "Pas de description";
        }

        public Produit(string nom, double prixUnitaire, string description) : this(nom, prixUnitaire)
        {
            this.description = description;
        }

        public string afficherInformation()
        {
            return String.Format("{0} : {1} euros - {2}", this.Nom, this.PrixUnitaire, this.Description);
        }


        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public double PrixUnitaire
        {
            get => prixUnitaire;
            set
            {
                if (value > 0)
                    prixUnitaire = value;
            }
        }
    }
}
