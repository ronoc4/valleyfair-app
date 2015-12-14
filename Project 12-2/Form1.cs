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
	public partial class frmTicketQueue : Form
	{

		public frmTicketQueue()
		{

			InitializeComponent();
			{
		
			}

		}

		// this button click adds a new ticket based on the information from the options window 
		private void btnIssueTicket_Click(object sender, EventArgs e)
		{
			// creates a new instance of the ticket class 
				Ticket t3 = new Ticket();

			// todo this if for testing purposed. Will need to be fixed. 
				t3.TicketNumber = listBoxTicketQueueList.Items.Count + 1;
				t3.TicketTime = DateTime.Now.AddMinutes(5);
			
				//Add new ticket
				listBoxTicketQueueList.Items.Add(t3.nextTicketNumber().ToString());
				//Increment total tickets
				lblOutsandingTicketTotal.Text = listBoxTicketQueueList.Items.Count.ToString();
				//Show time in label
				lblTimeofEntry.Text = t3.TicketTime.ToString();
			
			//todo add the method to check the number of tickets in the listbox to make sure we are not over the limit. 
		}

		// test this out a couple of times 
		private void btnOptions_Click(object sender, EventArgs e)
		{
			
		frmOptions Options = new frmOptions();
		this.Tag = Options.Tag; 
			Options.ShowDialog(); 
		}

		// when this form loads try and load the tagged property 
		private void Form1_Load(object sender, EventArgs e)
		{
			//todo maybe try loading into frmOptions first , and moving all of this out of this form load event into the initialize component section. 

			
			//	this.Tag = Setup.DialogResult;


			//	this.Hide();

			//		Setup.ShowDialog();

			//if (Setup.DialogResult.Equals(DialogResult.OK))
			//{
			//	this.ShowDialog();

			// loads this forms instance of the ticket which recieved from the tag on frmOptions 
			Ticket t2 = new Ticket();
			// coverts the tag to a ticket. 
			t2 = (Ticket)this.Tag;

			if (t2 == null)
			{
				MessageBox.Show("Could not find ticket Options. click on ticket options to configure. ", "Error");

			}
			else
			{
				//	//add the item to the ticket list 
				listBoxTicketQueueList.Items.Add(t2.nextTicketNumber().ToString());

				//	//this sets the text on the number of tickets in the list 
				lblOutsandingTicketTotal.Text = (listBoxTicketQueueList.Items.Count).ToString();

				//	//this for testing. For now it diplsays 5 minutes, but it not set equal to the options wait time. 

				//	//todo tie this into the ticket timewindow. also write this into the class as the timeout value. 
				lblTimeofEntry.Text = DateTime.Now.AddMinutes(5).ToLongTimeString();

				//	//todo setup the list to inherit a list from the Ticket class? 

				//	// loop over the list and try to read the time property for each ticket to check and see if it can enter. 
			}
		}

		// exit button click event 
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//Load form time ticker
		private void timeNowForm(object sender, EventArgs e)
		{

			DateTime ShortTime2 = DateTime.Now;
			string timeNow = ShortTime2.ToLongTimeString();
			this.Text = timeNow.ToString();
		}
	}
}