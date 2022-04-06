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

        public  List<Mensaje> GetConversation(string id1, string id2)
        {
            throw new NotImplementedException();
        }
    }
}
