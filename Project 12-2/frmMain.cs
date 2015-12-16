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
			// creates a new instance of the ticket class each time the button is clicked this will be the new instance of the ticket
			Ticket t3 = new Ticket();

			Ticket oldTicket = new Ticket();
			//todo put these into the ticket class to validate over the limit and end of day time. 
			bool OverTheLimit = false;
			// over the limit means that if we try and add a ticket to the list it will exceed the maximum allow in. 

			// to check this I need to have a number passed in that is equal to the number of tickets in the ticket queue list. 

			// todo add the endtime to the ticket class. 
			bool TimesUpDaysOver = false;

			// old ticket is casted from this tag , which i'm thinking is t2 from further down around line 72 when the form loads. 

			oldTicket = (Ticket)this.Tag;

			// increment the ticket + 1
			//t3.TicketNumber = (oldTicket.TicketNumber + 1); 
			//todo setup ticket to 
			//if (listBoxTicketQueueList.Items.Count >= oldTicket.TicketLimit)
			//{
			//	OverTheLimit = true;
			//	MessageBox.Show("Cannot add another ticket please wait until the ticket window opens again",
			//		"Ticket List Cannot Exceed Queue Limit of " + oldTicket.TicketLimit.ToString());
			//}

			// this should be the flag that is thrown to display that time is up, and program can no longer issue tickets
			// todo read description, code this event 
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

				lblTickets.Text = ticketLimitRange(oldTicket);
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

			// TESTED CODE TO IMPLEMENT. NOTES DON'T DELETE UNTIL PROGRAM IS COMPLETE 
			//	MessageBox.Show("ticket made it here. ticket Info : " + ticketSettings.nextTicketNumber()); 
			//add the item to the ticket list 
			//	listBoxTicketQueueList.Items.Add(t2.nextTicketNumber().ToString())
			//this sets the text on the number of tickets in the list 
			//	lblOutsandingTicketTotal.Text = (listBoxTicketQueueList.Items.Count).ToString();
			//this for testing. For now it diplsays 5 minutes, but it not set equal to the options wait time. 
			//todo tie this into the ticket timewindow. also write this into the class as the timeout value. 
			//		lblTimeofEntry.Text = DateTime.Now.AddMinutes(5).ToLongTimeString();

			//todo setup the list to inherit a list from the Ticket class? 

			// loop over the list and try to read the time property for each ticket to check and see if it can enter. 


		}

		//todo method to check the numbers that are avilable to enter. 

		//Load form time ticker
		private void timeNowForm(object sender, EventArgs e)
		{

			DateTime ShortTime2 = DateTime.Now;
			string timeNow = ShortTime2.ToLongTimeString();
			this.Text = timeNow.ToString();
		}

		// this method passes in the ticket from the options/setting window to see how  many tickets can enter at a time 
		public string ticketLimitRange(Ticket aTicket)
		{
			int upperLimit = aTicket.TicketLimit;
			int lowerLimit = aTicket.TicketLimit - aTicket.TicketLimit + 1;

			if (aTicket.TicketLimit >= listBoxTicketQueueList.Items.Count)
			{
				return "( " + lowerLimit.ToString() + " - " + upperLimit.ToString() + " )";
			}
			else if (aTicket.TicketLimit < listBoxTicketQueueList.Items.Count)
			{
				// tickets have to wait. Display a message 
				MessageBox.Show("You will have to wait..", "Notice!", MessageBoxButtons.OK,
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
				//	check = (Ticket)listBoxTicketQueueList.Items[0];

				for (int i = listBoxTicketQueueList.Items.Count - 1; i > -1; i--)
				{


					//		var exp = (ExpiringItem)listBoxTicketQueueList.Items[i];
					TimeSpan timeVisible = DateTime.Now - check.TicketTime;
					if (timeVisible.TotalSeconds == 30)
						listBoxTicketQueueList.Items.RemoveAt(0);
				}

			}
		}
	}
}