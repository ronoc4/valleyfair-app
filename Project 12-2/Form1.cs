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
	public partial class Form1 : Form
	{

		public Form1()
		{

			InitializeComponent();
			{
			
			}
			
		}

		// exit button click event 
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// this button click adds a new ticket based on the information from the options window 
		private void btnIssueTicket_Click(object sender, EventArgs e)
		{
			// creates a new instance of the ticket class 
		Ticket t3 = new Ticket();


			//todo put these into the ticket class to validate over the limit and end of day time. 
			bool OverTheLimit = false;
			// over the limit means that if we try and add a ticket to the list it will exceed the maximum allow in. 

			// to check this I need to have a number passed in that is equal to the number of tickets in the ticket queue list. 

			// todo add the endtime to the ticket class. 
			bool TimesUpDaysOver = false;

			// old ticket is casted from this tag , which i'm thinking is t2 from further down around line 72 when the form loads. 
			Ticket oldTicket = new Ticket();
			oldTicket = (Ticket)this.Tag;

			//todo write a method to check and see if the number of tickets in the list is greater than one. The problem here is that 
			// the ticket is being set to the starting ticket number from the options and only adding one the starting ticket number so it doesn't increase after the 2nd ticket is created.  
			
			// increment the ticket + 1
			t3.TicketNumber += oldTicket.TicketNumber + 1;


			if (listBoxTicketQueueList.Items.Count >= oldTicket.TicketLimit)
			{
				OverTheLimit = true; 
				MessageBox.Show("Cannot add another ticket please wait until the ticket window opens again", "Ticket List Cannot Exceed Queue Limit of " + oldTicket.TicketLimit.ToString());
			}

			else if (TimesUpDaysOver.Equals(true))
			{
				MessageBox.Show("Cannot add another ticket because the ride will close before they can ride", "Ride Closing Soon");
			}
			// if over the limit let them know another ticket cannot be added 

						// check the time to see if it falls before the end of the day. If it does let the user know that prior to trying to add the ticket because it won't work 

			else
			{
				
				// if we were to add another ticket to the listbox would it be less than or equal to the max

				// add the chosen option for the ticket time 
				t3.TicketTime = oldTicket.TicketTime.Add(oldTicket.TimeIncrement);

				//Add new ticket -- Next ticketNumber is used similar to an overide to string. It was written by Conner from the inital Ticket Class. 
				listBoxTicketQueueList.Items.Add(t3.nextTicketNumber().ToString());

				//Increment total tickets Mapped to the number of tickets in the list 
				lblOutsandingTicketTotal.Text = listBoxTicketQueueList.Items.Count.ToString();

				//Show time in label
				lblTimeofEntry.Text = t3.TicketTime.ToString();
				lblTickets.Text = CustomerNumbersCanEnter(t3); 
				//todo add the method to check the number of tickets in the listbox to make sure we are not over the limit. 
			}
		}
		// test this out a couple of times 
		private void btnOptions_Click(object sender, EventArgs e)
		{
			frmOptions Options = new frmOptions();
			Options.Show();
			this.Close(); 
		}

		// when this form loads try and load the tagged property 
		private void Form1_Load(object sender, EventArgs e)
		{
			frmOptions Setup = new frmOptions();

			this.Tag = Setup.DialogResult;
			Setup.ShowDialog();

			//todo try loading an instance of frmOptions first with a show dialog , and then make the dialog result equal to a tag, 
			// then convert the tag to a ticket 

			//todo maybe try loading into frmOptions first , and moving all of this out of this form load event into the initialize component section. 

			// loads this forms instance of the ticket which recieved from the tag on frmOptions 
			Ticket t2 = new Ticket();
			t2 = (Ticket)this.Tag;

			if (t2 == null)
			{
				MessageBox.Show("Could not cast value. Check your code and try again", "Error");

			}
			else
			{
				//add the item to the ticket list 
				listBoxTicketQueueList.Items.Add(t2.nextTicketNumber().ToString());

				//this sets the text on the number of tickets in the list 
				lblOutsandingTicketTotal.Text = (listBoxTicketQueueList.Items.Count).ToString();

				//this for testing. For now it diplsays 5 minutes, but it not set equal to the options wait time. 

				//todo tie this into the ticket timewindow. also write this into the class as the timeout value. 
				lblTimeofEntry.Text = DateTime.Now.AddMinutes(5).ToLongTimeString();

				//todo setup the list to inherit a list from the Ticket class? 

				// loop over the list and try to read the time property for each ticket to check and see if it can enter. 

			}
		}
	
		//todo method to check the numbers that are avilable to enter. 

		public void TicketsCanEnterLabelUpdate(List<Ticket> ticketQueue, Ticket orginalTicketSettings)
		{
			Ticket lowerendticket = ticketQueue.ElementAt(0);
			Ticket upperLimit = ticketQueue.ElementAt(orginalTicketSettings.TicketLimit); 
		// these numbers will tell you which tickets can enter 

			lblTickets.Text = "(" + lowerendticket.TicketNumber.ToString() + " - " + upperLimit.TicketNumber.ToString() + ")";
		}




		// pass this a list of tickets to check each as a ticket 
 //	   public void CustomerNumbersCanEnter(Ticket t)
 //	   {
 //		   // to get the customer numbers we need to know what the customer range is. So pass that in by passing in the object 
			
 //		   //t.TicketLimit will be the ticket 
 //				   // accesses the ticket limit property set by the options window. 
 //		   int addThisToListStartingLocation = t.TicketLimit;

 //		   // first ticket inthe list can enter is customer in the first spot
			
 //		   // so we need to extract that ticket number from what I want to be a list of Tickets. 
 //		   int highNum = listBoxTicketQueueList.Items.IndexOf(addThisToListStartingLocation); 
			
 //// get the first ticket in the list 

 //		   int min = 0; 
			
 //		   //	Ticket testmin = Ticket(list.ElementAt(0));

 //		   //min= list.IndexOf(0); 

 //		   int max = 5;
 //		   //  x can enter at a time 
 //		   //int start = t.TicketLimit;
 //		   string result =  "(" + min.ToString() + " - " + max.ToString() + ")";
 //		   return result;
 //	   }
			 
		
			
		// so when the timer hits its next postions it can update its label to say that 

		// customer x- x+x can enter  


		//Load form time ticker
		private void timeNowForm(object sender, EventArgs e)
		{

			DateTime ShortTime2 = DateTime.Now;
			string timeNow = ShortTime2.ToLongTimeString();
			this.Text = timeNow.ToString();
		}
	}
}