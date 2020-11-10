using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {

            Utilisateur user = Utilisateur.getInstance();


            Console.WriteLine("Saisir votre login :");
            string login = Console.ReadLine();
            Console.WriteLine("Saisir votre mot de passe :");
            string mdp = Console.ReadLine();


            if(!user.authenticate(login, mdp))
            {
                Console.WriteLine("Problème d'authentification veuillez vous reconnectez.");
                return;
            }

            Console.WriteLine("Saisir votre nom :");
            string nom = Console.ReadLine();

            user.nom = nom;


            Produit produit1 = new Produit("Souris", 8);
            Produit produit2 = new Produit("Clavier", 27, "Clavier d'ordinateur");
            Produit produit3 = new Produit("Cahier", 3, "Cahier de 50 pages");

            Console.WriteLine(produit1.afficherInformation());
            Console.WriteLine(produit2.afficherInformation());
            Console.WriteLine(produit3.afficherInformation());

            Facture bill = new Facture("0001", DateTime.Now);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(produit1.Nom);

            Console.ReadLine();

        }
    }
}
