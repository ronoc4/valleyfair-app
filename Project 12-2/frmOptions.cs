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
	public partial class frmOptions : Form
	{
		public frmOptions()
		{
			InitializeComponent();

			// call the method to set the initial options settings 
			initializeDisplaySettings();

		}
		
		private void initializeDisplaySettings()
		{
			// Load Options form on open 

			DateTime timeNow = DateTime.Now;
			DateTime timePlusFour = timeNow.AddHours(4);

			string defaultOpen = timeNow.ToLongTimeString();
			string defaultClose = timePlusFour.ToLongTimeString();

			// sets the starting values on the date time picker. 
			dateTimePickerStartTime.Value = DateTime.Now.AddSeconds(15);
			dateTimePickerEndTime.Value = DateTime.Now.AddHours(4);
			txtGuestWindow.Text = "5";
		}

		public bool IsValidData()
		{
			return
			  Validatior.IsPresent(txtMinWindow) &&
			  Validatior.IsInt(txtMinWindow) &&

			  Validatior.IsPresent(txtGuestWindow) &&
			  Validatior.IsInt(txtGuestWindow) &&
			  Validatior.IsPresent(txtFirstTicket) &&
			  Validatior.IsInt(txtFirstTicket);
		}

		// when this button is clicked check and see if data entered is valid 
		private void btnOptionsOK_Click(object sender, EventArgs e)
		{
			// this method checks all of the inputs to make sure they are valid
			if (IsValidData() == true)
			{
				// record selection and pass it to the next form 
				Ticket ticketSettings = new Ticket();

				// set ticket property values
				ticketSettings.TicketNumber = Convert.ToInt16(txtFirstTicket.Text);
				ticketSettings.TicketTime = dateTimePickerStartTime.Value;
				ticketSettings.TicketLimit = Convert.ToInt16(txtGuestWindow.Text);
				//t.TicketLimit = Convert.ToInt16(txtGuestWindow.Text);


				// this instance of this options form's Tag can be set equal to the ticket object type
				this.Tag = ticketSettings;
				
				// prep the form1 
				frmMain f1 = new frmMain();
				f1.Tag = ticketSettings; 
				// set form1's tag property equal to this tag
			

				// show the next form 
				f1.ShowDialog();
				if (f1.DialogResult == DialogResult.Cancel)
				{
					this.Close(); 
				}	
			}
		}
	}
}