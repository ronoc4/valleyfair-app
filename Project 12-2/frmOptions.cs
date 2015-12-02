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
          //  MessageBox.Show("All current tickets will be deleted");

            DateTime timeNow = DateTime.Now;
            DateTime timePlusFour = timeNow.AddHours(4);

            string defaultOpen = timeNow.ToLongTimeString();
            string defaultClose = timePlusFour.ToLongTimeString();


            txtStartTime.Text = defaultOpen;
            txtEndTime.Text = defaultClose;
            
        }




        public bool IsValidData()
        {
            return
              IsPresent(txtMinWindow, "Minutes Per Window") &&
              IsDecimal(txtMinWindow, "Minutes per Window") &&

              IsPresent(txtGuestWindow, "Guests Per Window") &&
              IsDecimal(txtGuestWindow, "Guests Per Window") &&
//need to add IsTime instead of IsDecimal
              IsPresent(txtStartTime, "Start time") &&
              IsDecimal(txtStartTime, "Start time") &&
//need to add IsTime instead of IsDecimal
              IsPresent(txtEndTime, "End time") &&
              IsDecimal(txtEndTime, "End time") &&

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

   //     public bool IsTime(TextBox textbox, string name)
     //   {
            
     //   }

        private void btnOptionsOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
                    }
    }

}
