using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserForm : Form
    {

        private User user;
        private Home home;
        private AddBooking bookingForm;
        
        public UserForm(Dictionary<string, UserForm> userForms, string name, string surname, string age, string email, string gender, Home home)
        {
            this.user = new User(name, surname, age, email, gender);
            this.home = home;
            this.bookingForm = new AddBooking(userForms, this);
            InitializeComponent();
        }

        public void addBooking(string name, DateTime startTime, DateTime endtime, List<UserForm> userForms)
        {
            this.user.addBooking(name, startTime, endtime, userForms);
        }

        public String getUserEmail()
        {
            return this.user.getEmail();
        }

        private void addBookingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.bookingForm.Show();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.home.Show();
        }
    }
}