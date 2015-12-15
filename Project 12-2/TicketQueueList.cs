using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_2
{
	public class TicketQueueList : Ticket
	{
		public new void Add(Ticket t)
		{
			base.Insert(t); 
		}

	}
}
