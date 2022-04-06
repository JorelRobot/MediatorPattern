using MediatorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Data
{
    public class UsuariosData
    {
        private List<Usuario> usuarios;

        public UsuariosData()
        {
            usuarios = new List<Usuario>()
            {
                new Usuario() { Id = Guid.NewGuid().ToString(), Name = "Joel Rueda", Email = "joel.rueda@email.com", Password = "genericpass" },
                new Usuario() { Id = Guid.NewGuid().ToString(), Name = "Monse Caldera", Email = "monse.caldera@email.com", Password = "genericpass" },
                new Usuario() { Id = Guid.NewGuid().ToString(), Name = "Alexis Vega", Email = "alexis.medina@email.com", Password = "genericpass" },
                new Usuario() { Id = Guid.NewGuid().ToString(), Name = "Naim Medina", Email = "naim.medina@email.com", Password = "genericpass" },
                new Usuario() { Id = Guid.NewGuid().ToString(), Name = "Diego Seda", Email = "diego.seda@email.com", Password = "genericpass" },
                new Usuario() { Id = Guid.NewGuid().ToString(), Name = "Roberto Nuñez", Email = "roberto.nunes@email.com", Password = "genericpass" },
                new Usuario() { Id = Guid.NewGuid().ToString(), Name = "Danny Rodriguez", Email = "daniel.rodriguez@email.com", Password = "genericpass" },
            };
        }

        public List<Usuario> getAllUsuarios()
        {
            return usuarios;
        }
    }
}
