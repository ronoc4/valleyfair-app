using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_2
{
    public class Ticket
    {
        private int ticketNumber;
        private int ticketTime;

        public Ticket()
        {
        }

        public Ticket(int ticketNumber, int ticketTime)
        {
            this.TicketNumber = ticketNumber;
            this.TicketTime = ticketTime;
        }

        public int TicketNumber { get; set; }
        public int TicketTime { get; set; }

        public string nextTicketNumber(string sep)
        {
            return TicketNumber.ToString() + sep + TicketTime.ToString(); 
        }


    }
}
