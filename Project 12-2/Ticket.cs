using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_2
{
	public class Ticket
	{
		// every ticket needs a ticket number
		private int ticketNumber;

		// ticketlimit will be equal to guests per window. 
		private int guestWindow;

		// this will be stored as an int and plugged into a datetime value later to calculate span 
		private int timeFrame;

		// time the ticket was issued. 
		private DateTime ticketTime;

		public int TimeFrameBetweenTickets 
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
		public int AllowedGuestPerTrip
		{
			get { return guestWindow; }
			set { guestWindow = value; }
		}
		// This value will be put into a method that is checking every time a tick happens. to make sure that a ticket isn't issued after the max time. 
#region Ticket Constructors
		// default contsructor
		public Ticket()
		{
		}

//A Ticket can alo consitst of only the ticket number as well as the start or end time. 
		public Ticket(int ticketNumber, DateTime ticketTime)
		{
			this.TicketNumber = ticketNumber;
			this.TicketTime = ticketTime;
		}

		// what a ticket should consist of -- In Development still 
		public Ticket(int ticketNumber, DateTime ticketTime, int ticketLimit)
		{
			// every ticket needs a ticket number 
			this.TicketNumber = ticketNumber;
			// date time it was issued 
			this.TicketTime = ticketTime;
			// a ticket doesn't need a ticketLimit , but it set in options and carried over to Main form. 
			this.guestWindow = ticketLimit; 

		}
#endregion
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

		// starting time for tickets 
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
			// if the listbox count is higher than the limit uhh... don't add it 
			if(ticketQueueCount + 1 >= t.guestWindow)
			{
				return false;

			}
			else { return true;  }
		}
		
		//todo this is used as an override to string method. 
		public string nextTicketNumber()
		{
			return ( "Ticket" + this.TicketNumber.ToString() +": Time in : " + this.TicketTime.ToShortTimeString());
		}

		public TimeSpan TimeIncrement { get; set; }
	}
}
