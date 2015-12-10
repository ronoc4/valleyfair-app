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

		//add a value for the end time of tickets. This will be the upper limit of the tickets. 
		// This value will be put into a method that is checking every time a tick happens. to make sure that a ticket isn't issued after the max time. 

		// trying to get this ticket to build a ticket in a key value pair 
		public Ticket()
		{
		}
		

		// what a ticket should consist of -- In Development still 
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

		//todo this is used as an override to string method. 
		public string nextTicketNumber()
		{
			return ( "Ticket" + TicketNumber.ToString() +": Time in : " + TicketTime.ToString()); 
		}
	}
}
