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

        public Booking(User user, string name, DateTime startTime, DateTime endTime)
        {
            this.user = user;
            this.name = name;
            this.startTime = startTime;
            this.endTime = endTime;
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

    }
}