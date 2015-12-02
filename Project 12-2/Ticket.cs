using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_2
{
    class Ticket
    {
        // every ticket needs a ticket number
        private int ticketNumber;
        // time the ticket was issued. 
        private DateTime ticketTime;


        public Ticket()
        {
        }

        // what a ticket should consist of 
        public Ticket(int ticketNumber, DateTime ticketTime)
        {
            this.TicketNumber = ticketNumber;
            this.TicketTime = ticketTime;
        }

        // access the ticket number field. 
        public int TicketNumber 
        {
            get
            {
                return ticketNumber;
            }
                set
                {
                    ticketNumber = value; 
                }
            }


        public DateTime TicketTime
        {
            get
            {
                return ticketTime;
            }
            set
            {
                ticketTime = value;
            }
        }


        public string nextTicketNumber(string sep)
        {
            return ( "Ticket" + TicketNumber.ToString() +":" + sep +  TicketTime.ToString());
        }
    }
}
