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

            this.Show();
        }

        
        private void initializeDisplaySettings()
        {
            // Load Options form on open 
            //MessageBox.Show("This is test2"); 
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
              Validatior.IsInt(txtMinWindow)&&

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
                // when ok button is clicked record selection and pass it to the next form 
                Ticket t = new Ticket();
                // maybe try and store this in a dictionary. 
                t.TicketNumber = Convert.ToInt16(txtFirstTicket.Text);
                t.TicketTime = Convert.ToDateTime(dateTimePickerStartTime.Value).ToLongDateString();
                // t = (this.TicketNumber, this.TicketTime); 
                this.Tag = t;

                Form1 f1 = new Form1();
                f1.Tag = this.Tag;

                f1.ShowDialog();
                this.Close();
            }
        }
    }
}