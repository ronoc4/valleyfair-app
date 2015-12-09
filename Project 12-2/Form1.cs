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


                // timer used for timestamp and testing. 
                DateTime currentTime = DateTime.Now;

                //need to add in a timer in order to refresh the text property of the thing
                System.Timers.Timer RefreshTimer = new System.Timers.Timer();
                RefreshTimer.Interval = 5000;
                RefreshTimer.Enabled = true;
                string ShortTime = currentTime.ToLongTimeString();
                this.Text = ShortTime;

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
            Ticket t3 = new Ticket();
            t3.TicketNumber = 2;
            t3.TicketNumber += 1;
            t3.TicketTime = DateTime.Now.AddMinutes(5).ToString();

            listBoxTicketQueueList.Items.Add(t3.nextTicketNumber().ToString());
            // add another ticket to the ticket box based on the objects in the box and the starting ticket number, and also map the time to the 
        }

        // test this out a couple of times 
        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions Options = new frmOptions();
            Options.Show();
            this.Hide();
        }

        // when this form loads try and load the tagged property 
        private void Form1_Load(object sender, EventArgs e)
        {
            Ticket t2 = new Ticket();
          
            
            t2 = (Ticket)this.Tag;
            if (t2 == null)
            {
                MessageBox.Show("Could not cast value. Check your code and try again", "Error");
                
            }
            else 
            {

                listBoxTicketQueueList.Items.Add(t2.nextTicketNumber().ToString());
                lblOutsandingTicketTotal.Text = (listBoxTicketQueueList.Items.Count).ToString();

                //todo setup the list to inherit a list from the Ticket class? 
                
                // loop over the list and try to read the time property for the  
            }
        }
    }
}