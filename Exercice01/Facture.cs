using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Facture
    {
        public string numero; 
        public DateTime date;
        public List<LigneFacture> produits;
        public Utilisateur createur;

        public Facture(string numero, DateTime date)
        {
            this.numero = numero;
            this.date = date;

            this.createur = Utilisateur.getInstance();

            Console.WriteLine("Une facture est crééé par {0}", this.createur.nom);
        }
    }
}
