using MediatorPattern.Data;
using MediatorPattern.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediatorPattern
{
    public partial class Dashboard : Form
    {
        private UsuariosData _usuariosData;
        private MensajesData _mensajesData;
        private Usuario _usersession;

        public Dashboard(Usuario usersession, UsuariosData usuariosData, MensajesData mensajesData)
        {
            InitializeComponent();

            _usersession = usersession;
            _usuariosData = usuariosData;
            _mensajesData = mensajesData;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _usersession.Name;
            panelWelcome.BringToFront();

            ListarAmigos();
        }

        private void ListarAmigos()
        {
            int y_position = 13;

            foreach (Usuario user in _usuariosData.getAllUsuarios())
            {

                if (user.Id.Equals(_usersession.Id)) continue;

                UserCardSidebar usercard = new UserCardSidebar();
                usercard.UserName = user.Name;
                usercard.LastMessagge = user.Email;
                usercard.UpdateContent();
                usercard.Click += SelectFriend;

                usercard.SetBounds(8, y_position, 275, 70);
                y_position = usercard.Bounds.Y + 75;

                panelAmigos.Controls.Add(usercard);
            }
        }

        private void SelectFriend(object sender, EventArgs e)
        {
            UserCardSidebar card = (UserCardSidebar) sender;
            lblChatFrindName.Text = card.UserName;

            Usuario friend = _usuariosData.getAllUsuarios().Find(u => u.Name.Equals(card.UserName));
            List<Mensaje> conversacion = _mensajesData.GetConversation(_usersession.Id, friend.Id); 

            panelWelcome.Visible = false;
        }
    }
}
