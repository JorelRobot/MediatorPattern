using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Models
{
    public class Mensaje
    {
        public string Id { get; set; }
        public string EmisorID { get; set; }
        public string ReceptorID { get; set; }
        public DateTime HoraFechaEnvio{ get; set; }
        public string BodyMessage { get; set; }
    }
}
