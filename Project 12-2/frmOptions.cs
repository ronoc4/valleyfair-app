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

            DateTime timeNow = DateTime.Now;
            DateTime timePlusFour = timeNow.AddHours(4);

            string defaultOpen = timeNow.ToLongTimeString();
            string defaultClose = timePlusFour.ToLongTimeString();

            // sets the starting values on the date time picker. 
            dateTimePickerStartTime.Value = DateTime.Now.AddSeconds(15);
            dateTimePickerEndTime.Value = DateTime.Now.AddHours(4);
            txtGuestWindow.Text = "5";

            this.ShowDialog();
            if (this.DialogResult.Equals(DialogResult.Cancel))
            {
                
                    List<string> infoFromOptionsFrm = new List<string>();
                    infoFromOptionsFrm.Add(txtFirstTicket.Text);
                    infoFromOptionsFrm.Add(dateTimePickerStartTime.Value.ToLongDateString());
                    this.Tag.Equals(infoFromOptionsFrm);
                    
            }

        }

        // move validation to its own static class
        #region Validation
        public bool IsValidData()
        {
            return
              IsPresent(txtMinWindow, "Minutes Per Window") &&
              IsDecimal(txtMinWindow, "Minutes per Window") &&

              IsPresent(txtGuestWindow, "Guests Per Window") &&
              IsDecimal(txtGuestWindow, "Guests Per Window") &&

              //todo rewrite this to check the times and make sure that there is 
                //need to add IsTime instead of IsDecimal
                //   IsPresent(txtStartTime, "Start time") &&
                // IsDecimal(txtStartTime, "Start time") &&

              //need to add IsTime instead of IsDecimal
                //IsPresent(txtEndTime, "End time") &&
                //IsDecimal(txtEndTime, "End time") &&

              IsPresent(txtFirstTicket, "First ticket number") &&
              IsDecimal(txtFirstTicket, "First ticket number");
        }

        public bool IsDecimal(TextBox textbox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textbox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a number.", "Entry Error");
                textbox.Focus();
                return false;
            }
        }

        // checks textboxes to see if they have text present 
        public bool IsPresent(TextBox textbox, string name)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry error");
                textbox.Focus();
                return false;
            }
            return true;
        }

        // checks to see if a valid time is picked. 
        public bool IsTime(DateTimePicker dtpickr, string name)
        {
            DateTime dtvalue = DateTime.Now;
            if (DateTime.TryParse(dtpickr.Value.ToShortDateString(), out dtvalue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // double check 
        public bool TimeIsOK(DateTime time1, DateTime time2)
        {
            if (time2 < time1)
            {
                MessageBox.Show("End time cannot be before the start time", "Time Entry Error");
                return false;
            }
            else if (time1 > DateTime.Now.AddSeconds(45))
            {
                MessageBox.Show("Start time cannot be in the past");
                return false;
            }
            return true;
        }
        #endregion

        // when this button is clicked check and see if data entered is valid 
        private void btnOptionsOK_Click(object sender, EventArgs e)
        {

            // when ok button is clicked record selection and pass it to the next form 
            Ticket t = new Ticket(); 
            // maybe try and store this in a dictionary. 
            t.TicketNumber = Convert.ToInt16(txtFirstTicket.Text);
            t.TicketTime =  Convert.ToDateTime(dateTimePickerStartTime.Value).ToLongDateString();
           // t = (this.TicketNumber, this.TicketTime); 
            this.Tag = t;

            Form1 f1 = new Form1();
            f1.Tag = this.Tag;
            MessageBox.Show(f1.Tag.ToString());
            this.Close();
            //// todo put arguments in to actually check
            ////            if (IsValidData())
}
    }
}