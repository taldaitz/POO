using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    class JoueurFactory
    {
        public static Joueur CreateJoueur()
        {
            return new Joueur("Joueur" + new Random().Next(), "Thomas", DateTime.Now, "en forme");
        }
    }
}
