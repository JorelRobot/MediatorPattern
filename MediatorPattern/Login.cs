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
    public partial class Login : Form
    {
        private UsuariosData _usuariosData = new UsuariosData();
        private MensajesData _mensajesData = new MensajesData();
        private Usuario _userloged;

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario? usuario = _usuariosData.getAllUsuarios().Find(u => u.Email.Equals(txtEmail.Text));

            if (usuario != null && usuario.Password.Equals(txtContrasena.Text))
            {
                _userloged = usuario;
                Dashboard dashboard = new Dashboard(_userloged, _usuariosData, _mensajesData);
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
