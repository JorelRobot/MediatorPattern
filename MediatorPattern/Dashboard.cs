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
        private Usuario _selectedFrined = null;
        private List<Mensaje> _selectedConversation = null;

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
            //conversacion = conversacion.OrderBy(o => o.HoraFechaEnvio).ToList();

            _selectedFrined = friend;
            _selectedConversation = conversacion;

            SetConversationUp();

            panelWelcome.Visible = false;
        }

        private void SetConversationUp ()
        {
            panelMensajes.Controls.Clear();
            int y_position = 10;

            Usuario friend = _usuariosData.getAllUsuarios().Find(u => u.Name.Equals(_selectedFrined.Name));
            List<Mensaje> conversacion = _mensajesData.GetConversation(_usersession.Id, friend.Id);
            //conversacion = conversacion.OrderBy(o => o.HoraFechaEnvio).ToList();

            _selectedFrined = friend;
            _selectedConversation = conversacion;

            if (_selectedFrined != null || _selectedConversation != null)
            {
                if (!_selectedConversation.Count.Equals(0)) { 
                    foreach (Mensaje mensaje in _selectedConversation)
                    {
                        CUMensaje card = new CUMensaje(mensaje, _selectedFrined.Id);

                        if (mensaje.EmisorID.Equals(_usersession.Id))
                        {
                            // Emisor Messagge
                            card.Location = new Point(380, y_position);
                        }
                        else
                        {
                            // Receptor Messagge
                            card.Location = new Point(5, y_position);
                        }

                        card.Visible = true;
                        panelMensajes.Controls.Add(card);
                        y_position += 120;
                    }
                }
            }

            panelMensajes.VerticalScroll.Value = panelMensajes.VerticalScroll.Maximum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMessageToSend.Text.Length != 0)
            {
                _mensajesData.SetMessageOnConversation(_usersession.Id, _selectedFrined.Id, txtMessageToSend.Text);

            }

            SetConversationUp();
            txtMessageToSend.Clear();
        }
    }
}
