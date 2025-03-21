using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPresence
{
    class Cours
    {
        public Cours() 
        {
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public TimeSpan HeureDebut { get; set; }
        public TimeSpan HeureFin { get; set; }
        public int SalleId { get; set; }
        public Salle Salle { get; set; }
   
    }

    class CoursView
    {
       

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public TimeSpan HeureDebut { get; set; }
        public TimeSpan HeureFin { get; set; }
        public Salle Salle { get; set; }

    }
}
