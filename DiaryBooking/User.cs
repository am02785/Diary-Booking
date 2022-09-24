using System;
using System.Collections.Generic;

namespace DiaryBooking
{
    class User
    {
        private string forename;
        private string surname;
        private string age;
        private string email;
        private List<Booking> bookings;

        public User(string forename, string surname, string age, string email)
        {
            this.forename = forename;
            this.surname = surname;
            this.age = age;
            this.email = email;
            this.bookings = new List<Booking>();
        }

        public void addBooking(string name, DateTime startTime, DateTime endTime)
        {
            Booking booking = new Booking(name, startTime, endTime);
            this.bookings.Add(booking);
        }

    }
}
