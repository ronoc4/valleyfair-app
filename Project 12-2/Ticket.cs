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

		// ticketlimit will be equal to guests per window. 
		private int ticketLimit;

		// this timeframe is the span of time that is measured 
		private TimeSpan timeFrame;

		public TimeSpan TimeSpan 
		{
			get
			{
				return timeFrame; 
			}
			set
			{
				timeFrame = value;
			}
		}


		//add a value for the end time of tickets. This will be the upper limit of the tickets that are allowed in the listbox
		public int TicketLimit
		{
			get { return ticketLimit; }
			set { ticketLimit = value; }
		}// This value will be put into a method that is checking every time a tick happens. to make sure that a ticket isn't issued after the max time. 

		// default contsructor
		public Ticket()
		{
		}
		

		// what a ticket should consist of -- In Development still 
		public Ticket(int ticketNumber, DateTime ticketTime, int ticketLimit)
		{
			// every ticket needs a ticket number 
			this.TicketNumber = ticketNumber;
			// date time it was issued 
			this.TicketTime = ticketTime;
			// a ticket doesn't need a ticketLimit , but it set in options and carried over to Main form. 
			this.ticketLimit = ticketLimit; 

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


		 // checks how many tickets can be in the lsit box at once 
		public bool UpperLimit(Ticket t, int ticketQueueCount)
		{
			// if you add this ticket to the list box will it exceed the number allowed in ? 

			// if the listbox count is higher than the limit uhh... don't add it 
			if(ticketQueueCount + 1 >= t.TicketLimit)
			{
				return false;

			}
			else { return true;  }
		}

		public TimeSpan SetTimeSpan(int userInput)
		{
			this.timeFrame = TimeSpan.Add(userInput).Minutes; 
		}

		//todo this is used as an override to string method. 
		public string nextTicketNumber()
		{
			return ( "Ticket" + TicketNumber.ToString() +": Time in : " + TicketTime.ToShortTimeString());
		}

		public TimeSpan TimeIncrement { get; set; }
	}
}
