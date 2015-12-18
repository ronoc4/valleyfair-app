using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_2
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		// exit button click event 
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// this button click adds a new ticket based on the information from the options window 
		private void btnIssueTicket_Click(object sender, EventArgs e)
		{

			timer1.Enabled = true;
			timer1.Start();

			Ticket t3 = new Ticket();

			Ticket oldTicket = new Ticket();


			//todo put these into the ticket class to validate over the limit and end of day time. 
			bool OverTheLimit = false;
			bool TimesUpDaysOver = false;


			oldTicket = (Ticket)this.Tag;

			// todo, code this event 
			if (TimesUpDaysOver.Equals(true))
			{
				MessageBox.Show("Cannot add another ticket because the ride will close before they can ride", "Ride Closing Soon");
			}
			// if over the limit let them know another ticket cannot be added 
			// check the time to see if it falls before the end of the day. 
			//If it does let the user know that prior to trying to add the ticket because it won't work 

			else
			{
				int lastTicketNumber = listBoxTicketQueueList.Items.Count;
				// add the chosen option for the ticket time 
				t3.TicketTime = DateTime.Now.ToLocalTime().AddSeconds(10);

				if (listBoxTicketQueueList.Items.Count == 0)
				{
					t3.TicketNumber = oldTicket.TicketNumber;
				}
				else if (listBoxTicketQueueList.Items.Count > 0)
				{
					t3.TicketNumber = lastTicketNumber + 1;
				}

				//t3.TicketNumber = oldTicket.TicketNumber + 1; 

				//Add new ticket -- Next ticketNumber is used similar to an overide to string. It was written by Conner from the inital Ticket Class. 
				listBoxTicketQueueList.Items.Add(t3.nextTicketNumber().ToString());

				//Increment total tickets Mapped to the number of tickets in the list 
				lblOutsandingTicketTotal.Text = listBoxTicketQueueList.Items.Count.ToString();

				//Show time in label
				lblTimeofEntry.Text = t3.TicketTime.ToString();

				lblTickets.Text = AllowedGuestPerTripRange(oldTicket);
				//todo add the method to check the number of tickets in the listbox to make sure we are not over the limit. 
			}
		}
		// test this out a couple of times 
		private void btnOptions_Click(object sender, EventArgs e)
		{
			// when this button is clicked go back to the options screen.
		}

		// when this form loads try and load the tagged property 
		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
			//loads an instance of frmOptions first with a show dialog , and then make the dialog result equal to a tag, 
			// then convert the tag to a ticket 
			Ticket ticketSettings = new Ticket();
			ticketSettings = (Ticket)this.Tag;

			// loads this forms instance of the ticket which recieved from the tag on frmOptions 
			if (ticketSettings == null)
			{
				MessageBox.Show("Could not load ticket setting. Select Options and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			//todo tie this into the ticket timewindow. also write this into the class as the timeout value. 
			// loop over the list and try to read the time property for each ticket to check and see if it can enter. 
			//		lblTimeofEntry.Text = DateTime.Now.AddMinutes(5).ToLongTimeString();
		}

		//todo method to check the numbers that are avilable to enter. 

		// this method passes in the ticket from the options/setting window to see how  many tickets can enter at a time 
		public string AllowedGuestPerTripRange(Ticket aTicket)
		{
			int upperLimit = aTicket.AllowedGuestPerTrip;
			int lowerLimit = aTicket.AllowedGuestPerTrip - aTicket.AllowedGuestPerTrip + 1;

			if (aTicket.AllowedGuestPerTrip >= listBoxTicketQueueList.Items.Count)
			{
				return "( " + lowerLimit.ToString() + " - " + upperLimit.ToString() + " )";
			}
			else if (aTicket.AllowedGuestPerTrip < listBoxTicketQueueList.Items.Count)
			{
				// tickets have to wait. Display a message 
				MessageBox.Show("You will have to wait..until" + aTicket.TicketTime.AddMinutes(aTicket.TimeFrameBetweenTickets).ToShortTimeString()  , "Notice!", MessageBoxButtons.OK,
					MessageBoxIcon.Hand);
				return "none";
			}
			return "none";
		}


		//TODO Finish the listbox timer once program is working again
		//Timer to remove items from list box right now every 30 seconds
		//Still looking into it
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (listBoxTicketQueueList.Items.Count > 0)
			{
				Ticket check = new Ticket();
				string theTicketInThebox = listBoxTicketQueueList.Items[0].ToString();

				for (int i = listBoxTicketQueueList.Items.Count - 1; i > -1; i--)
				{
					TimeSpan timeVisible = DateTime.Now - check.TicketTime;
					if (timeVisible.TotalSeconds > 30)
						listBoxTicketQueueList.Items.RemoveAt(0);
				}
			}
		}
	}
}
