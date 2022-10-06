using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string gender;
        private Dictionary<string, UserForm> userForms;
        private Home home;
        private Login login;
        
        public Form1(Dictionary<string, UserForm> userForms, Home home, Login login)
        {
            this.userForms = userForms;
            this.home = home;
            this.login = login;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string forename = txtForename.Text;
            string surname = txtSurname.Text;
            string age = txtAge.Text;
            string email = txtEmail.Text;
            this.Hide();
            var userForm = new UserForm(this.userForms, forename, surname, age, email, this.gender, this.home);
            this.login.addUserForm(email, userForm);
            userForm.Show();
        }

        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            this.gender = "male";
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            this.gender = "female";
        }

        private void registerBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.home.Show();
        }
    }
}