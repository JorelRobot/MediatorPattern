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
    public partial class CUMensaje : UserControl
    {
        private Mensaje _messagge;
        private string _receptorID;

        public CUMensaje(Mensaje messagge, string receptorID)
        {
            InitializeComponent();

            _messagge = messagge;
            _receptorID = receptorID;

            SetUP();
        }

        private void SetUP()
        {
            lblBodyMessagge.Text = _messagge.BodyMessage;
            lblDateMessagge.Text = _messagge.HoraFechaEnvio.ToString();

            this.BackColor = Color.Gray;

            lblBodyMessagge.TextAlign = ContentAlignment.TopLeft;
            lblBodyMessagge.Location = new Point(8, 8);
            lblBodyMessagge.ForeColor = Color.White;

            lblDateMessagge.TextAlign = ContentAlignment.TopLeft;
            lblDateMessagge.Location = new Point(3, 3);
            lblDateMessagge.ForeColor = Color.White;


            if (_receptorID.Equals(_messagge.EmisorID))
            {
                this.BackColor = Color.DarkSeaGreen;
            }
        }
    }
}
