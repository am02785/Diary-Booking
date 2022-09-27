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
        private Home home;
        private Login login;
        
        public Form1(Home home, Login login)
        {
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
            var userForm = new UserForm(forename, surname, age, email, this.gender, this.home);
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