using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    class Program
    {
        static void Main(string[] args)
        {

            //Joueur joueur1 = new Joueur("Aldaitz", "Thomas", new DateTime(1985, 04, 28)) { poste = "attaquant", numero= 5 };
            //Joueur joueur2 = new Joueur("Test", "Robert", new DateTime(1975, 08, 18)) { poste = "défenseur", numero= 11 };
            //Joueur joueur3 = new Joueur("Retest", "Jean", new DateTime(1988, 02, 12)) { poste = "milieu", numero= 8 };
            //Joueur joueur4 = new Joueur("Machin", "Truc", new DateTime(1982, 03, 16)) { poste = "défenseur", numero= 3 };

            //Gardien gardien = new Gardien("Dupont", "René", new DateTime(2000, 01, 01)) { numero = 1, tailleDesGants = 28 };

            //Coach entraineurOL = new Coach("Gerad", "Franck", new DateTime(1967, 08, 08), 12);
            //Coach entraineurPSG = new Coach("Durand", "Daniel", new DateTime(1967, 09, 18), 6);

            //Arbitre arbitre = new Arbitre("Luigi", "Mario", new DateTime(1976, 12, 01), 1994);

            //Abonne spectateur = new Abonne("Toto", "Bernard", new DateTime(2000, 01, 01));

            //Equipe team = new Equipe("PSG", "Paris", joueur4);
            //team.ajouterJoueur(joueur1);
            //team.ajouterJoueur(joueur2);
            //team.ajouterJoueur(joueur3);
            //team.ajouterJoueur(joueur4);

            //team.ajouterJoueur(gardien);

            ////team.presenterEquipe();


            //Match game = new Match(team, new Equipe("OL", "Lyon", entraineurOL), DateTime.Now.AddDays(1));

            //game.ajouterParticipant(joueur1);
            //game.ajouterParticipant(joueur2);
            //game.ajouterParticipant(joueur3);
            //game.ajouterParticipant(joueur4);
            //game.ajouterParticipant(arbitre);


            //Console.WriteLine(game.imprimerFeuilleMatch());




            //List<Personne> personnes = new List<Personne>();
            //personnes.Add(joueur1);
            //personnes.Add(joueur2);
            //personnes.Add(joueur3);
            //personnes.Add(joueur4);
            //personnes.Add(gardien);
            //personnes.Add(entraineurOL);
            //personnes.Add(entraineurPSG);
            //personnes.Add(arbitre);

            //foreach(Personne personne in personnes)
            //{
            //    Console.WriteLine(personne.sePresenter());
            //}


            Equipe psg = new Equipe("PSG", "Paris", new Coach("Gerad", "Franck", new DateTime(1967, 08, 08), 12));

            psg.genererEquipe();

            Console.ReadLine();

        }
    }
}
