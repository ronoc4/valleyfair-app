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
        private int ticketTime;


        public Ticket()
        {
        }

        public Ticket(int ticketNumber, int ticketTime)
        {
            this.TicketNumber = ticketNumber;
            this.TicketTime = ticketTime;
        }

        public int TicketNumber 
        {
            get
            {
                return ticketNumber;
            }
                set
                {
                    ticketNumber = Convert.ToInt16(value);
                }
            }
        public int TicketTime { get; set; }

        public string nextTicketNumber(string sep)
        {
            return ( "Ticket" + TicketNumber.ToString() +":" + sep + TicketTime.ToString());
        }
    }
}
