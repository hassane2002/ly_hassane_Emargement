using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPresence
{
    class Notification
    {
        public Notification()
        {
        }
        public int Id { get; set; }
        public string Message { get; set; }
        public int DestinataireId { get; set; }
        public Users Destinataire { get; set; }
        public DateTime DateEnvoi { get; set; }
    }
}
