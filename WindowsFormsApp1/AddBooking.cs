using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddBooking : Form
    {
        private UserForm userForm;
        private Dictionary<string, UserForm> userForms;
        private List<string> userEmails;
        private AddUser addUser;
        
        public AddBooking(Dictionary<string, UserForm> userForms, UserForm userForm)
        {
            this.userForms = userForms;
            this.userForm = userForm;
            this.userEmails = new List<string>();
            this.addUser = new AddUser(this);
            InitializeComponent();
        }

        public void addUserEmail(string email)
        {
            this.userEmails.Add(email);
        }

        private void addBookingButton_Click(object sender, EventArgs e)
        {
            string name = bookingName.Text;
            DateTime startTime = startTimePicker.Value;
            DateTime endTime = endTimePicker.Value;
            List<UserForm> userForms = new List<UserForm>();
            foreach (string email in this.userEmails)
            {
                userForms.Add(this.userForms[email]);
            }
            this.userForm.addBooking(name, startTime, endTime, userForms);
            this.userForm.updateBookings();
            this.Hide();
            this.userForm.Show();
        }

        private void bookingBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.userForm.Show();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            this.addUser.Show();
        }
    }
}