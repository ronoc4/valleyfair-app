using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_2
{
	class TicketInheritanceClass : Ticket
	{
		TicketInheritanceClass ForTheTiime = new TicketInheritanceClass();

		DateTime timer1;
		DateTime timer2;

		int minsPerWindow; 

		public void Timer1()
		{
			this.timer1 = TicketTime;

			
		}
	}
}
	
