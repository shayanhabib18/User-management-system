using System;
using System.Windows.Forms;

namespace VpAssignment
{
    public partial class DashboardForm : Form
    {
        private string userName;
        public DashboardForm(string name)
        {
            InitializeComponent();
            userName = name;
            lblWelcomeMessage.Text = "Welcome, " + userName;  
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Hide();
        }
    }
}
