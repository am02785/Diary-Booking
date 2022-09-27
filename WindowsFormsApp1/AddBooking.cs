using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddBooking : Form
    {
        private UserForm userForm;
        public AddBooking(UserForm userForm)
        {
            this.userForm = userForm;
            InitializeComponent();
        }

        private void addBookingButton_Click(object sender, EventArgs e)
        {
            string name = bookingName.Text;
            DateTime startTime = startTimePicker.Value;
            DateTime endTime = endTimePicker.Value;
            this.userForm.addBooking(name, startTime, endTime);
            this.userForm.updateBookings();
            this.Hide();
            this.userForm.Show();
        }

        private void bookingBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.userForm.Show();
        }
    }
}