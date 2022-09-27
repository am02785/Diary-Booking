using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {

        private Login loginForm;
        
        public Home()
        {
            this.loginForm = new Login(this);
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var register = new Form1(this, this.loginForm);
            register.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.loginForm.Show();
        }
    }
}