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
   //     private Dictionary<int, string> dictionaryTest; 

		private DateTime time1;
		private DateTime time2; 

        // trying to get this ticket to build a ticket in a key value pair 
        public Ticket()
        {
        }
        //public Ticket(Dictionary<int, string> dT ) //dt stands for dictionary test obj
        //{
        //    this.ticketNumber = dT.Keys[]; 
        //    this.ticketTime = dT.Values[]; 
        //}

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
		
		public DateTime Timer1
		{
			get
			{
				return time1;
			}
			set
			{

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

        //public Dictionary<int, string> StoreTicketSettings()
        //{
        //    get
        //    {
        //        return dictionaryTest; 
        //    }
        //    set
        //    {
               
        //        dictionaryTest.Add(ticketNumber, ticketTime); 
        //    }
            
        //}

        public string nextTicketNumber()
        {
            return ( "Ticket" + TicketNumber.ToString() +": Time in : " + TicketTime.ToString());
        }
    }
}
