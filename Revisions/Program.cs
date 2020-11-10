using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class Program
    {
        static void Main(string[] args)
        {

            Voiture car = new Voiture("437348", "Polo", "Jaune");

            Batmobile batmobile = new Batmobile("BATMAN");

            car.demarrer();
            car.accelerer();
            car.accelerer();
            car.accelerer();

            batmobile.demarrer();
            batmobile.allumerReacteur();
            batmobile.accelerer();
            batmobile.accelerer();
            batmobile.accelerer();
            batmobile.accelerer();
            batmobile.accelerer();

            Avion plane = new Avion();

            Pilote pilote = new Pilote();

            pilote.piloter(car);
            pilote.piloter(batmobile);
            pilote.piloter(plane);


            Console.ReadLine();
        }
    }
}
