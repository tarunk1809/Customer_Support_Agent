using Agent_Login.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agent_Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UiStyles.ApplyRounded(this, 25);  // makes the form corners round
            UiStyles.DrawGradient(panelLeft, System.Drawing.Color.SteelBlue, System.Drawing.Color.CornflowerBlue); // gradient
            UiStyles.MakeButtonRounded(btnLogin, 20); // round the login button

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Create an instance of AgentDashBoard and show it
            AgentDashBoard dashboard = new AgentDashBoard();
            dashboard.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
        
            this.WindowState = FormWindowState.Minimized;
        

    }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
