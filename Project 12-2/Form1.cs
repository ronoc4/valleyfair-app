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
            
           //     ReadSelectionFromOptionsForm(); 
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
           // Ticket newTicket = new Ticket(); 
            //newTicket =

            //todo create a new ticket from Tag
        }

        // test this out a couple of times 
        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions Options = new frmOptions();
            Options.ShowDialog();
            this.Hide(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmOptions Options = new frmOptions();
            Form1 f1 = new Form1();
            f1.Tag = Options.Tag; 
            Ticket t = new Ticket();
            DialogResult optionsSelection = Options.DialogResult;
            if (optionsSelection == DialogResult.Cancel)
            {
              
            }
            listBoxTicketQueueList.Items.Add(t); 
        }

    }
}
