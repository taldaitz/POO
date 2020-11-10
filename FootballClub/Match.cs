using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub
{
    class Match
    {
        private Equipe equipeDom;
        private Equipe equipeExt;
        private DateTime date;
        private List<IParticipant> participants;
        private List<ISpectateur> spectateurs;

        public Match(Equipe equipeDom, Equipe equipeExt, DateTime date)
        {
            this.equipeDom = equipeDom;
            this.equipeExt = equipeExt;
            this.date = date;

            this.participants = new List<IParticipant>();
            this.spectateurs = new List<ISpectateur>();
        }

        public void ajouterParticipant(IParticipant participant)
        {
            this.participants.Add(participant);
        }

        public void ajouterSpectateur(ISpectateur spectateur)
        {
            this.spectateurs.Add(spectateur);
        }

        public string imprimerFeuilleMatch()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Equipe Domcilie : {0}\n" , equipeDom.nom);
            sb.AppendFormat("Equipe Exterieur : {0}\n" , equipeExt.nom);
            sb.AppendFormat("Date : {0}\n" , date);

            sb.AppendFormat("Participants :\n");

            foreach(IParticipant participant in participants)
            {
                sb.AppendLine(participant.afficherParticipation());
            }

            return sb.ToString();
        }
    }
}
