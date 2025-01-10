using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteYonetimSistemi.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        bool isClicked;
        Point oldLocation;
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            oldLocation = e.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                this.Location = new Point(this.Location.X+(e.X-oldLocation.X),this.Location.Y+(e.Y-oldLocation.Y));
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked &= false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtHide_Click(object sender, EventArgs e)
        {

        }
    }
}
