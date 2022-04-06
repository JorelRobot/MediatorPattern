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
    public partial class UserCardSidebar : UserControl
    {
        public string UserName { get; set; }
        public string LastMessagge { get; set; }

        public UserCardSidebar()
        {
            InitializeComponent();
        }

        public void UpdateContent()
        {
            username.Text = UserName;
            lastmessagge.Text = LastMessagge;
        }

        private void UserCardSidebar_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UserCardSidebar_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSeaGreen;
        }
    }
}
