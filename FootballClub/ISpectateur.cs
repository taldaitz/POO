using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    interface ISpectateur
    {
        void assister();
        void supporter(Equipe equipe);
    }
}
