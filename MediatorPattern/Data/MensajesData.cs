using MediatorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Data
{
    public class MensajesData
    {
        private List<Mensaje> mensajes = new List<Mensaje>();

        public  List<Mensaje> GetConversation(string emisorId, string receptorId)
        {
            return mensajes.Where(m => m.EmisorID.Equals(emisorId) && m.ReceptorID.Equals(receptorId)).ToList();
        }

        public void SetMessageOnConversation(string emisorId, string receptorId, string mensaje)
        {
            mensajes.Add(new Mensaje()
            {
                Id = Guid.NewGuid().ToString(),
                EmisorID = emisorId,
                ReceptorID = receptorId,
                BodyMessage = mensaje,
                HoraFechaEnvio = DateTime.Now,
            });
        }
    }
}
