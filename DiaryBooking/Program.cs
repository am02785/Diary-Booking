using System;

namespace DiaryBooking
{
    class User
    {
        private string forename;
        private string surname;
        private string age;
        private string email;

        public User(string forename, string surname, string age, string email)
        {
            this.forename = forename;
            this.surname = surname;
            this.age = age;
            this.email = email;
        }

    }
}
