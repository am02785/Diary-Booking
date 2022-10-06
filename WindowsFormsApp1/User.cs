using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    class User
    {
        private string forename;
        private string surname;
        private string age;
        private string email;
        private string gender;
        private List<Booking> bookings;

        public User(string forename, string surname, string age, string email, string gender)
        {
            this.forename = forename;
            this.surname = surname;
            this.age = age;
            this.email = email;
            this.gender = gender;
            this.bookings = new List<Booking>();
        }

        public void addBooking(string name, DateTime startTime, DateTime endTime, List<UserForm> userForms)
        {
            Booking booking = new Booking(this, name, startTime, endTime, userForms);
            this.bookings.Add(booking);
        }

        public string getForename()
        {
            return this.forename;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string getBookings()
        {
            string result = "";
            foreach (Booking booking in this.bookings)
            {
                result = result + "name: " + booking.getName() + ", start time: " + booking.getStartTime() + ", end time: " +
                         booking.getEndTime();
                List<UserForm> userForms = booking.getUserForms();
                result = result + ", users: ";
                for (int i = 0; i < userForms.Count - 1; i++)
                {
                    result += userForms[i].getUserEmail() + ", ";
                }

                if (userForms.Any())
                {
                    result += userForms[userForms.Count-1].getUserEmail() + "\n";
                }
            }
            return result;
        }

    }
}