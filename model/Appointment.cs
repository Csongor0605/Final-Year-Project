using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Final_Year_Project.model
{
    public class Appointment
    {
        private long clientID;
        private DateTime time;
        private string notes;

        public Appointment(long id, DateTime time, string notes) 
        { 
            clientID = id;
            this.time = time;
            this.notes = notes;
        }

        public Appointment(Appointment oldAppointment, DateTime time) 
        { 
            clientID=oldAppointment.clientID;
            this.time = time;
            this.notes = oldAppointment.notes;
        }

        public long ClientID { get {  return clientID; } }
        public DateTime Time { get { return time; } }
        public string Notes { get { return notes;} }
        public override string ToString() { return "Appointment: at" + time + "\nclientID: " + clientID; }

        public string DisplayFormat
        {
            get { return time.ToString("t") + CurrData.GetClientName(clientID); }
        }
    }
}
