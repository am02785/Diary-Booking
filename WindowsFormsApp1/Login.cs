using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        private Dictionary<string, UserForm> userForms;
        private Home home;
        
        public Login(Dictionary<string, UserForm> userForms, Home home)
        {
            this.home = home;
            this.userForms = userForms;
            InitializeComponent();
        }

        private void loginButton2_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text;
            UserForm userForm = this.userForms[email];
            this.Hide();
            userForm.Show();
        }

        public void addUserForm(string email, UserForm userForm)
        {
            this.userForms.Add(email, userForm);
        }

        private void loginBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.home.Show();
        }
    }
}