using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Booking
    {

        private User user;
        private string name;
        private DateTime startTime;
        private DateTime endTime;
        private List<UserForm> userForms;

        public Booking(User user, string name, DateTime startTime, DateTime endTime, List<UserForm> userForms)
        {
            this.user = user;
            this.name = name;
            this.startTime = startTime;
            this.endTime = endTime;
            this.userForms = userForms;
        }

        public string getName()
        {
            return this.name;
        }

        public string getStartTime()
        {
            return this.startTime.ToString();
        }

        public string getEndTime()
        {
            return this.endTime.ToString();
        }

        public List<UserForm> getUserForms()
        {
            return this.userForms;
        }

    }
}