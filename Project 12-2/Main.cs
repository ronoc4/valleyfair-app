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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            frmOptions frm = new frmOptions();
            frm.ShowDialog();

            DateTime currentTime = DateTime.Now;

            //need to add in a timer in order to refresh the text property of the thing

            System.Timers.Timer RefreshTimer = new System.Timers.Timer();
          
            RefreshTimer.Interval = 5000;
            RefreshTimer.Enabled = true;

            string ShortTime = currentTime.ToLongTimeString();
            this.Text = ShortTime;

        }

        //Timer code to set numerous properties on form
        private void ticketTimer(object sender, EventArgs e)
        {

            DateTime ShortTime2 = DateTime.Now;
            string timeNow = ShortTime2.ToLongTimeString();
            this.Text = timeNow.ToString();
        }

        private void addItemtoListBox(object sender, EventArgs e)
        {
            
            listBoxTicketQueueList.Items.Add("Hello World");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
