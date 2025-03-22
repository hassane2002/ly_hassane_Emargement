using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GestionPresence
{
    class DbPresence : DbContext
    {
        public DbPresence() : base("ConnexionPrecence")
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Salle> Salles { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Emargement> Emargements { get; set; }
        public DbSet<Notification> Notifications { get; set; }
      
    }
}
