using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        
        private Dictionary<string, UserForm> userForms;
        private Login loginForm;
        
        public Home()
        {
            this.userForms = new Dictionary<string, UserForm>();
            this.loginForm = new Login(this.userForms, this);
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var register = new Form1(this.userForms, this, this.loginForm);
            register.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.loginForm.Show();
        }
    }
}