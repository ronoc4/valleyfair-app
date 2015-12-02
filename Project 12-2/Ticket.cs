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
        private string ticketTime;

        private List<string> settings;

        public Ticket()
        {
            
        }

        // what a ticket should consist of 
        public Ticket(int ticketNumber, string ticketTime)
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


        // switching back and forth between a string and a dateTime. still need to determine which one will be better. 
        public string TicketTime
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

        public List<string> GetSettings
        { 
           get
            {
                return settings; 
            }
            set
            {
                settings.Add(ticketTime); 
                settings.Add(ticketNumber.ToString());
                settings = value; 
            }

        }


        public string nextTicketNumber()
        {
            return ( "Ticket" + TicketNumber.ToString() +":" + TicketTime.ToString());
        }
    }
}
