using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPresence
{
    class Emargement
    {
        public Emargement()
        {
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Statut { get; set; } 
        public int ProfesseurId { get; set; }
        public Users Professeur { get; set; }
        public int CoursId { get; set; }
        public Cours Cours { get; set; }
    }
}
