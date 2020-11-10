using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions
{
    class Pilote
    {
        public string prenom;
        public string nom;


        public void piloter(IPilotable vehicule)
        {
            vehicule.avancer();
        }
    }
}
